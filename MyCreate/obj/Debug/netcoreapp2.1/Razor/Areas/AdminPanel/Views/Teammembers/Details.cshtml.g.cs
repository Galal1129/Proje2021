#pragma checksum "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96211bf40f4f1def4a6b6bd3fc4244d28060f4e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Teammembers_Details), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Teammembers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/Teammembers/Details.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_Teammembers_Details))]
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
#line 1 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\_ViewImports.cshtml"
using MyCreate;

#line default
#line hidden
#line 2 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\_ViewImports.cshtml"
using MyCreate.model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96211bf40f4f1def4a6b6bd3fc4244d28060f4e6", @"/Areas/AdminPanel/Views/Teammembers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43e707cba6080540843c85e100f244e396a4173", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Teammembers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCreate.model.Teammember>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DetailsPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 185, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n<div class=\"au-card recent-report\">\r\n    <div>\r\n\r\n        <h4>Teammember</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(265, 40, false);
#line 15 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(305, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(361, 36, false);
#line 18 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(397, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(453, 39, false);
#line 21 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Jop));

#line default
#line hidden
            EndContext();
            BeginContext(492, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(548, 35, false);
#line 24 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Jop));

#line default
#line hidden
            EndContext();
            BeginContext(583, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(639, 41, false);
#line 27 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(680, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(736, 37, false);
#line 30 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(773, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(829, 43, false);
#line 33 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.twitter));

#line default
#line hidden
            EndContext();
            BeginContext(872, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(928, 39, false);
#line 36 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.twitter));

#line default
#line hidden
            EndContext();
            BeginContext(967, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1023, 44, false);
#line 39 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1123, 40, false);
#line 42 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1219, 45, false);
#line 45 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.instagram));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1320, 41, false);
#line 48 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.instagram));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1417, 44, false);
#line 51 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.whatsapp));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1517, 40, false);
#line 54 "C:\Users\jalla\source\repos\MyCreate - Copy\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.whatsapp));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 147, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        <div class=\"form-group row\">\r\n            <div class=\"col-5 \">\r\n                ");
            EndContext();
            BeginContext(1704, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4908a26942da4fc5a8a1e5d73efb58e9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1735, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCreate.model.Teammember> Html { get; private set; }
    }
}
#pragma warning restore 1591
