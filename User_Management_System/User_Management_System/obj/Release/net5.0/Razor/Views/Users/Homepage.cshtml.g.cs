#pragma checksum "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Homepage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8905cf6fca82479879620a8577263001fc02905d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Homepage), @"mvc.1.0.view", @"/Views/Users/Homepage.cshtml")]
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
#line 1 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/_ViewImports.cshtml"
using User_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/_ViewImports.cshtml"
using User_Management_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8905cf6fca82479879620a8577263001fc02905d", @"/Views/Users/Homepage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9549f7c392f851d5d967255dfa23878fbba349b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Homepage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User_Management_System.Models.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Homepage.cshtml"
  
    ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome ");
#nullable restore
#line 8 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Homepage.cshtml"
                             Write(ViewBag.UsersName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User_Management_System.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
