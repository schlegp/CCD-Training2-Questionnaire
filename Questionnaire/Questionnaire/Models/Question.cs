﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire.Models
{
    public class Question
    {
        public string Text { get; set; }
        public Answer ChosenAnswer { get; set; }
        
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
