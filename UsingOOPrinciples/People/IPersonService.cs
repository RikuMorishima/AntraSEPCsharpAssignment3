using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPrinciples.People
{
    public interface IPersonService
    {
        public int getAge();
        public decimal getSalary();
        public string[] getAddresses();
    }
}
