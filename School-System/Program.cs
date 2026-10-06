using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string StudentName = "Raghad";
            int StudentAge = 24;
            double StudentGrade = 8.50;
            double StudentAverage = 3.40;
            char StudentGender = 'F';
            bool IsStudentActive = true;

            Console.WriteLine(StudentName);
            Console.WriteLine(StudentAge);
            Console.WriteLine(StudentGrade);
            Console.WriteLine(StudentAverage);
            Console.WriteLine(StudentGender);
            Console.WriteLine(IsStudentActive);

            string[] students = { "Raghad", "Mahmoud", "Mohammed", "Ahmad" };
            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);

            Console.WriteLine("Num of students :" + students.Length);


            Console.WriteLine("First student :"+students[0]);
            Console.WriteLine("last student :"+students[3]);

            students[0] = "Rama";

        }
    }
}
