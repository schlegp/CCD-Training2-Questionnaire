using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire.Models
{
    public class Question
    {
        public string QuestionText { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
    }
}
