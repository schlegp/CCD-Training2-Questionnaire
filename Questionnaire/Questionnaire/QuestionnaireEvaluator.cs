using Questionnaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire
{
    public class QuestionnaireEvaluator
    {
        public Score Evaluate(IEnumerable<Question> questions)
        {
            var score = CalculateScore(questions);
            
            return score;
        }

        public Score CalculateScore(IEnumerable<Question> questions)
        {
            IEnumerable<AnswerState> answerStates = questions.Select(IsAnswerCorrect);
            return new Score { AnswerStates = answerStates, Percentage = CalculatePercentage(questions) };
        }

        private int CalculatePercentage(IEnumerable<Question> questions)
        {
            var correctAnswers = questions.SelectMany(x => x.Answers.Where(y => y.IsChosen && y.IsCorrect));
            var numberQuestions = questions.Count();
            var score = correctAnswers.Count() / numberQuestions;
            var scorePercent = score * 100;
            return scorePercent;
        }

        public AnswerState IsAnswerCorrect(Question question)
        {
            return new AnswerState { CorrectAnswer = question.Answers.FirstOrDefault(x => x.IsCorrect), GivenAnswer = question.Answers.FirstOrDefault(x => x.IsChosen), Question = question};
        }
    }
}
