using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TPManager.Properties;
namespace TPManager.Forms
{
    public partial class Login : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        bool darkMode = false;
        public Login()
        {
            InitializeComponent();
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            var _username = txtuser.Text.Trim();
            var _password = txtpass.Text.Trim();
            var _ip = txtip.Text.Trim();

            if (VerifyIp(txtip.Text))
            {
                button1.Enabled = false;
                try
                {
                    var routerConnector = new RouterConnector(_ip, _username, _password);
                    await routerConnector.Login();
                    if (chkRemember.Checked)
                    {
                        SettingsSerializer.Settings.Application.Remember = true;
                        SettingsSerializer.UpdateLogin(_ip, _username, _password);
                    }
                    else
                    {
                        SettingsSerializer.Settings.Application.Remember = false;
                        SettingsSerializer.Settings.Application.Dark = false;
                    }

                    var form1 = new Main(_ip, _username, _password);
                    form1.Show();
                    Hide();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    if (ex.Message.Contains("IP"))
                    {
                        txtip.Focus();
                    }
                    else
                    {
                        txtuser.Focus();
                    }
                }

                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please make sure you entered a valid IP address");
            }
        }
        private void LoadData()
        {
            try
            {
                SettingsSerializer.ReadSettings();
                if (SettingsSerializer.Settings.Application.Remember)
                {
                    txtip.Text = SettingsSerializer.Settings.Router.Ip;
                    txtuser.Text = SettingsSerializer.Settings.Router.Username;
                    txtpass.Text = SettingsSerializer.Settings.Router.Password;
                    lblmodel.Text = SettingsSerializer.Settings.Router.Model;
                    darkMode = SettingsSerializer.Settings.Application.Dark;
                    chkRemember.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SettingsSerializer.WriteSettings();
            }
            UpdateTheme(darkMode);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblmodel.Parent = picBorder;
            ActiveControl = lblmodel;
            SendMessage(txtip.Handle, EM_SETCUEBANNER, 0, "IP Address ex 192.168.1.1");
            SendMessage(txtuser.Handle, EM_SETCUEBANNER, 0, "Username ex admin");
            SendMessage(txtpass.Handle, EM_SETCUEBANNER, 0, "Password ex admin");
            LoadData();
        }

        private static bool VerifyIp(string ip)
        {
            var ipRegex = new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$");
            var match = ipRegex.Match(ip);
            return match.Success;
        }
        private void UpdateTheme(bool isDark)
        {
            if (isDark)
            {
                Theme.DarkTheme();
                picBorder.Image = Resources.BorderDark;
                picID.Image = Resources.usernameDark;
                picPass.Image = Resources.passwordDark;
                picIP.Image = Resources.ipDark;
            }
            else
            {
                Theme.LightTheme();
                picBorder.Image = Resources.Border;
                picID.Image = Resources.username;
                picPass.Image = Resources.password;
                picIP.Image = Resources.ip;
            }
            Theme.UpdateTheme(this);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingsSerializer.WriteSettings();
        }
    }
}
