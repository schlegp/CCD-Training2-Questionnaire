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
            answer.RightAnswer = false;
            if (line[0] == '*')
                answer.RightAnswer = true;
            if (answer.RightAnswer)
            {
                answer.AnswerText = line.Substring(1)
            }
            else
            {
                answer.AnswerText = line;
            }
            return answer;
        }
    }
}
