using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class04
    {
        static void Main(string[] args)
        {
            string fullName;
            string driveLetter = "C";
            string folderPath = "Data";
            string fileName = "index.html";
            fullName=Combine(driveLetter, folderPath, fileName);
            Console.WriteLine(fullName);
            Console.ReadLine();
        }
        static string Combine(string driverLetter,string folderPath,string fileName)
        {
            string path;
            path=string.Format("{1}{0}{2}{0}{3}",Path.DirectorySeparatorChar,driverLetter,folderPath,fileName);
            return path;
        }
    }
}
