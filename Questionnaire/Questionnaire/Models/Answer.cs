using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire.Models
{
    public class Answer
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsChosen { get; set; }
    }
}
