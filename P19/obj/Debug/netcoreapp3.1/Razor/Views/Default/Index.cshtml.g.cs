#pragma checksum "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc9857c8bb1927e54c4283a5f0f81c2f908cb00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
#line 19 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
using P19;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc9857c8bb1927e54c4283a5f0f81c2f908cb00", @"/Views/Default/Index.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9857c8bb1927e54c4283a5f0f81c2f908cb002889", async() => {
                WriteLiteral("\r\n    <title>Телефонная книжка</title>\r\n    <style>\r\n        table, td {\r\n            border: 1px solid black;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc9857c8bb1927e54c4283a5f0f81c2f908cb004002", async() => {
                WriteLiteral("\r\n    <table border=\"1\">\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Фамилию</th>\r\n            <th>Имя</th>\r\n            <th>Отчество</th>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
          
            var book = new Book();
            var num = book.GetNumbers();
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
         foreach (var i in num)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td onclick=\"myFunction(this\"");
                BeginWriteAttribute("id", " id=\"", 617, "\"", 624, 1);
#nullable restore
#line 28 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
WriteAttributeValue("", 622, i, 622, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
                                                 Write(i.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
               Write(i.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
               Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
               Write(i.Name2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
#nullable restore
#line 35 "C:\Users\М\source\repos\P19\P19\Views\Default\Index.cshtml"
       int f;

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script>\r\n        function myFunction(x) {\r\n            var g = int.Parse(x.innerText)\r\n            var i = book.GetNumber(int.Parse(x.innerText))\r\n            alert(\"Row index is: \" + x.innerText)\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
