// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\ysspe\Desktop\WorkSpace\do-one-action\Pages\Index.razor"
 
    public string EntryButtonText { get; set; } = "Create the goal";
    public string BackLink { get; set; } = "/";
    public string EntryLink { get; set; } = "createAction/step01";

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
