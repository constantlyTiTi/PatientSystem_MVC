#pragma checksum "/Users/tingli/Desktop/homework/COMP229-web application/assignment/asp_git/PatientSystem/PatientSystem/PatientSystem/Views/Home/PatientList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8d8aa0f089510fcdedf73c2888f4cbf6466ba53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PatientList), @"mvc.1.0.view", @"/Views/Home/PatientList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PatientList.cshtml", typeof(AspNetCore.Views_Home_PatientList))]
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
#line 3 "/Users/tingli/Desktop/homework/COMP229-web application/assignment/asp_git/PatientSystem/PatientSystem/PatientSystem/Views/_ViewImports.cshtml"
using PatientSystem.Models;

#line default
#line hidden
#line 4 "/Users/tingli/Desktop/homework/COMP229-web application/assignment/asp_git/PatientSystem/PatientSystem/PatientSystem/Views/_ViewImports.cshtml"
using PatientSystem.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8d8aa0f089510fcdedf73c2888f4cbf6466ba53", @"/Views/Home/PatientList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a396b61ecbb579bae723183f0717a0b3f65d18", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PatientList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatientListViewModel>
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
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(152, 27, true);
            WriteLiteral("\r\n<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(179, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67636127c47d4b04a91f1a3b565ee816", async() => {
                BeginContext(185, 35, true);
                WriteLiteral("\r\n    <title>Patient List</title>\r\n");
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
            BeginContext(227, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(231, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5039651ee7ed4d70b0c43fb2fecf11e0", async() => {
                BeginContext(237, 23, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(261, 49, false);
#line 15 "/Users/tingli/Desktop/homework/COMP229-web application/assignment/asp_git/PatientSystem/PatientSystem/PatientSystem/Views/Home/PatientList.cshtml"
   Write(await Html.PartialAsync("PatientListPartialView"));

#line default
#line hidden
                EndContext();
                BeginContext(310, 22, true);
                WriteLiteral("\r\n    </div>\r\n    <div");
                EndContext();
                BeginWriteAttribute("page-model", " page-model=\"", 332, "\"", 361, 1);
#line 17 "/Users/tingli/Desktop/homework/COMP229-web application/assignment/asp_git/PatientSystem/PatientSystem/PatientSystem/Views/Home/PatientList.cshtml"
WriteAttributeValue("", 345, Model.PageInfor, 345, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(362, 43, true);
                WriteLiteral(" page-action=\"PatientList\">\r\n\r\n    </div>\r\n");
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
            BeginContext(412, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatientListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
