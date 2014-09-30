using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTTCameraControl
{
    public partial class fMain : Form
    {
        System.IO.Ports.SerialPort sp = new System.IO.Ports.SerialPort();
        public fMain()
        {
            InitializeComponent();
        }

        MqttClient mqttclient = null;

        int map(int x, int in_min, int in_max, int out_min, int out_max)
        {
            if (x < in_min)
                return out_min;
            if (x > in_max)
                return out_max;
            return (x - in_min) * (out_max - out_min)/(in_max - in_min) + out_min;
        } 

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.Messages.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
                Messages.AppendText(text + Environment.NewLine);
        }

        void SetSliderFromNuchuck()
        {
            if(sp.BytesToRead > 0)
            {
                string[] nckData = sp.ReadLine().TrimEnd('\r').Split(' ');
                if (nckData.Length != 7)
                    return; // communication error
                int panCandidate = map(Convert.ToInt32(nckData[2]),305,730,tbPan.Minimum,tbPan.Maximum);
                int tiltCandidate = map(Convert.ToInt32(nckData[1]), 0, 255, tbTilt.Maximum, tbTilt.Minimum);
                if (cbDebug.Checked)
                {
                    Messages.Text = string.Format("Pan: {0} {1} {2} Tilt: {3} {4} {5}\r\n", nckData[2], panCandidate, tbPan.Value,
                        nckData[3], tiltCandidate, tbTilt.Value) + Messages.Text;
//                    return;
                }
                tbPan.Value = panCandidate;
                tbTilt.Value = tiltCandidate;
                Application.DoEvents();
            }
        }

        string lastMessage = string.Empty;
        void setCamera()
        {
            string message = string.Format("{0},{1}", tbPan.Value, tbTilt.Value);

            if (mqttclient != null)
            {
                if (message != lastMessage)
                {
                    DateTime dt = DateTime.Now;
                    TimeSpan diff = DateTime.Now - dt;
                    lastMessage = message;
                    while ((diff.Seconds < 2) && (message == lastMessage))
                    {
                        diff = DateTime.Now - dt;
                        if (cbNunchuck.Checked)
                            SetSliderFromNuchuck();
                        message = string.Format("{0},{1}", tbPan.Value, tbTilt.Value);
                        Application.DoEvents();
                        
                    }
                    if (message == lastMessage)
                    {
                        Messages.Text = string.Format("Pan: {0} Tilt: {1} \r\n", tbPan.Value, tbTilt.Value) + Messages.Text;
                        mqttclient.Publish(Subscribe.Text, Encoding.UTF8.GetBytes(message));
                    }
                }
            }
        }

        private void cbConnImage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConnImage.Checked)
            {
                mqttclient = new MqttClient(Broker.Text);

                string clientId = Guid.NewGuid().ToString();
                mqttclient.Connect(clientId);

                mqttclient.Subscribe(new string[] { Subscribe.Text },
                    new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

                while (cbConnImage.Checked)
                {
                    Application.DoEvents();
                    if (cbNunchuck.Checked)
                        SetSliderFromNuchuck();
                    setCamera();
                }
            }
            else
            {
                mqttclient.Unsubscribe(new string[] { Subscribe.Text });
                mqttclient = null;
            }
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbConnImage.Checked = false;
        }

        private void cbNunchuck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNunchuck.Checked)
            {
                if (sp.IsOpen)
                    sp.Close();
                sp.PortName = Port.Text;
                sp.BaudRate = 9600;
                sp.ReadBufferSize = 20;
                sp.Open();
            }
            else
                sp.Close();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            if (ports.Length > 0)
                Port.Text = ports[ports.Length - 1];
        }

        int dPan = 5, dTilt = 5;
        private void cbAnimation_CheckedChanged(object sender, EventArgs e)
        {
            cbNunchuck.Checked = false;
            tbPan.Value = 90;
            tbTilt.Value = 90;
            Application.DoEvents();
            setCamera();
            while (cbAnimation.Checked)
            {
                if (tbPan.Value > (tbPan.Maximum - 30))
                    dPan = -1;
                else
                    if (tbPan.Value < (tbPan.Minimum + 30))
                    dPan = 1;
                if (tbTilt.Value > (tbTilt.Maximum - 30))
                    dTilt = -1;
                else
                    if (tbTilt.Value < (tbTilt.Minimum + 30))
                        dTilt = 1;
                tbPan.Value = tbPan.Value + dPan;
                tbTilt.Value = tbTilt.Value + dTilt;
                Application.DoEvents();
                setCamera();
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
