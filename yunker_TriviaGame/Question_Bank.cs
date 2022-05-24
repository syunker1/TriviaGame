using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace yunker_TriviaGame
{
    class Question_Bank
    {
        private const int NO_OF_QUESTIONS = 10;
        private const int NO_OF_ANSWERS = 4;
        private Question_Unit[] questionBank = new Question_Unit[NO_OF_QUESTIONS];

       

        public string GetAnswers(int i)
        {
            return questionBank[i].Answer;
        }
        public string GetCorrectAnswer(int i)
        {
            return questionBank[i].CorrectAnswer;
        }
        public string GetExplanation(int i)
        {
            return questionBank[i].Explanation;
        }
        public string GetQuestion(int i)
        {
            return questionBank[i].Question;
        }

        public bool ReadQuestionFile(string s)
        {
            bool foundFile = true;
            int i = 0;

            try
            {
                using (StreamReader streamReader = new StreamReader("trivia.txt.txt"))
                {
                    string text;
                    while ((text = streamReader.ReadLine()) != null)
                    {
                        questionBank[i] = new Question_Unit();
                        questionBank[i].Question = text;
                        questionBank[i].Answer = streamReader.ReadLine();
                        questionBank[i].CorrectAnswer = streamReader.ReadLine();
                        questionBank[i].Explanation = streamReader.ReadLine();
                        i++;
                    }
                }
            }
            catch
            {
                foundFile = false;
            }
            return foundFile;
        }
    }
}
