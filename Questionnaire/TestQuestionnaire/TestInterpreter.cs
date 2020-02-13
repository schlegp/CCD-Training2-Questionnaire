using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questionnaire;
using Questionnaire.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TestQuestionnaire
{
    [TestClass]
    public class TestInterpreter
    {
        private Interpreter testInterpreter;

        public TestInterpreter()
        {
            testInterpreter = new Interpreter();
        }


        [TestMethod]
        [DataRow("aösldkjfaölskdjföasldkf", false)]
        [DataRow("?aösldkjfaölskdjföasldkf", true)]
        public void TestIsQuestion(string line, bool expected)
        {
            var result = testInterpreter.IsQuestion(line);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestIsAnswer()
        {
            var line = "*Hallo";
            var expected = new Answer() { IsCorrect = true, Text = "Hallo" };
            var result = testInterpreter.InterpretAnswer(line);
            Assert.IsNotNull(result);
            Assert.AreEqual("Hallo", expected.Text);
            Assert.AreEqual(true, expected.IsCorrect);

            line = "Hallo";
            expected = new Answer() { IsCorrect = false, Text = "Hallo" };
            result = testInterpreter.InterpretAnswer(line);
            Assert.AreEqual(line, result.Text);
            Assert.AreEqual(false, result.IsCorrect);

        }


        [TestMethod]
        [DataRow("?aösldkjfaölskdjföasldkf")]
        public void TestQuestionInterpreter(string line)
        {
            Question result = testInterpreter.InterpretQuestion(line);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Text, (line).Substring(1));
        }

        [TestMethod]
        public void TestAddNotKnown()
        {
            var CorrectQuestion = new Question() { Text = "Test Question", ChoosenAnswer = "First Answer", Answers = new List<Answer>() { new Answer() { Text = "First Answer", IsCorrect = true }, new Answer() { Text = "Second Answer", IsCorrect = false } } };
            testInterpreter.AddNotKnown(CorrectQuestion);
            Assert.AreEqual(CorrectQuestion.Answers.Count, 3);
        }

        [TestMethod]
        public void TestAddNotKnownAsLast()
        {
            var CorrectQuestion = new Question() { Text = "Test Question", ChoosenAnswer = "First Answer", Answers = new List<Answer>() { new Answer() { Text = "First Answer", IsCorrect = true }, new Answer() { Text = "Second Answer", IsCorrect = false } } };
            testInterpreter.AddNotKnown(CorrectQuestion);
            Assert.AreEqual(CorrectQuestion.Answers.Last().Text, "Don't know");
            Assert.AreEqual(CorrectQuestion.Answers.Last().IsCorrect, false);
        }
    }
}
