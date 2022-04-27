using BACSender.XMLHandler.Types;
using System.Xml.Serialization;

namespace BACSender.XMLHandler
{
    public static class XMLHandler
    {
        public static DeviceStorage DeserializeDeviceDescriptor(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DeviceStorage));
            using (StringReader reader = new StringReader(xml))
            {
                var test = (DeviceStorage)serializer.Deserialize(reader);
                return test;
            }
        }
        public static void Serialize(DeviceStorage deviceStorage, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DeviceStorage));

            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, deviceStorage);
            writer.Close();
        }

    }
}
