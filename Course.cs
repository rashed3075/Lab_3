using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;
        public string Name
        {
            set { courseName = value; }
            get { return courseName; }
        }
        public string Code
        {
            set { courseCode = value; }
            get { return courseCode; }
        }
        public int Credit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }
        public void CourseInfo()
        {
            Console.WriteLine("Course Name : " + Name);
            Console.WriteLine("Code : " + Code);
            Console.WriteLine("Credit : " + Credit);
        }
    }
}
