using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Employee
    {
        //声明字段
        public string FirstName;
        public string LastName;
        public string Salary="Not Enough";
        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }
    }
    class Class01
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.FirstName = "Inigo";
            employee1.LastName = "Montoya";
            employee1.Salary = "Too Little";
            IncreaseSalary(employee1);
            //Console.WriteLine("{0} {1}:{2}",employee1.FirstName,employee1.LastName,employee1.Salary);
            Console.WriteLine($"{employee1.GetName()}:{employee1.Salary}");
            Console.ReadLine();
        }
        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "enough";
        }
    }
}
