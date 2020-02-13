using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuestionnaireClientSide.Models;

namespace QuestionnaireClientSide
{
    public partial class QuestionComp : ComponentBase
    {
        [Parameter]
        public Question Question { get; set; }

        public string Choosen { get; set; }


    }
}
