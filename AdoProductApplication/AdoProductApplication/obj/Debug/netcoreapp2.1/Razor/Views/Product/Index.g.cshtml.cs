#pragma checksum "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e099359e80e8ce464e866306283168170455e299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e099359e80e8ce464e866306283168170455e299", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d44cef195b48c85927159bc2045ff42fa9a17372", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product.Model.ProductList>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Product/SearchProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "AddProduct";

#line default
#line hidden
            BeginContext(93, 33, true);
            WriteLiteral("<h3>ProductList</h3>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 48, false);
#line 8 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
Write(Html.ActionLink("Add New Product", "AddProduct"));

#line default
#line hidden
            EndContext();
            BeginContext(175, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(183, 745, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5adc2a3afe7449b89a544081a99a602", async() => {
                BeginContext(254, 203, true);
                WriteLiteral("\r\n\r\n    <input type=\"text\" name=\"SearchText\" class=\"form-control\" placeholder=\"Product Name\" />\r\n    <span>Search Category :</span>\r\n    <select name=\"ProductCategoryById\" class=\"form-control\">\r\n        ");
                EndContext();
                BeginContext(457, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c859f02b674f407eb4c35ed2bcb284fe", async() => {
                    BeginContext(475, 6, true);
                    WriteLiteral("Select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(490, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(500, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e540886cea4e3aa4cdf836216e3baf", async() => {
                    BeginContext(518, 5, true);
                    WriteLiteral("Books");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(532, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(542, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "864245f9d5e04a39a4950cc366173156", async() => {
                    BeginContext(560, 6, true);
                    WriteLiteral("Fruits");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(575, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(585, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f681a4630ac344978ae2a9f0492a5813", async() => {
                    BeginContext(603, 10, true);
                    WriteLiteral("Vegetables");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(622, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(632, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c20e1bd8a2874a5c814fcec35dc33a93", async() => {
                    BeginContext(650, 7, true);
                    WriteLiteral("Clothes");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(666, 255, true);
                WriteLiteral("\r\n    </select>\r\n    <span>Cost Form :</span>\r\n    <input type=\"number\" name=\"MinRange\" class=\"form-control\" />\r\n    <span> To </span>\r\n    <input type=\"number\" name=\"MaxRange\" class=\"form-control\" />\r\n    <input type=\"submit\" class=\"btn btn-primary\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(928, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
#line 28 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(962, 75, true);
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1038, 45, false);
#line 33 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1139, 47, false);
#line 36 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1242, 48, false);
#line 39 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1346, 47, false);
#line 42 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductDate));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 61, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 47 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1503, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1564, 44, false);
#line 51 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1676, 46, false);
#line 54 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1790, 47, false);
#line 57 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1905, 46, false);
#line 60 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductDate));

#line default
#line hidden
            EndContext();
            BeginContext(1951, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2019, 74, false);
#line 63 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
               Write(Html.ActionLink("EditProduct", "EditProduct", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2118, 80, false);
#line 64 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
               Write(Html.ActionLink("ProductDetails", "ProductDetails", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2223, 64, false);
#line 65 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 68 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2342, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 71 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(2372, 37, true);
            WriteLiteral("    <h3>No records where found</h3>\r\n");
            EndContext();
#line 76 "C:\Users\SAURABH\Desktop\AdoProductApplication\AdoProductApplication\AdoProductApplication\Views\Product\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2412, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product.Model.ProductList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
