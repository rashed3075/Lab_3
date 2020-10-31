using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Rashedul Haque";
            s1.Id = "19-39431-1";
            s1.Department = "CSE";
            s1.Cgpa = 3.50f;
            s1.showInfo();


        }
    }
}
