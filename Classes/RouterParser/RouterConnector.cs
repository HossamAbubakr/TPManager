using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace TPManager
{
    partial class RouterConnector
    {
        protected readonly string _ip;
        private readonly HttpClient _httpClient;
        public RouterInfo Info;
        public RouterActions Action;
        public RouterConnector(string ip, string name, string password)
        {
            _ip = ip;
            _httpClient = new HttpClient(new HttpClientHandler { UseCookies = false });
            _httpClient.DefaultRequestHeaders.Referrer = new Uri($"http://{_ip}/");
            _httpClient.DefaultRequestHeaders.Add("Cookie", "Authorization=Basic " + Convert.ToBase64String(Encoding.Default.GetBytes($"{name}:{password}")));
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
            _httpClient.Timeout = TimeSpan.FromSeconds(5);
            Action = new RouterActions(_ip, _httpClient);
            Info = new RouterInfo(_ip, _httpClient);
        }
        public async Task Login()
        {
            // String Holding The Login URL
            var link = $"http://{_ip}/info.html";
            // Sending A Get Request And Getting The Result
            string response;
            try
            {
                response = await GetRequestAsync(link);
            }
            catch (Exception)
            {
                throw new ArgumentException("Request failed, please verify the router IP and try again");
            }
            if (response.Contains("The username or password is incorrect")) // Wrong Password or Username
            {
                throw new ArgumentException("Invalid username or password, please verify the login information and try again");
            }
        }
        private async Task<string> GetRequestAsync(string url)
        {
            return await _httpClient.GetStringAsync(url);
        }

    }
}
