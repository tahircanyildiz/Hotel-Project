#pragma checksum "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "158194d4da858f044cd5068a745a22ec66e85d66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158194d4da858f044cd5068a745a22ec66e85d66", @"/Views/Staff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f742f99c887e966e15603f2fae5d661cc40316", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StaffViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
  

    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Personel Adı </th>\r\n        <th>Personel Unvan </th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 19 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
                   Write(item.StaffID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 574, "\"", 613, 2);
            WriteAttributeValue("", 581, "/Staff/DeleteStaff/", 581, 19, true);
#nullable restore
#line 22 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
WriteAttributeValue("", 600, item.StaffID, 600, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 703, "\"", 742, 2);
            WriteAttributeValue("", 710, "/Staff/UpdateStaff/", 710, 19, true);
#nullable restore
#line 23 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
WriteAttributeValue("", 729, item.StaffID, 729, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\r\n                    <td><a href=\"#\" class=\"btn mb-1 btn-rounded btn-outline-primary\">Detaylar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Tahir\Desktop\Udemy\ApiConsumeProject\Frontend\HotelProject.WebUI\Views\Staff\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Staff/AddStaff/\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Personel Girişi</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StaffViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
