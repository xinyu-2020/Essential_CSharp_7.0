using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Employeee
    {
        public void Initialize(string newFirstName, string newLastName)
        {
            FirstName = newFirstName;
            LastName = newLastName;
        }
        public string LastName
        {
            get => _LastName;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                else
                {
                    value=value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentNullException("LastName cannot be blank.", "value");
                    }
                    else
                    {
                        _LastName = value;
                    }
                }
            }
        }
        private string _LastName;
    }
    class Class02
    {
        static void Main(string[] args)
        {
            
        }
    }
}
