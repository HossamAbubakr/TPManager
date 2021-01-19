using System;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPManager.Properties;

namespace TPManager.Forms
{
    public partial class Main : Form
    {
        readonly RouterConnector _routerConnector;
        public string Model;
        private bool qoscheck;
        readonly string _ip;
        readonly string _username;
        readonly string _password;
        private int counter = 60;
        public Main(string ip, string username, string password)
        {
            InitializeComponent();
            _ip = ip;
            _username = username;
            _password = password;
            _routerConnector = new RouterConnector(ip, username, password);
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = label1;
            lblDash.Parent = picBanner;
            UpdateTheme();
            comboQoS.DataSource = Enum.GetValues(typeof(QoSEnum));
            await LoadRouterData();
            Model = await _routerConnector.Info.GetInfoByField(InfoEnum.Hardware_Version);
            Model = string.Join(" ", Model.Split().Take(2));
            SettingsSerializer.Settings.Router.Model = Model;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private async Task LoadRouterData(bool forceUpdate = false)
        {
            txtStatus.Text = "";
            var fullInfo = await _routerConnector.Info.GetInfo(forceUpdate);
            lblWifiName.Text = "Name: " + await _routerConnector.Info.GetWifiInfoByField(WifiEnum.WIFI_Name);
            var wifiPassword = await _routerConnector.Info.GetWifiSecuInfoByField(WifiSecEnum.WIFI_Password);
            lblWifiPw.Text = "Password: " + wifiPassword.Substring(wifiPassword.Length - 4).PadLeft(wifiPassword.Length, '*');
            var qos = await _routerConnector.Info.GetQoS();
            if (qos.Item1)
            {
                comboQoS.Visible = true;
                btnApply.Visible = true;
                Enum.TryParse(qos.Item2.ToString(), out QoSEnum qosfield);
                comboQoS.SelectedItem = qosfield;
            }
            chkQos.Checked = qos.Item1;
            chkUpnp.Checked = await _routerConnector.Info.IsUPnPEnabled();
            chkWifi.Checked = await _routerConnector.Info.GetWifiInfoByField(WifiEnum.WIFI_Enabled) == "1";
            if (await _routerConnector.Info.GetWifiSecuInfoByField(WifiSecEnum.WPS_Enabled) == "enabled")
            {
                lblwpsenable.Text = "Enabled     ";
                lblwpsenable.ForeColor = Color.Crimson;
                wpsTip.SetToolTip(lblwpsenable, "Warning WPS is enabled! It can be easily exploited. Please go to the quick tools menu to disable it.");
                wpsTip.ToolTipIcon = ToolTipIcon.Warning;
            }
            else
            {
                lblwpsenable.Text = "Disabled     ";
                lblwpsenable.ForeColor = Color.CadetBlue;
                wpsTip.SetToolTip(lblwpsenable, "WPS is disabled, that's the expected behavior.");
                wpsTip.ToolTipIcon = ToolTipIcon.Info;
            }

            foreach (var item in fullInfo)
            {
                txtStatus.Text += $"{item.Key} : {item.Value}\r\n";
            }
        }
        private async void ChkWifi_Click(object sender, EventArgs e)
        {
            if (chkWifi.Checked)
            {
                var result = MessageBox.Show("Are you sure you want to disable the WIFI? devices that are depending on it such as printers might fail", "Confirm",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;
                await _routerConnector.Action.ToggleWifi(false);
                chkWifi.Checked = false;
            }
            else
            {
                chkWifi.Checked = true;
                await _routerConnector.Action.ToggleWifi(true);
            }
        }
        private void ChkWifi_CheckedChanged(object sender, EventArgs e)
        {
            chkWifi.Text = chkWifi.Checked ? "Enabled" : "Disabled";
            chkWifi.ForeColor = chkWifi.Checked ? Color.CadetBlue : Color.Crimson;
        }
        private async void ChkUpnp_Click(object sender, EventArgs e)
        {
            if (chkUpnp.Checked)
            {
                var result = MessageBox.Show("Are you sure you want to disable UPnP? services that are depending on it such as Torrent clients might fail", "Confirm",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;
                await _routerConnector.Action.ToggleUPNP(false);
                chkUpnp.Checked = false;
            }
            else
            {
                chkUpnp.Checked = true;
                await _routerConnector.Action.ToggleUPNP(true);
            }
        }
        private void ChkUpnp_CheckedChanged(object sender, EventArgs e)
        {
            chkUpnp.Text = chkUpnp.Checked ? "Enabled" : "Disabled";
        }
        private async void ChkQos_Click(object sender, EventArgs e)
        {
            if (chkQos.CheckState != CheckState.Indeterminate)
            {
                MessageBox.Show("Make sure to apply the settings for it to take effect", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                qoscheck = qoscheck == false;
                chkQos.CheckState = CheckState.Indeterminate;
            }
            else
            {
                var qos = await _routerConnector.Info.GetQoS();
                chkQos.CheckState = qos.Item1 ? CheckState.Checked : CheckState.Unchecked;
                qoscheck = qos.Item1;
            }
        }
        private void ChkQos_CheckStateChanged(object sender, EventArgs e)
        {
            switch (chkQos.CheckState)
            {
                case CheckState.Checked:
                    chkQos.Text = "Enabled";
                    break;
                case CheckState.Indeterminate:
                    chkQos.Text = "Pending";
                    comboQoS.Visible = true;
                    btnApply.Visible = true;
                    break;
                default:
                    chkQos.Text = "Disabled";
                    comboQoS.Visible = false;
                    btnApply.Visible = false;
                    break;
            }

            if (chkQos.CheckState != CheckState.Indeterminate)
            {
                qoscheck = chkQos.Checked;
            }
        }
        private void UpdateTheme()
        {
            picBanner.Image = Theme.CurrTheme == "Light" ? Resources.Border2 : Resources.Border2Dark;
            lblwpsenable.Image = Theme.CurrTheme == "Light" ? Resources.questionDark : Resources.question;
            Theme.UpdateTheme(this);
        }
        private void BtnRestart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restart your router?", "Attention!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) != DialogResult.Yes) return;
            _routerConnector?.Action.Restart();
            btnRestart.Text = counter.ToString();
            DisableControls(false);
            timer1.Start();
        }
        private async void BtnSpeed_Click(object sender, EventArgs e)
        {
            var currDownSpeed = await _routerConnector.Info.GetInfoByField(InfoEnum.Line_Download_Speed);
            var currUpSpeed = await _routerConnector.Info.GetInfoByField(InfoEnum.Line_Upload_Speed);

            var speedComparison = new SpeedComparison(currDownSpeed, currUpSpeed);
            speedComparison.ShowDialog();
        }
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            await LoadRouterData(true);
            btnRefresh.Enabled = true;

        }
        private void BtnMac_Click(object sender, EventArgs e)
        {
            var macFilter = new MACFilter(_ip, _username, _password);
            macFilter.ShowDialog();
        }
        private async void BtnApply_Click(object sender, EventArgs e)
        {
            if (qoscheck)
            {
                var qosValue = (int)(QoSEnum)Enum.Parse(typeof(QoSEnum), comboQoS.SelectedValue.ToString());
                await _routerConnector.Action.SetQoS(true, qosValue);
                chkQos.CheckState = CheckState.Checked;
            }
            else
            {
                await _routerConnector.Action.SetQoS(false);
                chkQos.CheckState = CheckState.Unchecked;
                comboQoS.Visible = false;
                btnApply.Visible = false;
            }
            MessageBox.Show("Settings Applied!");
        }
        private async void BtnConnected_Click(object sender, EventArgs e)
        {
            var devices = await _routerConnector.Info.GetConnectedDevices();
            var connectedDevices = new ConnectedDevices(devices);
            connectedDevices.ShowDialog();
        }
        private async void BtnAdvanced_Click(object sender, EventArgs e)
        {
            var info = await _routerConnector.Info.GetFullWifiInfo();
            var WifiAdvInfo = new WIFIAdvInfo(info);
            WifiAdvInfo.ShowDialog();
        }

        // Disable/Enable all groupboxes when a restart is initiated then finished
        private void DisableControls(bool enable)
        {
            foreach (Control c in Controls.OfType<GroupBox>())
            {
                c.Enabled = enable;
            }
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter < 1)
            {
                timer1.Stop();
                btnRestart.Text = "Restart Router";
                await LoadRouterData(true);
                DisableControls(false);
            }
            btnRestart.Text = counter.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(IsAdministrator())
            {
                var toolbox = new Toolbox();
                toolbox.ShowDialog();
            } else
            {
                MessageBox.Show("The commands in the toolbox require an elevated command prompt to run, please run the app as an administrator to use this feature.", "Permission required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (IsAdministrator())
            {
                var troubleshooter = new Troubleshooting();
                troubleshooter.ShowDialog();
            }
            else
            {
                MessageBox.Show("The commands in the toolbox require an elevated command prompt to run, please run the app as an administrator to use this feature.", "Permission required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
        }
    }
}
