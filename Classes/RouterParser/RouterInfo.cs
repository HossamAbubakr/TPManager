using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TPManager.Extensions;
namespace TPManager
{
    partial class RouterConnector
    {
        public class RouterInfo
        {
            private Dictionary<string, string> routerInfo; // Router Info Cache
            private Dictionary<string, string> wifiSecurityInfo; // WIFI Security Cache
            private Dictionary<string, string> wifiInfo; // WIFI Info Cache
            private readonly string _ip; // The Router IP
            private readonly HttpClient _httpClient; // The Pre-Configured HTTPClient

            public RouterInfo(string ip, HttpClient httpClient)
            {
                _ip = ip;
                _httpClient = httpClient;
            }
            public async Task<Dictionary<string, string>> GetWifiSecuInfo(bool forceUpdate = false)
            {
                if (forceUpdate == true || wifiSecurityInfo == null) // If a force update is requested or _WifiSecurityInfo is empty
                {
                    var link = $"http://{_ip}/wlsecurity.html";
                    var response = await GetRequestAsync(link);
                    var fieldsList = new List<(string, string)>
                    {
                        ("WIFI Password", "var wpaPskKey = '"),
                        ("WIFI Authentication", "var mode = '"),
                        ("WPA Encryption", "var wpa = '"),
                        ("WPS Enabled", "var WscMode       = '"),
                        ("WEP Enabled", "var wep = '"),
                        ("MAC Filter Mode", "var wlFltMacMode = '"),
                        ("RADIUS IP", "var radiusServerIP = '"),
                        ("RADIUS Port", "var radiusPort = '"),
                        ("WLCoreRev", "var wlCorerev = '"),
                        ("WPA Group Rekey", "var wpaGTKRekey = '")
                    };
                    wifiSecurityInfo = fieldsList.ToDictionary(field => field.Item1, field => response.GetTextBetween(field.Item2, "'")); // Assign the data to a cache to speed up consecutive requests.
                }
                return wifiSecurityInfo; // eitherway return the cached version
            }
            public async Task<string> GetWifiSecuInfoByField(WifiSecEnum field)
            {
                var wifiSec = await GetWifiSecuInfo();
                wifiSec.TryGetValue(field.ToString().Replace('_', ' '), out string wifiSecField);
                return wifiSecField;
            }
            public async Task<Dictionary<string, string>> GetWifiInfo(bool forceUpdate = false)
            {
                if (forceUpdate == true || wifiInfo == null) // If a force update is requested or _WifiInfo is empty
                {
                    var link = $"http://{_ip}/wlcfg.html";
                    var response = await GetRequestAsync(link);
                    var fieldsList = new List<(string, string)>
                    {
                        ("WIFI Name", "var ssid = '"),
                        ("WIFI Enabled", "var enbl = '"),
                        ("AP Isolation Enabled", "var enblWireless = '"),
                        ("Max Association", "var apIsolation= '"),
                        ("Wireless Media Extensions WME Enabled", "var disableWme = '"),
                        ("Wireless Multicast Forwarding WMF Enabled", "var enableWmf = '"),
                        ("Mesh Basic Service Set MBSS Supported", "var supportMbss = '"),
                    };
                    wifiInfo = fieldsList.ToDictionary(field => field.Item1, field => response.GetTextBetween(field.Item2, "'"));
                }
                return wifiInfo;
            }
            public async Task<string> GetWifiInfoByField(WifiEnum field)
            {
                var wifiInfo = await GetWifiInfo();
                wifiInfo.TryGetValue(field.ToString().Replace('_', ' '), out string wifiInfoField);
                return wifiInfoField;
            }

            public async Task<Dictionary<string, string>> GetFullWifiInfo()
            {
                var wifiInfo = await GetWifiInfo();
                var wifiSec = await GetWifiSecuInfo();
                return wifiInfo.Concat(wifiSec).ToDictionary(e => e.Key, e => e.Value);
            }

            public async Task<bool> IsUPnPEnabled()
            {
                var link = $"http://{_ip}/upnpcfg.html";
                return await GetFieldValue(link, "var enblUpnp = '", "'") == "1";
            }
            public async Task<(bool, int)> GetQoS()
            {   // String Holding The QoS State 0 = Disabled/State 1 = Enabled
                var link = $"http://{_ip}/qosqmgmt.html";
                // Check The Value And Return The Bool Result
                var enabled = await GetFieldValue(link, "var enblQos = '", "'") == "1";
                if (!enabled) return (false, 0); // Retrieve the QoS defmark and parse it to int
                var qos = int.Parse(await GetFieldValue(link, "var defMark = '", "'"));
                return (true, qos);
                // If Its Not Enabled Return False
            }
            public async Task<string> GetModel()
            {
                var link = $"http://{_ip}/";
                return await GetFieldValue(link, "Model No. ", "</td>");
            }

