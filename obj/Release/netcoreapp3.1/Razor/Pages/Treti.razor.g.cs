#pragma checksum "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Treti.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d69bd67398eb36174f22569000667ac5a93b3d0"
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
#line 7 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/treti")]
    public partial class Treti : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "id", "main-box");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<PrehistoryMethodApp.Components.Dropzone>(4);
            __builder.AddAttribute(5, "Cards", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<PrehistoryMethodApp.Data.Card>>(
#nullable restore
#line 4 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Treti.razor"
                     Cards

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "DefaultState", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PrehistoryMethodApp.Data.State>(
#nullable restore
#line 5 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Treti.razor"
                             DefaultState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "SuccessfulState", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PrehistoryMethodApp.Data.State>(
#nullable restore
#line 6 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Treti.razor"
                                SuccessfulState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "FailState", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PrehistoryMethodApp.Data.State>(
#nullable restore
#line 7 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Treti.razor"
                          FailState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "LeftColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Treti.razor"
                          LeftColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "RightColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Treti.razor"
                           RightColor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Treti.razor"
       
    private List<Card> Cards = new List<Card>();
    private string LeftColor = "#31a8d4";
    private string RightColor = "#0e6382";

    private State DefaultState = new State
    {
        Headline = "Učíme se keltsky",
        Text = "Z doby Keltů nám zůstalo mnoho zeměpisných názvů. Úkolem v tomto stanovišti je spojit keltské názvy řek (levý sloupec) s názvy českými (pravý sloupec), které k sobě patří. Postupujte ale opatrně! Pokud uděláte <b>JEDNU</b> chybu, záhadu tohoto stanoviště nerozluštíte."
    };
    private State SuccessfulState = new State
    {
        Headline = "Vyřešili jste záhadu stanoviště. Gratulujeme!",
        Text = "Zapiště si písmeno <b>T</b> a pokračujte prosím na další stanoviště."
    };
    private State FailState = new State
    {
        Headline = "Odpověděli jste 2x špatně.",
        Text = "Záhadu tohoto stanoviště se Vám nepodařilo rozluštit. Pokračujte prosím na další stanoviště."
    };

    protected override void OnInitialized()
    {
        var words = TasksDataService.TaskThree;
        Cards = words.ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
