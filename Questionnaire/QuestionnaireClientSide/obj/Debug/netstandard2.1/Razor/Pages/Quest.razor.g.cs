#pragma checksum "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b18352e590fe4471a50ae7436f0ea5611ecf17c"
// <auto-generated/>
#pragma warning disable 1591
namespace QuestionnaireClientSide.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\_Imports.razor"
using QuestionnaireClientSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\_Imports.razor"
using QuestionnaireClientSide.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\_Imports.razor"
using QuestionnaireClientSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\_Imports.razor"
using BlazorFabric;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/questionnaire")]
    public partial class Quest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
 if (Questions == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorFabric.Spinner>(2);
            __builder.AddAttribute(3, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFabric.SpinnerSize>(
#nullable restore
#line 7 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                   SpinnerSize.Medium

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Label", "Loading Questions ...");
            __builder.AddAttribute(5, "LabelPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFabric.SpinnerLabelPosition>(
#nullable restore
#line 7 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                                                                                   SpinnerLabelPosition.Bottom

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 8 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
}
else if (currentScore != null)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddContent(9, 
#nullable restore
#line 12 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
          currentScore.CountCorrect

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " out of ");
            __builder.AddContent(11, 
#nullable restore
#line 12 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                                            currentScore.AnswerStates.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " questions answered correctly (");
            __builder.AddContent(13, 
#nullable restore
#line 12 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                                                                                                             currentScore.Percentage

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, "%)");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 13 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
     foreach (var answerState in currentScore.AnswerStates)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "overflow:auto");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "h4");
            __builder.AddContent(21, 
#nullable restore
#line 16 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                 answerState.Question.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 17 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
             if (answerState.GivenAnswer == answerState.CorrectAnswer)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "div");
            __builder.OpenElement(25, "div");
            __builder.AddContent(26, "Your answer \'");
            __builder.AddContent(27, 
#nullable restore
#line 19 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                                        answerState.GivenAnswer.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, "\' is correct");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 20 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                ");
            __builder.OpenElement(31, "div");
            __builder.OpenElement(32, "div");
            __builder.AddContent(33, "Your answer \'");
            __builder.AddContent(34, 
#nullable restore
#line 23 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                                        answerState.GivenAnswer.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, "\' is wrong");
            __builder.CloseElement();
            __builder.OpenElement(36, "div");
            __builder.AddContent(37, "Correct answer: \'");
            __builder.AddContent(38, 
#nullable restore
#line 23 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                                                                                                           answerState.CorrectAnswer.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(39, "\'");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 24 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 26 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
     
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
     foreach (var question in Questions)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "        ");
            __builder.OpenComponent<QuestionnaireClientSide.QuestionComp>(44);
            __builder.AddAttribute(45, "Question", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<QuestionnaireClientSide.Models.Question>(
#nullable restore
#line 32 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                                question

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 33 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "    <div></div>\r\n    ");
            __builder.OpenComponent<BlazorFabric.PrimaryButton>(48);
            __builder.AddAttribute(49, "Text", "Submit");
            __builder.AddAttribute(50, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
                                                        Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 36 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\phsc1\source\repos\schlegp\CCD-Training2-Questionnaire\Questionnaire\QuestionnaireClientSide\Pages\Quest.razor"
       
    private int currentCount = 0;

    private QuestionHandler qHandler;
    private QuestionnaireEvaluator evaluator;
    private Score currentScore;

    private IEnumerable<Question> Questions;

    protected async override Task OnInitializedAsync()
    {

        qHandler = new QuestionHandler();
        evaluator = new QuestionnaireEvaluator();
        Questions = await qHandler.Provide();
    
    }

    private void Submit()
    {
        currentScore = evaluator.Evaluate(Questions);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591