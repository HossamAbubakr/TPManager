using System.Net.Http;
using System.Threading.Tasks;
using TPManager.Extensions;
namespace TPManager
{
    partial class RouterConnector {
        public class RouterActions
        {
            private readonly string _ip;
            private readonly HttpClient _httpClient;
            public RouterActions(string ip, HttpClient httpClient)
            {
                _ip = ip;
                _httpClient = httpClient;
            }

            public async Task ToggleWifi(bool enabled)
            {   // String Holding The WifiState URL State 0 = Disabled/State 1 = Enabled
                var state = enabled ? "1" : "0"; // Restricts the input instead of an accidental number outside of 0,1
                var link = $"http://{_ip}/wlcfg.wl?wlSsidIdx=0&wlEnbl={state}&";
                await AuthenticateRequest(link);
            }
            private async Task SetWifiName(string name)
            {
                var link = $"http://{_ip}/wlcfg.wl?wlSsidIdx=0&wlEnbl=1&wlSsid={name}&";
                await AuthenticateRequest(link);
            }

            public async Task ToggleUPNP(bool enabled)
            {
                var state = enabled ? "1" : "0";
                var link = $"http://{_ip}/upnpcfg.cgi?enblUpnp={state}&";
                await AuthenticateRequest(link);
            }
            public async Task SetDns(string fullDns)
            {
                var dns = fullDns.Split(':');
                var link = $"http://{_ip}/dnscfg.cgi?dnsPrimary={dns[0]}&dnsSecondary={dns[1]}&dnsIfcsList=&dnsRefresh=1&";
                await AuthenticateRequest(link);
            }

            public async Task DisableWps()
            {
                var link = $"http://{_ip}/wlsecurity.wl?wl_wsc_mode=disabled&";
                await AuthenticateRequest(link);
            }

            public async Task SetQoS(bool enable, int qos = -1)
            {   // String Holding The QoS URL State 0 = Disabled/State 1 = Enabled //enblQos
                var qosConfig = enable
                    ? $"http://{_ip}/qosmgmt.cmd?action=savapply&enblQos=1&defaultQueue=-1&defaultDscpMark={qos}&"
                    : $"http://{_ip}/qosmgmt.cmd?action=savapply&enblQos=0&defaultQueue=-1&defaultDscpMark=-1&";
                await AuthenticateRequest(qosConfig);
            }
            public async Task Restart()
            {
                var link = $"http://{_ip}/rebootinfo.cgi?";
                await AuthenticateRequest(link);
            }
            public async Task ToggleMac(MACEnum toggle)
            {
                var link = $"http://{_ip}/wlmacflt.cmd?action=save&wlFltMacMode={toggle}&";
                await AuthenticateRequest(link);
            }
            public async Task AddMacToFilter(string mac)
            {
                var link = $"http://{_ip}/wlmacflt.cmd?action=add&wlFltMacAddr={mac}&wlSyncNvram=1";
                await AuthenticateRequest(link);
            }
            public async Task RemoveMacFromFilter(string mac)
            {
                var link = $"http://{_ip}/wlmacflt.cmd?action=remove&rmLst={mac},%20";
                await AuthenticateRequest(link);
            }
            private async Task<string> GetSessionKey()
            {
                var link = $"http://{_ip}/wancfg.cmd?action=view";
                var response = await GetRequestAsync(link);
                return response.GetTextBetween("var sessionKey = '", "';");
            }
            private async Task<string> GetRequestAsync(string url)
            {
                return await _httpClient.GetStringAsync(url);
            }
            private async Task AuthenticateRequest(string url)
            {
                var sessionKey = await GetSessionKey();
                // Pass the session key at the end of the url
                url += $"sessionKey={sessionKey}";
                await GetRequestAsync(url);
            }
        }
    }
}
