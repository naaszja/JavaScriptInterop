#pragma checksum "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13639433a28abbc814508208e920eecbffef5d74"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.ServerApp.Pages.HumanResources
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
#line 3 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
using BethanysPieShopHRM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeedit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeedit/{EmployeeId}")]
    public partial class EmployeeEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "employee-edit");
#nullable restore
#line 6 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
   if (!Saved)
  {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h1");
            __builder.AddAttribute(3, "class", "page-title");
            __builder.AddContent(4, "Details for ");
            __builder.AddContent(5, 
#nullable restore
#line 8 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                            Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                      Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                                                     HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n\n      ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group row");
                __builder2.AddMarkupContent(19, "<label for=\"firstName\" class=\"col-sm-3\">First name: </label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "firstName");
                __builder2.AddAttribute(22, "class", "form-control col-sm-8");
                __builder2.AddAttribute(23, "placeholder", "Enter first name");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                                              Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "offset-sm-3 col-sm-8");
                __Blazor.BethanysPieShopHRM.ServerApp.Pages.HumanResources.EmployeeEdit.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 19 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                    () => Employee.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n\n      ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group row");
                __builder2.AddMarkupContent(35, "<label for=\"lastName\" class=\"col-sm-3\">Last name: </label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "id", "lastName");
                __builder2.AddAttribute(38, "class", "form-control col-sm-8");
                __builder2.AddAttribute(39, "placeholder", "Enter last name");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                                             Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.AddComponentReferenceCapture(43, (__value) => {
#nullable restore
#line 25 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                                                                                                    LastNameInputText = (Microsoft.AspNetCore.Components.Forms.InputText)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "offset-sm-3 col-sm-8");
                __Blazor.BethanysPieShopHRM.ServerApp.Pages.HumanResources.EmployeeEdit.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#nullable restore
#line 27 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                    () => Employee.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n\n      ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group row");
                __builder2.AddMarkupContent(52, "<label for=\"email\" class=\"col-sm-3\">Email: </label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "id", "email");
                __builder2.AddAttribute(55, "class", "form-control col-sm-8");
                __builder2.AddAttribute(56, "placeholder", "Enter email");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                                          Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "offset-sm-3 col-sm-8");
                __Blazor.BethanysPieShopHRM.ServerApp.Pages.HumanResources.EmployeeEdit.TypeInference.CreateValidationMessage_2(__builder2, 63, 64, 
#nullable restore
#line 35 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                    () => Employee.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n\n      ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group row");
                __builder2.AddMarkupContent(68, "<label for=\"longitude\" class=\"col-sm-3\">Longitude: </label>\n        ");
                __Blazor.BethanysPieShopHRM.ServerApp.Pages.HumanResources.EmployeeEdit.TypeInference.CreateInputNumber_3(__builder2, 69, 70, "longitude", 71, "form-control col-sm-8", 72, 
#nullable restore
#line 41 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                                                Employee.Longitude

#line default
#line hidden
#nullable disable
                , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Longitude = __value, Employee.Longitude)), 74, () => Employee.Longitude);
                __builder2.AddMarkupContent(75, "\n        ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "offset-sm-3 col-sm-8");
                __Blazor.BethanysPieShopHRM.ServerApp.Pages.HumanResources.EmployeeEdit.TypeInference.CreateValidationMessage_4(__builder2, 78, 79, 
#nullable restore
#line 43 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                    () => Employee.Longitude

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n\n      ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group row");
                __builder2.AddMarkupContent(83, "<label for=\"latitude\" class=\"col-sm-3\">Latitude: </label>\n        ");
                __Blazor.BethanysPieShopHRM.ServerApp.Pages.HumanResources.EmployeeEdit.TypeInference.CreateInputNumber_5(__builder2, 84, 85, "latitude", 86, "form-control col-sm-8", 87, 
#nullable restore
#line 49 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                                               Employee.Latitude

#line default
#line hidden
#nullable disable
                , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Latitude = __value, Employee.Latitude)), 89, () => Employee.Latitude);
                __builder2.AddMarkupContent(90, "\n        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "offset-sm-3 col-sm-8");
                __Blazor.BethanysPieShopHRM.ServerApp.Pages.HumanResources.EmployeeEdit.TypeInference.CreateValidationMessage_6(__builder2, 93, 94, 
#nullable restore
#line 51 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                    () => Employee.Latitude

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n\n      ");
                __builder2.AddMarkupContent(96, "<button type=\"submit\" class=\"btn btn-primary edit-btn\">Save employee</button>\n      ");
                __builder2.OpenElement(97, "a");
                __builder2.AddAttribute(98, "class", "btn btn-outline-primary edit-outline-btn");
                __builder2.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                                     NavigateToOverview

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(100, "Cancel");
                __builder2.CloseElement();
#nullable restore
#line 57 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
       if (Employee.EmployeeId > 0)
      {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(101, "a");
                __builder2.AddAttribute(102, "class", "btn btn-danger");
                __builder2.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                             DeleteEmployee

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(104, "\n          Delete\n        ");
                __builder2.CloseElement();
#nullable restore
#line 62 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
      }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 64 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"

  }
  else
  {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "alert" + " " + (
#nullable restore
#line 68 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                       StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(107, 
#nullable restore
#line 68 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                     Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\n    ");
            __builder.OpenElement(109, "a");
            __builder.AddAttribute(110, "class", "btn btn-outline-primary");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"
                                                  NavigateToOverview

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(112, "Back to overview");
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeEdit.razor"

  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BethanysPieShopHRM.ServerApp.Pages.HumanResources.EmployeeEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
