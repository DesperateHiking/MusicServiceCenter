#pragma checksum "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ab1433df4fbb07df78aaa8fc2687093bccdd17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload_List), @"mvc.1.0.view", @"/Views/Upload/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Upload/List.cshtml", typeof(AspNetCore.Views_Upload_List))]
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
#line 1 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\_ViewImports.cshtml"
using WebMusicCenter;

#line default
#line hidden
#line 2 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\_ViewImports.cshtml"
using WebMusicCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ab1433df4fbb07df78aaa8fc2687093bccdd17", @"/Views/Upload/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b539ac1b3b1cedd404e88be64b6cfe6edb399ee9", @"/Views/_ViewImports.cshtml")]
    public class Views_Upload_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<WebMusicCenter.Models.DataAccessPostgreSqlProvider.DbCompletingForm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
  
    ViewBag.Title = "Анкеты с описанием проблемы";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(193, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(198, 13, false);
#line 6 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(211, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 7 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
 foreach (var form in Model)
{

#line default
#line hidden
            BeginContext(251, 32, true);
            WriteLiteral("<div>\r\n    Название формы:\r\n    ");
            EndContext();
            BeginContext(284, 13, false);
#line 11 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
Write(form.FormName);

#line default
#line hidden
            EndContext();
            BeginContext(297, 28, true);
            WriteLiteral("\r\n    Имя заполнителя:\r\n    ");
            EndContext();
            BeginContext(326, 9, false);
#line 13 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
Write(form.Name);

#line default
#line hidden
            EndContext();
            BeginContext(335, 20, true);
            WriteLiteral("\r\n    Фамилия:\r\n    ");
            EndContext();
            BeginContext(356, 12, false);
#line 15 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
Write(form.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(368, 21, true);
            WriteLiteral("\r\n    Отчество:\r\n    ");
            EndContext();
            BeginContext(390, 15, false);
#line 17 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
Write(form.Patronymic);

#line default
#line hidden
            EndContext();
            BeginContext(405, 34, true);
            WriteLiteral("\r\n    Контактная информация:\r\n    ");
            EndContext();
            BeginContext(440, 19, false);
#line 19 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
Write(form.ContactDetails);

#line default
#line hidden
            EndContext();
            BeginContext(459, 16, true);
            WriteLiteral("\r\n    Тип:\r\n    ");
            EndContext();
            BeginContext(476, 19, false);
#line 21 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
Write(form.InstrumentType);

#line default
#line hidden
            EndContext();
            BeginContext(495, 17, true);
            WriteLiteral("\r\n    Дата:\r\n    ");
            EndContext();
            BeginContext(513, 11, false);
#line 23 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
Write(form.Create);

#line default
#line hidden
            EndContext();
            BeginContext(524, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(588, 10, true);
            WriteLiteral("\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 598, "\"", 621, 2);
            WriteAttributeValue("", 604, "Image?id=", 604, 9, true);
#line 27 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
WriteAttributeValue("", 613, form.Id, 613, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(622, 268, true);
            WriteLiteral(@" />

    <table class=""table table-bordered table-responsive table-hover"">
        <thead>
            <tr>
                <td>Id</td>
                <td>Модель инструмента</td>
                <td>Описание проблемы</td>
            </tr>
        </thead>
");
            EndContext();
#line 37 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
         if (form.Description != null)
        {
            foreach (var sm in form.Description)
            {

#line default
#line hidden
            BeginContext(1006, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1053, 5, false);
#line 42 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
                   Write(sm.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1058, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1090, 20, false);
#line 43 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
                   Write(sm.ModelOfInstrument);

#line default
#line hidden
            EndContext();
            BeginContext(1110, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1142, 18, false);
#line 44 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
                   Write(sm.FullDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1160, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1216, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
            EndContext();
#line 50 "C:\Users\Home\source\repos\Git\NewCenter\WebMusicCenter\Views\Upload\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<WebMusicCenter.Models.DataAccessPostgreSqlProvider.DbCompletingForm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
