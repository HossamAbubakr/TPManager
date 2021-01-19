
namespace TPManager.Forms
{
    partial class Troubleshooting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Troubleshooting));
            this.pictureStatic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pictureRenew = new System.Windows.Forms.PictureBox();
            this.pictureDNS = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureSock = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolboxTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatic)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRenew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDNS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSock)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureStatic
            // 
            this.pictureStatic.Image = global::TPManager.Properties.Resources.questionDark;
            this.pictureStatic.Location = new System.Drawing.Point(115, 3);
            this.pictureStatic.Name = "pictureStatic";
            this.pictureStatic.Size = new System.Drawing.Size(10, 10);
            this.pictureStatic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureStatic.TabIndex = 12;
            this.pictureStatic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Location = new System.Drawing.Point(11, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 173);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtOutput.Location = new System.Drawing.Point(6, 19);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(506, 148);
            this.txtOutput.TabIndex = 14;
            // 
            // pictureRenew
            // 
            this.pictureRenew.Image = global::TPManager.Properties.Resources.questionDark;
            this.pictureRenew.Location = new System.Drawing.Point(115, 0);
            this.pictureRenew.Name = "pictureRenew";
            this.pictureRenew.Size = new System.Drawing.Size(10, 10);
            this.pictureRenew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureRenew.TabIndex = 10;
            this.pictureRenew.TabStop = false;
            this.toolboxTip.SetToolTip(this.pictureRenew, resources.GetString("pictureRenew.ToolTip"));
            // 
            // pictureDNS
            // 
            this.pictureDNS.Image = global::TPManager.Properties.Resources.questionDark;
            this.pictureDNS.Location = new System.Drawing.Point(115, 0);
            this.pictureDNS.Name = "pictureDNS";
            this.pictureDNS.Size = new System.Drawing.Size(10, 10);
            this.pictureDNS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureDNS.TabIndex = 9;
            this.pictureDNS.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(13, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Execute";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureStatic);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(404, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 56);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reset Static IP";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureRenew);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(11, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 56);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Renew IP address";
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(13, 20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(99, 23);
            this.button11.TabIndex = 7;
            this.button11.Text = "Execute";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureSock);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Location = new System.Drawing.Point(273, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 56);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reset Winsock";
            // 
            // pictureSock
            // 
            this.pictureSock.Image = global::TPManager.Properties.Resources.questionDark;
            this.pictureSock.Location = new System.Drawing.Point(115, 3);
            this.pictureSock.Name = "pictureSock";
            this.pictureSock.Size = new System.Drawing.Size(10, 10);
            this.pictureSock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureSock.TabIndex = 11;
            this.pictureSock.TabStop = false;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(13, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "Execute";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureDNS);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Location = new System.Drawing.Point(142, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 56);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flush DNS cache";
            // 
            // toolboxTip
            // 
            this.toolboxTip.AutoPopDelay = 10000;
            this.toolboxTip.InitialDelay = 500;
            this.toolboxTip.ReshowDelay = 100;
            this.toolboxTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolboxTip.ToolTipTitle = "Information";
            // 
            // Troubleshooting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 254);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Troubleshooting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troubleshooting";
            this.Load += new System.EventHandler(this.Troubleshooting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRenew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDNS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSock)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureStatic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.PictureBox pictureRenew;
        private System.Windows.Forms.ToolTip toolboxTip;
        private System.Windows.Forms.PictureBox pictureDNS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureSock;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}