#pragma checksum "E:\ASP.NET Core\MVC\ASP.NET Core 5.0 MVC - The Beginners Guide To Becoming A Pro\InAndOut\InAndOut\Views\Expencese\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ebf1bb34ae25962d89a387e7058bd80a16fce1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expencese_Index), @"mvc.1.0.view", @"/Views/Expencese/Index.cshtml")]
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
#line 1 "E:\ASP.NET Core\MVC\ASP.NET Core 5.0 MVC - The Beginners Guide To Becoming A Pro\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP.NET Core\MVC\ASP.NET Core 5.0 MVC - The Beginners Guide To Becoming A Pro\InAndOut\InAndOut\Views\_ViewImports.cshtml"
using InAndOut.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebf1bb34ae25962d89a387e7058bd80a16fce1a", @"/Views/Expencese/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68bf42a2f6da1b0bba0ff4b16a23c8e4ecef32e", @"/Views/_ViewImports.cshtml")]
    public class Views_Expencese_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InAndOut.Models.Expencese>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expencese", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container p-3\">\r\n\r\n\t<div class=\"row pt-4 pb-4\">\r\n\t\t<div class=\"col-7\">\r\n\t\t\t<h2 class=\"text-primary\"> Expenceses List </h2>\r\n\t\t</div>\r\n\t\t<div class=\"col-5 text-lg-right\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ebf1bb34ae25962d89a387e7058bd80a16fce1a4435", async() => {
                WriteLiteral("\r\n\t\t\t\t<strong> Create new Expencese </strong>\r\n\t\t\t");
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
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<br />\r\n\r\n");
#nullable restore
#line 18 "E:\ASP.NET Core\MVC\ASP.NET Core 5.0 MVC - The Beginners Guide To Becoming A Pro\InAndOut\InAndOut\Views\Expencese\Index.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t<table>\r\n\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th> Name </th>\r\n\t\t\t\t<th> Amount </th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\r\n\t\t<tbody>\r\n\r\n");
#nullable restore
#line 32 "E:\ASP.NET Core\MVC\ASP.NET Core 5.0 MVC - The Beginners Guide To Becoming A Pro\InAndOut\InAndOut\Views\Expencese\Index.cshtml"
             foreach (var exp in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td width=\"50%\"> ");
#nullable restore
#line 35 "E:\ASP.NET Core\MVC\ASP.NET Core 5.0 MVC - The Beginners Guide To Becoming A Pro\InAndOut\InAndOut\Views\Expencese\Index.cshtml"
                                Write(exp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t\t\t<td width=\"30%\"> ");
#nullable restore
#line 36 "E:\ASP.NET Core\MVC\ASP.NET Core 5.0 MVC - The Beginners Guide To Becoming A Pro\InAndOut\InAndOut\Views\Expencese\Index.cshtml"
                                Write(exp.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 38 "E:\ASP.NET Core\MVC\ASP.NET Core 5.0 MVC - The Beginners Guide To Becoming A Pro\InAndOut\InAndOut\Views\Expencese\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</tbody>\r\n\r\n\t</table>\r\n");
#nullable restore
#line 43 "E:\ASP.NET Core\MVC\ASP.NET Core 5.0 MVC - The Beginners Guide To Becoming A Pro\InAndOut\InAndOut\Views\Expencese\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InAndOut.Models.Expencese>> Html { get; private set; }
    }
}
#pragma warning restore 1591
