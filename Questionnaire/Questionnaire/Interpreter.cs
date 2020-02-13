using Questionnaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire
{
    public class Interpreter
    {
        public bool IsQuestion(string line)
        {
            if (line[0] == '?')
                return true;
            return false;
        }

        public Answer InterpretAnswer(string line)
        {
            var answer = new Answer();
            answer.IsCorrect = false;
            if (line[0] == '*')
                answer.IsCorrect = true;
            if (answer.IsCorrect)
            {
                answer.Text = line.Substring(1);
            }
            else
            {
                answer.Text = line;
            }
            answer.Type = BlazorFabric.SelectableOptionMenuItemType.Normal;
            return answer;
        }

        public Question InterpretQuestion(string line)
        {
            var question = new Question();
            question.Text = line.Substring(1);
            return question;
        }

        public IEnumerable<Question> Interpret(IEnumerable<string> lines)
        {
            List<Question> questions = new List<Question>();
            Question currentQuestion = null;
            foreach(var line in lines)
            {
                var isQuestion = IsQuestion(line);
                if (isQuestion)
                {
                    if (currentQuestion != null)
                        currentQuestion.Answers.Add(new Answer { IsChosen = false, IsCorrect = false, Text = "Don't Know", Type = BlazorFabric.SelectableOptionMenuItemType.Normal });
                    currentQuestion = InterpretQuestion(line);
                    questions.Add(currentQuestion);
                }
                else
                {
                    currentQuestion.Answers.Add(InterpretAnswer(line));
                }
            }

            return questions;
        }
    }
}
