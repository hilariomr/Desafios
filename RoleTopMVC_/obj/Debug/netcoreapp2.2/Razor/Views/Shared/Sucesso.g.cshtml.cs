#pragma checksum "C:\Users\32727031874\Documents\RoleTopMVC_\Views\Shared\Sucesso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e4270be083112e3efc6ae39853c11c0d9cc532d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Sucesso), @"mvc.1.0.view", @"/Views/Shared/Sucesso.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Sucesso.cshtml", typeof(AspNetCore.Views_Shared_Sucesso))]
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
#line 1 "C:\Users\32727031874\Documents\RoleTopMVC_\Views\_ViewImports.cshtml"
using RoleTopMVC_;

#line default
#line hidden
#line 2 "C:\Users\32727031874\Documents\RoleTopMVC_\Views\_ViewImports.cshtml"
using RoleTopMVC_.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4270be083112e3efc6ae39853c11c0d9cc532d", @"/Views/Shared/Sucesso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"809ed92997f0cf6c24deb3b87cfd3ff24603c442", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Sucesso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<main> \r\n    <h2>\r\n        ");
            EndContext();
            BeginContext(28, 14, false);
#line 3 "C:\Users\32727031874\Documents\RoleTopMVC_\Views\Shared\Sucesso.cshtml"
   Write(Model.NomeView);

#line default
#line hidden
            EndContext();
            BeginContext(42, 41, true);
            WriteLiteral(" Concluido!\r\n    </h2>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(84, 14, false);
#line 6 "C:\Users\32727031874\Documents\RoleTopMVC_\Views\Shared\Sucesso.cshtml"
   Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(98, 19, true);
            WriteLiteral("\r\n    </p>\r\n</main>");
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
