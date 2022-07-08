using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingOOPrinciples.People;
using UsingOOPrinciples.Courses;

namespace UsingOOPrinciples.Departments
{
    public class Department
    {
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public List<Course> OfferedCourse { get; set; }
    }
}
