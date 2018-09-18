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
            myQuestions.Add(new ShortAnswerQuestion(
                    "What is the Minnesota state bird?",
                    "Loon"));
            myQuestions.Add(new TrueFalseQuestion(
                   "St. Scholatsica is over 100 years old",
                   "True"));
            String[] possibleAnswers = { "Dave Vosen", "Jen Rosato", "Tom Buck", "Tom Gibbons" };
            myQuestions.Add(new MultipleChoiceQuestion(
                    "Which faculty member owns a number of bee hives?",
                    possibleAnswers,
                    2));

            //Shuffle the questions and set the starting one to zero
            myQuestions = Shuffle(myQuestions);
            currentQuestion = 0;
        }

        /// <summary>
        /// from http://www.rudrasofttech.com/blog/how-to-shuffle-or-randomize-a-generic-list-using-csharp
        /// </summary>
        /// <typeparam name="t"></typeparam>
        /// <param name="list"></param>
        /// <returns>shuffledList</returns>
        public List<t> Shuffle<t>(List<t> list)
        {
            var rnd = new Random();

            List<t> shuffledList = new List<t>();

            //make a list of the indexes for list
            int listLength = list.Count;

            for (int i = 0; i < listLength; i++)
            {

                //get a random index from the list of index
                int index = rnd.Next(0, list.Count);

                //pick the object from list based on index value stored in list of indexes
                shuffledList.Add(list[index]);

                //remove the selected index from list of indexes
                list.RemoveAt(index);
            }

            return shuffledList;
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
