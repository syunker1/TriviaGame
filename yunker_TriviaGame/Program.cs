using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace yunker_TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Info i = new Info();
            Controller c = new Controller();
            i.DisplayInfo("Trivia Game");
            c.Welcome();
            c.PlayAgain();

        }
    }
}
