<<<<<<< HEAD
#pragma checksum "D:\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d05b0419508635802786cdff4ac43691eb055caa"
=======
#pragma checksum "C:\Users\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d05b0419508635802786cdff4ac43691eb055caa"
>>>>>>> master
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_Remove), @"mvc.1.0.view", @"/Views/Destination/Remove.cshtml")]
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
<<<<<<< HEAD
#line 1 "D:\LCStudent\Capstone\TripTrack\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\LCStudent\Capstone\TripTrack\Views\_ViewImports.cshtml"
>>>>>>> master
using TripTrack;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "D:\LCStudent\Capstone\TripTrack\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\LCStudent\Capstone\TripTrack\Views\_ViewImports.cshtml"
>>>>>>> master
using TripTrack.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05b0419508635802786cdff4ac43691eb055caa", @"/Views/Destination/Remove.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fcd129743f6ded4be15aa7241b7f0378dfdc55b", @"/Views/_ViewImports.cshtml")]
    public class Views_Destination_Remove : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
<<<<<<< HEAD
#line 1 "D:\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
=======
#line 1 "C:\Users\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
>>>>>>> master
Write(ViewBag.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d05b0419508635802786cdff4ac43691eb055caa3689", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "D:\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d05b0419508635802786cdff4ac43691eb055caa3713", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
>>>>>>> master
     foreach (var Destination in ViewBag.destinations)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"checkbox\" name=\"destinationIds\"");
                BeginWriteAttribute("id", " id=\"", 166, "\"", 171, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 172, "\"", 206, 1);
#nullable restore
<<<<<<< HEAD
#line 7 "D:\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
=======
#line 7 "C:\Users\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
>>>>>>> master
WriteAttributeValue("", 180, Destination.DestinationId, 180, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 225, "\"", 257, 1);
#nullable restore
<<<<<<< HEAD
#line 8 "D:\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
=======
#line 8 "C:\Users\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
>>>>>>> master
WriteAttributeValue("", 231, Destination.DestinationId, 231, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
<<<<<<< HEAD
#line 8 "D:\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
=======
#line 8 "C:\Users\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
>>>>>>> master
                                           Write(Destination.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        <br/>\r\n");
#nullable restore
<<<<<<< HEAD
#line 10 "D:\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
=======
#line 10 "C:\Users\LCStudent\Capstone\TripTrack\Views\Destination\Remove.cshtml"
>>>>>>> master
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Remove Selected Destination(s)\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
