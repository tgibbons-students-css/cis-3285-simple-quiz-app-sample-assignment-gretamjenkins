using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleQuizApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication.Tests
{
    [TestClass()]
    public class ShortAnswerQuestionTests
    {
        [TestMethod()]
        public void getQuestion_NormalTest()
        {
            // Arrange
            String strQuestion = "Test 111";
            String strAnswer = "Answer 111";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act
            String strResult = q.getQuestion();

            //Assert
            Assert.AreEqual(strQuestion, strResult);

        }
        [TestMethod()]
        public void getQuestion_EmptyStringTest()
        {
            // Arrange
            String strQuestion = "";
            String strAnswer = "Answer 111";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act
            String strResult = q.getQuestion();

            //Assert
            Assert.AreEqual(strQuestion, strResult);

        }
        [TestMethod()]
        public void getQuestion_LongStringTest()
        {
            // Arrange
            String strQuestion = "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
            String strAnswer = "Answer 111";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act
            String strResult = q.getQuestion();

            //Assert
            Assert.AreEqual(strQuestion, strResult);

        }

        [TestMethod()]
        public void getAnswer_NormalTest()
        {
            // Arrange
            String strQuestion = "Test 201";
            String strAnswer = "Answer 201";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act
            String strResult = q.getAnswer();

            //Assert
            Assert.AreEqual(strAnswer, strResult);
        }

        [TestMethod()]
        public void checkAnswer_NormalTest()
        {
            // Arrange
            String strQuestion = "Test 301";
            String strAnswer = "Answer 301";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strAnswer));
        }

        [TestMethod()]
        public void checkAnswer_LowerCaseTest()
        {
            // Arrange
            String strQuestion = "Test 302";
            String strAnswer = "Answer 302";
            String strLowerCaseAnswer = "answer 302";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strLowerCaseAnswer));
        }
        [TestMethod()]
        public void checkAnswer_UpperCaseTest()
        {
            // Arrange
            String strQuestion = "Test 303";
            String strAnswer = "Answer 303";
            String strLowerCaseAnswer = "ANSWER 303";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strLowerCaseAnswer));
        }
        [TestMethod()]
        // Test space before answer
        public void checkAnswer_ExtraSpaceBeforeTest()
        {
            // Arrange
            String strQuestion = "Test question here?";
            String strAnswer = "Answer to question";
            String strAnswerWithSpaceBefore = " Answer to question";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strAnswerWithSpaceBefore));
        }
        [TestMethod()]
        // Test space after answer
        public void checkAnswer_ExtraSpaceAfterTest()
        {
            // Arrange
            String strQuestion = "Test question here?";
            String strAnswer = "Answer to question";
            String strAnswerWithSpaceAfter = "Answer to question ";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act

            //Assert
            Assert.IsTrue(q.checkAnswer(strAnswerWithSpaceAfter));
        }
        [TestMethod()]
        public void checkAnswer_WrongAnswerTest()
        {
            // Arrange
            String strQuestion = "Test 304";
            String strAnswer = "Given Answer 304";
            String strWrongAnswer = "Wrong Answer 304";
            Question q = new ShortAnswerQuestion(strQuestion, strAnswer);

            //Act
            String strResult = q.getAnswer();

            //Assert
            Assert.IsFalse(q.checkAnswer(strWrongAnswer));
        }
    }
}