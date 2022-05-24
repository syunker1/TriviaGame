using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yunker_TriviaGame
{
    class Question_Unit
    {
        private string answer;
        private string correctAnswer;
        private string explanation;
        private string question;

        public string Answer { get { return this.answer; } 
            set { this.answer = value; } }
        public string CorrectAnswer { get { return this.correctAnswer; } 
            set { this.correctAnswer = value; } }
        public string Explanation { get { return this.explanation; } 
            set { this.explanation = value; } }
        public string Question { get { return this.question; }
            set { this.question = value; } }
    }
}
