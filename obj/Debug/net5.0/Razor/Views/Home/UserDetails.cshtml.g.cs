#pragma checksum "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/UserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be8a6f0c63c78461240050422da09d88ce4a611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserDetails), @"mvc.1.0.view", @"/Views/Home/UserDetails.cshtml")]
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
#line 1 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/UserDetails.cshtml"
using CS_View_Models_B.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be8a6f0c63c78461240050422da09d88ce4a611", @"/Views/Home/UserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa5f0a1d6818172ac3b9123237c16f60e8290816", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Here is a User!</h1>\r\n</div>\r\n");
#nullable restore
#line 8 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/UserDetails.cshtml"
 foreach(var user in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/UserDetails.cshtml"
  Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/UserDetails.cshtml"
                  Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "/mnt/c/Users/enoch/Desktop/coding_dojo/Dojo_Assignments/cs_stack/cs_assignments/CS_View_Models_B/Views/Home/UserDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
