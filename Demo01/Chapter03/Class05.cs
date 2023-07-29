using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Class05
    {
        static void Main(string[] args)
        {
            string reverse, palindrome;
            char[] temp;

            Console.WriteLine("Enter a palindrome:");
            palindrome = Console.ReadLine();

            //移除空格，并转换成小写
            reverse = palindrome.Replace(" ", "");
            reverse=reverse.ToLower();

            temp=reverse.ToCharArray();
            System.Array.Reverse(temp);

            if (reverse == new string(temp))
            {
                Console.WriteLine($"\"{palindrome}\" is a palinddrome.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"\"{palindrome}\" is not a palinddrome.");
                Console.ReadLine();
            }
        }
    }
}
