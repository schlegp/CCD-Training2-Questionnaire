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
    }
}
