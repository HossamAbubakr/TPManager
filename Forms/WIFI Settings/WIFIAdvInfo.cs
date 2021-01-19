using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TPManager.Extensions;

namespace TPManager.Forms
{
    public partial class WIFIAdvInfo : Form
    {
        private readonly Dictionary<string, string> _wifiDictionary;
        private Size _txtSize = new Size(251, 304);
        public WIFIAdvInfo(Dictionary<string, string> wifiDictionary)
        {
            InitializeComponent();
            _wifiDictionary = wifiDictionary;
        }
        private void WIFIAdvInfo_Load(object sender, EventArgs e)
        {
            ActiveControl = label1;
            UpdateTheme();
            foreach (var field in _wifiDictionary)
            {
                var tempValue = field.Value;
                if (field.Value == "" || field.Key == "WIFI Password") continue;
                if (field.Value == "enabled")
                {
                    tempValue = "True";
                }
                else if (field.Key.Contains("Enabled") || field.Key.Contains("Supported") || field.Value == "disabled")
                {
                    if (field.Value == "0")
                    {
                        tempValue = "False";
                    }
                    else if(field.Value == "1")
                    {
                        tempValue = "True";
                    }
                    else
                    {
                        tempValue = field.Value;
                    }
                }
                else if (field.Key == "WIFI Authentication" || field.Key == "WPA Encryption")
                {
                    tempValue = tempValue.ToUpper();
                }
                else if (field.Key == "MAC Filter Mode")
                {
                    tempValue = char.ToUpper(field.Value[0]) + field.Value.Substring(1);
                }
                txtStatus.AppendText( $"{field.Key} : {tempValue} \r\n");
                txtStatus.ColorText(tempValue, Color.CadetBlue);
            }
        }
        private void UpdateTheme()
        {
            if (Theme.CurrTheme == "Dark")
            {
                BackColor = ColorTranslator.FromHtml("#1E1E1E");
                txtStatus.BackColor = ColorTranslator.FromHtml("#2D2D2D");
                txtStatus.ForeColor = ColorTranslator.FromHtml("#DADADA");
            }
            else
            {
                BackColor = ColorTranslator.FromHtml("#FFFFFF");
                txtStatus.BackColor = ColorTranslator.FromHtml("#FAFAFA");
                txtStatus.ForeColor = ColorTranslator.FromHtml("#000000");
            }
        }
        private void TxtStatus_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            const int margin = 5;
            RichTextBox rch = sender as RichTextBox;
            _txtSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
            rch.ClientSize = _txtSize;
            this.CenterToScreen();
        }
    }
}
