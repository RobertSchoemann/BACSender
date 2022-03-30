using System.Xml.Serialization;

namespace BACSender.XMLHandler.Types
{
    [XmlRoot(ElementName = "Object")]
    public class Object
    {

        [XmlElement(ElementName = "Properties")]
        public Properties Properties { get; set; }

        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "Instance")]
        public int Instance { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
