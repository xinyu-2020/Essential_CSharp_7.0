using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Employee
    {
        //构造函数
        public Employee(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        //声明字段
        public void Initialize(int id)
        {
            _Id=id.ToString();
        }
        public string Id
        {
            get => _Id;
        }
        private string _Id;


        private string FirstName;
        public string GetFirstName()
        {
            return FirstName;
        }
        public void SetFirstName(string NewFirstName)
        {
            FirstName = NewFirstName;
        }
        //public string LastName;
        private string LastName;
        public string GetLastName()
        {
            return LastName;
        }
        public void SetLastName(string newLastName)
        {
            LastName = newLastName;
        }
        public string Title{get;set;}
        public string Salary="Not Enough";
        private string Password;
        private bool IsAuthenticated;
        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }
        public void SetName(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine($"Name changed to '{this.GetName()}'");
        }
        //public void SetName(string FirstName, string LastName)
        //{
        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //}
        public void Save()
        {
            DataStorage.Store(this);
        }
        public bool Logon(string password)
        {
            if (Password == password)
            {
                IsAuthenticated = true;
            }
            return IsAuthenticated;
        }
        public bool GetIsAuthenticated()
        {
            return IsAuthenticated;
        }
    }
    class DataStorage
    {
        public static void Store(Employee employee)
        {
            FileStream stream =new FileStream(employee.FirstName+employee.LastName+".dat", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);
            writer.Dispose();//关闭流
        }
        public static void Load(string firstName,string lastName)
        {
            Employee employee = new Employee();
            FileStream stream = new FileStream(employee.FirstName + employee.LastName + ".dat", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            employee.FirstName = reader.ReadLine();
            employee.LastName = reader.ReadLine();
            employee.Salary= reader.ReadLine();
            reader.Dispose();
            
        }
    }
    class Class01
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Inigo", "Mon") { Title = "111" };
            Employee employee2 = new Employee("Inigo", "Mon");
            employee1.Initialize(42);
            //employee1.FirstName = "Inigo";
            //employee1.LastName = "Montoya";
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
