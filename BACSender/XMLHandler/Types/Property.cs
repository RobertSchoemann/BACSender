using System.Xml.Serialization;

namespace BACSender.XMLHandler.Types
{
    [XmlRoot(ElementName = "Property")]
    public class Property
    {

        [XmlElement(ElementName = "Value")]
        public List<string> Value { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "Tag")]
        public string Tag { get; set; }

        [XmlText]
        public string Text { get; set; }

        public Property(string id, string tag, List<string> value)
        {
            Id = id;
            Tag = tag;
            Value = value;
        }
        public Property()
        {

        }
    }
}
