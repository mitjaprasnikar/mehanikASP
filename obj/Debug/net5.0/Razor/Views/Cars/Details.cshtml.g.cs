#pragma checksum "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dfc00ab8989b6d65d8df91e0f4fde966b0b9bdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Details), @"mvc.1.0.view", @"/Views/Cars/Details.cshtml")]
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
#line 1 "D:\Projekti\MehanikASP\Views\_ViewImports.cshtml"
using MehanikASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projekti\MehanikASP\Views\_ViewImports.cshtml"
using MehanikASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dfc00ab8989b6d65d8df91e0f4fde966b0b9bdf", @"/Views/Cars/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e5cc77b3c80fe00954909e0b1878a5bcfdfb6df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cars_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MehanikASP.Models.Car>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddServiceToCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:red;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
  
    ViewData["Title"] = "O vozilu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h3>");
#nullable restore
#line 11 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
   Write(Html.DisplayFor(model => model.Znamka));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 11 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
                                             Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h5><a");
            BeginWriteAttribute("href", " href=\"", 196, "\"", 238, 2);
            WriteAttributeValue("", 203, "/Customers/Details/", 203, 19, true);
#nullable restore
#line 12 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
WriteAttributeValue("", 222, Model.StrankaId, 222, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Stranka.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
                                                                                                Write(Html.DisplayFor(model => model.Stranka.Naslov));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
                                                                                                                                                  Write(Html.DisplayFor(model => model.Stranka.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n    \r\n    \r\n    \r\n    <hr />\r\n\r\n    \r\n\r\n    <dl class=\"row\" style=\"float:left; width:50%;\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Znamka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Znamka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Letnik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Letnik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.VIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.kW));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.kW));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipMotorja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipMotorja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RegOzn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.RegOzn));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
        
    </dl>


    <table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">Datum</th>
      <th scope=""col"">Kilometri</th>
      <th scope=""col"">Oljni Filter</th>
      <th scope=""col"">Zračni Filter</th>
      <th scope=""col"">Filter Goriva</th>
      <th scope=""col"">Filter Kabine</th>
      <th scope=""col"">Opombe</th>
    </tr>
  </thead>
  

");
#nullable restore
#line 81 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
         foreach (var item in Model.Servisi)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr>\r\n      <th scope=\"row\"><a");
            BeginWriteAttribute("href", " href=\"", 2430, "\"", 2463, 2);
            WriteAttributeValue("", 2437, "/Services/Details/", 2437, 18, true);
#nullable restore
#line 85 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
WriteAttributeValue("", 2455, item.Id, 2455, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">  ");
#nullable restore
#line 85 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
                                                        Write(Html.ValueFor(m => item.Datum,"{0:dd/MM/yyyy}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n      <td>");
#nullable restore
#line 86 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
     Write(item.Kilometri);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td> ");
#nullable restore
#line 87 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
      Write(Html.CheckBoxFor(x => item.OljniFilter,new {@disabled = "disabled"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n      <td>");
#nullable restore
#line 88 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
     Write(Html.CheckBoxFor(x => item.ZracniFilter,new {@disabled = "disabled"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n      <td>");
#nullable restore
#line 89 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
     Write(Html.CheckBoxFor(x => item.FilterGoriva,new {@disabled = "disabled"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 90 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
     Write(Html.CheckBoxFor(x => item.FilterKabine,new {@disabled = "disabled"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 91 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
     Write(item.Opombe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    \r\n  </tbody>\r\n");
#nullable restore
#line 95 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
    
        

    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n</div>\r\n\r\n<div style=\"clear:both;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dfc00ab8989b6d65d8df91e0f4fde966b0b9bdf13977", async() => {
                WriteLiteral("Dodaj Servis");
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
#line 105 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dfc00ab8989b6d65d8df91e0f4fde966b0b9bdf16109", async() => {
                WriteLiteral("Uredi Vozilo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dfc00ab8989b6d65d8df91e0f4fde966b0b9bdf18230", async() => {
                WriteLiteral("Izbriši vozilo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "D:\Projekti\MehanikASP\Views\Cars\Details.cshtml"
                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dfc00ab8989b6d65d8df91e0f4fde966b0b9bdf20438", async() => {
                WriteLiteral("Nazaj");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MehanikASP.Models.Car> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
