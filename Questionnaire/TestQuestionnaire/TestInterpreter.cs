﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void TestIsAnswer()
        {
            var line = "*Hallo";
            var expected = new Answer() { IsChosen = false, IsCorrect = true, Text = "Hallo" };
            var result = testInterpreter.InterpretAnswer(line);
            Assert.IsNotNull(result);
            Assert.AreEqual("Hallo", expected.Text);
            Assert.AreEqual(true, expected.IsCorrect);

            line = "Hallo";
            expected = new Answer() { IsChosen = false, IsCorrect = false, Text = "Hallo" };
            result = testInterpreter.InterpretAnswer(line);
            Assert.AreEqual(line, result.Text);
            Assert.AreEqual(false, result.IsCorrect);

        }
    }
}