using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questionnaire;
using Questionnaire.Models;
using System;
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
        [DataRow("?aösldkjfaölskdjföasldkf")]
        public void TestQuestionInterpreter(string line)
        {
            Question result = testInterpreter.InterpretQuestion(line);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Text, (line).Substring(1));
        }
    }
}
