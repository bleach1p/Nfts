#pragma checksum "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dec9f8cd513a567dedb31cf6561ba870bc5fcf29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Nfts), @"mvc.1.0.view", @"/Views/Home/Nfts.cshtml")]
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
#line 1 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\_ViewImports.cshtml"
using Nfts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\_ViewImports.cshtml"
using Nfts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec9f8cd513a567dedb31cf6561ba870bc5fcf29", @"/Views/Home/Nfts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e296bd058d5a93e1d8c26eb96662347a7844a391", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Nfts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Nfts.RetornoNfts>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
  
    ViewData["Title"] = "Itens";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dec9f8cd513a567dedb31cf6561ba870bc5fcf293559", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Dono da conta
            </th>
            <th>
                Conta
            </th>
            <th>
                Nome
            </th>
            <th>
                Raridade
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
         foreach (var item in Model.InfosGerais.Where(x => x.DonoConta == "Johann").ToList())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
           Write(Html.DisplayFor(modelItem => item.DonoConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
               Write(Html.DisplayFor(modelItem => item.Conta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item.Rarity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Dono da conta
            </th>
            <th>
                Conta
            </th>
            <th>
                Nome
            </th>
            <th>
                Raridade
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 68 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
         foreach (var item in Model.InfosGerais.Where(x => x.DonoConta == "Felipe").ToList())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
               Write(Html.DisplayFor(modelItem => item.DonoConta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
               Write(Html.DisplayFor(modelItem => item.Conta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item.Rarity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 84 "C:\Users\jojoh\source\repos\Nfts\Nfts\Views\Home\Nfts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Nfts.RetornoNfts> Html { get; private set; }
    }
}
#pragma warning restore 1591
