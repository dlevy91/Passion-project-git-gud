#pragma checksum "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21a534ba0c0328eedf5daaa260bbc1618a46b208"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GitGud_ViewMessages), @"mvc.1.0.view", @"/Views/GitGud/ViewMessages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21a534ba0c0328eedf5daaa260bbc1618a46b208", @"/Views/GitGud/ViewMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39147a92bf84a37d7c1b4723462c1da589e9a707", @"/Views/_ViewImports.cshtml")]
    public class Views_GitGud_ViewMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gitgudclone.Data.ApplicationDbContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "gitgud", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "viewmessagedetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<h1>Unread Messages</h1>
<table class=""table table-dark"">
  <thead>
    <tr>
      <th scope=""col"">Status</th>
      <th scope=""col"">Time</th>
      <th scope=""col"">From</th>
      <th scope=""col"">Subject</th>
    </tr>
  </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
       foreach (MessagesModel message in @Model.messagesList)
      {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
         if(message.recipientEmail == User.Identity.Name)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n");
#nullable restore
#line 19 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
             if(message.isRead == false)
            {
  

#line default
#line hidden
#nullable disable
            WriteLiteral("              <th scope=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
               if(@message.isRead == false)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Unread</span>\r\n");
#nullable restore
#line 26 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
              }
              else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Read</span>\r\n");
#nullable restore
#line 29 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </th>\r\n");
            WriteLiteral("              <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a534ba0c0328eedf5daaa260bbc1618a46b2086187", async() => {
#nullable restore
#line 32 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                                        Write(message.messageDate);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-messageID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                    WriteLiteral(message.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-messageID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
            WriteLiteral("              <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a534ba0c0328eedf5daaa260bbc1618a46b2089211", async() => {
#nullable restore
#line 34 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                                        Write(message.userEmail);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-messageID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                    WriteLiteral(message.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-messageID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
            WriteLiteral("              <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a534ba0c0328eedf5daaa260bbc1618a46b20812233", async() => {
#nullable restore
#line 36 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                                        Write(message.subjectLine);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-messageID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                    WriteLiteral(message.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-messageID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tr>\r\n");
#nullable restore
#line 39 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
         
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>    \r\n");
            WriteLiteral("\r\n<h1>Read Messages</h1>\r\n<table class=\"table table-dark\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"col\">Status</th>\r\n      <th scope=\"col\">From</th>\r\n      <th scope=\"col\">Body</th>\r\n    </tr>\r\n  </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
       foreach (MessagesModel message in @Model.messagesList)
      {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
         if(message.recipientEmail == User.Identity.Name)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n");
#nullable restore
#line 60 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
             if(message.isRead == true)
            {
  

#line default
#line hidden
#nullable disable
            WriteLiteral("              <th scope=\"row\">\r\n");
#nullable restore
#line 64 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
               if(@message.isRead == false)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Unread</span>\r\n");
#nullable restore
#line 67 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
              }
              else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Read</span>\r\n");
#nullable restore
#line 70 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </th>\r\n");
            WriteLiteral("              <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a534ba0c0328eedf5daaa260bbc1618a46b20818027", async() => {
#nullable restore
#line 73 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                                        Write(message.messageDate);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-messageID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                    WriteLiteral(message.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-messageID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
            WriteLiteral("              <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a534ba0c0328eedf5daaa260bbc1618a46b20821052", async() => {
#nullable restore
#line 75 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                                        Write(message.userEmail);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-messageID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                    WriteLiteral(message.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-messageID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
            WriteLiteral("              <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a534ba0c0328eedf5daaa260bbc1618a46b20824075", async() => {
#nullable restore
#line 77 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                                        Write(message.subjectLine);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-messageID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
                                                                                                    WriteLiteral(message.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-messageID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["messageID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 78 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tr>\r\n");
#nullable restore
#line 80 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\student\Code_School\Projects\Passion-project-git-gud\gitgudclone\Views\GitGud\ViewMessages.cshtml"
         
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gitgudclone.Data.ApplicationDbContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
