#pragma checksum "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9aefb5d51b2e1a7c4d4d4fcd65791b81187004a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            __builder.AddMarkupContent(1, "<h3>Component1</h3>");
#nullable restore
#line 10 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>check</th>\n                <th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th></tr></thead>\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 27 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "checkbox");
            __builder.AddAttribute(11, "name", "math");
            __builder.AddAttribute(12, "value", "");
            __builder.AddAttribute(13, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                                                                           forecast.IsChecked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => forecast.IsChecked = __value, forecast.IsChecked));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 36 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "p");
            __builder.AddContent(28, 
#nullable restore
#line 43 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
    pushCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                  OnButtonClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "count");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                  OnRegisterButtonClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "登録");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                  OnActionButton

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "コントローラー");
            __builder.CloseElement();
#nullable restore
#line 49 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
 if (tempForecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<p><em>Loading...</em></p>");
#nullable restore
#line 52 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "table");
            __builder.AddAttribute(43, "class", "table");
            __builder.AddMarkupContent(44, "<thead><tr><th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th></tr></thead>\n        ");
            __builder.OpenElement(45, "tbody");
#nullable restore
#line 65 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
             foreach (var forecast in tempForecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "tr");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 68 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 69 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                    ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 70 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                    ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 71 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "p");
            __builder.AddContent(59, 
#nullable restore
#line 78 "/Users/hiyoshiyousuke/Projects/BlazorWeb/BlazorWeb/Client/Pages/DataList.razor"
    text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
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
