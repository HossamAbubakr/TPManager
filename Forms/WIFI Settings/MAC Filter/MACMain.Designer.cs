namespace TPManager.Forms
{
    partial class MACFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MACFilter));
            this.lstMac = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMac = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMACAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMACAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.macTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.contextMac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMac
            // 
            this.lstMac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstMac.ContextMenuStrip = this.contextMac;
            this.lstMac.FullRowSelect = true;
            this.lstMac.GridLines = true;
            this.lstMac.HideSelection = false;
            this.lstMac.Location = new System.Drawing.Point(12, 35);
            this.lstMac.Name = "lstMac";
            this.lstMac.Size = new System.Drawing.Size(252, 199);
            this.lstMac.TabIndex = 3;
            this.lstMac.UseCompatibleStateImageBehavior = false;
            this.lstMac.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MAC Address";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tag";
            this.columnHeader2.Width = 101;
            // 
            // contextMac
            // 
            this.contextMac.ImeMode = System.Windows.Forms.ImeMode.On;
            this.contextMac.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMACAddressToolStripMenuItem,
            this.modifyTagToolStripMenuItem,
            this.removeMACAddressToolStripMenuItem});
            this.contextMac.Name = "contextMac";
            this.contextMac.ShowImageMargin = false;
            this.contextMac.Size = new System.Drawing.Size(168, 70);
            this.contextMac.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMac_Opening);
            // 
            // addMACAddressToolStripMenuItem
            // 
            this.addMACAddressToolStripMenuItem.Name = "addMACAddressToolStripMenuItem";
            this.addMACAddressToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addMACAddressToolStripMenuItem.Text = "Add MAC Address";
            this.addMACAddressToolStripMenuItem.Click += new System.EventHandler(this.AddMACAddressToolStripMenuItem_Click);
            // 
            // modifyTagToolStripMenuItem
            // 
            this.modifyTagToolStripMenuItem.Name = "modifyTagToolStripMenuItem";
            this.modifyTagToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modifyTagToolStripMenuItem.Text = "Set/Modify Tag";
            this.modifyTagToolStripMenuItem.Click += new System.EventHandler(this.ModifyTagToolStripMenuItem_Click);
            // 
            // removeMACAddressToolStripMenuItem
            // 
            this.removeMACAddressToolStripMenuItem.Name = "removeMACAddressToolStripMenuItem";
            this.removeMACAddressToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.removeMACAddressToolStripMenuItem.Text = "Remove MAC Address";
            this.removeMACAddressToolStripMenuItem.Click += new System.EventHandler(this.RemoveMACAddressToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAC Filter Mode: ";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(100, 11);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(0, 13);
            this.lblFilter.TabIndex = 5;
            // 
            // macTip
            // 
            this.macTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(179, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Change Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MACFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MACFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MAC Filter";
            this.Load += new System.EventHandler(this.MACFilter_Load);
            this.contextMac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem addMACAddressToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMac;
        private System.Windows.Forms.ListView lstMac;
        private System.Windows.Forms.ToolStripMenuItem modifyTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMACAddressToolStripMenuItem;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ToolTip macTip;
        private System.Windows.Forms.Button button1;
    }
}
