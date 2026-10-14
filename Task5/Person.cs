using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Person
    {
        public string Name;
        public int Age {  get; set;}

        private int internalCode;//cannot be accessed because its private can seen just inside the scope
        protected string SchoolName { get; set;}
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);

        }

    }
}
