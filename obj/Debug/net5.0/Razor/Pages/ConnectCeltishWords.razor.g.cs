#pragma checksum "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\ConnectCeltishWords.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77127f0a2d67ccc80391c4d70133add7aa3052d0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/keltove")]
    public partial class ConnectCeltishWords : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "id", "main-box");
            __builder.OpenComponent<PrehistoryMethodApp.Components.Dropzone>(3);
            __builder.AddAttribute(4, "Cards", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<PrehistoryMethodApp.Data.Card>>(
#nullable restore
#line 4 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\ConnectCeltishWords.razor"
                     Cards

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "DefaultState", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PrehistoryMethodApp.Data.State>(
#nullable restore
#line 5 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\ConnectCeltishWords.razor"
                             TasksDataService.TaskTwoState["default"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "SuccessfulState", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PrehistoryMethodApp.Data.State>(
#nullable restore
#line 6 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\ConnectCeltishWords.razor"
                                TasksDataService.TaskTwoState["success"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "FailState", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PrehistoryMethodApp.Data.State>(
#nullable restore
#line 7 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\ConnectCeltishWords.razor"
                          TasksDataService.TaskTwoState["fail"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "LeftColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\ConnectCeltishWords.razor"
                          LeftColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "RightColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\ConnectCeltishWords.razor"
                           RightColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Max_Mistakes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 10 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\ConnectCeltishWords.razor"
                            1

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\ConnectCeltishWords.razor"
       
    private List<Card> Cards = new List<Card>();
    private string LeftColor = "#c2d9fc";
    private string RightColor = "#afc1db";

    protected override void OnInitialized()
    {
        var words = TasksDataService.TaskTwo;
        Cards = words.ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
