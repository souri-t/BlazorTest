// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWeb.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using BlazorWeb.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/_Imports.razor"
using BlazorWeb.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
using BlazorWeb.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datalist")]
    public partial class DataList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
       
    private WeatherForecast[] forecasts;

    private WeatherForecast[] tempForecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("DataList");
    }

    protected int pushCount;

    private void OnButtonClick()
    {
        pushCount++;
    }

    public string text;
    private void OnRegisterButtonClick()
    {
        this.text = this.forecasts.Count().ToString();
        this.tempForecasts = this.forecasts.Where(e => e.IsChecked).ToArray();

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                                                                                            
    }
    async Task OnActionButton()
    {
        OwnData ownData = await Http.GetFromJsonAsync<OwnData>("DataList/SiteData");
        this.text = ownData.Name;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
