using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();


            //creat two lbjects of class student
            Student student1 = new Student();
            Student student2 = new Student();
            
            //set values
            student1.Name = "raghad";
            student1.Age = 24;
            student1.Grade = 50;
            student1.StudentId = 101;


            student2.Name = "delara";
            student2.Age = 23;
            student2.Grade = 70;
            student1.StudentId = 102;


            student1.DisplayInfo();

            Console.WriteLine("-------------------");

            student2.DisplayInfo();


            Console.WriteLine("-------------------");

            Teacher teacher = new Teacher();

            teacher.Name = "delara";
            teacher.Age = 23;
            teacher.Subject = "math";

            teacher.DisplayTeacherInfo();






            Console.WriteLine("-------------------");








            //person.SchoolName;
            //person.internalCode;

            SchoolReport schoolReport = new SchoolReport();//creat object for SchoolReport class
            schoolReport.ReportTitle = "c-sharp";
            schoolReport.DisplayReportTitle();

            




        }
    }
}
