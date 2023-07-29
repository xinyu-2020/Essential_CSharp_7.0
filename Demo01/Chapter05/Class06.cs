using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class06
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ConvertToPhoneNumber.exe <phrase>");
                Console.WriteLine("'-' indicates no standard phone button");
                return 1;
            }
            foreach (string word in args)
            {
                foreach (char character in word)
                {
                    if (TryGetPhoneButton(character, out char button))
                    {
                        Console.Write(button);
                    }
                    else
                    {
                        Console.Write('_');
                    }
                }
            }
            Console.ReadLine();
            return 0;
        }
        //out指定传出变量
        static bool TryGetPhoneButton(char character, out char button)
        {
            bool success = true;
            switch (char.ToLower(character))
            {
                case '1':
                    button = '1';
                    break;
                case '2':
                    button = '2';
                    break;
                case '-':
                    button = '-';
                    break;
                default:
                    button = '-';
                    success = false;
                    break;
            }
            return success;
        }
    }
}
