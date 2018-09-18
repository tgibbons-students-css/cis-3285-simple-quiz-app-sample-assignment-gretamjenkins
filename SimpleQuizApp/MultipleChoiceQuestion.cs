using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication
{
    public class MultipleChoiceQuestion : Question
    {
        string[] possibleAnswers;
        int answerIndex;

        public MultipleChoiceQuestion(string questionText, string[] possibleAnswers, int answerIndex) : base(questionText)
        {
            this.possibleAnswers = possibleAnswers;
            this.answerIndex = answerIndex;
        }

        /// getQuestion()
        /// @return Adds newline after each possible answer
        public override string getQuestion()
        {
            string fullQuestion = questionText + Environment.NewLine;
            foreach (string s in possibleAnswers)
            {
                fullQuestion += s + Environment.NewLine;
            }
            return fullQuestion;
        }

        public override string getAnswer()
        {
            return possibleAnswers[answerIndex];
        }

        public override bool checkAnswer(string answer)
        {
            return (answer.Equals(possibleAnswers[answerIndex], StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
