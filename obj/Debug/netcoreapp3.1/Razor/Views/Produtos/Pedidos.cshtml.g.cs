#pragma checksum "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d17eadbe3adeed154cc312a2450eb81c96295faa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Pedidos), @"mvc.1.0.view", @"/Views/Produtos/Pedidos.cshtml")]
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
#line 1 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\_ViewImports.cshtml"
using ATV4PI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\_ViewImports.cshtml"
using ATV4PI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml"
using MySqlConnector;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17eadbe3adeed154cc312a2450eb81c96295faa", @"/Views/Produtos/Pedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c09148cba5340e551710a29aee4a6d59374a75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Produtos_Pedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produtos>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml"
  
    ViewData["Title"] = "Compras";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr class=""table"">
            <th>Id</th> <br>
            <th>Valor Produto</th> <br>
            <th>Quantidade</th> <br>
            <th>Valor Total</th> <br>
            <th>Opera????es</th> 
        </tr>
    </thead>
");
#nullable restore
#line 20 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml"
     foreach (Produtos p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table\">\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml"
           Write(p.IdProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml"
           Write(p.ValorProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml"
           Write(p.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml"
           Write(p.ValorTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>\r\n              \r\n               \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Jhones\OneDrive\SENAC\ProjetoIntegrador\ATV4PI\Views\Produtos\Pedidos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produtos>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
