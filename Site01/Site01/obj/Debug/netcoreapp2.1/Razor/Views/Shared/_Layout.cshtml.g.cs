#pragma checksum "C:\Users\joedenascimento\source\repos\Site01\Site01\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f77602af8c3569a156ce7d0cdcacd2136d87301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\joedenascimento\source\repos\Site01\Site01\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f77602af8c3569a156ce7d0cdcacd2136d87301", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\joedenascimento\source\repos\Site01\Site01\Views\Shared\_Layout.cshtml"
   
    string Login = Context.Session.GetString("Login");

#line default
#line hidden
            BeginContext(99, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(107, 267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f5045fabcb4b9198311d8f92cc3c20", async() => {
                BeginContext(113, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(127, 13, false);
#line 7 "C:\Users\joedenascimento\source\repos\Site01\Site01\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(140, 227, true);
                WriteLiteral("</title>\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\" integrity=\"sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh\" crossorigin=\"anonymous\">\r\n");
                EndContext();
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
            EndContext();
            BeginContext(374, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(376, 2085, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406f80bebcfd40dc993ac2a1ac0da640", async() => {
                BeginContext(382, 764, true);
                WriteLiteral(@"
        <header>
            <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                <a class=""navbar-brand"" href=""/"">Banco de Palavras</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>

                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav mr-auto"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""/"">Inicio</a>
                        </li>
");
                EndContext();
#line 23 "C:\Users\joedenascimento\source\repos\Site01\Site01\Views\Shared\_Layout.cshtml"
                         if(Login != null)
                        {

#line default
#line hidden
                BeginContext(1217, 352, true);
                WriteLiteral(@"                            <li class=""nav-item active"">
                                <a class=""nav-link"" href=""/palavra"">Palavras</a>
                            </li>
                            <li class=""nav-item active"">
                                <a class=""nav-link"" href=""/home/logout"">Logout</a>
                            </li>
");
                EndContext();
#line 31 "C:\Users\joedenascimento\source\repos\Site01\Site01\Views\Shared\_Layout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1653, 175, true);
                WriteLiteral("                            <li class=\"nav-item active\">\r\n                                <a class=\"nav-link\" href=\"/home/login\">Login</a>\r\n                            </li>\r\n");
                EndContext();
#line 37 "C:\Users\joedenascimento\source\repos\Site01\Site01\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
                BeginContext(1855, 318, true);
                WriteLiteral(@"

                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/contato"">Contato</a>
                        </li>

                    </ul>
                </div>
            </nav>
        </header>

    <div class=""container"">
       
        <div>
            ");
                EndContext();
                BeginContext(2174, 12, false);
#line 52 "C:\Users\joedenascimento\source\repos\Site01\Site01\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2186, 171, true);
                WriteLiteral("\r\n        </div>\r\n        <footer>\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12\">\r\n                    Todos os direitos reservados &copy; 2010 - ");
                EndContext();
                BeginContext(2358, 17, false);
#line 57 "C:\Users\joedenascimento\source\repos\Site01\Site01\Views\Shared\_Layout.cshtml"
                                                          Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(2375, 79, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </footer>\r\n\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2461, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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