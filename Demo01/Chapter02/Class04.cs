using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Class04
    {
        static void Main(string[] args)
        {
            checked
            {
                int n = int.MaxValue;
                n = n + 1;
                Console.WriteLine(n);
            }
        }
    }
}
