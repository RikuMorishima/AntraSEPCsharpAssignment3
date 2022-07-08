using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingOOPrinciples.People;

namespace UsingOOPrinciples.Courses
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
