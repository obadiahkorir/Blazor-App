#pragma checksum "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e0c93fd77bd597b033d3b03297e8b0ffa5f4cb9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Client.Pages.Developer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using BlazorCRUD.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projects\BlazorCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/developer")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Developers</h3>\r\n");
            __builder.AddMarkupContent(1, "<small>Add as many developers as you wish.</small>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"form-group pull-right\"><a class=\"btn btn-success\" href=\"developer/create\"><i class=\"oi oi-plus\"></i> Create New</a></div>\r\n<br>");
#nullable restore
#line 10 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
 if (developers == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "Loading...");
#nullable restore
#line 12 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
                           
}
else if (developers.Length == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "No Records Found.");
#nullable restore
#line 16 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped");
            __builder.AddMarkupContent(7, "<thead><tr><th>Id</th>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th>Email</th>\r\n                <th>Experience (Years)</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 32 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
             foreach (Developer dev in developers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 35 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
                         dev.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 36 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
                         dev.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 37 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
                         dev.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 38 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
                         dev.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 39 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
                         dev.Experience

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "btn btn-success");
            __builder.AddAttribute(28, "href", "developer/edit/" + (
#nullable restore
#line 41 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
                                                                         dev.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-danger");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
                                                                   () => Delete(dev.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Projects\BlazorCRUD\Client\Pages\Developer\FetchData.razor"
       
    Developer[] developers { get; set; }
    protected override async Task OnInitializedAsync()
    {
        developers = await client.GetFromJsonAsync<Developer[]>("api/developer");
    }
    async Task Delete(int developerId)
    {
        var dev = developers.First(x => x.Id == developerId);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {dev.FirstName}'s ({dev.Id}) Record?"))
        {
            await client.DeleteAsync($"api/developer/{developerId}");
            await OnInitializedAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
