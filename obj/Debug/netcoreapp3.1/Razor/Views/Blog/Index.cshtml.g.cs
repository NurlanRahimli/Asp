#pragma checksum "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9086c47d0b296c8da7c89d38c710bab537d839e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 2 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\_ViewImports.cshtml"
using Eterna_backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9086c47d0b296c8da7c89d38c710bab537d839e", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33f1c1f780b4c8bedb65b4d204e13fdebe4cd5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Box>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <ol>
                <li><a href=""index.html"">Home</a></li>
                <li>Blog</li>
            </ol>
            <h2>Blog</h2>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Blog Section ======= -->
    <section id=""blog"" class=""blog"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""row"">

                <div class=""col-lg-8 entries"">

");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                     foreach (Box item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <article class=\"entry\">\r\n\r\n                            <div class=\"entry-img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a9086c47d0b296c8da7c89d38c710bab537d839e5245", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 815, "~/img/blog/", 815, 11, true);
#nullable restore
#line 30 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 826, item.Image, 826, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <h2 class=\"entry-title\">\r\n                                <a href=\"blog-single.html\">");
#nullable restore
#line 34 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </h2>

                            <div class=""entry-meta"">
                                <ul>
                                    <li class=""d-flex align-items-center""><i class=""bi bi-person""></i> <a href=""blog-single.html"">");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                                                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                                                                                                                                        Write(item.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li class=\"d-flex align-items-center\"><i class=\"bi bi-clock\"></i> <a href=\"blog-single.html\"><time datetime=\"2020-01-01\">");
#nullable restore
#line 40 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                                                                                                                                                        Write(item.Date.ToString("MMM d, yyyy "));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</time></a></li>
                                    <li class=""d-flex align-items-center""><i class=""bi bi-chat-dots""></i> <a href=""blog-single.html"">12 Comments</a></li>
                                </ul>
                            </div>

                            <div class=""entry-content"">
                                <p>
                                    ");
#nullable restore
#line 47 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                                <div class=""read-more"">
                                    <a href=""blog-single.html"">Read More</a>
                                </div>
                            </div>

                        </article><!-- End blog entry -->
");
#nullable restore
#line 55 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                    <div class=""blog-pagination"">
                        <ul class=""justify-content-center"">
                            <li><a href=""#"">1</a></li>
                            <li class=""active""><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                        </ul>
                    </div>

                </div><!-- End blog entries list -->

                <div class=""col-lg-4"">

                    <div class=""sidebar"">

                        <h3 class=""sidebar-title"">Search</h3>
                        <div class=""sidebar-item search-form"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9086c47d0b296c8da7c89d38c710bab537d839e10716", async() => {
                WriteLiteral("\r\n                                <input type=\"text\">\r\n                                <button type=\"submit\"><i class=\"bi bi-search\"></i></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div><!-- End sidebar search formn-->

                        <h3 class=""sidebar-title"">Categories</h3>
                        <div class=""sidebar-item categories"">
                            <ul>
                                <li><a href=""#"">General <span>(25)</span></a></li>
                                <li><a href=""#"">Lifestyle <span>(12)</span></a></li>
                                <li><a href=""#"">Travel <span>(5)</span></a></li>
                                <li><a href=""#"">Design <span>(22)</span></a></li>
                                <li><a href=""#"">Creative <span>(8)</span></a></li>
                                <li><a href=""#"">Educaion <span>(14)</span></a></li>
                            </ul>
                        </div><!-- End sidebar categories-->

                        <h3 class=""sidebar-title"">Recent Posts</h3>
                        <div class=""sidebar-item recent-posts"">
");
#nullable restore
#line 95 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                             foreach (Post item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"post-item clearfix\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a9086c47d0b296c8da7c89d38c710bab537d839e13592", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4282, "~/img/blog/", 4282, 11, true);
#nullable restore
#line 98 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 4293, item.Image, 4293, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <h4><a href=\"blog-single.html\">");
#nullable restore
#line 99 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <time datetime=\"2020-01-01\">Jan 1, 2020 ");
#nullable restore
#line 100 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                                                                       Write(item.Date.ToString("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n                                </div>\r\n");
#nullable restore
#line 102 "C:\Users\Lenovo\source\repos\Eterna-backend\Eterna-backend\Views\Blog\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div><!-- End sidebar recent posts-->

                        <h3 class=""sidebar-title"">Tags</h3>
                        <div class=""sidebar-item tags"">
                            <ul>
                                <li><a href=""#"">App</a></li>
                                <li><a href=""#"">IT</a></li>
                                <li><a href=""#"">Business</a></li>
                                <li><a href=""#"">Mac</a></li>
                                <li><a href=""#"">Design</a></li>
                                <li><a href=""#"">Office</a></li>
                                <li><a href=""#"">Creative</a></li>
                                <li><a href=""#"">Studio</a></li>
                                <li><a href=""#"">Smart</a></li>
                                <li><a href=""#"">Tips</a></li>
                                <li><a href=""#"">Marketing</a></li>
                            </ul>
                        </div><!-- End sidebar tags-->

  ");
            WriteLiteral("                  </div><!-- End sidebar -->\r\n\r\n                </div><!-- End blog sidebar -->\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </section><!-- End Blog Section -->\r\n\r\n</main><!-- End #main -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Box>> Html { get; private set; }
    }
}
#pragma warning restore 1591
