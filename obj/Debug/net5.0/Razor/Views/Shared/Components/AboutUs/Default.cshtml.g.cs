#pragma checksum "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13b6d35331252984f9e36ffcd8555cae0cf2c57c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutUs_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutUs/Default.cshtml")]
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
#line 1 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\_ViewImports.cshtml"
using DemoTraveler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\_ViewImports.cshtml"
using DemoTraveler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13b6d35331252984f9e36ffcd8555cae0cf2c57c", @"/Views/Shared/Components/AboutUs/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6325ad69784e179b4747c81b97ca68776a231e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutUs_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AboutUs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
  
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid py-5"">
        <div class=""container pt-5"">
            <div class=""row"">
                <div class=""col-lg-6"" style=""min-height: 500px;"">
                    <div class=""position-relative h-100"">
                        <img class=""position-absolute w-100 h-100""");
            BeginWriteAttribute("src", " src=\"", 709, "\"", 746, 2);
            WriteAttributeValue("", 715, "..\\", 715, 3, true);
#nullable restore
#line 24 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 718, Url.Content(item.AboutImg1), 718, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""object-fit: cover;"">
                    </div>
                </div>
                <div class=""col-lg-6 pt-5 pb-lg-5"">
                    <div class=""about-text bg-white p-4 p-lg-5 my-lg-5"">
                        <h6 class=""text-primary text-uppercase"" style=""letter-spacing: 5px;"">About Us</h6>
                        <h1 class=""mb-3"">");
#nullable restore
#line 30 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                    Write(localizer["We Provide Best Tour Packages In Your Budget"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p></p>\r\n                        <div class=\"row mb-4\">\r\n                            <div class=\"col-6\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1354, "\"", 1391, 2);
            WriteAttributeValue("", 1360, "../", 1360, 3, true);
#nullable restore
#line 34 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 1363, Url.Content(item.AboutImg2), 1363, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1392, "\"", 1398, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-6\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1541, "\"", 1578, 2);
            WriteAttributeValue("", 1547, "../", 1547, 3, true);
#nullable restore
#line 37 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
WriteAttributeValue("", 1550, Url.Content(item.AboutImg3), 1550, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1579, "\"", 1585, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1683, "\"", 1690, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary mt-1\">");
#nullable restore
#line 40 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                                           Write(localizer["Book Now"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 46 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- About Start -->
<!-- About End -->
<!-- Feature Start -->
<div class=""container-fluid pb-5"">
    <div class=""container pb-5"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""d-flex mb-4 mb-lg-0"">
                    <div class=""d-flex flex-shrink-0 align-items-center justify-content-center bg-primary mr-3"" style=""height: 100px; width: 100px;"">
                        <i class=""fa fa-2x fa-money-check-alt text-white""></i>
                    </div>
                    <div class=""d-flex flex-column"">
                        <h5");
            BeginWriteAttribute("class", " class=\"", 2444, "\"", 2452, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                Write(localizer["Competitive Pricing"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"m-0\">");
#nullable restore
#line 61 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                  Write(localizer["Competitive Pricing"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""d-flex mb-4 mb-lg-0"">
                    <div class=""d-flex flex-shrink-0 align-items-center justify-content-center bg-primary mr-3"" style=""height: 100px; width: 100px;"">
                        <i class=""fa fa-2x fa-award text-white""></i>
                    </div>
                    <div class=""d-flex flex-column"">
                        <h5");
            BeginWriteAttribute("class", " class=\"", 3061, "\"", 3069, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                Write(localizer["Best Services"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"m-0\">");
#nullable restore
#line 72 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                  Write(localizer["Best Services"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""d-flex mb-4 mb-lg-0"">
                    <div class=""d-flex flex-shrink-0 align-items-center justify-content-center bg-primary mr-3"" style=""height: 100px; width: 100px;"">
                        <i class=""fa fa-2x fa-globe text-white""></i>
                    </div>
                    <div class=""d-flex flex-column"">
                        <h5");
            BeginWriteAttribute("class", " class=\"", 3666, "\"", 3674, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                Write(localizer["Worldwide Coverage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"m-0\">");
#nullable restore
#line 83 "C:\Users\ABOOD ALAMAYREH\source\repos\DemoTraveler\Views\Shared\Components\AboutUs\Default.cshtml"
                                  Write(localizer["Worldwide Coverage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Feature End -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> locOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AboutUs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
