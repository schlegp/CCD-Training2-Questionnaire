using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFabric;

namespace Questionnaire.Models
{
    public class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
