namespace TPManager.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnRestart = new System.Windows.Forms.Button();
            this.comboQoS = new System.Windows.Forms.ComboBox();
            this.chkWifi = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMac = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupQuick = new System.Windows.Forms.GroupBox();
            this.lblDash = new System.Windows.Forms.Label();
            this.groupWifi = new System.Windows.Forms.GroupBox();
            this.lblWifiPw = new System.Windows.Forms.Label();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.lblwpsenable = new System.Windows.Forms.Label();
            this.btnConnected = new System.Windows.Forms.Button();
            this.lblwp = new System.Windows.Forms.Label();
            this.lblWifiName = new System.Windows.Forms.Label();
            this.lblWifiStat = new System.Windows.Forms.Label();
            this.groupExtended = new System.Windows.Forms.GroupBox();
            this.groupAdvanced = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkQos = new System.Windows.Forms.CheckBox();
            this.lblQos = new System.Windows.Forms.Label();
            this.chkUpnp = new System.Windows.Forms.CheckBox();
            this.lblUpnp = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.wpsTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.groupQuick.SuspendLayout();
            this.groupWifi.SuspendLayout();
            this.groupExtended.SuspendLayout();
            this.groupAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.ForeColor = System.Drawing.Color.Black;
            this.btnRestart.Location = new System.Drawing.Point(6, 18);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(86, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart Router";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // comboQoS
            // 
            this.comboQoS.BackColor = System.Drawing.SystemColors.Control;
            this.comboQoS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQoS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboQoS.FormattingEnabled = true;
            this.comboQoS.Location = new System.Drawing.Point(120, 66);
            this.comboQoS.Name = "comboQoS";
            this.comboQoS.Size = new System.Drawing.Size(108, 21);
            this.comboQoS.TabIndex = 5;
            this.comboQoS.Visible = false;
            // 
            // chkWifi
            // 
            this.chkWifi.AutoCheck = false;
            this.chkWifi.AutoSize = true;
            this.chkWifi.Location = new System.Drawing.Point(52, 16);
            this.chkWifi.Name = "chkWifi";
            this.chkWifi.Size = new System.Drawing.Size(67, 17);
            this.chkWifi.TabIndex = 7;
            this.chkWifi.Text = "Disabled";
            this.chkWifi.UseVisualStyleBackColor = true;
            this.chkWifi.CheckedChanged += new System.EventHandler(this.ChkWifi_CheckedChanged);
            this.chkWifi.Click += new System.EventHandler(this.ChkWifi_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(211, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Info";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // btnMac
            // 
            this.btnMac.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMac.Location = new System.Drawing.Point(186, 14);
            this.btnMac.Name = "btnMac";
            this.btnMac.Size = new System.Drawing.Size(111, 23);
            this.btnMac.TabIndex = 10;
            this.btnMac.Text = "WIFI MAC Filter";
            this.btnMac.UseVisualStyleBackColor = true;
            this.btnMac.Click += new System.EventHandler(this.BtnMac_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeed.Location = new System.Drawing.Point(98, 18);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(107, 23);
            this.btnSpeed.TabIndex = 11;
            this.btnSpeed.Text = "Speed Comparison";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.BtnSpeed_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(8, 15);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(183, 241);
            this.txtStatus.TabIndex = 13;
            // 
            // groupQuick
            // 
            this.groupQuick.Controls.Add(this.btnRestart);
            this.groupQuick.Controls.Add(this.btnSpeed);
            this.groupQuick.Controls.Add(this.btnRefresh);
            this.groupQuick.Location = new System.Drawing.Point(12, 67);
            this.groupQuick.Name = "groupQuick";
            this.groupQuick.Size = new System.Drawing.Size(304, 55);
            this.groupQuick.TabIndex = 14;
            this.groupQuick.TabStop = false;
            this.groupQuick.Text = "Quick Settings";
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.BackColor = System.Drawing.Color.Transparent;
            this.lblDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.ForeColor = System.Drawing.Color.White;
            this.lblDash.Location = new System.Drawing.Point(12, 16);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(117, 25);
            this.lblDash.TabIndex = 16;
            this.lblDash.Text = "Dashboard";
            // 
            // groupWifi
            // 
            this.groupWifi.Controls.Add(this.lblWifiPw);
            this.groupWifi.Controls.Add(this.btnAdvanced);
            this.groupWifi.Controls.Add(this.lblwpsenable);
            this.groupWifi.Controls.Add(this.btnConnected);
            this.groupWifi.Controls.Add(this.lblwp);
            this.groupWifi.Controls.Add(this.lblWifiName);
            this.groupWifi.Controls.Add(this.lblWifiStat);
            this.groupWifi.Controls.Add(this.chkWifi);
            this.groupWifi.Controls.Add(this.btnMac);
            this.groupWifi.Location = new System.Drawing.Point(12, 129);
            this.groupWifi.Name = "groupWifi";
            this.groupWifi.Size = new System.Drawing.Size(304, 104);
            this.groupWifi.TabIndex = 17;
            this.groupWifi.TabStop = false;
            this.groupWifi.Text = "WIFI Settings";
            // 
            // lblWifiPw
            // 
            this.lblWifiPw.AutoSize = true;
            this.lblWifiPw.Location = new System.Drawing.Point(6, 83);
            this.lblWifiPw.Name = "lblWifiPw";
            this.lblWifiPw.Size = new System.Drawing.Size(56, 13);
            this.lblWifiPw.TabIndex = 16;
            this.lblWifiPw.Text = "Password:";
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanced.Location = new System.Drawing.Point(186, 72);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(111, 23);
            this.btnAdvanced.TabIndex = 15;
            this.btnAdvanced.Text = "Advanced Info";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.BtnAdvanced_Click);
            // 
            // lblwpsenable
            // 
            this.lblwpsenable.AutoSize = true;
            this.lblwpsenable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblwpsenable.Location = new System.Drawing.Point(40, 61);
            this.lblwpsenable.Name = "lblwpsenable";
            this.lblwpsenable.Size = new System.Drawing.Size(0, 13);
            this.lblwpsenable.TabIndex = 14;
            // 
            // btnConnected
            // 
            this.btnConnected.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnected.Location = new System.Drawing.Point(186, 43);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(111, 23);
            this.btnConnected.TabIndex = 12;
            this.btnConnected.Text = "Connected Devices";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.BtnConnected_Click);
            // 
            // lblwp
            // 
            this.lblwp.AutoSize = true;
            this.lblwp.Location = new System.Drawing.Point(6, 61);
            this.lblwp.Name = "lblwp";
            this.lblwp.Size = new System.Drawing.Size(38, 13);
            this.lblwp.TabIndex = 13;
            this.lblwp.Text = "WPS: ";
            // 
            // lblWifiName
            // 
            this.lblWifiName.AutoSize = true;
            this.lblWifiName.Location = new System.Drawing.Point(6, 39);
            this.lblWifiName.Name = "lblWifiName";
            this.lblWifiName.Size = new System.Drawing.Size(41, 13);
            this.lblWifiName.TabIndex = 11;
            this.lblWifiName.Text = "Name: ";
            // 
            // lblWifiStat
            // 
            this.lblWifiStat.AutoSize = true;
            this.lblWifiStat.Location = new System.Drawing.Point(6, 17);
            this.lblWifiStat.Name = "lblWifiStat";
            this.lblWifiStat.Size = new System.Drawing.Size(46, 13);
            this.lblWifiStat.TabIndex = 0;
            this.lblWifiStat.Text = "Status : ";
            // 
            // groupExtended
            // 
            this.groupExtended.Controls.Add(this.txtStatus);
            this.groupExtended.Location = new System.Drawing.Point(329, 67);
            this.groupExtended.Name = "groupExtended";
            this.groupExtended.Size = new System.Drawing.Size(200, 266);
            this.groupExtended.TabIndex = 18;
            this.groupExtended.TabStop = false;
            this.groupExtended.Text = "Extended Info";
            // 
            // groupAdvanced
            // 
            this.groupAdvanced.Controls.Add(this.button3);
            this.groupAdvanced.Controls.Add(this.button1);
            this.groupAdvanced.Controls.Add(this.button2);
            this.groupAdvanced.Controls.Add(this.chkQos);
            this.groupAdvanced.Controls.Add(this.lblQos);
            this.groupAdvanced.Controls.Add(this.chkUpnp);
            this.groupAdvanced.Controls.Add(this.lblUpnp);
            this.groupAdvanced.Controls.Add(this.comboQoS);
            this.groupAdvanced.Controls.Add(this.btnApply);
            this.groupAdvanced.Location = new System.Drawing.Point(12, 240);
            this.groupAdvanced.Name = "groupAdvanced";
            this.groupAdvanced.Size = new System.Drawing.Size(304, 93);
            this.groupAdvanced.TabIndex = 19;
            this.groupAdvanced.TabStop = false;
            this.groupAdvanced.Text = "Advanced Settings";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(98, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Troubleshooting";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(211, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Toolbox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // chkQos
            // 
            this.chkQos.AutoCheck = false;
            this.chkQos.AutoSize = true;
            this.chkQos.Location = new System.Drawing.Point(52, 72);
            this.chkQos.Name = "chkQos";
            this.chkQos.Size = new System.Drawing.Size(67, 17);
            this.chkQos.TabIndex = 23;
            this.chkQos.Text = "Disabled";
            this.chkQos.UseVisualStyleBackColor = true;
            this.chkQos.CheckStateChanged += new System.EventHandler(this.ChkQos_CheckStateChanged);
            this.chkQos.Click += new System.EventHandler(this.ChkQos_Click);
            // 
            // lblQos
            // 
            this.lblQos.AutoSize = true;
            this.lblQos.Location = new System.Drawing.Point(6, 73);
            this.lblQos.Name = "lblQos";
            this.lblQos.Size = new System.Drawing.Size(31, 13);
            this.lblQos.TabIndex = 22;
            this.lblQos.Text = "QoS:";
            // 
            // chkUpnp
            // 
            this.chkUpnp.AutoCheck = false;
            this.chkUpnp.AutoSize = true;
            this.chkUpnp.Location = new System.Drawing.Point(52, 50);
            this.chkUpnp.Name = "chkUpnp";
            this.chkUpnp.Size = new System.Drawing.Size(67, 17);
            this.chkUpnp.TabIndex = 21;
            this.chkUpnp.Text = "Disabled";
            this.chkUpnp.UseVisualStyleBackColor = true;
            this.chkUpnp.CheckedChanged += new System.EventHandler(this.ChkUpnp_CheckedChanged);
            this.chkUpnp.Click += new System.EventHandler(this.ChkUpnp_Click);
            // 
            // lblUpnp
            // 
            this.lblUpnp.AutoSize = true;
            this.lblUpnp.Location = new System.Drawing.Point(6, 51);
            this.lblUpnp.Name = "lblUpnp";
            this.lblUpnp.Size = new System.Drawing.Size(38, 13);
            this.lblUpnp.TabIndex = 20;
            this.lblUpnp.Text = "UPnP:";
            // 
            // btnApply
            // 
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(234, 64);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(63, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(541, 58);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 15;
            this.picBanner.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 343);
            this.Controls.Add(this.groupAdvanced);
            this.Controls.Add(this.groupExtended);
            this.Controls.Add(this.groupWifi);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.groupQuick);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP-Manager ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupQuick.ResumeLayout(false);
            this.groupWifi.ResumeLayout(false);
            this.groupWifi.PerformLayout();
            this.groupExtended.ResumeLayout(false);
            this.groupExtended.PerformLayout();
            this.groupAdvanced.ResumeLayout(false);
            this.groupAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnMac;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.CheckBox chkQos;
        private System.Windows.Forms.CheckBox chkUpnp;
        private System.Windows.Forms.CheckBox chkWifi;
        private System.Windows.Forms.ComboBox comboQoS;
        private System.Windows.Forms.GroupBox groupAdvanced;
        private System.Windows.Forms.GroupBox groupExtended;
        private System.Windows.Forms.GroupBox groupQuick;
        private System.Windows.Forms.GroupBox groupWifi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Label lblQos;
        private System.Windows.Forms.Label lblUpnp;
        private System.Windows.Forms.Label lblWifiName;
        private System.Windows.Forms.Label lblWifiPw;
        private System.Windows.Forms.Label lblWifiStat;
        private System.Windows.Forms.Label lblwp;
        private System.Windows.Forms.Label lblwpsenable;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ToolTip wpsTip;

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}
