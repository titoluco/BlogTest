#pragma checksum "C:\Users\logonrmlocal\Downloads\New folder\BlogTest\Blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eba7c6468dd6fbf54fc29135cb4b55a34a4a6875"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\logonrmlocal\Downloads\New folder\BlogTest\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#line 2 "C:\Users\logonrmlocal\Downloads\New folder\BlogTest\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eba7c6468dd6fbf54fc29135cb4b55a34a4a6875", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(1238, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 49 "C:\Users\logonrmlocal\Downloads\New folder\BlogTest\Blog\Views\Home\Index.cshtml"
  
        ViewData["Title"] = "Home Page";
    

#line default
#line hidden
            BeginContext(1295, 1559, true);
            WriteLiteral(@"
    <div class=""text-center"" id=""blog-title"">
        <h1 class=""display-4"">MBC - Meu Bloguinho Camarada</h1>
        <p>study and share, a learning philosophy</p>
    </div>

    <div class=""alert alert-info show"" id=""connection-status""></div>

    <div class=""blog-list card-columns"" id=""blog-list"">
    </div>

    <div class=""center"">
        <button class=""btn btn-primary"" onclick=""pageEvents.loadMoreBlogPosts();"">ver mais</button>
        <br /><br />
    </div>

    <div id=""blog-item-container""></div>

    <script id=""blog-card"" type=""text/template"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">{{PostId}} - {{Title}}</h5>
                <p class=""card-text"">{{ShortDescription}}</p>
                <button onclick=""pageEvents.loadBlogPost('{{Link}}');"" class=""btn btn-primary"">ir</button>
            </div>
        </div>
    </script>
    <script id=""blog-item"" type=""text/template"">
        <div id=""{{Link}}"" class=""bl");
            WriteLiteral(@"og-item"">
            {{Content}}
        </div>
        <a href=""#blog-title"" class=""btn btn-primary"">voltar</a>
    </script>

    <script id=""blog-content-not-found"" type=""text/template"">
        <h1>
            Ups, artigo não está no Cache!
        </h1>
        <div>
            Você quer que a gente continue tentando fazer download do artigo
            em plano de fundo e te avise quando estiver disponível?
        </div>
        <br />
        <button class=""btn btn-success"">Sim!</button>
    </script>
");
            EndContext();
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