            private async Task<string> GetFieldValue(string url, string fieldName, string fieldEnd)
            {
                var response = await GetRequestAsync(url);
                var isFunctionEnabled = response.GetTextBetween(fieldName, fieldEnd);
                return isFunctionEnabled;
            }
            public async Task<Dictionary<string, string>> GetInfo(bool forceUpdate = false)
            {
                if (forceUpdate == true || routerInfo == null) // If a force update is requested or _WifiInfo is empty
                {
                    var link = $"http://{_ip}/info.html";
                    var response = await GetRequestAsync(link);
                    var internetInfoArray = response.GetTextBetween("var info = '", "'").Split('|'); // The internet info are saved as a javascript array
                    var infoDic = new Dictionary<string, string>
                    {
                        { "Firmware Version", response.GetTextBetween("Firmware Version:</td><td class=\"dataStyle\">", "</td>") },
                        { "Hardware Version", response.GetTextBetween("Hardware Version:</td><td class=\"dataStyle\">", "</td>") },
                        { "System Running Time", response.GetTextBetween("System Running Time:</td><td class=\"dataStyle\">", "</td>") },
                        { "LAN IP Address" ,response.GetTextBetween("LAN IP Address:</td><td class=\"dataStyle\">", "</td>") },
                        { "LAN MAC Address", response.GetTextBetween("LAN MAC Address:</td><td class=\"dataStyle\">", "</td>") },
                        { "Line State", response.GetTextBetween("var state = '", "';") },
                        { "Line Download Speed", response.GetTextBetween("Line Rate - Downstream (Kbps):</td>\");document.writeln(\"<td class=\\\"dataStyle\\\">", "</td>") },
                        { "Line Upload Speed", response.GetTextBetween("Line Rate - Upstream (Kbps):</td>\");document.writeln(\"<td class=\\\"dataStyle\\\">", "</td>") },
                        { "DNS Servers", response.GetTextBetween(@"DNS Server (Primary, Secondary):</td>\n\t<td class=""dataStyle"">';html += '", @"</td>\n</tr>\n';") },
                        { "Connection Type", internetInfoArray[3]},
                        { "Internet State", internetInfoArray[4]},
                        { "WAN IP", internetInfoArray[5]},
                        { "Default Gateway", internetInfoArray[7]},
                        { "MAC Address", internetInfoArray[9] }
                    };
                    routerInfo = infoDic;
                }
                return routerInfo;
            }
            public async Task<string> GetInfoByField(InfoEnum field)
            {
                var info = await GetInfo();
                info.TryGetValue(field.ToString().Replace('_', ' '), out string InfoField);
                return InfoField;
            }
            public async Task<List<string>> GetMacFilter()
            {
                var link = $"http://{_ip}/wlmacflt.cmd";
                var response = await GetRequestAsync(link);
                // Regular Expression That Looks For This Pattern <td>00:00:00:00:00:00</td>
                var matches = new Regex("((<td>))([0-9a-fA-F]{2}[:]){5}([0-9a-fA-F]{2})((</td>))").Matches(response);
                //Retrieve The Matched Results
                return matches.Count <= 0 ? null : (from Match result in matches select result.Value.GetTextBetween("<td>", "</td>")).ToList();
            }
            public async Task<List<(string, string, string, string)>> GetConnectedDevices()
            {
                var link = $"http://{_ip}/dhcpinfo.html";
                var response = await GetRequestAsync(link);
                var matches = new Regex(@"((?<=&nbsp;).*[^</]*)(<\/td><td>)([a-z0-9]{2}[:]){5}([a-z0-9]{2})(</td><td>)(?:[0-9]{1,3}\.){3}[0-9]{1,3}(<\/td><td>)[^<]*").Matches(response).OfType<Match>().Select(x => x.Groups[0].Value).ToList();
                if (matches.Count <= 0) return null;
                var items = matches.Select(match => match.Split(new[] { "</td><td>" }, StringSplitOptions.None)).Select(split => (split[0], split[1], split[2], split[3])).ToList();
                return items;
            }
            private async Task<string> GetRequestAsync(string url)
            {
                return await _httpClient.GetStringAsync(url);
            }
        }
    }
}
