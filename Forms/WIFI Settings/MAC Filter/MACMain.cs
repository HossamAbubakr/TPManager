using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TPManager.Properties;

namespace TPManager.Forms
{
    public partial class MACFilter : Form
    {
        readonly RouterConnector _routerConnector;
        private List<Mac> macList = new List<Mac>();
        private string filterMode;
        public MACFilter(string ip, string username, string password)
        {
            InitializeComponent();
            _routerConnector = new RouterConnector(ip, username, password);
        }
        private async void MACFilter_Load(object sender, EventArgs e)
        {
            ActiveControl = lblFilter;
            UpdateTheme();
            try
            {
                filterMode = await _routerConnector.Info.GetWifiSecuInfoByField(WifiSecEnum.MAC_Filter_Mode);
                SetMacFilter(filterMode);
                var addresses = await _routerConnector.Info.GetMacFilter();
                macList = SettingsSerializer.Settings.Mac;
                if (addresses.Count <= 0) return;
                foreach (var address in addresses)
                {
                    if (macList != null)
                    {
                        lstMac.Items.Add(address).SubItems.Add(GetTag(address));
                    }
                    else
                    {
                        lstMac.Items.Add(address);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetMacFilter(string filterMode)
        {
            switch (filterMode)
            {
                case "disabled":
                    lblFilter.Text = "Disabled     ";
                    macTip.SetToolTip(lblFilter, "All devices with a valid password are allowed into the network.");
                    break;
                case "allow":
                    lblFilter.Text = "Allow Mode     ";
                    lblFilter.ForeColor = Color.CadetBlue;
                    macTip.SetToolTip(lblFilter, "Only the devices in the filter are allowed into the network.");
                    break;
                case "deny":
                    lblFilter.Text = "Block Mode     ";
                    lblFilter.ForeColor = Color.Crimson;
                    macTip.SetToolTip(lblFilter, "Devices in the filter are banned from the network even if they have a valid password.");
                    break;
            }
        }
        private void AddTag(string mac, string tag)
        {
            SettingsSerializer.AddMAC(mac, tag);
        }
        private string GetTag(string address)
        {
            var mac = macList.Where(m => m.Address == address).FirstOrDefault();
            if(mac == null)
            {
                return "";
            }
            return mac.Tag;
        }
        private void ModifyTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.MACTag())
            {
                if (form.ShowDialog() != DialogResult.OK) return;
                var tag = form.tag;
                var mac = lstMac.SelectedItems[0].Text;
                AddTag(mac, tag);
                if (lstMac.SelectedItems[0].SubItems.Count == 1)
                {
                    lstMac.SelectedItems[0].SubItems.Add(tag);
                }
                else
                {
                    lstMac.SelectedItems[0].SubItems[1].Text = tag;
                }
            }
        }
        private void ContextMac_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lstMac.SelectedItems.Count < 0)
            {
                contextMac.Items[1].Enabled = false;
                contextMac.Items[2].Enabled = false;
            }
            else
            {
                contextMac.Items[1].Enabled = true;
                contextMac.Items[2].Enabled = true;

            }
        }
        private void AddMACAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new MACAdd())
            {
                if (form.ShowDialog() != DialogResult.OK) return;
                var mac = form.Mac.ToUpper();
                var tag = form.tag;
                if (macList == null || !macList.Any(m => m.Address == form.Mac.ToUpper()))
                {
                    _routerConnector?.Action.AddMacToFilter(mac);
                    SettingsSerializer.AddMAC(mac, tag);
                    lstMac.Items.Add(mac).SubItems.Add(tag);
                    macList?.Add( new Mac { Address= mac,Tag = tag });
                }
                else
                {
                    MessageBox.Show($"MAC address {mac} already exists in the filter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
        }
        private void RemoveMACAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMac.SelectedItems.Count > 0)
            {
                var response = MessageBox.Show("Are you sure you want to delete this MAC Address? Depending on the filter mode this might not be able to connect to this router until its added again. Continue?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (response != DialogResult.Yes) return;
                var mac = lstMac.SelectedItems[0].Text;
                _routerConnector?.Action.RemoveMacFromFilter(mac);
                SettingsSerializer.RemoveMAC(mac);
                lstMac.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("No MAC-Address selected, Please make sure to select an item for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void UpdateTheme()
        {
            lblFilter.ImageAlign = ContentAlignment.MiddleRight;
            lblFilter.Image = Theme.CurrTheme == "Dark" ? Resources.question : Resources.questionDark;
            Theme.UpdateTheme(this);
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Warning! Changing your MAC filter settings can lock you out from using the Internet on all devices connected to the WIFI, Please only proceed if you know what you are doing.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (var form = new MACToggle(filterMode))
                {
                    var dialogResult = form.ShowDialog();
                    if(dialogResult == DialogResult.OK)
                    {
                        if(form.filterMode != filterMode)
                        { 
                        filterMode = form.filterMode;
                        SetMacFilter(filterMode);
                        MACEnum macMode = (MACEnum)Enum.Parse(typeof(MACEnum), filterMode);
                        await _routerConnector.Action.ToggleMac(macMode);
                        MessageBox.Show("MAC Restriction Mode Updated.");
                        }
                    }
                }
            }
        }
    }
}
