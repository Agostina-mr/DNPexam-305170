#pragma checksum "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d97ebd7305aa72e9f43b3b05a9f3ada6f5eb3f3a"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
using Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
using System.Xml.Schema;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ToysAndChildren")]
    public partial class ToysAndChildren : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ToysAndChildren</h3>");
#nullable restore
#line 7 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
 if (children == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
}
else if (!children.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>No children or Toys exist.</em></p>");
#nullable restore
#line 18 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "p");
            __builder.AddMarkupContent(4, "\r\n        Filter by Gender: ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
                                                         FilterByGender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
     foreach (var child in childrenToDisplay)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, 
#nullable restore
#line 26 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
            child.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " is ");
            __builder.AddContent(12, 
#nullable restore
#line 26 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
                           child.Age

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " years old . Their toys include: ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.AddMarkupContent(17, "<thead><tr><th>Name</th>\r\n                <th>Colour</th>\r\n                <th>Is favorite?</th>\r\n                <th>Delete</th></tr></thead>\r\n            ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 38 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
             foreach (var toy in child.Toys)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 41 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
                         toy.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 42 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
                         toy.Color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 43 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
                         toy.IsFavourite

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
                                            () => RemoveToy(@toy.ToyId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\agosm\RiderProjects\DNPexam-305170\Blazor\Pages\ToysAndChildren.razor"
       
    private List<Child> children = new List<Child>();
    private List<Child> childrenToDisplay = new List<Child>();
    protected override async Task OnInitializedAsync()
    {
        children = await services.GetAllChildren();
        childrenToDisplay = children;

    }

    private async Task RemoveToy(int toyId)
    {
       await services.RemoveToy( toyId);
        children = await services.GetAllChildren();
        childrenToDisplay = children;
    }

    private void FilterByGender(ChangeEventArgs gender)
    {
        childrenToDisplay = children.Where(c => c.Gender == (string) gender.Value).ToList();
        if ("" == (string) gender.Value)
        {
            childrenToDisplay = children;
        }
       
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private KinderGardenServices services { get; set; }
    }
}
#pragma warning restore 1591
