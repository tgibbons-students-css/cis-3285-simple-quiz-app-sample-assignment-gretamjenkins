using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication
{
    public class ShortAnswerQuestion : Question
    {
        private String answer;

        /**
         * Constructor
         * @param questionText - The text for the short answer question
         * @param answerText - The correct answer for the short answer question, case is irrelevant
         */
        public ShortAnswerQuestion(string questionText, String answerText) : base(questionText)
        {
            answer = answerText;
        }

        /**
         * getAnswer()
         * @return The correct answer to this question as a single string
         */

        public override string getAnswer()
        {
            return (answer);
        }
        /**
         * checkAnswer(String givenAnswer)
         * @param givenAnswer - The answer the user entered to be compared with the correct answer
         * @return True is givenAnswer matches the correct answer, this is not case-sensitive
         */
        public override bool checkAnswer(String givenAnswer)
        {
            return (answer.Equals(givenAnswer, StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
