#pragma checksum "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\BrowserOnlineIndicator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2fe122b3f9dee852218a3bcca5fed9e635d0df3"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.ServerApp.Components
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
    public partial class BrowserOnlineIndicator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\BrowserOnlineIndicator.razor"
 if (_isOnline)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"isOnline\">You\'re online</div>");
#nullable restore
#line 4 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\BrowserOnlineIndicator.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"isOffline\">You\'re offline</div>");
#nullable restore
#line 8 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\BrowserOnlineIndicator.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\jlnaasz\Desktop\Syncfusion Support\javascript-interop-blazor-applications\03\demos\before\BethanysPieShopHRM.ServerApp\Components\BrowserOnlineIndicator.razor"
       
  private bool _isOnline = true;

  // TODO: Get status from navigator's onLine property
  //       and subscribe to 'online' and 'offline' events to update

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
