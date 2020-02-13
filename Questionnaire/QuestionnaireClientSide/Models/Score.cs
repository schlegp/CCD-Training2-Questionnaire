using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireClientSide.Models
{
    public class Score
    {
        public int Percentage { get; set; }

        public int CountCorrect { get; set; }
        public int CountWrong { get; set; }

        public IEnumerable<AnswerState> AnswerStates { get; set; }
    }
}
