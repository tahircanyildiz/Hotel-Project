#pragma checksum "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Testimonial\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43ba7de6450bef94e4cb5188acd43952b804d41b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_Index), @"mvc.1.0.view", @"/Views/Testimonial/Index.cshtml")]
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
#line 1 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43ba7de6450bef94e4cb5188acd43952b804d41b", @"/Views/Testimonial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f742f99c887e966e15603f2fae5d661cc40316", @"/Views/_ViewImports.cshtml")]
    public class Views_Testimonial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TestimonialViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Testimonial\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Referans Görsel</th>\r\n        <th>Referans Adı</th>\r\n        <th>Referans Ünvanı</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Testimonial\Index.cshtml"
 foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <th>");
#nullable restore
#line 23 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Testimonial\Index.cshtml"
       Write(item.TestimonialID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Testimonial\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Testimonial\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 540, "\"", 585, 2);
            WriteAttributeValue("", 547, "/Staff/DeleteStaff/", 547, 19, true);
#nullable restore
#line 26 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 566, item.TestimonialID, 566, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 667, "\"", 712, 2);
            WriteAttributeValue("", 674, "/Staff/UpdateStaff/", 674, 19, true);
#nullable restore
#line 27 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 693, item.TestimonialID, 693, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Testimonial\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Staff/AddStaff/\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Personel Girişi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TestimonialViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
