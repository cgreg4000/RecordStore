#pragma checksum "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02f83f558e6c2c662c285f9ade2e868aa76c16b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f83f558e6c2c662c285f9ade2e868aa76c16b3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"424ead1ab0ee5f1f810a398581f821621a6bb112", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/records/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex justify-content-between align-items-center mt-3 pl-5 pr-5 mr-5 ml-5\">\r\n    <h1><a class=\"text-body text-decoration-none display-4\" href=\"/home\">RecordStore</a></h1>\r\n    <div class=\"text-center d-flex\">\r\n");
#nullable restore
#line 8 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
          
            if (ViewBag.LoggedInUser == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <a class=\"btn btn-dark\" href=\"/register\">Register</a>\r\n                    <a class=\"btn btn-dark ml-4\" href=\"/login\">Login</a>\r\n                </div>\r\n");
#nullable restore
#line 15 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3>Welcome ");
#nullable restore
#line 18 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                       Write(ViewBag.LoggedInUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h3>\r\n                <div class=\"d-flex align-items-center\">\r\n");
#nullable restore
#line 20 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                      
                        if (ViewBag.LoggedInUser.UserType == "Administrator")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5><a class=\"ml-4 text-body text-decoration-none\" href=\"/admin/dashboard\">Admin Dashboard</a></h5>\r\n");
#nullable restore
#line 24 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5><a class=\"ml-4 text-body text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 1133, "\"", 1184, 2);
            WriteAttributeValue("", 1140, "/users/myorders/", 1140, 16, true);
#nullable restore
#line 27 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
WriteAttributeValue("", 1156, ViewBag.LoggedInUser.UserId, 1156, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">My Orders</a></h5>\r\n");
#nullable restore
#line 28 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5><a class=\"ml-4 text-body text-decoration-none\" href=\"/logout\">Logout</a></h5>\r\n                </div>\r\n");
#nullable restore
#line 32 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<hr>\r\n\r\n<div class=\"d-flex pl-5 pr-5 ml-5 mr-5\">\r\n    <div class=\"mr-3 mt-3 col-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02f83f558e6c2c662c285f9ade2e868aa76c16b37556", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"search\" name=\"Search\" class=\"form-control\">\r\n                <input type=\"submit\" class=\"btn btn-dark float-right mt-2\" value=\"Search\">\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"d-flex flex-wrap col-10\">\r\n");
#nullable restore
#line 48 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
          
            if (ViewBag.Search == null || ViewBag.Search == "")
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                 foreach (Record r in ViewBag.AllRecords)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card m-3 album\" style=\"width: 14rem;\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2156, "\"", 2170, 1);
#nullable restore
#line 54 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
WriteAttributeValue("", 2162, r.Cover, 2162, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2171, "\"", 2185, 1);
#nullable restore
#line 54 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
WriteAttributeValue("", 2177, r.Title, 2177, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\"><a class=\"text-body stretched-link text-decoration-none\"");
            BeginWriteAttribute("href", "\r\n                            href=\"", 2345, "\"", 2401, 2);
            WriteAttributeValue("", 2381, "/records/", 2381, 9, true);
#nullable restore
#line 57 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
WriteAttributeValue("", 2390, r.RecordId, 2390, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                                   Write(r.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 58 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                            Write(r.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">$");
#nullable restore
#line 59 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                             Write(r.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 60 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                              
                                if (r.Quantity == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-danger\">OUT OF STOCK</p>\r\n");
#nullable restore
#line 64 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"card-text\">");
#nullable restore
#line 67 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                                    Write(r.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in stock</p>\r\n");
#nullable restore
#line 68 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 72 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                 
            }
            else
            {
                bool found = false;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                 foreach (Record r in ViewBag.AllRecords)
                {
                    if (r.Artist.Contains(ViewBag.Search, StringComparison.OrdinalIgnoreCase) || r.Title.Contains(ViewBag.Search,
                    StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                 
                if (found)
                {
                    foreach (Record r in ViewBag.AllRecords)
                    {
                        if (r.Artist.Contains(ViewBag.Search, StringComparison.OrdinalIgnoreCase) || r.Title.Contains(ViewBag.Search,
                        StringComparison.OrdinalIgnoreCase))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card mt-3 mb-3 ml-3 album\" style=\"width: 14rem;\">\r\n                                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 4044, "\"", 4058, 1);
#nullable restore
#line 93 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
WriteAttributeValue("", 4050, r.Cover, 4050, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4059, "\"", 4073, 1);
#nullable restore
#line 93 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
WriteAttributeValue("", 4065, r.Title, 4065, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title\"><a");
            BeginWriteAttribute("href", " href=\"", 4195, "\"", 4222, 2);
            WriteAttributeValue("", 4202, "/records/", 4202, 9, true);
#nullable restore
#line 95 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
WriteAttributeValue("", 4211, r.RecordId, 4211, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 95 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                                                                     Write(r.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 96 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                                    Write(r.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"card-text\">$");
#nullable restore
#line 97 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                                     Write(r.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 98 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                      
                                        if (r.Quantity == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"text-danger\">OUT OF STOCK</p>\r\n");
#nullable restore
#line 102 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"card-text\">");
#nullable restore
#line 105 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                                            Write(r.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in stock</p>\r\n");
#nullable restore
#line 106 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 110 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                        }
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2>No records found matching that search.</h2>\r\n");
#nullable restore
#line 116 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/test_project/RecordStore/Views/Home/Index.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
