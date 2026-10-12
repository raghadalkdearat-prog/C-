using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task4
{
    internal class STUDENTS
    {
        public string Name;

        public int Age;

        public double Grade;


        public void DisplayInfo()
        {
            Console.WriteLine("Student Name :"+Name);
            Console.WriteLine("Age :"+Age);
            Console.WriteLine("Grad :"+Grade);
        }

        public STUDENTS(string n,int a,double g)
        {
            Name = n;
            Age = a;
            Grade = g;

        }


    }
}
