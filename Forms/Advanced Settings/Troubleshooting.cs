using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TPManager.Forms
{
    public partial class Troubleshooting : Form
    {
        public Troubleshooting()
        {
            InitializeComponent();
        }

        private void Troubleshooting_Load(object sender, EventArgs e)
        {
            Theme.UpdateTheme(this);
            toolboxTip.SetToolTip(pictureRenew,
                "Releasing and Renewing the IP address of the computer will fix most minor glitches and errors.\t\n" +
                "It also refreshes the internet connection, which allows other changes and troubleshooting to take effect.");

            toolboxTip.SetToolTip(pictureDNS,
                "Your PC keeps a list of websites hostnames and IP addresses that you visit and saves it in DNS resolver cache.\t\n" +
                "any corruption in the DNS resolver cache could lead to slower or no access to websites.");

            toolboxTip.SetToolTip(pictureSock,
                "Windows uses multiple network sockets to exchange information,However, any corruption in sockets or an infected LSP\t\n" +
                "could lead to slow connection, website redirects, or even no access to websites.");

            toolboxTip.SetToolTip(pictureStatic,
                "Resetting your computer’s Internet Protocol (TCP/IP) settings to default can solve some browsing issues\t\n" +
                "particularly in case of a misconfigured NUC (Network interface controller).");
        }
        private void ExecuteCommand(string command)
        {
            string output = "";
            Process process = new Process
            {
                StartInfo =
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    FileName = "cmd.exe",
                    Arguments = "/C " + command
                }
            };
            process.Start();
            process.WaitForExit();
            if (process.HasExited)
            {
                output = process.StandardOutput.ReadToEnd();
            }

            txtOutput.Text += $"Executed command: {command}\r\nOutput:{(output == "" ? "Ok" : output)}";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ExecuteCommand("ipconfig /release");
            ExecuteCommand("ipconfig /renew");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ExecuteCommand("ipconfig /flushdns");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh winsock reset");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh int ip reset");
        }
    }
}
