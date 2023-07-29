using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class14
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Begin executing");
                Console.WriteLine("Throw exception");
                throw new Exception("Arbitrary exception");
                Console.WriteLine("End executing");
            }
            catch (FormatException exception)
            {
                Console.WriteLine("A FormatException was thrown");
            }
            catch(Exception exception) {
                Console.WriteLine($"Unexpected error:{exception.Message}");
            }
            Console.WriteLine("ShutDown...");
            Console.ReadLine();
          
        }
    }
}
