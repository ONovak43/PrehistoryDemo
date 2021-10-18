#pragma checksum "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ef7c256219fee0b37298884f0e7e9070d997db"
// <auto-generated/>
#pragma warning disable 1591
namespace PrehistoryMethodApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using PrehistoryMethodApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using PrehistoryMethodApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using PrehistoryMethodApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using PrehistoryMethodApp.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ctvrty")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/paty")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/sesty")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/sedmy")]
    public partial class Ctvrte : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "id", "main-box");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg text-center");
            __builder.OpenElement(7, "h1");
            __builder.AddContent(8, 
#nullable restore
#line 12 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                 State.Headline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, 
#nullable restore
#line 14 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                  (MarkupString)State.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
     foreach (var question in Questions)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row" + " mb-1" + " " + (
#nullable restore
#line 20 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                              GetQuestionClass(question)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-12 card p-2");
            __builder.AddAttribute(16, "ondragstart", "event.dataTransfer.setData(\'text\', event.target.id);");
            __builder.AddAttribute(17, "style", "background-color: #fff3e0");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "font-weight-bold justify-content-center align-items-center text-center mb-2");
            __builder.OpenElement(20, "h5");
            __builder.AddContent(21, 
#nullable restore
#line 23 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                          (MarkupString)question.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-sm col-12 m-auto card-col");
#nullable restore
#line 26 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                       var i = 0; 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
#nullable restore
#line 28 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                         foreach (var ans in question.Answers)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-6 mb-1");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "text-center" + " card" + " m-auto" + " question-card" + " justify-content-center" + " align-items-center" + " " + (
#nullable restore
#line 31 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                                                                                                                              TrueFalse == false ? "card-with-ans" : ans.Text == "pravda" ? "card-true" : "card-false"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                                               () => AnswerClick(question, ans)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, 
#nullable restore
#line 33 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                                     ans.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
                            i++;
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Ctvrte.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }

    private int MAX_MISTAKES = 0;

    private char[] chars = new char[] { 'a', 'b', 'c', 'd' };

    private int mistakes = 0;

    private int RightAns = 0;

    private List<Question> Questions = new();
    private List<Question> HiddenItems = new();
    private State State = new();
    private State DefaultState;
    private State SuccessState;
    private State FailState;
    private bool TrueFalse = false;

    protected override void OnInitialized()
    {
        Question[] questions;

        var uri = NavigationManager.Uri;

        if (uri.Contains("/paty"))
        {
            questions = TasksDataService.TaskFive;
            DefaultState = TasksDataService.TaskFiveState["default"];
            SuccessState = TasksDataService.TaskFiveState["success"];
            FailState = TasksDataService.TaskFiveState["fail"];
        }
        else if (uri.Contains("/sesty"))
        {
            questions = TasksDataService.TaskSix;
            DefaultState = TasksDataService.TaskSixState["default"];
            SuccessState = TasksDataService.TaskSixState["success"];
            FailState = TasksDataService.TaskSixState["fail"];
            MAX_MISTAKES = 1;
        }
        else if (uri.Contains("/sedmy"))
        {
            questions = TasksDataService.TaskSeven;
            DefaultState = TasksDataService.TaskSevenState["default"];
            SuccessState = TasksDataService.TaskSevenState["success"];
            FailState = TasksDataService.TaskSevenState["fail"];
            MAX_MISTAKES = 1;
            TrueFalse = true;
        }
        else
        {
            questions = TasksDataService.TaskFour;
            DefaultState = TasksDataService.TaskFourState["default"];
            SuccessState = TasksDataService.TaskFourState["success"];
            FailState = TasksDataService.TaskFourState["fail"];
        }

        Questions = questions.ToList().OrderBy(x => Guid.NewGuid()).ToList();

        State.Headline = DefaultState.Headline;
        State.Text = DefaultState.Text;
    }

    private async Task AnswerClick(Question question, Answer answer)
    {
        var param = new ModalParameters();
        var modal = Modal.Show<ConfirmBox>($"Jste si jisti, že chcete zvolit {answer.Text}?");

        var result = await modal.Result;

        if (result.Cancelled)
            return;

        if (answer.RightAnswer)
        {
            HideQuestion(question);
            RightAns++;
            if (RightAns == Questions.Count)
            {
                State.Headline = SuccessState.Headline;
                State.Text = SuccessState.Text;
            }
            return;
        }
        else if (mistakes >= MAX_MISTAKES)
        {
            State.Headline = FailState.Headline;
            State.Text = FailState.Text;
            HideAll();
            param.Add(nameof(question.Advices), question.WrongAnswer);
            Modal.Show<Advice>("Konec, odpověděli jste chybně!", param);
            return;
        }
        mistakes++;

        param.Add(nameof(question.Advices), question.Advices);
        Modal.Show<Advice>("Chyba!", param);
    }

    private void HideQuestion(Question question)
    {
        HiddenItems.Add(question);
    }

    private void HideAll()
    {
        HiddenItems = Questions;
    }

    private string GetQuestionClass(Question question) => CheckIfQuestionIsHidden(question) ? "card-hidden " : "";

    private bool CheckIfQuestionIsHidden(Question question) => HiddenItems.Contains(question);

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591