using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class FileController
    {

        public string CheckThePath()
        {
            String path;
            path = Data.PathForDeserialization;
            //считали путь из ресурсного файла
            while (!File.Exists(path))
            { //проверили путь
                Console.WriteLine("Your path to file for deserialization do not exist. You should enter the existing path in resours file.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(-1);
            }
            return path;
        }
    }
}
