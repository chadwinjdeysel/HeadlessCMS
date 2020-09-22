#pragma checksum "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c5eb1efe0397ccfbaaad077b3ca2ae4310d1cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Add), @"mvc.1.0.view", @"/Views/Content/Add.cshtml")]
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
#line 1 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\_ViewImports.cshtml"
using ContentManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\_ViewImports.cshtml"
using ContentManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\_ViewImports.cshtml"
using ContentManagementSystem.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5eb1efe0397ccfbaaad077b3ca2ae4310d1cea", @"/Views/Content/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ffe7be2330505309634ebefe745b3ab2de9c32", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Field>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"display-4\">Add Content</h1>\r\n<p>edit your content as you wish</p>\r\n\r\n<div class=\"d-flex justify-content-center\">\r\n\r\n    <div class=\"col-8\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c5eb1efe0397ccfbaaad077b3ca2ae4310d1cea4616", async() => {
                WriteLiteral("\r\n\r\n            <input hidden\r\n                   name=\"ModelId\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 352, "\"", 411, 1);
#nullable restore
#line 16 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
WriteAttributeValue("", 380, ViewData["ModelId"].ToString(), 380, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n");
#nullable restore
#line 18 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
             foreach (var item in Model)
            {

                if (item.fieldType == FieldType.ShortText)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 24 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <input class=\"form-control\"\r\n                               type=\"text\"");
                BeginWriteAttribute("name", "\r\n                               name=\"", 749, "\"", 796, 1);
#nullable restore
#line 27 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
WriteAttributeValue("", 788, item.Id, 788, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n");
#nullable restore
#line 29 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
                }

                if (item.fieldType == FieldType.LongText)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 34 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <textarea class=\"form-control\"\r\n                                  maxlength=\"5000\"");
                BeginWriteAttribute("name", "\r\n                                  name=\"", 1132, "\"", 1182, 1);
#nullable restore
#line 37 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
WriteAttributeValue("", 1174, item.Id, 1174, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </textarea>\r\n                    </div>\r\n");
#nullable restore
#line 40 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
                }

                if (item.fieldType == FieldType.Number)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <label>");
#nullable restore
#line 45 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <input class=\"form-control\"\r\n                               type=\"number\"");
                BeginWriteAttribute("name", "\r\n                               name=\"", 1534, "\"", 1581, 1);
#nullable restore
#line 48 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
WriteAttributeValue("", 1573, item.Id, 1573, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n");
#nullable restore
#line 50 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
                }

                if (item.fieldType == FieldType.File)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n\r\n                        <label>");
#nullable restore
#line 56 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <div class=\"custom-file\">\r\n                            <input type=\"file\"\r\n                                class=\"custom-file-input\"");
                BeginWriteAttribute("name", "\r\n                                name=\"", 1965, "\"", 2013, 1);
#nullable restore
#line 60 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
WriteAttributeValue("", 2005, item.Id, 2005, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <label class=\"custom-file-label\" for=\"customFile\">Choose file</label>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 64 "C:\Projects\ContentManagementSystem\contentmanagementsystem\Views\Content\Add.cshtml"
                    
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <button class=\"btn btn-primary btn-block my-4\">\r\n                Add\r\n            </button>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        // Add the following code if you want the name of the file appear on select
        $("".custom-file-input"").on(""change"", function() {
            var fileName = $(this).val().split(""\\"").pop();
             $(this).siblings("".custom-file-label"").addClass(""selected"").html(fileName);
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Field>> Html { get; private set; }
    }
}
#pragma warning restore 1591
