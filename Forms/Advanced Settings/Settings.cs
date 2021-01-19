using System;
using System.Diagnostics;
using System.Windows.Forms;
using TPManager.Properties;

namespace TPManager.Forms
{
    public partial class Settings : Form
    {
        public bool isDark = false;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            isDark = SettingsSerializer.Settings.Application.Dark;
            Theme.UpdateTheme(this);
            UpdateButton();
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (isDark)
            {
                pictureBox1.Image = Resources.ToLight;

            } else
            {
                pictureBox1.Image = Resources.ToDark;
            }
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            UpdateButton();
            //pictureBox1.Image = (Bitmap)(Resources.ResourceManager.GetObject(name));
        }
        private void UpdateButton()
        {
            if (isDark)
            {
                pictureBox1.Image = Resources.Dark;

            }
            else
            {
                pictureBox1.Image = Resources.Light;
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            isDark = !isDark;
            UpdateButton();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SettingsSerializer.Settings.Application.Dark = isDark;
            SettingsSerializer.WriteSettings();
            MessageBox.Show("Settings saved! Please restart the app for these changes to take effect.", "Settings successfully saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/HossamAbubakr/TPManager");
        }
    }
}
