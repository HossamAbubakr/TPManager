using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPManager.Forms
{
    public partial class SpeedComparison : Form
    {
        private string _htmlSpeed;
        private readonly string _currDownload;
        private readonly string _currUpload;
        private string _conDownload, _conUpload;
        private readonly HttpClient _httpClient;
        public SpeedComparison(string currDownload, string currUpload)
        {
            InitializeComponent();
            _currDownload = currDownload;
            _currUpload = currUpload;
            _httpClient = new HttpClient(new HttpClientHandler
            {
                UseProxy = false,
                UseCookies = false,
                AutomaticDecompression = DecompressionMethods.GZip,
            });

            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.129 Safari/537.36");
        }

        private void SpeedComparison_Load(object sender, EventArgs e)
        {
            ActiveControl = label1;
            UpdateTheme();
            LoadData();
        }
        private async void LoadData()
        {
            lbldownload.Text = (float.Parse(_currDownload) / 1000).ToString("0.##") + "Mbps";
            lblupload.Text = (float.Parse(_currUpload) / 1000).ToString("0.##") + "Mbps";
            var countries = Enum.GetNames(typeof(CountryEnum)).Select(item => item.Replace('_', ' ')).OrderBy(x => x.ToString()).ToList();
            comboBox1.DataSource = countries;
            await Task.WhenAll(GetSpeed(), GetCountry());
            button1.Enabled = true;
        }
        private async Task GetSpeed(int countryCode = 0)
        {
            if (_htmlSpeed == null)
            {
                const string url = "https://www.speedtest.net/global-index";
                lblworker.Text = "Worker : Loading Data...";
                _htmlSpeed = await GetData(url);
                lblworker.Text = "Worker : idle";
            }
            else
            {
                var regex = new Regex($"(\"country_id\":{countryCode},\"download_mbps\":\"[^\"]+\",\"upload_mbps\":\"[^\"]+\")");
                var matchCollection = regex.Matches(_htmlSpeed);
                _conDownload = GetTextBetween(matchCollection[0].Value, "\"download_mbps\":\"", "\",");
                _conUpload = GetTextBetween(matchCollection[0].Value, "\"upload_mbps\":\"", "\"").Replace(" ", "_");
                lbldownloadcon.Text = _conDownload + "Mbps";
                lbluploadcon.Text = _conUpload + "Mbps";
            }
        }
        private async Task GetCountry()
        {
            const string url = "http://ip-api.com/json/?fields=country";
            lblcountry.Text = "Loading...";
            var html = await GetData(url);
            if (html == null)
                return;
            var country = GetTextBetween(html, "{\"country\":\"", "\"}");
            lblcountry.Text = country;
        }
        private async Task<string> GetData(string url)
        {
            try
            {
                var html = await _httpClient.GetStringAsync(url);
                return html;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private static string GetTextBetween(string strSource, string strStart, string strEnd)
        {
            // Parse A Text From Between Two Specific Strings Credits Goes To /1178686/oscar In StackOverflow 
            if (!strSource.Contains(strStart) || !strSource.Contains(strEnd)) return "";
            var start = strSource.IndexOf(strStart, 0, StringComparison.Ordinal) + strStart.Length;
            var end = strSource.IndexOf(strEnd, start, StringComparison.Ordinal);
            return strSource.Substring(start, end - start);
        }

        private string CalculateData(string data, string input1, string input2)
        {
            string message;
            float percentage;
            float number1 = float.Parse(input1), number2 = float.Parse(input2) * 1000;
            if (number1 > number2)
            {
                percentage = ((number1 - number2) * 100) / number1;
                message = $"Your {data} speed is {percentage:0.##}% faster";
            }
            else if (number1 < number2)
            {
                percentage = ((number2 - number1) * 100) / number2;
                message = $"Your {data} speed is {percentage:0.##}% slower";
            }
            else
            {
                message = $"Your {data} speed is equal";
            }
            return message;
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            var qosValue = (int)(CountryEnum)Enum.Parse(typeof(CountryEnum), comboBox1.SelectedValue.ToString().Replace(" ", "_"));
            await GetSpeed(qosValue);
            lblworker.Text = CalculateData("download", _currDownload, _conDownload);
            lbldowncomp.Text = CalculateData("upload", _currUpload, _conUpload);
        }
        private void UpdateTheme()
        {
            Theme.UpdateTheme(this);
        }
    }
}
