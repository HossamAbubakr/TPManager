using System.Collections.Generic;
using System.Xml.Serialization;

namespace TPManager
{
    public class Settings
    {
        [XmlElement("App-Settings")]
        public AppSettings Application = new AppSettings();
        [XmlElement("Router-Settings")]
        public RouterSettings Router = new RouterSettings();
        [XmlArray("MAC-Tags"), XmlArrayItem("MAC")]
        public List<Mac> Mac { get; internal set; } = new List<Mac>();

    }
    public class AppSettings
    {
        [XmlElement("Remember-Settings")]
        public bool Remember { get; set; } = false;
        [XmlElement("Dark-Mode")]
        public bool Dark { get; set; } = false;
    }
    public class RouterSettings
    {
        [XmlElement("IP")]
        public string Ip { get; set; }
        [XmlElement("Username")]
        public string Username { get; set; }
        [XmlElement("Password")]
        public string Password { get; set; }
        [XmlElement("Model")]
        public string Model { get; set; }
    }
    public class Mac
    {
        [XmlAttribute]
        public string Address { get; set; }
        [XmlAttribute]
        public string Tag { get; set; }
    }
}
