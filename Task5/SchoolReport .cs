using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    sealed internal class SchoolReport  // Another class cannot inherit from SchoolReport
    // because SchoolReport is marked as sealed.
    {
        public string ReportTitle {  get; set;}
        public void DisplayReportTitle()
        {
            Console.WriteLine("Report title : " + ReportTitle);
        }
       
    }
}
