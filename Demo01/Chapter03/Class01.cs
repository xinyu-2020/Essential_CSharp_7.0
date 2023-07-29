using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Class01
    {
        static void Main(string[] args)
        {
            int? count = null;
            //隐式类型，以支持匿名类型
            Console.WriteLine("Enter text:");
            var text=Console.ReadLine();
            var uppercase=text.ToUpper();
            Console.WriteLine(uppercase);
            Console.ReadLine();

            var patent1 = new
            {
                Title = "Bifocals",
                YearOfPublication = "1784"
            };
            var patent2 = new
            {
                Title = "Phonograph",
                YearOfPublication = "1684"
            };
            Console.WriteLine($"{patent1.Title} {patent1.YearOfPublication}");
            Console.WriteLine($"{patent2.Title} {patent2.YearOfPublication}");
            Console.ReadLine() ;
        }
    }
}
