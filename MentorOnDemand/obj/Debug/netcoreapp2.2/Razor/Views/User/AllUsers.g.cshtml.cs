#pragma checksum "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7edd181fa1fb4076396b5e79cc547b17e5e6f329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AllUsers), @"mvc.1.0.view", @"/Views/User/AllUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/AllUsers.cshtml", typeof(AspNetCore.Views_User_AllUsers))]
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
#line 1 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\_ViewImports.cshtml"
using MentorOnDemand;

#line default
#line hidden
#line 2 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\_ViewImports.cshtml"
using MentorOnDemand.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edd181fa1fb4076396b5e79cc547b17e5e6f329", @"/Views/User/AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e87722786ff3d12e5d6a6cc030d23eb6ea832f", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MentorOnDemand.Entities.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
  
    ViewData["Title"] = "AllUsers";

#line default
#line hidden
            BeginContext(96, 32, true);
            WriteLiteral("\r\n<h1>AllUsers</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(128, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7edd181fa1fb4076396b5e79cc547b17e5e6f3293880", async() => {
                BeginContext(153, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(167, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(260, 38, false);
#line 16 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(298, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(354, 44, false);
#line 19 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(398, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(454, 44, false);
#line 22 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(498, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(554, 45, false);
#line 25 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(599, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(655, 44, false);
#line 28 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(699, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(755, 49, false);
#line 31 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactNumber));

#line default
#line hidden
            EndContext();
            BeginContext(804, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(860, 40, false);
#line 34 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
            EndContext();
            BeginContext(900, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(956, 47, false);
#line 37 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.LinkedinURL));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1059, 46, false);
#line 40 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1161, 42, false);
#line 43 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1259, 51, false);
#line 46 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.ConfirmedSignUp));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1366, 49, false);
#line 49 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.ResetPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1471, 53, false);
#line 52 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.ResetPasswordDate));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 58 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1642, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1691, 37, false);
#line 61 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1728, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1784, 43, false);
#line 64 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1827, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1883, 43, false);
#line 67 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1982, 44, false);
#line 70 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2026, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2082, 43, false);
#line 73 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2125, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2181, 48, false);
#line 76 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2285, 39, false);
#line 79 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2380, 46, false);
#line 82 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.LinkedinURL));

#line default
#line hidden
            EndContext();
            BeginContext(2426, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2482, 45, false);
#line 85 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Experience));

#line default
#line hidden
            EndContext();
            BeginContext(2527, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2583, 41, false);
#line 88 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
            EndContext();
            BeginContext(2624, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2680, 50, false);
#line 91 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.ConfirmedSignUp));

#line default
#line hidden
            EndContext();
            BeginContext(2730, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2786, 48, false);
#line 94 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.ResetPassword));

#line default
#line hidden
            EndContext();
            BeginContext(2834, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2890, 52, false);
#line 97 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.ResetPasswordDate));

#line default
#line hidden
            EndContext();
            BeginContext(2942, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2998, 65, false);
#line 100 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3063, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3084, 71, false);
#line 101 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3155, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3176, 69, false);
#line 102 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3245, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 105 "C:\Users\hp\Desktop\MentorOnDemand\MentorOnDemand\MentorOnDemand\Views\User\AllUsers.cshtml"
}

#line default
#line hidden
            BeginContext(3284, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MentorOnDemand.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
