using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Class04
    {
        static void Main(string[] args)
        {
            //int[,] cells = new int[3, 3];
            int[,] cells = { { 1, 0, 2 }, { 2, 0, 3 }, { 1, 2, 1 } };
            string[] languages = new string[] { "A", "B", "C", "D" };
            languages.GetLength(0);
            System.Array.Resize(ref languages, 10);
            Console.WriteLine(languages.Length);
        }
    }
}
