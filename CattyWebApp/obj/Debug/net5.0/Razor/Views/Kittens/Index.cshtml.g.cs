#pragma checksum "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9308e3f0a8ac46bfc07fc624f290ca346f713d5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kittens_Index), @"mvc.1.0.view", @"/Views/Kittens/Index.cshtml")]
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
#line 1 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\_ViewImports.cshtml"
using CattyWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\_ViewImports.cshtml"
using CattyWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9308e3f0a8ac46bfc07fc624f290ca346f713d5f", @"/Views/Kittens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7267ec67af519e64d6716696988e43caf66590f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Kittens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CattyWebLibrary.Models.Kitten>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 828, "\"", 850, 1);
#nullable restore
#line 35 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
WriteAttributeValue("", 834, item.PictureURL, 834, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:128px;\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
               Write(Html.ActionLink("Edit", "Update", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 51 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 52 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\andra.vasilcoiu\Desktop\QAProject\CattyWebApp\Views\Kittens\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CattyWebLibrary.Models.Kitten>> Html { get; private set; }
    }
}
#pragma warning restore 1591