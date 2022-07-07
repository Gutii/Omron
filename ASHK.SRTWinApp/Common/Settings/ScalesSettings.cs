namespace ASHK.SRTApp.Common.Settings
{
    public class ScalesSettings
    {
        [System.Xml.Serialization.XmlAttribute()]
        public string IP { get; set; }
        [System.Xml.Serialization.XmlAttribute()]
        public int Port { get; set; }
        [System.Xml.Serialization.XmlAttribute()]
        public string Name { get; set; }
    }
}
