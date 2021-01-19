using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace TPManager.Forms
{
    public partial class ConnectedDevices : Form
    {
        private readonly List<(string, string, string, string)> _devices;
        public ConnectedDevices(List<(string, string, string, string)> Devices)
        {
            InitializeComponent();
            _devices = Devices;
        }

        private void ConnectedDevices_Load(object sender, EventArgs e)
        {
            Theme.UpdateTheme(this);
            if (_devices == null) return;
            foreach (var (DeviceName, MACAdress, NetworkIP, TimeOnline) in _devices)
            {
                var listItem = new ListViewItem(DeviceName);
                listItem.SubItems.Add(MACAdress);
                listItem.SubItems.Add(NetworkIP);
                listItem.SubItems.Add(TimeOnline);
                lstConnected.Items.Add(listItem);
            }
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            macStrip.Enabled = lstConnected.SelectedItems.Count > 0;
        }

        private void MacStrip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lstConnected.SelectedItems[0].SubItems[1].Text);
        }
    }
}
