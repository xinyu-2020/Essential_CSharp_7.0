using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Class02
    {
        static void Main(string[] args)
        {
            string palindrome;
            Console.Write("Enter a palindrome:");
            palindrome = Console.ReadLine();
            Console.WriteLine($"The palindrome \"{palindrome}\" is "+$"{palindrome.Length} characters");
            Console.ReadLine();
        }
    }
}
