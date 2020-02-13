using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire.Models
{
    public class Score
    {
        public int Percentage { get; set; }

        public IEnumerable<AnswerState> AnswerStates { get; set; }
    }
}
