#pragma checksum "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc7134c07f3c4a3b929f51acd5f5486561f2699"
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
    public partial class CallJavaScriptFunctionsThatReturnValue : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Call JavaScript functions that return a value</h2>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-outline-success");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
                                                          ShowPrompt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Show Prompt");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddContent(11, "Prompt result: ");
            __builder.AddContent(12, 
#nullable restore
#line 7 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
                             promptResult

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-outline-success");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
                                                          CreateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Get object from JavaScript");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddContent(24, 
#nullable restore
#line 13 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
              employee?.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " ");
            __builder.AddContent(26, 
#nullable restore
#line 13 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
                                   employee?.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " (");
            __builder.AddContent(28, 
#nullable restore
#line 13 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
                                                        employee?.Email

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, ")");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
        private string promptResult;
            private Employee employee;
            private async Task ShowPrompt()

            {
                var result = await JSRuntime.InvokeAsync<string>("blazorInterop.showPrompt", "What's your name?", promptResult ?? "");

                if (result != null)
                {
                    promptResult = result;
                }
            }

            private async Task CreateEmployee()
            {
                employee = await JSRuntime.InvokeAsync<Employee>("blazorInterop.createEmployee", "Jamie", "Naasz");
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591