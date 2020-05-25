#pragma checksum "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619ad2944f57646fa279905d05c35e22aa616368"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RPDemoApp.Pages.Orders.Pages_Orders_List), @"mvc.1.0.razor-page", @"/Pages/Orders/List.cshtml")]
namespace RPDemoApp.Pages.Orders
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\_ViewImports.cshtml"
using RPDemoApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619ad2944f57646fa279905d05c35e22aa616368", @"/Pages/Orders/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6da786e6850f6567fa7cf4da72be5e1d75e1de", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Orders_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of Orders</h1>\r\n");
#nullable restore
#line 8 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
 if (@Model.Orders is null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>The are no orders at the moment.</h4>\r\n");
#nullable restore
#line 11 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped"">
        <thead class=""thead-dark"">
            <tr>
                <th>Order Name</th>
                <th>Order Date</th>
                <th>Food</th>
                <th>Quantity</th>
                <th>Total</th>
                <th>View</th>
                <th>Delete</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
             foreach (var order in Model.Orders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
                   Write(order.OrderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
                   Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
                   Write(order.FoodId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
                   Write(order.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
                   Write(string.Format("{0:C}", order.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>View</td>\r\n                    <td>Delete</td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 43 "C:\Users\mphet\source\home\RPDemo\RPDemoApp\Pages\Orders\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RPDemoApp.Pages.Orders.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RPDemoApp.Pages.Orders.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RPDemoApp.Pages.Orders.ListModel>)PageContext?.ViewData;
        public RPDemoApp.Pages.Orders.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591