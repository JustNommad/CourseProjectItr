#pragma checksum "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b03f0bd62c2667c77ab567a7b4fd7d527170947"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AdminList), @"mvc.1.0.view", @"/Views/User/AdminList.cshtml")]
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
#line 2 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b03f0bd62c2667c77ab567a7b4fd7d527170947", @"/Views/User/AdminList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AdminList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseProjectItr.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
  
    ViewBag.Title = Localizer["AdminPanel"];

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <nav class=\"navbar navbar-dark bg-dark\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b03f0bd62c2667c77ab567a7b4fd7d5271709474097", async() => {
                WriteLiteral("\r\n                <button class=\"btn btn-success\" type=\"button\" onclick=\"sendDataUn()\">");
#nullable restore
#line 12 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                                                                                Write(Localizer["Unblock"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                <button class=\"btn btn-warning\" type=\"button\" onclick=\"sendDataB()\">");
#nullable restore
#line 13 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                                                                               Write(Localizer["Block"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                <button class=\"btn btn-danger\" type=\"button\" onclick=\"sendDataD()\">");
#nullable restore
#line 14 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                                                                              Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </nav>

        <table class=""table table-striped table-dark"">
            <tr>
                <th scope=""col"">
                    <div class=""custom-control custom-checkbox"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""checkAll"" onclick='addAllItem()' unchecked>
                        <label class=""custom-control-label"" for=""checkAll"" name=""labelAll"">All</label>
                    </div>
                </th>
                <th scope=""col"">");
#nullable restore
#line 26 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                           Write(Localizer["Id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 27 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                           Write(Localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 28 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                           Write(Localizer["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 29 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                           Write(Localizer["Register"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 30 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                           Write(Localizer["LastLogin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n            <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">\r\n                            <div class=\"custom-control custom-checkbox\">\r\n                                <input type=\"checkbox\" class=\"custom-control-input\"");
            BeginWriteAttribute("id", " id=\"", 1783, "\"", 1796, 1);
#nullable restore
#line 38 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
WriteAttributeValue("", 1788, user.Id, 1788, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"users\" unchecked>\r\n                                <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 1890, "\"", 1904, 1);
#nullable restore
#line 39 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
WriteAttributeValue("", 1896, user.Id, 1896, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                            </div>\r\n                        </th>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                       Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b03f0bd62c2667c77ab567a7b4fd7d52717094710401", async() => {
#nullable restore
#line 43 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                                                                                 Write(user.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                                                                                                 Write(user.LastName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                                                          WriteLiteral(user.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                       Write(user.RegisterDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                       Write(user.LastLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 48 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\User\AdminList.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseProjectItr.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
