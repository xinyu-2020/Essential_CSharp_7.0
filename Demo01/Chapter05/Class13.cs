using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class13
    {
        static int Main(string[] args)
        {
            string firstName;
            string ageText;
            int age;
            int result = 0;

            Console.WriteLine("Hey you");
            Console.Write("Enter your first name:");
            firstName = Console.ReadLine();
            Console.Write("Enter your age:");
            ageText = Console.ReadLine();
            

            try
            {
                age = int.Parse(ageText);
                Console.WriteLine($"Hi {firstName}! You are {age * 12} months old.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"The age entered,{ageText}, is not valid.");
                result = 1;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unexpected error:{exception.Message}");
                result = 1;
            }
            finally {
                Console.WriteLine($"goobye {firstName}");
            }
            Console.ReadLine();
            return result;

            
        }
    }
}
