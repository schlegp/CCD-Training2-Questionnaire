using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questionnaire;
using Questionnaire.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TestQuestionnaire
{
    [TestClass]
    public class TestQuestionnaireEvaluator
    {
        private QuestionnaireEvaluator Evaluator;
        public TestQuestionnaireEvaluator()
        {
            Evaluator = new QuestionnaireEvaluator();
        }

        [TestMethod]
        public void TestIsAnswerCorrectRightQuestionText()
        {
            var CorrectQuestion = new Question() { Text = "Test Question", ChosenAnswer = new Answer { Text = "Right Answer" }, Answers = new List<Answer>() { new Answer() { Text = "Right Answer", IsCorrect = true } } };
            var answer = Evaluator.IsAnswerCorrect(CorrectQuestion);
            Assert.AreEqual(answer.Question.Text, CorrectQuestion.Text);
        }

        [TestMethod]
        public void TestIsAnswerCorrectTrue()
        {
            var CorrectQuestion = new Question() { Text = "Test Question", ChosenAnswer = new Answer { Text = "Right Answer"}, Answers = new List<Answer>() { new Answer() { Text = "Right Answer", IsCorrect = true } } };
            var answer = Evaluator.IsAnswerCorrect(CorrectQuestion);
            Assert.AreEqual(answer.GivenAnswer.Text, CorrectQuestion.ChosenAnswer.Text);
            Assert.AreEqual(answer.CorrectAnswer.Text, CorrectQuestion.ChosenAnswer.Text);
        }

        [TestMethod]
        public void TestIsAnswerCorrectFalse()
        {
            var CorrectQuestion = new Question() { Text = "Test Question", ChosenAnswer = new Answer { Text = "False Answer" }, Answers = new List<Answer>() { new Answer() { Text = "Right Answer", IsCorrect = true }, new Answer() { Text = "False Answer", IsCorrect = false } } };
            var answer = Evaluator.IsAnswerCorrect(CorrectQuestion);
            Assert.AreEqual(answer.GivenAnswer.Text, CorrectQuestion.ChosenAnswer.Text);
            Assert.AreNotEqual(answer.CorrectAnswer.Text, CorrectQuestion.ChosenAnswer.Text);
        }

        [TestMethod]
        public void TestCalculatePercentage()
        {
            List<Question> questions = new List<Question>
            {
                new Question { Text = "", ChosenAnswer = new Answer { Text = "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}
            };
            var expected = 33;
            var percentage = Evaluator.CalculatePercentage(questions);
            Assert.AreEqual(expected, percentage);

            questions = new List<Question>
            {
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}
            };
            expected = 66;
            percentage = Evaluator.CalculatePercentage(questions);
            Assert.AreEqual(expected, percentage);

            questions = new List<Question>
            {
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}
            };
            expected = 100;
            percentage = Evaluator.CalculatePercentage(questions);
            Assert.AreEqual(expected, percentage);

            questions = new List<Question>
            {
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}
            };
            expected = 50;
            percentage = Evaluator.CalculatePercentage(questions);
            Assert.AreEqual(expected, percentage);

            questions = new List<Question>
            {
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}
            };
            expected = 25;
            percentage = Evaluator.CalculatePercentage(questions);
            Assert.AreEqual(expected, percentage);

            questions = new List<Question>
            {
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}
            };
            expected = 75;
            percentage = Evaluator.CalculatePercentage(questions);
            Assert.AreEqual(expected, percentage);
        }

        [TestMethod]
        public void TestEvaluator()
        {
            List<Question> questions = new List<Question>
            {
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }},
                new Question { Text = "", ChosenAnswer = new Answer { Text =  "2" }, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}
            };

            var expected = new Score
            {
                Percentage = 40,
                AnswerStates = new List<AnswerState>
            {
                new AnswerState { GivenAnswer = new Answer { Text = "1", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}},
                new AnswerState { GivenAnswer = new Answer { Text = "2", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "2", IsCorrect = true} }}},
                new AnswerState { GivenAnswer = new Answer { Text = "2", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "2", IsCorrect = true} }}},
                new AnswerState { GivenAnswer = new Answer { Text = "1", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}},
                new AnswerState { GivenAnswer = new Answer { Text = "1", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}},
                new AnswerState { GivenAnswer = new Answer { Text = "1", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "1", IsCorrect = true} }}},
                new AnswerState { GivenAnswer = new Answer { Text = "2", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "2", IsCorrect = true} }}},
                new AnswerState { GivenAnswer = new Answer { Text = "2", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "2", IsCorrect = true} }}},
                new AnswerState { GivenAnswer = new Answer { Text = "2", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "2", IsCorrect = true} }}},
                new AnswerState { GivenAnswer = new Answer { Text = "2", IsCorrect = true}, CorrectAnswer = new Answer { Text = "1", IsCorrect = true}, Question = new Question { Text = "", ChosenAnswer = new Answer { Text =  "1"}, Answers = new List<Answer> { new Answer { Text = "2", IsCorrect = true} }}}
            }
            };

            var actual = Evaluator.Evaluate(questions);
            Assert.AreEqual(expected.Percentage, actual.Percentage);
            Assert.AreEqual(expected.AnswerStates.Count(), actual.AnswerStates.Count());

        }
    }
}
