#pragma checksum "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "638f8cddc566a3034aa209e48124125e74be4498"
// <auto-generated/>
#pragma warning disable 1591
namespace do_one_action.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using do_one_action;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using do_one_action.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using do_one_action.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\_Imports.razor"
using do_one_action.Components.Atom;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container mt-5\">\r\n    <h1 class=\"text-center\">Do One Action</h1>\r\n</div>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "href", 
#nullable restore
#line 7 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Index.razor"
                EntryLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 7 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Index.razor"
                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<do_one_action.Components.Atom.BaseButton>(6);
                __builder2.AddAttribute(7, "ClickEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Index.razor"
                             CallConsole

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(8, "ButtonText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Index.razor"
                                                       EntryButton

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Index.razor"
 
    public string EntryButton { get; set; } = "Create the goal";
    public string EntryLink { get; set; } = "counter";

    private void CallConsole(MouseEventArgs e)
    {
        Console.WriteLine("Clicked!", e);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
