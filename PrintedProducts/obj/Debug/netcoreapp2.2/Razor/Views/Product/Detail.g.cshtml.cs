#pragma checksum "C:\Users\echao\source\repos\PrintedProducts\PrintedProducts\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1048ae069165118a7d3a9a4ad6d38c84a695b1f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Detail.cshtml", typeof(AspNetCore.Views_Product_Detail))]
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
#line 1 "C:\Users\echao\source\repos\PrintedProducts\PrintedProducts\Views\_ViewImports.cshtml"
using PrintedProducts;

#line default
#line hidden
#line 2 "C:\Users\echao\source\repos\PrintedProducts\PrintedProducts\Views\_ViewImports.cshtml"
using PrintedProducts.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1048ae069165118a7d3a9a4ad6d38c84a695b1f3", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c44928a6be5d078fb26995dfae634863c1dbec", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\echao\source\repos\PrintedProducts\PrintedProducts\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(70, 122, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <h3>\r\n                ");
            EndContext();
            BeginContext(193, 11, false);
#line 10 "C:\Users\echao\source\repos\PrintedProducts\PrintedProducts\Views\Product\Detail.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(204, 43, true);
            WriteLiteral("\r\n            </h3><img alt=\"Product Image\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 247, "", 267, 1);
#line 11 "C:\Users\echao\source\repos\PrintedProducts\PrintedProducts\Views\Product\Detail.cshtml"
WriteAttributeValue("", 252, Model.ImageUrl, 252, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(267, 119, true);
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"row\"></div>\r\n        <div class=\"col-md-4\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(387, 21, false);
#line 16 "C:\Users\echao\source\repos\PrintedProducts\PrintedProducts\Views\Product\Detail.cshtml"
           Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(408, 160, true);
            WriteLiteral("\r\n            </p><img alt=\"IsInStock\" src=\"\" />\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    Quantity in stock: ");
            EndContext();
            BeginContext(569, 23, false);
#line 20 "C:\Users\echao\source\repos\PrintedProducts\PrintedProducts\Views\Product\Detail.cshtml"
                                  Write(Model.QuantityAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(592, 93, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    Price: ");
            EndContext();
            BeginContext(686, 11, false);
#line 23 "C:\Users\echao\source\repos\PrintedProducts\PrintedProducts\Views\Product\Detail.cshtml"
                      Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(697, 178, true);
            WriteLiteral("\r\n                    <a href=\"#\" class=\"btn btn-primary btn-md\" type=\"button\">Add to Cart</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
