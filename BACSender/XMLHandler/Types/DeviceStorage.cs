using System.Xml.Serialization;

namespace BACSender.XMLHandler.Types
{
    [XmlRoot(ElementName = "DeviceStorage")]
    public class DeviceStorage
    {

        [XmlElement(ElementName = "Objects")]
        public Objects Objects { get; set; }

        [XmlAttribute(AttributeName = "xsi")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "xsd")]
        public string Xsd { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}