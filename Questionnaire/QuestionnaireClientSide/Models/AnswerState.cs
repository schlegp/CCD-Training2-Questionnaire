using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireClientSide.Models
{
    public class AnswerState
    {
        public bool Correct { get; set; }
        public Question Question { get; set; }
        public Answer GivenAnswer { get; set; }
        public Answer CorrectAnswer { get; set; }
    }
}
