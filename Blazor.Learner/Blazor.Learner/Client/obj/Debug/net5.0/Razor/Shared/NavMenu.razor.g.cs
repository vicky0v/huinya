#pragma checksum "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d669574849b64f6555c218f0cf985e739912e766"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Learner.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using Blazor.Learner.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-fj36rnjt2l");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-fj36rnjt2l>Blog</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-fj36rnjt2l");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-fj36rnjt2l></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenComponent<MudBlazor.MudPaper>(10);
            __builder.AddAttribute(11, "Height", "700px");
            __builder.AddAttribute(12, "Style", "overflow:hidden; position:relative;");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudDrawerContainer>(14);
                __builder2.AddAttribute(15, "Class", "mud-height-full");
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDrawer>(17);
                    __builder3.AddAttribute(18, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                 0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerVariant>(
#nullable restore
#line 10 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                              DrawerVariant.Persistent

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                                               Color.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Open", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                open

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "OpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => open = __value, open))));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudDrawerHeader>(24);
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(26);
                            __builder5.AddAttribute(27, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 12 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(29, "Menu");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavMenu>(31);
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(33, "li");
                            __builder5.AddAttribute(34, "class", "nav-item px-3");
                            __builder5.AddAttribute(35, "b-fj36rnjt2l");
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
                            __builder5.AddAttribute(37, "class", "nav-link");
                            __builder5.AddAttribute(38, "href", "");
                            __builder5.AddAttribute(39, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(40, "Style", 
#nullable restore
#line 16 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                                        $"color:{Colors.LightGreen.Accent3}; background:{Colors.BlueGrey.Darken4};"

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudMenu>(42);
                                __builder6.AddAttribute(43, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                        Icons.Filled.Home

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(44, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                  Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(45, "\r\n                ");
                            __builder5.OpenElement(46, "li");
                            __builder5.AddAttribute(47, "class", "nav-item px-3");
                            __builder5.AddAttribute(48, "b-fj36rnjt2l");
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
                            __builder5.AddAttribute(50, "class", "nav-link");
                            __builder5.AddAttribute(51, "href", "counter");
                            __builder5.AddAttribute(52, "Style", 
#nullable restore
#line 22 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                      $"color:{Colors.LightGreen.Accent3}; background:{Colors.BlueGrey.Darken4};"

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudMenu>(54);
                                __builder6.AddAttribute(55, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                        Icons.Material.Filled.Favorite

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(56, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                               Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(57, "\r\n                ");
                            __builder5.OpenElement(58, "li");
                            __builder5.AddAttribute(59, "class", "nav-item px-3");
                            __builder5.AddAttribute(60, "b-fj36rnjt2l");
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
                            __builder5.AddAttribute(62, "class", "nav-link");
                            __builder5.AddAttribute(63, "href", "fetchdata");
                            __builder5.AddAttribute(64, "Style", 
#nullable restore
#line 28 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                        $"color:{Colors.LightGreen.Accent3};  background:{Colors.BlueGrey.Darken4};"

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudMenu>(66);
                                __builder6.AddAttribute(67, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                        Icons.Filled.Cloud

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(68, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 29 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                   Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(69, "\r\n                ");
                            __builder5.OpenElement(70, "li");
                            __builder5.AddAttribute(71, "class", "nav-item px-3");
                            __builder5.AddAttribute(72, "b-fj36rnjt2l");
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(73);
                            __builder5.AddAttribute(74, "class", "nav-link");
                            __builder5.AddAttribute(75, "href", "developer");
                            __builder5.AddAttribute(76, "Style", 
#nullable restore
#line 34 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                        $"color:{Colors.LightGreen.Accent3};  background:{Colors.BlueGrey.Darken4};"

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudMenu>(78);
                                __builder6.AddAttribute(79, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                        Icons.Filled.Extension

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(80, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 35 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                       Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(81, "\r\n                ");
                            __builder5.OpenElement(82, "li");
                            __builder5.AddAttribute(83, "class", "nav-item px-3");
                            __builder5.AddAttribute(84, "b-fj36rnjt2l");
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(85);
                            __builder5.AddAttribute(86, "class", "nav-link");
                            __builder5.AddAttribute(87, "href", "Post");
                            __builder5.AddAttribute(88, "Style", 
#nullable restore
#line 40 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                   $"color:{Colors.LightGreen.Accent3}; background:{Colors.BlueGrey.Darken4};"

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudMenu>(90);
                                __builder6.AddAttribute(91, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                        Icons.Filled.AddPhotoAlternate

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(92, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 42 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                               Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n        ");
                    __builder3.OpenElement(94, "div");
                    __builder3.AddAttribute(95, "class", "d-flex justify-center align-center mud-height-full");
                    __builder3.AddAttribute(96, "b-fj36rnjt2l");
                    __builder3.OpenComponent<MudBlazor.MudButton>(97);
                    __builder3.AddAttribute(98, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 49 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 49 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                       Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
                                                                                ToggleDrawer

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(102, "Open menu");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    bool open = false;

    void ToggleDrawer()
    {
        open = !open;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
