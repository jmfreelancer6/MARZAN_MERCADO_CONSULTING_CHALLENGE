#pragma checksum "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43b49e3507b324914b99c41db2c44d04a3a708b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Details), @"mvc.1.0.view", @"/Views/Clientes/Details.cshtml")]
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
#line 1 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\_ViewImports.cshtml"
using TestCode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\_ViewImports.cshtml"
using TestCode.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43b49e3507b324914b99c41db2c44d04a3a708b", @"/Views/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1679f3caf49b4ac1f30cb593dfe4e68b887a43ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Core.Models.ClientesDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
  
    ViewData["Title"] = "Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-xl px-4 mt-4"">
    <h1>Cliente</h1>
    <hr class=""mt-0 mb-4"">
    <div class=""row"">
        <div class=""col-xl-12"">
            <!-- Account details card-->
            <div class=""card mb-4"">
                <div class=""card-header"">Cliente # ");
#nullable restore
#line 14 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.No_Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43b49e3507b324914b99c41db2c44d04a3a708b5588", async() => {
                WriteLiteral("\r\n                        <!-- Form Group (username)-->\r\n                        <div class=\"mb-3\">\r\n                            <label class=\"small mb-1\">");
#nullable restore
#line 19 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
                                                 Write(Html.DisplayNameFor(model => model.No_Cliente));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                            <input class=\"form-control\"");
                BeginWriteAttribute("value", "  value=\"", 745, "\"", 797, 1);
#nullable restore
#line 20 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
WriteAttributeValue("", 754, Html.DisplayFor(model => model.No_Cliente), 754, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                        </div>
                        <!-- Form Row-->
                        <div class=""row gx-3 mb-3"">
                            <!-- Form Group (first name)-->
                            <div class=""col-md-6"">
                                <label class=""small mb-1"">");
#nullable restore
#line 26 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1220, "\"", 1267, 1);
#nullable restore
#line 27 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
WriteAttributeValue("", 1228, Html.DisplayFor(model => model.Nombre), 1228, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                            </div>\r\n                            <!-- Form Group (last name)-->\r\n                            <div class=\"col-md-6\">\r\n                                <label class=\"small mb-1\">");
#nullable restore
#line 31 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1600, "\"", 1649, 1);
#nullable restore
#line 32 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
WriteAttributeValue("", 1608, Html.DisplayFor(model => model.Apellido), 1608, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                            </div>
                        </div>
                        <!-- Form Row        -->
                        <div class=""row gx-3 mb-3"">
                            <!-- Form Group (organization name)-->
                            <div class=""col-md-6"">
                                <label class=""small mb-1"">");
#nullable restore
#line 39 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2125, "\"", 2174, 1);
#nullable restore
#line 40 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
WriteAttributeValue("", 2133, Html.DisplayFor(model => model.Telefono), 2133, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                            </div>\r\n                        </div>\r\n                        <!-- Form Group (email address)-->\r\n                        <div class=\"mb-3\">\r\n                            <label class=\"small mb-1\"> ");
#nullable restore
#line 45 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                            <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2525, "\"", 2575, 1);
#nullable restore
#line 46 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
WriteAttributeValue("", 2533, Html.DisplayFor(model => model.Direccion), 2533, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-sm-10\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43b49e3507b324914b99c41db2c44d04a3a708b11263", async() => {
                    WriteLiteral("Editar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Joskin Villaman\Desktop\TestCode\TestCode\Views\Clientes\Details.cshtml"
                                                       WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-sm-2\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43b49e3507b324914b99c41db2c44d04a3a708b13740", async() => {
                    WriteLiteral("Regresar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Core.Models.ClientesDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591