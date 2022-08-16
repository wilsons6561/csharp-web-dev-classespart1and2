using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public List<Student> StudentsInClass { get; set; }


    }
}
