#pragma checksum "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c838d6d8e12cc2e6d1589de2f5e547956776b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\tigra\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tigra\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c838d6d8e12cc2e6d1589de2f5e547956776b9", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center text-dark\">Корзина</h1>\r\n");
#nullable restore
#line 7 "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml"
 if(ViewBag.cart!=null)
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml"
     foreach (var item in ViewBag.cart)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <div class=\"active text-dark\">\r\n            <div >Название: ");
#nullable restore
#line 12 "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml"
                       Write(item.Phone.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div >Описание: ");
#nullable restore
#line 13 "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml"
                       Write(item.Phone.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div >Стоимость: ");
#nullable restore
#line 14 "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml"
                        Write(item.Phone.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div >Количество: ");
#nullable restore
#line 15 "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml"
                         Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div >Общая стоимость: ");
#nullable restore
#line 16 "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml"
                               Write(item.Quantity * item.Phone.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n        </div>\r\n    </p>\r\n");
#nullable restore
#line 20 "C:\Users\tigra\source\repos\Shop\Shop\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
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