#pragma checksum "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/Numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d98d5d24178eb0063d4efec1a9332c5f5755dc7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Numbers), @"mvc.1.0.view", @"/Views/Home/Numbers.cshtml")]
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
#line 1 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/_ViewImports.cshtml"
using CS_View_Models_B;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/_ViewImports.cshtml"
using CS_View_Models_B.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d98d5d24178eb0063d4efec1a9332c5f5755dc7e", @"/Views/Home/Numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa5f0a1d6818172ac3b9123237c16f60e8290816", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Here are some numbers!</h1>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 9 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/Numbers.cshtml"
 foreach(var num in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/Numbers.cshtml"
  Write(num);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/Numbers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
