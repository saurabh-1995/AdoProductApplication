#pragma checksum "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60bd902041681fec2c1c11a93cec0731e66937d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductDetails), @"mvc.1.0.view", @"/Views/Product/ProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductDetails.cshtml", typeof(AspNetCore.Views_Product_ProductDetails))]
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
#line 1 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\_ViewImports.cshtml"
using AdoProductApplication;

#line default
#line hidden
#line 2 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\_ViewImports.cshtml"
using AdoProductApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60bd902041681fec2c1c11a93cec0731e66937d7", @"/Views/Product/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d44cef195b48c85927159bc2045ff42fa9a17372", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product.Model.ProductList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
  
    ViewData["Title"] = "ProductDetails";

#line default
#line hidden
            BeginContext(84, 128, true);
            WriteLiteral("\r\n<h2>ProductDetails</h2>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(213, 45, false);
#line 13 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(258, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(304, 41, false);
#line 17 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(345, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(391, 47, false);
#line 21 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(438, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(484, 43, false);
#line 25 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(571, 48, false);
#line 28 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(619, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(665, 44, false);
#line 32 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(709, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 47, false);
#line 36 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDate));

#line default
#line hidden
            EndContext();
            BeginContext(802, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(848, 43, false);
#line 40 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProductDate));

#line default
#line hidden
            EndContext();
            BeginContext(891, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(939, 75, false);
#line 46 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
Write(Html.ActionLink("EditProduct", "EditProduct", new { id = Model.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1023, 40, false);
#line 47 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\ProductDetails.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 12, true);
            WriteLiteral("\r\n</p>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product.Model.ProductList> Html { get; private set; }
    }
}
#pragma warning restore 1591