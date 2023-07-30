using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    public class PdaItem
    {
        //public string Name { get; set; }
        //待重写
        public virtual string Name{get;set;}
        private string _Name;
        public DateTime LastUpdatad{get;set;}
        protected Guid ObjectKey{get;set;}
    }
    public class Person
    {
        ///
    }
    //类的继承
    public class Contact:PdaItem
    {
        private Person InternalPerson{get;set;}
        public string FirstName
        {
            get
            {
                return InternalPerson.FirstName;
            }
            set
            {
                InternalPerson.FirstName=value;
            }
        }
        public string LastName
        {
            get
            {
                return InternalPerson.LastName;
            }
            set
            {
                InternalPerson.LastNamr = value;
            }
        }
        public string Address { get; set; }
        public string Phone{get;set;}
        void Save()
        {
            FileStream stream = File.OpenWrite(ObjectKey + ".dat");
        }
        void Load(PdaItem pdaItem)
        {
            Contact contact=pdaItem as Contact;
            if (contact != null)
            {
                contact.ObjectKey = ObjectKey;
            }
        }
        //重写
        public override string Name
        {
            get => $"{FirstName} {LastName}";
            set
            {
                //遇空格拆分字符串
                string[] names=value.Split(' ');
                FirstName = names[0];
                LastName = names[1];
            }

        }
    }
    class Class01
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            contact.Name = "AAA";
            
        }
    }
}
