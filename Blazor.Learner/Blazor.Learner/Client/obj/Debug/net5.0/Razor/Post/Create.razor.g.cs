#pragma checksum "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed09812f47fae0c11a4eb8c9bfa0ea7600a4b6fd"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Learner.Client.Post
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
#line 12 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Create.razor"
using Blazor.Learner.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/post/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Post</h3>\r\n\r\n");
            __builder.OpenComponent<Blazor.Learner.Client.Post.Form>(1);
            __builder.AddAttribute(2, "ButtonText", "Create Blog");
            __builder.AddAttribute(3, "post", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.Learner.Shared.Models.Post>(
#nullable restore
#line 8 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Create.razor"
                                      post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Create.razor"
                      CreatePost

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\user\Desktop\Blazor.Learner (2)\Blazor.Learner (2)\Blazor.Learner\Blazor.Learner\Blazor.Learner\Client\Post\Create.razor"
       
    Post post = new Post();
    async Task CreatePost()
    {
        await http.PostAsJsonAsync("api/post", post);
        uriHelper.NavigateTo("post");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
