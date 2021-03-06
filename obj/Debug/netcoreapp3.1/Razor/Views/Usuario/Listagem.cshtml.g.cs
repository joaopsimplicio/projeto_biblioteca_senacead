#pragma checksum "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de1012655f9acebe42b2a846ce397b70d5e5108e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
#line 1 "C:\Users\Windows 7\Documents\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Windows 7\Documents\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de1012655f9acebe42b2a846ce397b70d5e5108e", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários cadastrados no sistema</h1>\r\n\r\n<p class=\"text-danger\"> ");
#nullable restore
#line 5 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
                   Write(ViewData["mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
         foreach (Usuario u in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 21 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
                 if (u.Tipo == Usuario.Admin) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 23 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 27 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 694, "\"", 725, 2);
            WriteAttributeValue("", 701, "/Usuario/Edicao?Id=", 701, 19, true);
#nullable restore
#line 29 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 720, u.Id, 720, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 766, "\"", 799, 2);
            WriteAttributeValue("", 773, "/Usuario/Exclusao?Id=", 773, 21, true);
#nullable restore
#line 30 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 794, u.Id, 794, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Windows 7\Documents\Biblioteca\Views\Usuario\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"/Usuario/Cadastro\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
