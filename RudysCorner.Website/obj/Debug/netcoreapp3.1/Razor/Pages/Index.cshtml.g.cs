#pragma checksum "C:\src\rudysCorner\RudysCorner.Website\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e4341ced2e89d4938fc3ae85d2ebe4ce4f40ffc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoCrafts.Website.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContosoCrafts.Website.Pages
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
#line 1 "C:\src\rudysCorner\RudysCorner.Website\Pages\_ViewImports.cshtml"
using ContosoCrafts.Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e4341ced2e89d4938fc3ae85d2ebe4ce4f40ffc", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db118a47d3e250874f275a02edb59e72b8b81e7e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\src\rudysCorner\RudysCorner.Website\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"display-4\">Colin Crafts</h1>\r\n</div>\r\n\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 12 "C:\src\rudysCorner\RudysCorner.Website\Pages\Index.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 305, "\"", 352, 4);
            WriteAttributeValue("", 313, "background-image:", 313, 17, true);
            WriteAttributeValue(" ", 330, "url(\'", 331, 6, true);
#nullable restore
#line 15 "C:\src\rudysCorner\RudysCorner.Website\Pages\Index.cshtml"
WriteAttributeValue("", 336, product.Image, 336, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 350, "\')", 350, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div class=\"card-body\"><h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\src\rudysCorner\RudysCorner.Website\Pages\Index.cshtml"
                                                     Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></div>\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\src\rudysCorner\RudysCorner.Website\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoCrafts.WebSite.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoCrafts.WebSite.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoCrafts.WebSite.Pages.IndexModel>)PageContext?.ViewData;
        public ContosoCrafts.WebSite.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
