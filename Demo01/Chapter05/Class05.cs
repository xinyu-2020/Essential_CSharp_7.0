using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class05
    {
        static void Main(string[] args)
        {
            string first = "hello";
            string second = "goodbye";
            Swap(ref first, ref second);
            Console.WriteLine($@"first=""{first}"",second=""{second}""");
            Console.ReadLine();
        }
        //参数是引用
        static void Swap(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y=temp;
        }
    }
}
