#pragma checksum "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aff1fac568bbfd16af27eac6573134e5abab3f86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_CountryDetails), @"mvc.1.0.view", @"/Views/Countries/CountryDetails.cshtml")]
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
#line 1 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\_ViewImports.cshtml"
using CountriesWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\_ViewImports.cshtml"
using CountriesWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff1fac568bbfd16af27eac6573134e5abab3f86", @"/Views/Countries/CountryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"603b01e09a171025f0d2bee0f19c2d74d5b4b8f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Countries_CountryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Country>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CountryDescription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Countries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml"
  
    ViewData["Title"] = "Country Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml"
Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 5 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml"
               Write(ViewBag.cName);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
            WriteLiteral("<h3>");
#nullable restore
#line 8 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml"
Write(ViewBag.cName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p><b>Language:</b> ");
#nullable restore
#line 9 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml"
               Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><b>Greeting:</b> ");
#nullable restore
#line 10 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml"
               Write(Model.Greeting);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>\r\n    <b>National Colors:</b>\r\n    <ul>\r\n");
#nullable restore
#line 14 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml"
         foreach (var color in Model.NationalColors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 16 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml"
           Write(color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\jenif\source\repos\CountriesWebApp\CountriesWebApp\Views\Countries\CountryDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff1fac568bbfd16af27eac6573134e5abab3f866161", async() => {
                WriteLiteral("\r\n    <button>Learn more about this country</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Country> Html { get; private set; }
    }
}
#pragma warning restore 1591
