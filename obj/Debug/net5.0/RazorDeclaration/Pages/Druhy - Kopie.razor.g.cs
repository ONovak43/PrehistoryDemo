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
#line 3 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Druhy - Kopie.razor"
using PrehistoryMethodApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Druhy___Kopie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Druhy - Kopie.razor"
       
    private List<Card> Cards = new List<Card>();
    private List<Card> CardsTwo = new List<Card>();
    private Card activeItem = new Card();
    private Card lastActiveItem = new Card();
    private List<Card> hiddenItems = new List<Card>();
    private Dictionary<Card, string> cardColors = new Dictionary<Card,string>();
    private List<Card> RightAnswers = new List<Card>();
    private string State = "Úkolem v tomto stanovišti je spojit pojmy, které k sobě patří. Postupujte ale opatrně! Pokud uděláte <b>JEDNU</b> chybu, záhadu tohoto stanoviště nerozluštíte.";
    private string Headline = "Vítejte na stanovišti číslo jedna!";
    private bool mistake = false;
    private bool instructionHidden = false;

    protected override void OnInitialized()
    {
        var words = TasksService.TaskOne;
        Cards = words.ToList();
        CardsTwo = words.ToList().OrderBy(x => Guid.NewGuid()).ToList();
    }

    private void OnDragStart(Card card, DragEventArgs dragEventArgs)
    {
        lastActiveItem = activeItem = card;
        dragEventArgs.DataTransfer.EffectAllowed = "move";
    }

    private void OnDragEnd(Card card)
    {
        lastActiveItem = activeItem;
        activeItem = null;
    }

    private void OnDrop(Card card)
    {
        if (card.Equals(lastActiveItem))
        {
            ChangeColor(card);
            RightAnswers.Add(card);
            if(RightAnswers.Count == Cards.Count)
            {
                HideAll();
                var parameteres = new ModalParameters();
                parameteres.Add("SecretWord", "U");

                modal.Show<Winner>("Vítězství!", parameteres);
                State = "Zapiště si písmeno <b>U</b> a pokračujte prosím na další stanoviště.";
                Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!";
            }
        }
        else if (mistake)
        {
            HideAll();
            instructionHidden = true;
            var parameteres = new ModalParameters();
            parameteres.Add(nameof(card.Advices), lastActiveItem.WrongAnswer);

            modal.Show<Advice>("Konec!", parameteres);
            State = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště.";
            Headline = "Odpověděli jste 2x špatně.";
        }
        else
        {
            mistake = true;
            var parameteres = new ModalParameters();
            parameteres.Add(nameof(card.Advices), lastActiveItem.Advices);

            modal.Show<Advice>("Chyba!", parameteres);
        }
    }

    private string GetItemClasses(Card card)
    {
        var output = "";
        output += CheckIfItemIsActive(card) ? "card-dragging " : "";
        output += CheckIfItemIsHidden(card) ? "card-hidden " : "";
        return output;
    }

    private string GetDropItemClasses(Card card)
    {
        var output = "";
        output += CheckIfItemIsHidden(card) ? "card-hidden " : "";
        return output;
    }

    private string GetInstructionClass() => instructionHidden ? "card-hidden" : "";

    private string GetWrongAnswerClass() => instructionHidden ? "" : "card-hidden";

    private string GetBgColor(Card card, bool isRight = true) => CheckIfItemHasColor(card) ? cardColors[card] : isRight ? "#D89E4F" : "#AF6500";

    private bool CheckIfItemIsActive(Card card) => card.Equals(activeItem);

    private bool CheckIfItemIsHidden(Card card) => hiddenItems.Contains(card);
    private bool CheckIfItemHasColor(Card card) => cardColors.ContainsKey(card);

    private void ChangeColor(Card card)
    {
        var random = new Random();
        var color = String.Format("#{0:X6}", random.Next(0x1000000));
        cardColors.Add(card, color);
        HideItem(card);
    }

    private void HideItem(Card card)
    {
        hiddenItems.Add(card);
    }

    private void HideAll()
    {
        hiddenItems = Cards;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TasksDataService TasksService { get; set; }
    }
}
#pragma warning restore 1591
