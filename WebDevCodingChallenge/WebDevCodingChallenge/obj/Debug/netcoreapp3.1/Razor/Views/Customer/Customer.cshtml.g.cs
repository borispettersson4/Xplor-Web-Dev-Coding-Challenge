#pragma checksum "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab295c98a9f96c7d3f386c316ceacfdd4d38aa19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Customer), @"mvc.1.0.view", @"/Views/Customer/Customer.cshtml")]
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
#line 1 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\_ViewImports.cshtml"
using WebDevCodingChallenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\_ViewImports.cshtml"
using WebDevCodingChallenge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab295c98a9f96c7d3f386c316ceacfdd4d38aa19", @"/Views/Customer/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df025c81fe8d921e5c17794f433a4a324e6f3a44", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("region_us"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("region_se"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("m"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("f"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("customerFormSubmit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
  
    ViewData["Title"] = "Edit Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<script>\r\n        $(document).ready(function () {\r\n            console.log(\"");
#nullable restore
#line 13 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
                    Write(Model.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            $(\"input#field_firstName\").attr(\"value\", \"");
#nullable restore
#line 14 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
                                                 Write(Model.firstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            $(\"input#field_lastName\").attr(\"value\", \"");
#nullable restore
#line 15 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
                                                Write(Model.lastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            $(\"input#field_email\").attr(\"value\", \"");
#nullable restore
#line 16 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
                                             Write(Model.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            $(\"input#field_phone\").attr(\"value\", \"");
#nullable restore
#line 17 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
                                             Write(Model.phone_number);

#line default
#line hidden
#nullable disable
                WriteLiteral("\".replace(\"&#x2B;\", \"+\"));\r\n            $(\"input#field_balance\").attr(\"value\", \"");
#nullable restore
#line 18 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
                                               Write(Model.balance);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            if (\"");
#nullable restore
#line 19 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
            Write(Model.phone_number);

#line default
#line hidden
#nullable disable
                WriteLiteral("\".replace(\"&#x2B;\", \"+\").includes(\"+46\")) {\r\n                $(\"option#region_se\").attr(\"selected\", \"selected\");\r\n                $(\"option#region_us\").attr(\"selected\", \"\");\r\n            }\r\n            if (\"");
#nullable restore
#line 23 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
            Write(Model.gender);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" == ""f"") {
                $(""option#f"").attr(""selected"", ""selected"");
                $(""option#m"").attr(""selected"", """");
            }

            $(""#headerMain"").html(""Edit Customer"");
            $("".description"").html(""Modify an existing Customer. Edit the details below, then press <b>Submit</b> to create a POST request to the API. The server will then update this Customer"");
        });
</script>
");
#nullable restore
#line 32 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n        $(document).ready(function () {\r\n            console.log(\"No Model Present\");\r\n        });\r\n        </script>\r\n");
#nullable restore
#line 40 "C:\Users\boris\source\repos\WebDevCodingChallenge\WebDevCodingChallenge\Views\Customer\Customer.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""text-center"">

    <h4 id=""headerMain"" class=""headerMain"">Create New Customer</h4>

    <div>
        <label class=""description"">
            Add new Customer. Enter the required details below, then press <b>Submit</b> to create a POST request to the API. The server will then create a Customer.
        </label>
    </div>

    <div class=""customerForm"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab295c98a9f96c7d3f386c316ceacfdd4d38aa1910484", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label class=""form_font"" for=""firstname"" id=""form_firstName"">First Name</label>
                <input id=""field_firstName"" class=""form-control"" type=""text""
                       name=""firstname"" placeholder=""Enter your first name""");
                BeginWriteAttribute("value", "\r\n                       value=\"", 2166, "\"", 2198, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div>
            <div class=""form-group"">
                <label class=""form_font"" for=""lastname"" id=""form_lastName"">Last Name</label>
                <input id=""field_lastName"" class=""form-control"" type=""text""
                       name=""lastname"" placeholder=""Enter your last name""");
                BeginWriteAttribute("value", "\r\n                       value=\"", 2504, "\"", 2536, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div>
            <div class=""form-group"">
                <label class=""form_font"" style=""color:red"">*</label>
                <label class=""form_font"" for=""email"" id=""form_email"">Email</label>
                <input id=""field_email"" class=""form-control"" type=""text""
                       name=""email"" placeholder=""Enter your email address""");
                BeginWriteAttribute("value", "\r\n                       value=\"", 2900, "\"", 2932, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div>
            <div class=""form-group"">
                <label class=""form_font"" for=""phone"" id=""form_phone"">Phone Number</label>
                <div class=""input-group"">
                    <select id=""field_country"" class=""form-control"" name=""country"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab295c98a9f96c7d3f386c316ceacfdd4d38aa1912619", async() => {
                    WriteLiteral("US +1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab295c98a9f96c7d3f386c316ceacfdd4d38aa1914067", async() => {
                    WriteLiteral("SE +46");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                    <input id=\"field_phone\" class=\"form-control\" type=\"text\"\r\n                           name=\"phone\" placeholder=\"Enter your phone number\"");
                BeginWriteAttribute("value", "\r\n                           value=\"", 3535, "\"", 3571, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""form_font"">Gender</label>
                <div>
                    <select id=""field_gender"" class=""form-control"" name=""gender"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab295c98a9f96c7d3f386c316ceacfdd4d38aa1915836", async() => {
                    WriteLiteral("Male");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab295c98a9f96c7d3f386c316ceacfdd4d38aa1917283", async() => {
                    WriteLiteral("Female");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""form_font"" for=""balance"" id=""form_balance"">Balance Amount</label>
                <input id=""field_balance"" class=""form-control"" type=""text""
                       name=""balance"" placeholder=""Enter balance amount in USD""");
                BeginWriteAttribute("value", "\r\n                       value=\"", 4304, "\"", 4336, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Submit\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
