namespace TPManager.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button1 = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lblmodel = new System.Windows.Forms.Label();
            this.picIP = new System.Windows.Forms.PictureBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picID = new System.Windows.Forms.PictureBox();
            this.picBorder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(71, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(12, 58);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(192, 20);
            this.txtuser.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(12, 84);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(192, 20);
            this.txtpass.TabIndex = 2;
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(12, 110);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(192, 20);
            this.txtip.TabIndex = 7;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.ForeColor = System.Drawing.Color.Black;
            this.chkRemember.Location = new System.Drawing.Point(12, 136);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(114, 17);
            this.chkRemember.TabIndex = 8;
            this.chkRemember.Text = "Remember my Info";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.BackColor = System.Drawing.Color.Transparent;
            this.lblmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.ForeColor = System.Drawing.Color.White;
            this.lblmodel.Location = new System.Drawing.Point(9, 14);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(89, 16);
            this.lblmodel.TabIndex = 13;
            this.lblmodel.Text = "Router Model";
            // 
            // picIP
            // 
            this.picIP.Image = ((System.Drawing.Image)(resources.GetObject("picIP.Image")));
            this.picIP.Location = new System.Drawing.Point(185, 112);
            this.picIP.Name = "picIP";
            this.picIP.Size = new System.Drawing.Size(16, 16);
            this.picIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picIP.TabIndex = 12;
            this.picIP.TabStop = false;
            // 
            // picPass
            // 
            this.picPass.Image = ((System.Drawing.Image)(resources.GetObject("picPass.Image")));
            this.picPass.Location = new System.Drawing.Point(185, 86);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(16, 16);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPass.TabIndex = 11;
            this.picPass.TabStop = false;
            // 
            // picID
            // 
            this.picID.Image = ((System.Drawing.Image)(resources.GetObject("picID.Image")));
            this.picID.Location = new System.Drawing.Point(185, 60);
            this.picID.Name = "picID";
            this.picID.Size = new System.Drawing.Size(16, 16);
            this.picID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picID.TabIndex = 10;
            this.picID.TabStop = false;
            // 
            // picBorder
            // 
            this.picBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBorder.Location = new System.Drawing.Point(0, 0);
            this.picBorder.Name = "picBorder";
            this.picBorder.Size = new System.Drawing.Size(216, 44);
            this.picBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBorder.TabIndex = 9;
            this.picBorder.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(216, 189);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.picIP);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.picID);
            this.Controls.Add(this.picBorder);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.PictureBox picBorder;
        private System.Windows.Forms.PictureBox picID;
        private System.Windows.Forms.PictureBox picIP;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;

        #endregion
    }
}