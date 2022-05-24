using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yunker_TriviaGame
{
    class Info
    {
        public void DisplayInfo(string assignment)
        {
            const string barrior = "*******************************************";
            Console.WriteLine(barrior);
            Console.WriteLine();
            Console.WriteLine("Name:\t\tSteve Yunker");
            Console.WriteLine("Course:\t\tITDEV-115-501");
            Console.WriteLine("Instructor:\tJ. Christie");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine(barrior);
        }
    }
}
