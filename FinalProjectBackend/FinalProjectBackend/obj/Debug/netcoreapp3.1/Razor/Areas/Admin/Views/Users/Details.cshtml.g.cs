#pragma checksum "C:\Users\ACER\Desktop\Full-Stack-Final-Project\FinalProjectBackend\FinalProjectBackend\Areas\Admin\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94223f32fad6597bf3df3653c5be297b289c1a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Details.cshtml")]
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
#line 1 "C:\Users\ACER\Desktop\Full-Stack-Final-Project\FinalProjectBackend\FinalProjectBackend\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProjectBackend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\Full-Stack-Final-Project\FinalProjectBackend\FinalProjectBackend\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProjectBackend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\Desktop\Full-Stack-Final-Project\FinalProjectBackend\FinalProjectBackend\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProjectBackend.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94223f32fad6597bf3df3653c5be297b289c1a4", @"/Areas/Admin/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c318ba9cf79d8a31bab08b4a19fc6bea20a64bf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserRoleVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ACER\Desktop\Full-Stack-Final-Project\FinalProjectBackend\FinalProjectBackend\Areas\Admin\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"detail-box\" style=\"width:400px; height:250px; background-color:red;\">\r\n    <h3 style=\"text-align:center; padding-top: 15px; color:white\">");
#nullable restore
#line 7 "C:\Users\ACER\Desktop\Full-Stack-Final-Project\FinalProjectBackend\FinalProjectBackend\Areas\Admin\Views\Users\Details.cshtml"
                                                             Write(Model.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ACER\Desktop\Full-Stack-Final-Project\FinalProjectBackend\FinalProjectBackend\Areas\Admin\Views\Users\Details.cshtml"
     foreach (var item in Model.UserRoles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"text-align:center; color:black; font-size:21px\">");
#nullable restore
#line 11 "C:\Users\ACER\Desktop\Full-Stack-Final-Project\FinalProjectBackend\FinalProjectBackend\Areas\Admin\Views\Users\Details.cshtml"
                                                             Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\ACER\Desktop\Full-Stack-Final-Project\FinalProjectBackend\FinalProjectBackend\Areas\Admin\Views\Users\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserRoleVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
