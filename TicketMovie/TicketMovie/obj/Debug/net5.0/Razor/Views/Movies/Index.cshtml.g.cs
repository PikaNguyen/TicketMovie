#pragma checksum "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d4f09d85cb4b3e592f5d53c01287b0ed40b828b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d4f09d85cb4b3e592f5d53c01287b0ed40b828b", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd74a9cda0a30c01986da8f63ab84808f81d0327", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "List of Movie";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 \">\r\n        <table class=\"table \">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 13 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 20 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 733, "\"", 753, 1);
#nullable restore
#line 24 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
WriteAttributeValue("", 739, item.ImageUrl, 739, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 754, "\"", 770, 1);
#nullable restore
#line 24 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
WriteAttributeValue("", 760, item.Name, 760, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:150px\" />\r\n                        </td>\r\n                        <td class=\"align-middle\" style=\"width:auto\">\r\n                            ");
#nullable restore
#line 27 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
                       Write(Html.DisplayFor(x => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\" style=\"width:auto\">\r\n                            ");
#nullable restore
#line 30 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
                       Write(Html.DisplayFor(x => item.Discription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
