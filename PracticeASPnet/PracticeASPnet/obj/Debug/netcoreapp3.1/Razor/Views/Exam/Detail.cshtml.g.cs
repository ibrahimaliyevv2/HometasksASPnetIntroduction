#pragma checksum "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce0dea91cdea279cd3d772a9c89a8b55dd06d9fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_Detail), @"mvc.1.0.view", @"/Views/Exam/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0dea91cdea279cd3d772a9c89a8b55dd06d9fc", @"/Views/Exam/Detail.cshtml")]
    #nullable restore
    public class Views_Exam_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
#nullable restore
#line 1 "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml"
  
    int examPoint = 88;
    int[] points = { 1, 2, 3, 4, 5 };

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce0dea91cdea279cd3d772a9c89a8b55dd06d9fc3007", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce0dea91cdea279cd3d772a9c89a8b55dd06d9fc4376", async() => {
                WriteLiteral(@"

    <div class=""container"">
        <nav class=""navbar navbar-light bg-light"">
            <div class=""container-fluid"">
                <a class=""navbar-brand"">Navbar</a>
                <form class=""d-flex"">
                    <input class=""form-control me-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                    <button class=""btn btn-outline-success"" type=""submit"">Search</button>
                    <div class=""wish-box"">
                        <span id=""wishCount"">0</span>
                        <i class=""fa-solid fa-heart float-end"" style=""cursor: pointer;""></i>
                    </div>
                </form>
            </div>
        </nav>
    </div>
    <div class=""container"">
        <div class=""row"" id=""items"">
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <h1>Detail page   - ");
#nullable restore
#line 37 "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml"
                               Write(TempData["ExamId"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n                <h1>Detail page   - ");
#nullable restore
#line 38 "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml"
                               Write(ViewData["ExamId"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n                <h1>Detail page   - ");
#nullable restore
#line 39 "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml"
                               Write(ViewBag.ExamId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n                <h3>Exam Students   - ");
#nullable restore
#line 40 "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml"
                                 Write(ViewBag.StudentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                <h3>Exam point   - ");
#nullable restore
#line 41 "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml"
                              Write(examPoint);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n\n                <ul>\n");
#nullable restore
#line 44 "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml"
                     for (int i = 0; i < points.Length; i++)
                    {
                        points[i] += 10;

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\n                            ");
#nullable restore
#line 48 "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml"
                       Write(points[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </li>\n");
#nullable restore
#line 50 "/Users/ibrahimaliyevv/Desktop/HometasksASPnetIntroduction/PracticeASPnet/PracticeASPnet/Views/Exam/Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\n\n\n\n            </div>\n        </div>\n    </div>\n\n\n");
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
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
