using System.Xml;
using System.Xml.Serialization;

namespace Task8
{
    class Deserialization
    {

        public BookCollection DeserializeXML()
        {

            BookCollection books = null;

            FileController fileController = new FileController();
            string path = fileController.CheckThePath();

            XmlSerializer serializer = new XmlSerializer(typeof(BookCollection));


            using (XmlReader reader = XmlReader.Create(path))
            {
                books = (BookCollection)serializer.Deserialize(reader);
                reader.Close();
            }

            return books;
        }

    }
}
