using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingOOPrinciples.Departments;

namespace UsingOOPrinciples.People
{
    internal class Instructor : Person
    {

        private Department department;
        private decimal bonus;
        public Instructor(string name, DateTime birthDate, string[] addresses) : base(name, birthDate, addresses)
        {
            department = new Department();
        }

        public override decimal getSalary()
        {
            return base.getSalary() + bonus;
        }
    }
}
