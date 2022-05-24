using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace yunker_TriviaGame
{
    class Controller
    {
        

        public void Welcome()
        {
            WriteLine("Welcome to movie trivia!\nIf you are ready to play, " +
                "press enter to start.");
            ReadLine();
            Clear();
        }
        public void PlayAgain()
        {
            do
            {
                Play();
                WriteLine("Do you want to play again? Enter Y or N");
            } while (ReadLine().ToUpper() == "Y");
        }

        public void Play()
        {
            Question_Bank QuestionList = new Question_Bank();
            int correctAnswers = 0;
            int wrongAnswers = 0;
            char[] ch = new char[1]{ Convert.ToChar(",") };
            int index = 1;

            if (!QuestionList.ReadQuestionFile("trivia.txt.txt"))
            {
                WriteLine("Exception caught");
            }
            for (int i2 = 0; i2 < 10; i2++)
            {
                WriteLine("Question " + index + "\n");
                WriteLine(QuestionList.GetQuestion(i2));
                string[] questions = QuestionList.GetAnswers(i2).Split(ch);
                WriteLine("");
                WriteLine("A)   " + questions[0]);
                WriteLine("B)  " + questions[1]);
                WriteLine("C)  " + questions[2]);
                WriteLine("D)  " + questions[3]);
                WriteLine("");
                WriteLine("Select A, B, C, or D: ");
                index++;
                string answer = ReadLine();
                 while (answer.ToUpper() != "A" &&
                        answer.ToUpper() != "B" &&
                        answer.ToUpper() != "C" &&
                        answer.ToUpper() != "D")
                {
                    WriteLine("Invalid input, choose A, B, C, or D");
                    answer = ReadLine();
                }
                    if (answer != null)
                {
                    answer = answer.Substring(0).ToUpper();
                }

                    if (answer == QuestionList.GetCorrectAnswer(i2))
                {
                    correctAnswers++;
                    WriteLine("That is correct, well done!");
                    WriteLine("");
                }
                    else
                {
                    wrongAnswers++;
                    WriteLine("Incorrect: " + QuestionList.GetExplanation(i2));
                    WriteLine("");
                }
                WriteLine("Press the enter key when you are ready to continue");
                ReadLine();
                Clear();
            }
            WriteLine("Total Correct: " + correctAnswers);
            WriteLine("Total Incorrect: " + wrongAnswers);
        }
    }
}
