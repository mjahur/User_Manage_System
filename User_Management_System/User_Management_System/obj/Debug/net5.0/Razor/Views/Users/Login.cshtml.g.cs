#pragma checksum "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ece937cc15a251b24d1630b93cfb8f5056d87dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Login), @"mvc.1.0.view", @"/Views/Users/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ece937cc15a251b24d1630b93cfb8f5056d87dc", @"/Views/Users/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9549f7c392f851d5d967255dfa23878fbba349b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User_Management_System.Models.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Login</h2>\n");
#nullable restore
#line 7 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>AccountHolder</h4>\n        <hr />\n        ");
#nullable restore
#line 14 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 16 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 18 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 19 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 24 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
       Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 26 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
           Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 27 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"Login\" class=\"btn btn-default\" />\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 37 "/Users/umaryaqub/Documents/Projects/User_Management_System/User_Manage_System/User_Management_System/User_Management_System/Views/Users/Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User_Management_System.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
