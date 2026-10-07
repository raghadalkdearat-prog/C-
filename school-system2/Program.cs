using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_system2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter student name");
           string username= Console.ReadLine();
            


            Console.WriteLine("enter student age");
           int userage= Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("enter student graade");
           double usergrade= Convert.ToDouble(Console.ReadLine());
           


            Console.WriteLine("enter student average");
           double useraverage= Convert.ToDouble(Console.ReadLine());
       


            Console.WriteLine("enter student gender");
           char usergender= Convert.ToChar(Console.ReadLine());


            Console.WriteLine($"Welcom {username}");
            Console.WriteLine($"User name : { username} \n age :{userage}\n User grade :{usergrade}\n User average :{useraverage}\n User gender : {usergender}" );

            Console.WriteLine($"Original User name:{username}\n User name Upper case : {username.ToUpper()}\n User name Lower case :{username.ToLower()} \n Firt char of name : { char.ToUpper(username[0])}");



            Console.WriteLine("================================================================");



            int bonus = 5;
            bool Adult;
            double newaverage = bonus + useraverage;

            Console.WriteLine($"Bonus = {bonus}");
            Console.WriteLine($"new average : {newaverage}");

            Console.WriteLine("================================================================");


            if (newaverage >= 50)
            {
                Console.WriteLine(" result : pass");
            }
            else
            {
                Console.WriteLine(" result : fail");
            }

            if (userage >= 18)
            {
               Adult = true;
                Console.WriteLine($"Adult:{Adult}");
            }
            else
            {
                Adult = false;
                Console.WriteLine($"Adult:{Adult}");
            }
        }
    }
}
