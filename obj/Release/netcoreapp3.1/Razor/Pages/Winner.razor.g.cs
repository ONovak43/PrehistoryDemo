#pragma checksum "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Winner.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80f761e194fc52484a190339e6a3ea2c4895ccbe"
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
#line 15 "C:\Users\onova\source\repos\PrehistoryMethodApp\_Imports.razor"
using PrehistoryMethodApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Winner.razor"
using PrehistoryMethodApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/winner")]
    public partial class Winner : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal-body text-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<p>Výborně. Všechny tvé odpovědi jsou správné.</p>\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddMarkupContent(5, "Heslo tohoto stanoviště je ");
            __builder.OpenElement(6, "b");
            __builder.AddContent(7, 
#nullable restore
#line 7 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Winner.razor"
                                      SecretWord

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(8, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\onova\source\repos\PrehistoryMethodApp\Pages\Winner.razor"
       
    [Parameter] public string SecretWord { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
