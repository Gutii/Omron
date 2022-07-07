namespace ASHK.SRTApp.Common.Settings
{
    public class LogsSettings
    {
        [System.Xml.Serialization.XmlAttribute()]
        public bool SaveFile { get; set; }
        [System.Xml.Serialization.XmlAttribute()]
        public bool CleanFile { get; set; }
        [System.Xml.Serialization.XmlAttribute()]
        public int CleanFileCount { get; set; }
        [System.Xml.Serialization.XmlAttribute()]
        public bool SaveDB { get; set; }
        [System.Xml.Serialization.XmlAttribute()]
        public bool SaveEvent { get; set; }
    }
}
