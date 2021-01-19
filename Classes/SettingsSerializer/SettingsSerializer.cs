using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TPManager
{
    public static class SettingsSerializer
    {
        public static Settings Settings = new Settings();
        private static readonly string path = AppDomain.CurrentDomain.BaseDirectory + "settings.xml";

        public static void ReadSettings()
        {
            if (File.Exists(path))
            {
                var deserializer = new XmlSerializer(typeof(Settings));
                using (var reader = XmlReader.Create(inputUri: path))
                {
                    Settings = (Settings)deserializer.Deserialize(reader);
                }
            }
            else
            {
                throw new ArgumentException("Configuration file missing! We will attempt to re-build It. if the error continues please re-download the application");
            }
        }
        public static void AddMAC(string Address, string Tag)
        {
            Mac mac = new Mac
            {
                Address = Address,
                Tag = Tag,
            };
            Settings.Mac.Add(mac);
        }
        public static void RemoveMAC(string Address)
        {
            Settings.Mac.RemoveAll(m => m.Address == Address);
        }
        public static void UpdateLogin(string ip = "", string username = "", string password = "")
        {
            Settings.Router.Ip = ip;
            Settings.Router.Username = username;
            Settings.Router.Password = password;
        }
        public static void WriteSettings()
        {
            using (var writer = new StreamWriter(path: path))
            {
                var serializer = new XmlSerializer(typeof(Settings));
                serializer.Serialize(writer, Settings);
                writer.Close();
            }
        }
    }
}
