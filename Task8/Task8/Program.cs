

using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            Help();
            Deserialization deserial = new Deserialization();
            BookCollection books = deserial.DeserializeXML();
            Serialization serial = new Serialization();
            serial.SerializeXML(books);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }


        public static void Help()
        {
            string help = "This program will help you to deserialize and serialize xml file.\n"+
                $"Path to the file for deserialization: {Data.PathForDeserialization}.\n"+
                $"Path to the file for writing result of serialization: {Data.PathForSerialization}";
            Console.WriteLine(help);

        }
    }
}
