using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===== Student Information =====");

            STUDENTS student1 = new STUDENTS("Roze", 22, 80);//استدعيت التاسك من خلال انشاء اوبجيكت منه
            student1.Name = "Roze";
            student1.Age = 22;
            student1.Grade=80;
            student1.DisplayInfo();


            Console.WriteLine("==========");


            STUDENTS student2 = new STUDENTS("Sara", 21, 60);
            student2.Name = "Sara";
            student2.Age = 21;
            student2.Grade = 60;
            student2.DisplayInfo();


            Console.WriteLine("==========");

            STUDENTS student3 = new STUDENTS("Omar", 23, 75);
            student3.Name = "Omar";
            student3.Age = 23;
            student3.Grade = 75;
            student3.DisplayInfo();




           



        }
    }
}
