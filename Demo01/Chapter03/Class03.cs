using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Class03
    {
        static void Main(string[] args)
        {
            //元组声明和赋值
            //(string country, string capital, double gdpPerCapita) = ("MAl", "Lil", 226.4);
            
            (string Name, string Capital, double GdpPerCapital) countryInfo = ("MAL", "Lil", 22.6);



            Console.WriteLine($"The poorest country was {countryInfo.Name},{countryInfo.Capital}:{countryInfo.GdpPerCapital}.");
            Console.ReadLine();
        }
    }
}
