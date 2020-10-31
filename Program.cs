using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Student Class
            Student s1 = new Student();
            s1.Name = "Rashedul Haque";
            s1.Id = "19-39431-1";
            s1.Department = "CSE";
            s1.Cgpa = 3.50f;
            s1.ShowInfo();

            // Space beetween 2 class
            Console.WriteLine("-----------------------");

            // Triangle Class
            Triangle t1 = new Triangle();
            t1.X = 10;
            t1.Y = 5;
            t1.Z = 20;
            t1.ShowInfo();
            t1.TestTriangle();


            // Space beetween 2 class
            Console.WriteLine("-----------------------");

            // Account Class

            Account a1 = new Account();
            a1.Name = "Rashed";
            a1.Id = "XX-XXXX-XX";
            a1.Balance = 10000;
            a1.ShowInfo();
            Console.WriteLine();
            a1.Deposit(500);
            Console.WriteLine();
            a1.Withdraw(-2);

            // Space beetween 2 class
            Console.WriteLine("-----------------------");
            //Course Class
            Course c1 = new Course();
            c1.Name = "Object oriented programmin 2";
            c1.Code = "CSE 3110";
            c1.Credit = 3;
            c1.CourseInfo();
        }
    }
}
