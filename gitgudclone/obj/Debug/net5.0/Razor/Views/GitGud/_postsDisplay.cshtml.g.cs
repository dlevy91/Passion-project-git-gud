#pragma checksum "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_postsDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2e20e9fe0c930865ac858b9ac989482ef75e5f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GitGud__postsDisplay), @"mvc.1.0.view", @"/Views/GitGud/_postsDisplay.cshtml")]
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
#line 1 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\_ViewImports.cshtml"
using gitgudclone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\_ViewImports.cshtml"
using gitgudclone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e20e9fe0c930865ac858b9ac989482ef75e5f3", @"/Views/GitGud/_postsDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39147a92bf84a37d7c1b4723462c1da589e9a707", @"/Views/_ViewImports.cshtml")]
    public class Views_GitGud__postsDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gitgudclone.Models.PostsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card text-white bg-dark mb3 \" style=\"width: 18rem;\">\r\n    <div class=\"card-body\">\r\n        <p id=\"id\" class=\"card-title\">");
#nullable restore
#line 5 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_postsDisplay.cshtml"
                                 Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <ul id=\"id\" class = \"card-title\">\r\n");
#nullable restore
#line 8 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_postsDisplay.cshtml"
             foreach (StepsModel step in @Model.postSteps)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
#nullable restore
#line 11 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_postsDisplay.cshtml"
               Write(step.step);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_postsDisplay.cshtml"
                     if (step.img != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=", 460, "", 474, 1);
#nullable restore
#line 14 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_postsDisplay.cshtml"
WriteAttributeValue("", 465, step.img, 465, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\" alt=\"step.img\"/>\r\n");
#nullable restore
#line 15 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_postsDisplay.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n");
#nullable restore
#line 17 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\_postsDisplay.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gitgudclone.Models.PostsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
