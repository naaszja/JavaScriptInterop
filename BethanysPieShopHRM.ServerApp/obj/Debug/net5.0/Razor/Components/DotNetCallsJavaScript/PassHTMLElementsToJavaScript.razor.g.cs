#pragma checksum "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\PassHTMLElementsToJavaScript.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fde9c6c039b8ca615edf1eb3f1c0595fde3a0b3"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.ServerApp.Components.DotNetCallsJavaScript
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Services.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Services.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Services.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.Shared;

#line default
#line hidden
#nullable disable
    public partial class PassHTMLElementsToJavaScript : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Pass HTML element references to JavaScript</h2>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<label>Element to focus:</label>\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddElementReferenceCapture(7, (__value) => {
#nullable restore
#line 7 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\PassHTMLElementsToJavaScript.razor"
                 elementToFocus = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-outline-success");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\PassHTMLElementsToJavaScript.razor"
                                                  FocusElement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Focus Element");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\PassHTMLElementsToJavaScript.razor"
       private ElementReference elementToFocus;

        protected async   override Task OnAfterRenderAsync(bool firstRender) {
        await FocusElement();
    }

    private async Task FocusElement()
    {
        await JSRuntime.InvokeVoidAsync("blazorInterop.focusElement", elementToFocus);
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
