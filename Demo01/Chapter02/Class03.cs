using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Class03
    {
        static void Main(string[] args)
        {
            string text;
            Console.Write("Enter text:");
            text = Console.ReadLine();

            text=text.ToUpper();
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
