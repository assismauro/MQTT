namespace MQTTCameraControl
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAnimation = new System.Windows.Forms.CheckBox();
            this.cbDebug = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.cbNunchuck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Subscribe = new System.Windows.Forms.TextBox();
            this.tbPan = new System.Windows.Forms.TrackBar();
            this.cbConnImage = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Broker = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTilt = new System.Windows.Forms.TrackBar();
            this.Messages = new System.Windows.Forms.TextBox();
            this.help = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTilt)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(828, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.cbAnimation);
            this.panel1.Controls.Add(this.cbDebug);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Port);
            this.panel1.Controls.Add(this.cbNunchuck);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Subscribe);
            this.panel1.Controls.Add(this.tbPan);
            this.panel1.Controls.Add(this.cbConnImage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Broker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 100);
            this.panel1.TabIndex = 2;
            // 
            // cbAnimation
            // 
            this.cbAnimation.AutoSize = true;
            this.cbAnimation.Location = new System.Drawing.Point(399, 76);
            this.cbAnimation.Name = "cbAnimation";
            this.cbAnimation.Size = new System.Drawing.Size(72, 17);
            this.cbAnimation.TabIndex = 10;
            this.cbAnimation.Text = "Animation";
            this.cbAnimation.UseVisualStyleBackColor = true;
            this.cbAnimation.CheckedChanged += new System.EventHandler(this.cbAnimation_CheckedChanged);
            // 
            // cbDebug
            // 
            this.cbDebug.AutoSize = true;
            this.cbDebug.Location = new System.Drawing.Point(333, 76);
            this.cbDebug.Name = "cbDebug";
            this.cbDebug.Size = new System.Drawing.Size(58, 17);
            this.cbDebug.TabIndex = 9;
            this.cbDebug.Text = "Debug";
            this.cbDebug.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(145, 74);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 7;
            // 
            // cbNunchuck
            // 
            this.cbNunchuck.AutoSize = true;
            this.cbNunchuck.Location = new System.Drawing.Point(251, 77);
            this.cbNunchuck.Name = "cbNunchuck";
            this.cbNunchuck.Size = new System.Drawing.Size(76, 17);
            this.cbNunchuck.TabIndex = 6;
            this.cbNunchuck.Text = "Nunchuck";
            this.cbNunchuck.UseVisualStyleBackColor = true;
            this.cbNunchuck.CheckedChanged += new System.EventHandler(this.cbNunchuck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subscribe";
            // 
            // Subscribe
            // 
            this.Subscribe.Location = new System.Drawing.Point(15, 74);
            this.Subscribe.Name = "Subscribe";
            this.Subscribe.Size = new System.Drawing.Size(124, 20);
            this.Subscribe.TabIndex = 4;
            this.Subscribe.Text = "home/remotePiCamera";
            // 
            // tbPan
            // 
            this.tbPan.Location = new System.Drawing.Point(220, 25);
            this.tbPan.Maximum = 140;
            this.tbPan.Minimum = 1;
            this.tbPan.Name = "tbPan";
            this.tbPan.Size = new System.Drawing.Size(327, 45);
            this.tbPan.TabIndex = 3;
            this.tbPan.TickFrequency = 10;
            this.tbPan.Value = 70;
            // 
            // cbConnImage
            // 
            this.cbConnImage.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbConnImage.AutoSize = true;
            this.cbConnImage.Location = new System.Drawing.Point(145, 25);
            this.cbConnImage.Name = "cbConnImage";
            this.cbConnImage.Size = new System.Drawing.Size(42, 23);
            this.cbConnImage.TabIndex = 2;
            this.cbConnImage.Text = "Start!";
            this.cbConnImage.UseVisualStyleBackColor = true;
            this.cbConnImage.CheckedChanged += new System.EventHandler(this.cbConnImage_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broker";
            // 
            // Broker
            // 
            this.Broker.Location = new System.Drawing.Point(15, 28);
            this.Broker.Name = "Broker";
            this.Broker.Size = new System.Drawing.Size(124, 20);
            this.Broker.TabIndex = 0;
            this.Broker.Text = "iot.eclipse.org";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbTilt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 425);
            this.panel2.TabIndex = 3;
            // 
            // tbTilt
            // 
            this.tbTilt.Location = new System.Drawing.Point(41, 6);
            this.tbTilt.Maximum = 120;
            this.tbTilt.Minimum = 10;
            this.tbTilt.Name = "tbTilt";
            this.tbTilt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbTilt.Size = new System.Drawing.Size(45, 272);
            this.tbTilt.TabIndex = 0;
            this.tbTilt.TickFrequency = 10;
            this.tbTilt.Value = 60;
            // 
            // Messages
            // 
            this.Messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Messages.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messages.Location = new System.Drawing.Point(124, 100);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Messages.Size = new System.Drawing.Size(704, 425);
            this.Messages.TabIndex = 4;
            // 
            // help
            // 
            this.help.Dock = System.Windows.Forms.DockStyle.Right;
            this.help.Location = new System.Drawing.Point(553, 0);
            this.help.Multiline = true;
            this.help.Name = "help";
            this.help.ReadOnly = true;
            this.help.Size = new System.Drawing.Size(275, 100);
            this.help.TabIndex = 11;
            this.help.Text = resources.GetString("help.Text");
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 547);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "fMain";
            this.Text = "MQTT Remote Camera Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbConnImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Broker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tbPan;
        private System.Windows.Forms.TrackBar tbTilt;
        private System.Windows.Forms.TextBox Messages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Subscribe;
        private System.Windows.Forms.CheckBox cbNunchuck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.CheckBox cbDebug;
        private System.Windows.Forms.CheckBox cbAnimation;
        private System.Windows.Forms.TextBox help;
    }
}

