#pragma checksum "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\Admin\ListaCategorias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a93b568d2d99fad130204a4d9b2f5a884846435"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListaCategorias), @"mvc.1.0.view", @"/Views/Admin/ListaCategorias.cshtml")]
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
#line 1 "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\_ViewImports.cshtml"
using PROJETO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\_ViewImports.cshtml"
using PROJETO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a93b568d2d99fad130204a4d9b2f5a884846435", @"/Views/Admin/ListaCategorias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"151b1ad9ed162840df1a79d7172f2d41d72dd26e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListaCategorias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PROJETO.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovaCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\Admin\ListaCategorias.cshtml"
  
    Layout = "_NovoLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Categorias - Admin</h1>
<hr/>

<script>
    $(document).ready( function () {
    $('#categorias').DataTable();
} );
</script>

<table id=""categorias"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Imagem da Categoria</th>
            <th>Nome da Categoria</th>
            <th>A????es poss??veis</th>
        </tr>
    </thead>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a93b568d2d99fad130204a4d9b2f5a8848464355340", async() => {
                WriteLiteral("\r\n    <tbody>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a93b568d2d99fad130204a4d9b2f5a8848464355621", async() => {
                    WriteLiteral("Adicionar Categoria");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<p></p>\r\n");
#nullable restore
#line 25 "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\Admin\ListaCategorias.cshtml"
         foreach (var categoria in Model)
        {
            var imagemPath = "~/Imagens/" + (categoria.NomeCategoria + ".jpg");

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td width=\"200\" >");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3a93b568d2d99fad130204a4d9b2f5a8848464357563", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\Admin\ListaCategorias.cshtml"
                               WriteLiteral(imagemPath);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 29 "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\Admin\ListaCategorias.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                <td>\r\n                Categoria: ");
#nullable restore
#line 31 "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\Admin\ListaCategorias.cshtml"
                      Write(categoria.NomeCategoria);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-success\"");
                BeginWriteAttribute("href", " href=\"", 1029, "\"", 1072, 2);
                WriteAttributeValue("", 1036, "/Admin/EditarCategoria/", 1036, 23, true);
#nullable restore
#line 34 "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\Admin\ListaCategorias.cshtml"
WriteAttributeValue("", 1059, categoria.Id, 1059, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Editar Nome</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\anam\OneDrive - GFT Technologies SE\Desktop\PROJETO\Views\Admin\ListaCategorias.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n    ");
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
            WriteLiteral("\r\n</table>\r\n<div><b>Obs: Ainda n??o ?? poss??vel alterar ou adicionar uma nova imagem de Categoria</b><p>\r\n    Imagens dispon??veis para Categorias: Ax??, com??dia, eletr??nica, forr??, mpb, pop, rock, samba, sertanejo. \r\n</p></div><p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PROJETO.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
