#pragma checksum "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07b74909033e7e37d6b866eb3d77d3aa882431cc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b74909033e7e37d6b866eb3d77d3aa882431cc", @"/Views/Movies/Index.cshtml")]
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
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 40 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4 col-xl-6 border-primary mb-3"">
            <div class=""card mb-3""style=""max-width:540px;"">
                <div class=""row g-0"">
                    <div class=""col-md-12"">
                        <div class=""card-header text-white bg-info"">
                            <p class=""card-text"">
                                <h5 class=""card-title"">
                                    Movie Name
                                    <a class=""text-white float-right"">Edit</a>
                                </h5>
                            </p>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 2030, "\"", 2036, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 2050, "\"", 2056, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""col-md-6"">
                        <div class=""card-body"">
                            <p class=""card-text"">Description</p>
                            <p class=""card-text""><b>Cinema: </b>Name cinema sample</p>
                            <p class=""card-text""><b>Category: </b>category sample</p>
                            <p class=""card-text""><b>Start Date: </b>start date sample</p>
                            <p class=""card-text""><b>End Date: </b>end date sample</p>
                            <p class=""card-text"">
                                <b>Status: </b>
                                Status sample
                            </p>
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""card-footer"">
                            <p class=""card-text"">
                                <a class=""btn btn-outline-primary float-right"">show detail<");
            WriteLiteral("/a>\r\n                                <a class=\"btn btn-success text-white\">Add to cart</a>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 82 "D:\Asp git\TicketMovie\TicketMovie\TicketMovie\Views\Movies\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
