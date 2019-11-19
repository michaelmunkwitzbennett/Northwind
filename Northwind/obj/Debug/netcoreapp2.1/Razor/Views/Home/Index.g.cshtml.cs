#pragma checksum "C:\Users\scawd\source\repos\Northwind\Northwind\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b25b9e2d6ab8f84de4288798d0f0a6571456f0d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Home.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(Northwind.Views.Home.Home.Views_Home_Index))]
namespace Northwind.Views.Home.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\scawd\source\repos\Northwind\Northwind\Views\Home\Index.cshtml"
using Northwind.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b25b9e2d6ab8f84de4288798d0f0a6571456f0d9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9a8f25754e8a6130fcf6b741acedd9114e42f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Discount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 906, true);
            WriteLiteral(@"<!-- toast -->
<div id=""toast"" class=""toast"">
    <div class=""toast-header"">
        <strong class=""mr-auto"" id=""product"">Product Name</strong>
        <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
    <div class=""toast-body"">
        Discount Code: <strong id=""code"">CODE</strong>
    </div>
</div>

<div class=""jumbotron my-2"">
    <h1 class=""display-4"">Northwind</h1>
    <p class=""lead"">We have the best prices and selection of high quality foods &amp; beverages on the planet! Check out our featured discounts below.</p>
    <hr class=""my-4"">
    <p>For exceptional international quisuine, look no further.</p>
    <a class=""btn btn-outline-primary btn-lg"" href=""#"" role=""button""><i class=""fas fa-shopping-cart""></i> Order Now</a>
</div>

<div class=""row"">
");
            EndContext();
#line 25 "C:\Users\scawd\source\repos\Northwind\Northwind\Views\Home\Index.cshtml"
     foreach (Discount d in Model)
    {

#line default
#line hidden
            BeginContext(1004, 64, true);
            WriteLiteral("        <div class=\"col-md m-3 p-3 discounts\">\r\n            <h3>");
            EndContext();
            BeginContext(1069, 7, false);
#line 28 "C:\Users\scawd\source\repos\Northwind\Northwind\Views\Home\Index.cshtml"
           Write(d.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 55, true);
            WriteLiteral("</h3>\r\n            <div class=\"mb-4\">\r\n                ");
            EndContext();
            BeginContext(1132, 13, false);
#line 30 "C:\Users\scawd\source\repos\Northwind\Northwind\Views\Home\Index.cshtml"
           Write(d.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1145, 55, true);
            WriteLiteral("\r\n            </div>\r\n            <i>Discount expires: ");
            EndContext();
            BeginContext(1201, 32, false);
#line 32 "C:\Users\scawd\source\repos\Northwind\Northwind\Views\Home\Index.cshtml"
                            Write(d.EndTime.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 60, true);
            WriteLiteral("</i><br />\r\n            <a href=\"#\" class=\"code\" data-code=\"");
            EndContext();
            BeginContext(1294, 6, false);
#line 33 "C:\Users\scawd\source\repos\Northwind\Northwind\Views\Home\Index.cshtml"
                                           Write(d.Code);

#line default
#line hidden
            EndContext();
            BeginContext(1300, 16, true);
            WriteLiteral("\" data-product=\"");
            EndContext();
            BeginContext(1317, 7, false);
#line 33 "C:\Users\scawd\source\repos\Northwind\Northwind\Views\Home\Index.cshtml"
                                                                  Write(d.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1324, 77, true);
            WriteLiteral("\"><i class=\"far fa-hand-point-right\"></i> Discount Code</a>\r\n        </div>\r\n");
            EndContext();
#line 35 "C:\Users\scawd\source\repos\Northwind\Northwind\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1408, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1436, 68, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\" src=\"/js/client.js\"></script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Discount>> Html { get; private set; }
    }
}
#pragma warning restore 1591