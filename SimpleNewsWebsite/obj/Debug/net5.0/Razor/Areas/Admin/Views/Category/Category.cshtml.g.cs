#pragma checksum "D:\HK2.2022\net\03032022\SimpleNewsWebsite\SimpleNewsWebsite\Areas\Admin\Views\Category\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b8d4140f72fa61eef21945577947731e04a5cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Category), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8d4140f72fa61eef21945577947731e04a5cbf", @"/Areas/Admin/Views/Category/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/category.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\HK2.2022\net\03032022\SimpleNewsWebsite\SimpleNewsWebsite\Areas\Admin\Views\Category\Category.cshtml"
  
    ViewBag.Title = "Trang category";
    ViewBag.TextLogin = "Admin đang đăng nhập";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <p>\r\n        Trang category nè\r\n    </p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b8d4140f72fa61eef21945577947731e04a5cbf5071", async() => {
                WriteLiteral("\r\n        <div class=\"mb-4\">\r\n            <input name=\"catName\" type=\"text\" id=\"catName\" placeholder=\"Nhập tên danh mục\">\r\n            &nbsp;<input class=\"form-check-input\" type=\"checkbox\" name=\"catStatus\"");
                BeginWriteAttribute("value", " value=\"", 546, "\"", 554, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"catStatus\">&nbsp;<span id=\"hienThi\">Hiển thị</span>\r\n            &nbsp;<button type=\"submit\" class=\"btn btn-primary\">Thêm/cập nhật</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h4>Danh sách danh mục</h4>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b8d4140f72fa61eef21945577947731e04a5cbf7500", async() => {
                WriteLiteral("\r\n        <div class=\"mb-3\">\r\n            <input name=\"query\" type=\"text\" id=\"query\" placeholder=\"Từ khóa\">\r\n            &nbsp;<button type=\"submit\" class=\"btn btn-primary\">Tìm</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <br />
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Tên danh mục</th>
                <th scope=""col"">Trạng thái</th>
                <th scope=""col"">Chức năng</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope=""row"">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td>mdo</td>
            </tr>
            <tr>
                <th scope=""row"">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>fat</td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td colspan=""2"">Larry the Bird</td>
                <td>twitter</td>
            </tr>
            <tr>
                <th scope=""row"">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td>mdo</td>
            </tr>
            <tr>
           ");
            WriteLiteral(@"     <th scope=""row"">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>fat</td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td colspan=""2"">Larry the Bird</td>
                <td>twitter</td>
            </tr>
            <tr>
                <th scope=""row"">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td>mdo</td>
            </tr>
            <tr>
                <th scope=""row"">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>fat</td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td colspan=""2"">Larry the Bird</td>
                <td>twitter</td>
            </tr>
            <tr>
                <th scope=""row"">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td>mdo</td>
            </tr>
            <tr>
                <th s");
            WriteLiteral(@"cope=""row"">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>fat</td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td colspan=""2"">Larry the Bird</td>
                <td>twitter</td>
            </tr>
            <tr>
                <th scope=""row"">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td>mdo</td>
            </tr>
            <tr>
                <th scope=""row"">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>fat</td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td colspan=""2"">Larry the Bird</td>
                <td>twitter</td>
            </tr>
            <tr>
                <th scope=""row"">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td>mdo</td>
            </tr>
            <tr>
                <th scope=""row""");
            WriteLiteral(@">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>fat</td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td colspan=""2"">Larry the Bird</td>
                <td>twitter</td>
            </tr>
            <tr>
                <th scope=""row"">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td>mdo</td>
            </tr>
            <tr>
                <th scope=""row"">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>fat</td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td colspan=""2"">Larry the Bird</td>
                <td>twitter</td>
            </tr>
        </tbody>
    </table>
</div>

");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b8d4140f72fa61eef21945577947731e04a5cbf13725", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
