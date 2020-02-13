using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireClientSide.Models
{
    public class Question
    {
        public string Text { get; set; }
        public string ChoosenAnswer { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
