using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingOOPrinciples.Courses;

namespace UsingOOPrinciples.People
{
    public class Student : Person, IStudentService
    {
        public List<Course> CourseList { get; set; }
        private List<GradePoint> GradePoints { get; set; }
        
        public Student(string name, DateTime birthDate, string[] addresses) : base(name, birthDate, addresses)
        {
            CourseList = new List<Course>();
            GradePoints = new List<GradePoint>();
        }

        public float calculateGPA()
        {
            float gpa=0.0f;
            foreach (GradePoint gp in GradePoints)
            {
                gpa += (float)gp;
            }
            return gpa / GradePoints.Count;
        }
    }
}
