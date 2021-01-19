using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TPManager.Forms
{
    public partial class Toolbox : Form
    {
        public Toolbox()
        {
            InitializeComponent();
        }

        private void Toolbox_Load(object sender, EventArgs e)
        {
            Theme.UpdateTheme(this);
            toolboxTip.SetToolTip(pictureDCA,
                "DCA – short for Direct Cache Access\t\n" +
                "can improve your connection by transferring data directly to your CPU cache." +
                "\t\nHowever, only certain motherboards actually support DCA\t\nso Windows disables DCA by default");

            toolboxTip.SetToolTip(pictureTune,
                "TCP receive window autotuning lets the operating system monitor bandwidth,\t\n" +
                "network delay, and application delay. The system can configure connections\t\n" +
                "by scaling the receive window to maximize network performance.");

            toolboxTip.SetToolTip(pictureDMA,
                "The purpose of NetDMA was to reduce CPU usage by offloading memcpy\t\n" +
                "to a generic offload engine.But in networking, we tend to handle fairly small buffers.\t\n" +
                "Thus it's disabled by default on windows 8 and up.");

            toolboxTip.SetToolTip(pictureHeur,
                "Scaling Heuristics is an algorithm to identify connectivity and throughput problems caused by many Firewalls\t\n" +
                "and other middle boxes that don't interpret Window Scaling option correctly.\t\n" +
                "The system will try to identify connectivity and throughput problems and take appropriate measures.");
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

            txtOutput.Text += $"Executed command: {command}\r\nOutput:{output}";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh int tcp set global dca=enabled");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh int tcp set global dca=disabled");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh int tcp set global autotuninglevel=normal");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh int tcp set global autotuninglevel=disabled");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh int tcp set global netdma=enabled");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh int tcp set global netdma=disabled");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh interface tcp set heuristics enabled");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ExecuteCommand("netsh interface tcp set heuristics disabled");
        }
    }
}
