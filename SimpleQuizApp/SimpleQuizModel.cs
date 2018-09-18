using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication
{
    /**
     * SimpleQuizModel implements a list of quiz questions 
     * Based on the assignment posted at: http://cs.calvin.edu/books/processing/c13oop/lab.html
     * 
     * @author jrosato in Java, tgibbons in C#
     */
    public class SimpleQuizModel
    {
        private List<Question> myQuestions;
        private int currentQuestion; //index of the current question being displayed

        public SimpleQuizModel()
        {
            myQuestions = new List<Question>();

            //Add your questions here
            //This example uses a ShortAnswerQuestion but they could be they other types, too
            //such as FillInBlankQuestion or TrueFalseQuestion
            myQuestions.Add(new ShortAnswerQuestion(
                    "What is the name of Jerry Lee Lewis's biggest solid gold hit?",
                    "Great Balls of Fire"));
            //ADD MORE EXAMPLE QUESTIONS HERE
            /*
            myQuestions.add(new ShortAnswerQuestion(
                    "What is the Minnesota state bird?",
                    "Loon"));
            myQuestions.add(new TrueFalseQuestion(
                   "St. Scholatsica is over 100 years old",
                   "True"));
            String[] possibleAnswers = { "Dave Vosen", "Jen Rosato", "Tom Buck", "Tom Gibbons" };
            myQuestions.add(new MultipleChoiceQuestion(
                    "Which faculty member owns a number of bee hives?",
                    possibleAnswers,
                    2));
            */

            //Shuffle the questions and set the starting one to zero
            // Collections.shuffle(myQuestions);            // C# does not have a clear shuffle option
            currentQuestion = 0;
        }

        /**
         * Return the full specification for the current question.
         * 
         * @return the full question
         */
        public String getCurrentQuestion()
        {
            return myQuestions[currentQuestion].getQuestion();
        }

        /**
         * Return the answer to the current question
         * 
         * @return the answer
         */
        public String getCurrentAnswer()
        {
            return myQuestions[currentQuestion].getAnswer();
        }

        /**
         * Returns true if the given answer is correct for the current question.
         * 
         * @param answer
         *            the user's answer
         * @return true if and only if the given answer is correct
         */
        public bool checkCurrentAnswer(String answer)
        {
            return myQuestions[currentQuestion].checkAnswer(answer);
        }

        /**
         * Returns true if this quiz has another question.
         * 
         * @return true if and only if this quiz has another question
         */
        public bool hasNext()
        {
            return currentQuestion < myQuestions.Count - 1;
        }

        /**
         * Advance to the next question.
         * 
         * @throws Exception
         *             if there are no more questions
         */
        public void next()
        {
            if (currentQuestion == myQuestions.Count - 1)
                //put it back at the first question
                currentQuestion = 0;
            else
                currentQuestion++;
        }

    }
}
