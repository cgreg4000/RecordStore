#pragma checksum "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5592b4ee3fc4c0929e45dd0e98199160c71d0712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RecordsPartial), @"mvc.1.0.view", @"/Views/Home/RecordsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5592b4ee3fc4c0929e45dd0e98199160c71d0712", @"/Views/Home/RecordsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"424ead1ab0ee5f1f810a398581f821621a6bb112", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RecordsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-striped\">\n    <tr>\n        <th>Record ID</th>\n        <th>Title</th>\n        <th>Artist</th>\n        <th>Price</th>\n        <th>Quantity</th>\n        <th>Actions</th>\n    </tr>\n");
#nullable restore
#line 10 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
      
        foreach (Record r in ViewBag.AllRecords)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th>");
#nullable restore
#line 14 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
               Write(r.RecordId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 15 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
               Write(r.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 16 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
               Write(r.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 17 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
               Write(r.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 18 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
               Write(r.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th><a");
            BeginWriteAttribute("href", " href=\"", 485, "\"", 512, 2);
            WriteAttributeValue("", 492, "/records/", 492, 9, true);
#nullable restore
#line 19 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
WriteAttributeValue("", 501, r.RecordId, 501, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-body text-decoration-none\">View</a> | <a");
            BeginWriteAttribute("href", "\n                    href=\"", 566, "\"", 618, 2);
            WriteAttributeValue("", 593, "/records/edit/", 593, 14, true);
#nullable restore
#line 20 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
WriteAttributeValue("", 607, r.RecordId, 607, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-body text-decoration-none\">Edit</a> | <a");
            BeginWriteAttribute("href", "\n                    href=\"", 672, "\"", 726, 2);
            WriteAttributeValue("", 699, "/records/delete/", 699, 16, true);
#nullable restore
#line 21 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
WriteAttributeValue("", 715, r.RecordId, 715, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger text-decoration-none\">Delete</a></th>\n            </tr>\n");
#nullable restore
#line 23 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/RecordsPartial.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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