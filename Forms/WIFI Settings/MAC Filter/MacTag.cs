using System;
using System.Windows.Forms;

namespace TPManager.Forms
{
    public partial class MACTag : Form
    {
        public string tag { get; private set; }
        public MACTag()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                tag = textBox1.Text.Trim();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("The tag can't be left empty");
            }
        }
        private void MACTag_Load(object sender, EventArgs e)
        {
            Theme.UpdateTheme(this);
        }
    }
}
