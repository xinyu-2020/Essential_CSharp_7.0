using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class01
    {
        static void Main(string[] args)
        {
            //File.Copy(oldFileName,newFileName,false);
            string firstName;
            string lastName;
            string fullName;
            string initials;
            Console.WriteLine("Key you!");

            firstName = GetUserInput("Enter your first name:");
            lastName = GetUserInput("Enter your last name:");

            fullName=GetFullName(firstName, lastName);
            initials=GetInitials(firstName, lastName);
            DisplayGreeting(fullName, initials);
            Console.ReadLine();
        }

        static string GetInitials(string firstName, string lastName)
        {
            return $"{firstName[0]}.{lastName[0]}";
        }

        static void DisplayGreeting(string fullName, string initials)
        {
            Console.WriteLine($"Hello {fullName}! Your initials are {initials}");
        }

        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

    }
}
