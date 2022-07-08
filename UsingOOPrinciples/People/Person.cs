using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPrinciples.People
{
    public abstract class Person : IPersonService
    {
        private static int MaxID = 0;
        public Person(string name, DateTime birthDate, string[] addresses)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.id = MaxID++;
            this.addresses = new List<string>(addresses);
        }
        private DateTime birthDate;
        // public int Age { get { return DateTime.Now.Subtract(birthDate).Days / 365; }  }
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
        }

        private decimal salary=0;
        public decimal Salary { 
            get { return salary; }
            set { if (value > 0) salary = value; } 
        }

        private List<String> addresses;
        public List<string> Addresses { get { return addresses; } }

        public virtual int getAge()
        {
            return DateTime.Now.Subtract(birthDate).Days / 365;
        }

        public virtual decimal getSalary()
        {
            return salary;
        }

        public virtual string[] getAddresses()
        {
            return addresses.ToArray();
        }
    }
}
