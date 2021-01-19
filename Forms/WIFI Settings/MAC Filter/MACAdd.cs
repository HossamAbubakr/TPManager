using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TPManager.Forms
{
    public partial class MACAdd : Form
    {
        public string Mac { get; private set; }
        public string tag { get; private set; }
        public MACAdd()
        {
            InitializeComponent();
        }
  
        private void Button1_Click(object sender, EventArgs e)
        {
            if (VerifyMac(textBox1.Text))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("The tag can't be left empty");
                }
                else
                {
                    Mac = textBox1.Text.Trim();
                    tag = textBox2.Text.Trim();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Please make sure you entered a valid MAC address");
            }
        }
        private void MACAdd_Load(object sender, EventArgs e)
        {
            ActiveControl = label1;
            Theme.UpdateTheme(this);
        }
        private bool VerifyMac(string mac)
        {
            var macRegex = new Regex("([0-9a-fA-F]{2}[:]){5}([0-9a-fA-F]{2})");
            var match = macRegex.Match(mac);
            return match.Success;
        }
    }
}
