using System.Xml.Serialization;

namespace BACSender.XMLHandler.Types
{
    [XmlRoot(ElementName = "Objects")]
    public class Objects
    {

        [XmlElement(ElementName = "Object")]
        public List<BACSender.XMLHandler.Types.Object> Object { get; set; }
    }
}
