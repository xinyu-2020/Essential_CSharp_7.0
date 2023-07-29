using System;

namespace Chapter05
{
    class Class02
    {
        static void Main(string[] args)
        {
            (string First, string Last) name = GetName();
            Console.WriteLine($"Hello {name.First} {name.Last}!");
            Console.ReadLine();
        }
        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        //返回值为元组
        static (string First, string Last) GetName()
        {
            string firstName,lastName;
            firstName=GetUserInput("Enter your first name:");
            lastName = GetUserInput("Enter your last name:");
            return (firstName,lastName);
        }
    }
}
