using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Task8
{
    class Serialization
    {
        public void SerializeXML(BookCollection books)
        {

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
       
            ns.Add("","http://library.by/catalog");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(BookCollection));
            string path = Data.PathForSerialization;
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = Encoding.UTF8;
                settings.Indent = true;
        
                using (var xw = XmlWriter.Create(stream, settings))
                {
                    xmlSerializer.Serialize(xw, books, ns);
                }
            }
        }
    }
}