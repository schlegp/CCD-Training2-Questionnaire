using QuestionnaireClientSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireClientSide
{
    public class QuestionnaireEvaluator
    {
        public Score Evaluate(IEnumerable<Question> questions)
        {
            IEnumerable<AnswerState> answerStates = questions.Select(IsAnswerCorrect);
            var percentage = CalculatePercentage(questions);
            return CreateScore(answerStates,percentage);
        }

        public Score CreateScore(IEnumerable<AnswerState> answerStates, int percentage)
        {
            var returnScore = new Score();
            returnScore.AnswerStates = answerStates;
            returnScore.CountCorrect = answerStates.Count(x => x.Correct);
            returnScore.CountWrong = answerStates.Count(x => !x.Correct);
            returnScore.Percentage = percentage;
            return returnScore;

        }

        public int CalculatePercentage(IEnumerable<Question> questions)
        {
            var correctAnswers = questions.SelectMany(x => x.Answers.Where(y => x.ChoosenAnswer == y.Text && y.IsCorrect));
            var numberQuestions = questions.Count();
            var score = (double)correctAnswers.Count() / (double)numberQuestions;
            var scorePercent = score * 100;
            return (int)scorePercent;
        }

        public AnswerState IsAnswerCorrect(Question question)
        {
            var answerState = new AnswerState
            {
                CorrectAnswer = question.Answers.FirstOrDefault(x => x.IsCorrect),
                GivenAnswer = question.Answers.FirstOrDefault(x => x.Text == question.ChoosenAnswer),
                Question = question
            };
            answerState.Correct = answerState.GivenAnswer == answerState.CorrectAnswer;
            return answerState;
        }
    }
}
