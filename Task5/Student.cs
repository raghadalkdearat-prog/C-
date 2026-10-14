using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Student : Person
    {

        public int Grade {  get; set; }
        public int StudentId { get; set; }

        public void DisplaySchoolName()// قدرت استخدمه لانه ورثته من person
        {
            Console.WriteLine("School Name: " + SchoolName);//هون قدرت استخدمه لانه protected يعني بس بين  الاب و الابن
        }


    }
}
