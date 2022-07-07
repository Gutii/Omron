
namespace ASHK.SRTApp.Common.Settings
{
    public class AplicationSettings
    {
        [System.Xml.Serialization.XmlAttribute()]
        public bool LoadDB { get; set; }
        [System.Xml.Serialization.XmlAttribute()]
        public bool EnableSettings { get; set; } = true;
        [System.Xml.Serialization.XmlAttribute()]
        public bool EnableConnectDB { get; set; } = true;
        [System.Xml.Serialization.XmlAttribute()]
        public string ClientName { get; set; } = "";
        [System.Xml.Serialization.XmlAttribute()]
        public bool AutoUpdate { get; set; }
        [System.Xml.Serialization.XmlAttribute()]
        public string PathUpdate { get; set; } = "";
    }
}
