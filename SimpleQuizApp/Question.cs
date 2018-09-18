using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication
{
    abstract class Question
    {
        protected String questionText;

        public Question(String questionText)
        {
            this.questionText = questionText;
        }

        public virtual String getQuestion() { return this.questionText; }

        public abstract String getAnswer();
        public abstract bool checkAnswer(String answer);

    }
}
