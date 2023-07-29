using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    class Class04
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            Console.WriteLine("hey,you");
            Console.Write("Enter your first name:");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name:");
            lastName = Console.ReadLine();
            //字符串插值格式化
            Console.WriteLine($"your full name is {firstName} {lastName}.");
            Console.WriteLine("your full name is {0} {1}.",firstName,lastName);
            Console.ReadLine();
        }
    }
}
