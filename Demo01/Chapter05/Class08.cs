using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class08
    {
        static void Main(string[] args)
        {
            string fullName;
            fullName = Combine(Directory.GetCurrentDirectory(), "bin", "config", "index.html");
            Console.WriteLine(fullName);

            fullName = Combine(Environment.SystemDirectory, "temp", "index.html");
            Console.WriteLine(fullName);

            fullName = Combine(new string[] { "C:\\", "Data", "HomeDir", "index.html" });
            Console.WriteLine(fullName);
            
            Console.ReadLine();
        }

        static string Combine(params string[] paths)
        {
            string result=string.Empty;
            foreach (string path in paths)
            {
                result = Path.Combine(result,path);
            }
            return result;
        }
    }
}
