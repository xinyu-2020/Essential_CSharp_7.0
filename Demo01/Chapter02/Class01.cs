using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Class01
    {
        static void Main(string[] args)
        {
            const double number = 1.618033988749895;
            double result;
            string text;

            //转换为字符串
            text = $"{number}";
            result=double.Parse(text) ;
            //此处没有使用R说明符，因此值不同
            Console.WriteLine($"{result==number}:result==number");

            text = string.Format("{0:R}", number);
            result = double.Parse(text) ;
            Console.WriteLine($"{result == number}:result==number");
            Console.ReadLine();
        }
    }
}
