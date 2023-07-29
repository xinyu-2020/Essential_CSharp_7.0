using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class12
    {
        static void Main(string[] args)
        {
            string firstName;
            string ageText;
            int age;
            Console.WriteLine("Hey you");
            Console.Write("Enter your first name:");
            firstName = Console.ReadLine();
            Console.Write("Enter your age:");
            ageText = Console.ReadLine();
            age=int.Parse(ageText);
            Console.WriteLine($"Hi {firstName}! You are {age*12} months old.");
            Console.ReadLine();
        }
    }
}
