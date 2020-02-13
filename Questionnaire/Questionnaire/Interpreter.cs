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
                        AddNotKnown(currentQuestion);
                    currentQuestion = InterpretQuestion(line);
                    questions.Add(currentQuestion);
                }
                else
                {
                    currentQuestion.Answers.Add(InterpretAnswer(line));
                }
            }
            AddNotKnown(currentQuestion);
            
            return questions;
        }

        public void AddNotKnown(Question question)
        {
            var nullAnswer = new Answer { IsCorrect = false, Text = "Don't know" };
            question.Answers?.Add(nullAnswer);
        }
    }
}
