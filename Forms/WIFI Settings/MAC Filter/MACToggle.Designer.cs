
namespace TPManager.Forms
{
    partial class MACToggle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MACToggle));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.allow = new System.Windows.Forms.RadioButton();
            this.deny = new System.Windows.Forms.RadioButton();
            this.disabled = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MAC Filter Mode: ";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(114, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // allow
            // 
            this.allow.AutoSize = true;
            this.allow.Location = new System.Drawing.Point(109, 9);
            this.allow.Name = "allow";
            this.allow.Size = new System.Drawing.Size(50, 17);
            this.allow.TabIndex = 7;
            this.allow.TabStop = true;
            this.allow.Text = "Allow";
            this.allow.UseVisualStyleBackColor = true;
            // 
            // deny
            // 
            this.deny.AutoSize = true;
            this.deny.Location = new System.Drawing.Point(165, 9);
            this.deny.Name = "deny";
            this.deny.Size = new System.Drawing.Size(50, 17);
            this.deny.TabIndex = 8;
            this.deny.TabStop = true;
            this.deny.Text = "Deny";
            this.deny.UseVisualStyleBackColor = true;
            // 
            // disabled
            // 
            this.disabled.AutoSize = true;
            this.disabled.Location = new System.Drawing.Point(221, 9);
            this.disabled.Name = "disabled";
            this.disabled.Size = new System.Drawing.Size(66, 17);
            this.disabled.TabIndex = 9;
            this.disabled.TabStop = true;
            this.disabled.Text = "Disabled";
            this.disabled.UseVisualStyleBackColor = true;
            // 
            // MACToggle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 74);
            this.Controls.Add(this.disabled);
            this.Controls.Add(this.deny);
            this.Controls.Add(this.allow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MACToggle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter Mode";
            this.Load += new System.EventHandler(this.MACToggle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton allow;
        private System.Windows.Forms.RadioButton deny;
        private System.Windows.Forms.RadioButton disabled;
    }
}