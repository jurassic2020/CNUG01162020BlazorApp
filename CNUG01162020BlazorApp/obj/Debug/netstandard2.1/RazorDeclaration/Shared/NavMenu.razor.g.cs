#pragma checksum "C:\dev\Blazor\CNUG01162020BlazorApp\CNUG01162020BlazorApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "559484c0fe6f39e224e10f02cd9f0072951789a5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CNUG01162020BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\Blazor\CNUG01162020BlazorApp\CNUG01162020BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\Blazor\CNUG01162020BlazorApp\CNUG01162020BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\Blazor\CNUG01162020BlazorApp\CNUG01162020BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\Blazor\CNUG01162020BlazorApp\CNUG01162020BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\Blazor\CNUG01162020BlazorApp\CNUG01162020BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\Blazor\CNUG01162020BlazorApp\CNUG01162020BlazorApp\_Imports.razor"
using CNUG01162020BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\Blazor\CNUG01162020BlazorApp\CNUG01162020BlazorApp\_Imports.razor"
using CNUG01162020BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\dev\Blazor\CNUG01162020BlazorApp\CNUG01162020BlazorApp\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591