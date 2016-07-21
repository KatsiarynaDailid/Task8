using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Task8 { 

    [Serializable()]
    public class Book
    {


        [XmlIgnore]
        public DateTime PublishDate { get; set; }

        [XmlIgnore]
        public DateTime RegistrationDate { get; set; }
        


        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date")]
        public string PublishDateStr
        {
            get { return this.PublishDate.ToString("yyyy-MM-dd"); }
            set { this.PublishDate = DateTime.Parse(value); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date")]
        public string RegistrationDateStr
        {
            get { return this.RegistrationDate.ToString("yyyy-MM-dd"); }
            set { this.RegistrationDate = DateTime.Parse(value); }
        }

    }

    [Serializable()]
    [XmlRootAttribute("catalog", Namespace = "http://library.by/catalog")]
    public class BookCollection
    {
        [XmlIgnore]
        public DateTime Date { get; set; }

        private List<Book> books;

        [XmlElement("book")]
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        [XmlAttribute("date")]
        public string DateStr
        {
            get { return this.Date.ToString("yyyy-MM-dd"); }
            set { this.Date = DateTime.Parse(value); }
        }

    }


}
