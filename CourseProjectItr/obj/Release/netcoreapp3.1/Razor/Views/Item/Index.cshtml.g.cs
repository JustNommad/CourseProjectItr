#pragma checksum "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be118a0b60d0b0b7e0fc5978bcf80ade3654533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
#line 2 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be118a0b60d0b0b7e0fc5978bcf80ade3654533", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseProjectItr.Models.Items>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/itemPage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
  
    ViewBag.Title = Localizer["ItemPage"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2be118a0b60d0b0b7e0fc5978bcf80ade36545334534", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<input hidden id=\"userName\"");
            BeginWriteAttribute("value", " value=\"", 251, "\"", 278, 1);
#nullable restore
#line 9 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
WriteAttributeValue("", 259, User.Identity.Name, 259, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input hidden id=\"itemID\"");
            BeginWriteAttribute("value", " value=\"", 309, "\"", 326, 1);
#nullable restore
#line 10 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
WriteAttributeValue("", 317, Model.Id, 317, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<div class=\"image-item\">\r\n");
#nullable restore
#line 13 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
     if (Model.ImageUrl != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 409, "\"", 443, 1);
#nullable restore
#line 15 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
WriteAttributeValue("", 415, Url.Content(Model.ImageUrl), 415, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" style=\"width: 18%;max-height: 100%;\" />\r\n");
#nullable restore
#line 16 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mainfield\">\r\n    <h1>");
#nullable restore
#line 18 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h2 class=\"text-muted\">");
#nullable restore
#line 19 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
                      Write(Model.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2 class=\"text-muted\">");
#nullable restore
#line 20 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
                      Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <table>\r\n        <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
             for (int i = 0; i < ViewBag.Collection.Count && i < ViewBag.Item.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-muted\"><th>");
#nullable restore
#line 25 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
                                  Write(ViewBag.Collection[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th><td>");
#nullable restore
#line 25 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
                                                                 Write(ViewBag.Item[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 26 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div class=\"likeField\">\r\n        <label class=\"controle-label likeLable text-muted\">");
#nullable restore
#line 30 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
                                                      Write(Localizer["Like"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 30 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
                                                                          Write(ViewBag.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        <div class=\"likeButton\" id=\"likeInputForm\">\r\n            <input class=\"btn btn-outline-success my-2 my-sm-0\" type=\"button\" id=\"sendLikeBtn\"");
            BeginWriteAttribute("value", " value=\"", 1208, "\"", 1234, 1);
#nullable restore
#line 32 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
WriteAttributeValue("", 1216, Localizer["Like"], 1216, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n<hr />\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be118a0b60d0b0b7e0fc5978bcf80ade365453310784", async() => {
                WriteLiteral("\r\n        <table>\r\n");
#nullable restore
#line 41 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
             foreach (var c in ViewBag.Comments)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content text-white bg-dark"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"">
                                ");
#nullable restore
#line 47 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
                           Write(c.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </h5>\r\n                        </div>\r\n                        <div class=\"modal-body\">\r\n                            <div class=\"container-fluid\">\r\n                                <span>\r\n                                    ");
#nullable restore
#line 53 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
                               Write(c.Comment);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 59 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n        <div id=\"commentList\"></div>\r\n\r\n        <div id=\"inputForm\">\r\n            <label class=\"controle-label\">");
#nullable restore
#line 64 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
                                     Write(Localizer["InputComment"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"message\" />\r\n            <input class=\"btn btn-outline-success my-2 my-sm-0\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2427, "\"", 2467, 1);
#nullable restore
#line 66 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
WriteAttributeValue("", 2441, Localizer["InputComment"], 2441, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("aria-lable", " aria-lable=\"", 2468, "\"", 2507, 1);
#nullable restore
#line 66 "C:\Users\JustNomad\source\repos\CourseProjectItr\CourseProjectItr\Views\Item\Index.cshtml"
WriteAttributeValue("", 2481, Localizer["InputComment"], 2481, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                   type=\"button\" id=\"sendCommentBtn\" value=\"Input\">\r\n        </div>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be118a0b60d0b0b7e0fc5978bcf80ade365453314262", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <script>
            const hubConnection = new signalR.HubConnectionBuilder()
                .withUrl(""/chat"")
                .build();

            hubConnection.on('SendComment', function (message, userName, itemID) {
                if (itemID == document.querySelector('#itemID').value) {

                const comment = document.createElement('div');
                comment.innerHTML = `<div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content text-white bg-dark"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"">
                            ${userName}
                            </h5>
                        </div>
                        <div class=""modal-body"">
                            <div class=""container-fluid"">
                                <span>
                                ${message}
                                </span>
                            </div>
             ");
                WriteLiteral(@"           </div>
                    </div>
                </div>`;
                document.querySelector(""#commentList"").appendChild(comment);
                };
            });

            hubConnection.on('SendLike', function (likes) {
                document.getElementById(""likeField"").value = likes;
            })

            document.getElementById(""sendLikeBtn"").addEventListener(""click"", async function (e) {
                let itemID = document.getElementById(""itemID"").value;
                const result = await fetch('/User/Like', {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        ItemID: itemID,
                        Choise: ""true""
                    })
                });
                if (result.ok === true) {
                    const res = awa");
                WriteLiteral(@"it result.json();
                    hubConnection.invoke(""SendLike"", res.like);
                }
            });

            document.getElementById(""sendCommentBtn"").addEventListener(""click"", async function (e) {
                let message = document.getElementById(""message"").value;
                let itemID = document.getElementById(""itemID"").value;
                let userName = document.getElementById(""userName"").value;
                const result = await fetch('/User/Comment', {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        UserName: userName,
                        ItemID: itemID,
                        Comment: message
                    })
                });
                if (result.ok === true) {
                    const res = await result.json(");
                WriteLiteral(");\r\n                    hubConnection.invoke(\"SendComment\", res.comment, res.userName, res.itemId);\r\n                }\r\n            });\r\n            hubConnection.start();\r\n        </script>\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseProjectItr.Models.Items> Html { get; private set; }
    }
}
#pragma warning restore 1591
