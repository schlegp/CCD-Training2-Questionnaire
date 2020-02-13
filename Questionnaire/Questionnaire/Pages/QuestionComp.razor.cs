using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Questionnaire.Models;

namespace Questionnaire
{
    public partial class QuestionComp : ComponentBase
    {
        [Parameter]
        public Question Question { get; set; }
    }
}
