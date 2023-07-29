using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    class Class03
    {
        static void Main(string[] args)
        {
            string valerie;
            string miracleMax = "Have fun storming the castle!";
            valerie = "Think it will work?";
            Console.WriteLine(miracleMax);
            Console.WriteLine(valerie);
            miracleMax = "It would take a miracle.";
            Console.WriteLine(miracleMax);
            valerie = miracleMax = "111";
            //多个赋值操作
            Console.WriteLine(valerie);
            Console.WriteLine(miracleMax);
            Console.ReadLine();
        }
    }
}
