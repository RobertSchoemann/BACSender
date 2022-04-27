using System.Xml.Serialization;

namespace BACSender.XMLHandler.Types
{
    [XmlRoot(ElementName = "Properties")]
    public class Properties
    {

        [XmlElement(ElementName = "Property")]
        public List<Property> Property { get; set; }
    }
}
