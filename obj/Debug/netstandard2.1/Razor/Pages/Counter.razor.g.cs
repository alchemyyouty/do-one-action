#pragma checksum "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "595d23be0f55f94bcca5ab5b24cc13c591759acb"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\nWelcome to my new app.\r\n\r\n");
            __builder.OpenComponent<do_one_action.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Current count: ");
            __builder.AddContent(6, 
#nullable restore
#line 8 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Counter.razor"
       
	private int currentCount = 0;

	private void IncrementCount()
	{
		currentCount++;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
