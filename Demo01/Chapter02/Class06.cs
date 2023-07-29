using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Class06
    {
        static void Main(string[] args)
        {
            double number;
            string input;
            Console.WriteLine("Enter a number:");
            input= Console.ReadLine();
            if (double.TryParse(input, out  number))
            {
                Console.WriteLine($"input was parsed successfully to {number}.");
            }
            else
            {
                Console.WriteLine("The text entered was not a valid number.");
            }
            Console.ReadLine();
        }
    }
}
