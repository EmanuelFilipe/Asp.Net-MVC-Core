#pragma checksum "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7a7137505e057720373ff349f3b6d23951ecc8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos__DetalharProduto), @"mvc.1.0.view", @"/Views/Produtos/_DetalharProduto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/_DetalharProduto.cshtml", typeof(AspNetCore.Views_Produtos__DetalharProduto))]
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
#line 1 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7a7137505e057720373ff349f3b6d23951ecc8f", @"/Views/Produtos/_DetalharProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b042e5fc3232b5e5435141a47b6f7f1bfc6439c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos__DetalharProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 250px; margin-top: 7px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
  
    ViewData["Title"] = "Detalhe do Produto - " + Model.Nome;

#line default
#line hidden
            BeginContext(116, 58, true);
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    <h4 class=\"modal-title\">");
            EndContext();
            BeginContext(175, 17, false);
#line 7 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(192, 173, true);
            WriteLiteral("</h4>\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\">\r\n        <span aria-hidden=\"true\">x</span><span class=\"sr-only\">Fechar</span>\r\n    </button>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(365, 2175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7a7137505e057720373ff349f3b6d23951ecc8f5373", async() => {
                BeginContext(392, 40, true);
                WriteLiteral("\r\n    <div class=\"modal-body\">\r\n        ");
                EndContext();
                BeginContext(432, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7a7137505e057720373ff349f3b6d23951ecc8f5797", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 15 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(468, 83, true);
                WriteLiteral("\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                ");
                EndContext();
                BeginContext(551, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7a7137505e057720373ff349f3b6d23951ecc8f7714", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 561, "~/imagens/", 561, 10, true);
#line 19 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
AddHtmlAttributeValue("", 571, Model.Imagem, 571, 13, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
AddHtmlAttributeValue("", 591, Model.Imagem, 591, 13, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(647, 130, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <dl>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(778, 48, false);
#line 24 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayNameFor(model => model.FornecedorId));

#line default
#line hidden
                EndContext();
                BeginContext(826, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(906, 47, false);
#line 27 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayFor(model => model.Fornecedor.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(953, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1033, 40, false);
#line 30 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1073, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1153, 36, false);
#line 33 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1189, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1269, 45, false);
#line 36 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
                EndContext();
                BeginContext(1314, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1394, 41, false);
#line 39 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
                EndContext();
                BeginContext(1435, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1515, 41, false);
#line 42 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
                EndContext();
                BeginContext(1556, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1636, 25, false);
#line 45 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Model.Valor.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(1661, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1741, 48, false);
#line 48 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
                EndContext();
                BeginContext(1789, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1869, 44, false);
#line 51 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
                EndContext();
                BeginContext(1913, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1993, 41, false);
#line 54 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
                EndContext();
                BeginContext(2034, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(2114, 37, false);
#line 57 "C:\Users\emanuelfilipe\Desktop\projeto\src\DevIO.App\Views\Produtos\_DetalharProduto.cshtml"
                   Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
                EndContext();
                BeginContext(2151, 382, true);
                WriteLiteral(@"
                    </dd>
                </dl>
            </div>
        </div>

        <div class=""modal-footer"">
            <div class=""col-md-6""></div>
            <div class=""col-md-6 text-right"">
                <input type=""button"" name=""Fechar"" value=""Fechar"" class=""btn btn-secondary"" data-dismiss=""modal"" />
            </div>
        </div>

    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591