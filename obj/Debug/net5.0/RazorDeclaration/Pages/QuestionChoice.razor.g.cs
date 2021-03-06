// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pestniklin")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/venuse")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/mamut")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/stonehenge")]
    public partial class QuestionChoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\QuestionChoice.razor"
       
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

        if (uri.Contains("/venuse"))
        {
            questions = TasksDataService.TaskFive;
            DefaultState = TasksDataService.TaskFiveState["default"];
            SuccessState = TasksDataService.TaskFiveState["success"];
            FailState = TasksDataService.TaskFiveState["fail"];
        }
        else if (uri.Contains("/mamut"))
        {
            questions = TasksDataService.TaskSix;
            DefaultState = TasksDataService.TaskSixState["default"];
            SuccessState = TasksDataService.TaskSixState["success"];
            FailState = TasksDataService.TaskSixState["fail"];
            MAX_MISTAKES = 1;
        }
        else if (uri.Contains("/stonehenge"))
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
        var modal = Modal.Show<ConfirmBox>($"Jste si jisti, ??e chcete zvolit {answer.Text}?");

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
            Modal.Show<Advice>("Konec, odpov??d??li jste chybn??!", param);
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
    private string GetBg(Question question) => "background-color: #fff3e0";


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
