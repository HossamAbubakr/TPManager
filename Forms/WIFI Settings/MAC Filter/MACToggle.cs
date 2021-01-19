using System;
using System.Linq;
using System.Windows.Forms;

namespace TPManager.Forms
{
    public partial class MACToggle : Form
    {
        public string filterMode;
        public MACToggle(string filterMode)
        {
            InitializeComponent();
            this.filterMode = filterMode;

        }

        private void MACToggle_Load(object sender, EventArgs e)
        {
            Theme.UpdateTheme(this);
            foreach (RadioButton r in Controls.OfType<RadioButton>())
            {
                r.Checked = r.Name == filterMode;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (RadioButton r in Controls.OfType<RadioButton>())
            {
                filterMode = r.Checked ? r.Name: filterMode;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
