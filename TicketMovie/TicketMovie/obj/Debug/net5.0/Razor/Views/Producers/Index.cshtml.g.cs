#pragma checksum "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "083b3999a8921502130ce88c38f157f24beae80a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producers_Index), @"mvc.1.0.view", @"/Views/Producers/Index.cshtml")]
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
#line 1 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\_ViewImports.cshtml"
using TicketMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\_ViewImports.cshtml"
using TicketMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"083b3999a8921502130ce88c38f157f24beae80a", @"/Views/Producers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd74a9cda0a30c01986da8f63ab84808f81d0327", @"/Views/_ViewImports.cshtml")]
    public class Views_Producers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"
  
    ViewData["Title"] = "List of Producer";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 \">\r\n        <table class=\"table \">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 13 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProfilePictureUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 20 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">\r\n                        <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 728, "\"", 757, 1);
#nullable restore
#line 24 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"
WriteAttributeValue("", 734, item.ProfilePictureUrl, 734, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 758, "\"", 774, 1);
#nullable restore
#line 24 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"
WriteAttributeValue("", 764, item.Name, 764, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:150px\" />\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 27 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"
                   Write(Html.DisplayFor(x => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 30 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"
                   Write(Html.DisplayFor(x => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td class=""align-middle"">
                        <a class=""btn btn-outline-primary"">Edit</a>
                        <a class=""btn btn-outline-info"">Details</a>
                        <a class=""btn btn-danger"">Delete</a>
                    </td>
                </tr>
");
#nullable restore
#line 38 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Producers\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Producer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
