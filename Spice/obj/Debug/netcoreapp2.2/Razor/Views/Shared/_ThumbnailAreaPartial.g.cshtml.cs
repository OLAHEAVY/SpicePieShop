#pragma checksum "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74f516b13a7babd3d83ab36c3e5d542b35d11c52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThumbnailAreaPartial), @"mvc.1.0.view", @"/Views/Shared/_ThumbnailAreaPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ThumbnailAreaPartial.cshtml", typeof(AspNetCore.Views_Shared__ThumbnailAreaPartial))]
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
#line 1 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f516b13a7babd3d83ab36c3e5d542b35d11c52", @"/Views/Shared/_ThumbnailAreaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThumbnailAreaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(150, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
 if (Model.Count() > 0)
{
    //Assigning the category name to a post class for the jquery method to toggle

#line default
#line hidden
            BeginContext(265, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 273, "\"", 372, 4);
            WriteAttributeValue("", 281, "col-12", 281, 6, true);
            WriteAttributeValue(" ", 287, "post", 288, 5, true);
#line 9 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
WriteAttributeValue(" ", 292, Model.FirstOrDefault().Category.Name.Replace(" ",string.Empty), 293, 63, false);

#line default
#line hidden
            WriteAttributeValue(" ", 356, "menu-restaurant", 357, 16, true);
            EndWriteAttribute();
            BeginContext(373, 68, true);
            WriteLiteral(">\r\n        <div class=\"row\">\r\n            <h3 class=\"text-success\"> ");
            EndContext();
            BeginContext(442, 36, false);
#line 11 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                 Write(Model.FirstOrDefault().Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(478, 26, true);
            WriteLiteral(" </h3>\r\n        </div>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(553, 154, true);
            WriteLiteral("            <div class=\"border border-info rounded col-12\" style=\"margin-bottom:10px; margin-top:10px; padding:10px\">\r\n                <div class=\"row\">\r\n");
            EndContext();
            BeginContext(770, 82, true);
            WriteLiteral("                    <div class=\"col-md-3 col-sm-12\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 852, "\"", 869, 1);
#line 20 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
WriteAttributeValue("", 858, item.Image, 858, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(870, 96, true);
            WriteLiteral(" width=\"99%\" style=\"border-radius:5px;border:1px solid #bbb9b9\" />\r\n                    </div>\r\n");
            EndContext();
            BeginContext(1038, 50, true);
            WriteLiteral("                <div class=\"col-md-9 col-sm-12\">\r\n");
            EndContext();
            BeginContext(1159, 89, true);
            WriteLiteral("                    <div class=\"row pr-3\">\r\n                        <div class=\"col-8\">\r\n");
            EndContext();
            BeginContext(1301, 92, true);
            WriteLiteral("                            <label class=\"text-primary\" style=\"font-size:21px;color:maroon\">");
            EndContext();
            BeginContext(1394, 9, false);
#line 28 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                                                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1403, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 30 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                             if (item.Spicyness == "1")
                            {

#line default
#line hidden
            BeginContext(1587, 80, true);
            WriteLiteral("                                <img srcset=\"/images/mild.png\" title=\"Mild\" />\r\n");
            EndContext();
#line 33 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                            }

#line default
#line hidden
            BeginContext(1698, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 34 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                             if (item.Spicyness == "2")
                            {

#line default
#line hidden
            BeginContext(1786, 82, true);
            WriteLiteral("                                <img srcset=\"/images/spicy.png\" title=\"Spicy\" />\r\n");
            EndContext();
#line 37 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                            }

#line default
#line hidden
            BeginContext(1899, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 38 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                             if (item.Spicyness == "3")
                            {

#line default
#line hidden
            BeginContext(1987, 91, true);
            WriteLiteral("                                <img srcset=\"/images/veryspicy.png\" title=\"Very Spicy\" />\r\n");
            EndContext();
#line 41 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                            }

#line default
#line hidden
            BeginContext(2109, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
            BeginContext(2191, 110, true);
            WriteLiteral("                        <div class=\"col-4 text-right\" style=\"color:maroon\">\r\n                            <h4>$");
            EndContext();
            BeginContext(2302, 10, false);
#line 45 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                            Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2312, 156, true);
            WriteLiteral("</h4>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row pr-3\">\r\n                        <div class=\"col-8\">\r\n");
            EndContext();
            BeginContext(2528, 133, true);
            WriteLiteral("                            <label class=\"rounded\" style=\"font-size:15px;font-weight:bolder;color:white;background-color:dodgerblue\">");
            EndContext();
            BeginContext(2662, 21, false);
#line 51 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                                                                                                                Write(item.SubCategory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2683, 125, true);
            WriteLiteral("</label>\r\n\r\n                        </div>\r\n                        <div class=\"col-4\"></div>\r\n                    </div>\r\n\r\n");
            EndContext();
            BeginContext(2872, 104, true);
            WriteLiteral("                    <div class=\"row col-12 text-justify d-none d-md-block\">\r\n                        <p>");
            EndContext();
            BeginContext(2977, 26, false);
#line 59 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                      Write(Html.Raw(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3003, 136, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-12 offset-md-9 text-center\">\r\n                        ");
            EndContext();
            BeginContext(3139, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f516b13a7babd3d83ab36c3e5d542b35d11c5211972", async() => {
                BeginContext(3224, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3235, 98, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 67 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(3344, 45, true);
            WriteLiteral("        <div class=\"p-4\"></div>\r\n    </div>\r\n");
            EndContext();
#line 70 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Views\Shared\_ThumbnailAreaPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591