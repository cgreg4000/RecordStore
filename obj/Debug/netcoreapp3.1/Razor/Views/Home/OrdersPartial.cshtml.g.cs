#pragma checksum "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb18a5d788e61021e33834ae0747b845ec23a851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrdersPartial), @"mvc.1.0.view", @"/Views/Home/OrdersPartial.cshtml")]
namespace AspNetCore
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
#line 1 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/_ViewImports.cshtml"
using RecordStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/_ViewImports.cshtml"
using RecordStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb18a5d788e61021e33834ae0747b845ec23a851", @"/Views/Home/OrdersPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"424ead1ab0ee5f1f810a398581f821621a6bb112", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrdersPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-striped\">\n    <tr>\n        <th>Order ID</th>\n        <th>Date</th>\n        <th>Name</th>\n        <th>Record</th>\n        <th>Price</th>\n        <th>Quantity</th>\n        <th>OrderTotal</th>\n        <th>Actions</th>\n    </tr>\n");
#nullable restore
#line 12 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
      
        foreach (Order o in ViewBag.AllOrders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th>");
#nullable restore
#line 16 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
               Write(o.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 17 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
               Write(o.CreatedAt.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 18 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
               Write(o.Buyer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
                                  Write(o.Buyer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 19 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
               Write(o.Record.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 20 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
               Write(o.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 21 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
               Write(o.QuantityBought);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 22 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
               Write(o.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th><a");
            BeginWriteAttribute("href", " href=\"", 673, "\"", 705, 2);
            WriteAttributeValue("", 680, "/orders/delete/", 680, 15, true);
#nullable restore
#line 23 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
WriteAttributeValue("", 695, o.OrderId, 695, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger text-decoration-none\">Cancel</a></th>\n            </tr>\n");
#nullable restore
#line 25 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/OrdersPartial.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
