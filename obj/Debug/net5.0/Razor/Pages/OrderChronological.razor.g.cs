#pragma checksum "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bbed7e75ec34d76aab9c808cf4bf67b82e75e09"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ddum")]
    public partial class OrderChronological : Microsoft.AspNetCore.Components.ComponentBase
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
#line 5 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
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
#line 7 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                  (MarkupString)State.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row" + " " + (
#nullable restore
#line 11 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                     GetGameClasses()

#line default
#line hidden
#nullable disable
            ) + " ");
#nullable restore
#line 12 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
         for (var i = 0; i < ShuffleCards.Count; i++)
        {
            var num = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-3 p-2");
            __builder.AddEventPreventDefaultAttribute(17, "ondragover", true);
            __builder.AddAttribute(18, "ondragover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                                                         () => { }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ondrop", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                          () => OnDrop(num)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "font-weight-bold justify-content-center align-items-center text-center card res-text");
            __builder.AddAttribute(22, "style", "min-height: 5vw; background-color: #fccb81");
            __builder.AddContent(23, 
#nullable restore
#line 20 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                      i+1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, ".\r\n");
#nullable restore
#line 21 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                     if (PlacedCards != null && PlacedCards.ContainsKey(i))
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, 
#nullable restore
#line 23 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                          (MarkupString)PlacedCards[i].FirstWord

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 23 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                                                                 
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row" + " " + (
#nullable restore
#line 29 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                     GetGameClasses()

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 30 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
         foreach (var card in ShuffleCards)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
             if (PlacedCards == null || (PlacedCards != null && !PlacedCards.ContainsValue(card)))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-3" + " p-2" + " " + (
#nullable restore
#line 34 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                                       GetItemClasses(card)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ondragstart", "event.dataTransfer.setData(\'text\', event.target.id);");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "justify-content-center align-items-center card text-center res-text ");
            __builder.AddAttribute(34, "draggable", "true");
            __builder.AddAttribute(35, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                                       (arg) => OnDragStart(card, arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "ondragend", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                                     (arg) => OnDragEnd(card)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "style", "min-height: 5vw; background-color: #fff3e0");
            __builder.AddContent(38, 
#nullable restore
#line 40 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                          (MarkupString)card.FirstWord

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row" + " " + (
#nullable restore
#line 46 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                     GetGameClasses()

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-12 d-flex justify-content-center align-items-center");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                              Check

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "class", "btn btn-primary m-2");
            __builder.AddMarkupContent(47, "Ověřit");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
                              Reset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "class", "btn btn-outline-danger m-2");
            __builder.AddContent(52, "Reset");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\OrderChronological.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }

    private List<Card> Cards;
    private List<Card> ShuffleCards;
    private State State = new();
    private State DefaultState;
    private State SuccessState;
    private State FailState;
    private Card activeItem;
    private Card lastActiveItem;
    private const int MAX_MISTAKES = 1;
    private Dictionary<int, Card> PlacedCards = new();
    private bool failure = false;
    private int mistakes = 0;

    protected override void OnInitialized()
    {
        var words = TasksDataService.TaskEight;
        Cards = words.ToList();
        ShuffleCards = Cards.ToList().OrderBy(x => Guid.NewGuid()).ToList();
        DefaultState = TasksDataService.TaskEightState["default"];
        SuccessState = TasksDataService.TaskEightState["success"];
        FailState = TasksDataService.TaskEightState["fail"];
        State = DefaultState;
    }

    public void OnDragStart(Card card, DragEventArgs dragEventArgs)
    {
        lastActiveItem = activeItem = card;
        dragEventArgs.DataTransfer.EffectAllowed = "move";
    }

    public void OnDragEnd(Card card)
    {
        if (card is null)
        {
            throw new ArgumentNullException(nameof(card));
        }

        lastActiveItem = activeItem;
        activeItem = default(Card);
    }

    public void OnDrop(int position)
    {
        PlacedCards[position] = lastActiveItem;
    }

    private void Check()
    {
        var param = new ModalParameters();

        if (PlacedCards.Count != Cards.Count)
        {
            param.Add("Advices", "Musíte seřadit všechna období.");
            Modal.Show<Advice>("Přesuňte všechna období!", param);
            return;
        }
        for(var i = 0; i < Cards.Count; i++)
        {
            if(PlacedCards[i].Equals(Cards[i]))
            {
                State = SuccessState;
                HideAll();
            }
            else
            {
                if (MAX_MISTAKES <= mistakes)
                {
                    State = FailState;
                    HideAll();
                }
                else
                {
                    param.Add("Advices", "Takhle po sobě jednotlivá období nenásledují, použijte tlačítko \"Reset\" a zkuste to znova.");
                    Modal.Show<Advice>("Špatně seřazeno, zbývá Vám ještě jeden pokus", param);
                    mistakes++;
                }
                return;
            }
        }

    }

    private string GetGameClasses() => CheckIfGameIsHidden() ? "card-hidden " : "";

    private bool CheckIfGameIsHidden() => failure;
    private bool CheckIfItemIsActive(Card card) => card.Equals(activeItem);

    private string GetItemClasses(Card card)
    {
        var output = "";
        output += CheckIfItemIsActive(card) ? "card-dragging " : "";
        return output;
    }

    private void Reset()
    {
        PlacedCards = new();
    }

    private void HideAll()
    {
        failure = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
