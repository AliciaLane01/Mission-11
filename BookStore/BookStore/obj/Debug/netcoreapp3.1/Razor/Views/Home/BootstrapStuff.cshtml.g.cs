#pragma checksum "C:\Users\alici\source\repos\BookStore\BookStore\Views\Home\BootstrapStuff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a82a62df6739a93a29dfc13e147036d8a5eb9e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BootstrapStuff), @"mvc.1.0.view", @"/Views/Home/BootstrapStuff.cshtml")]
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
#line 3 "C:\Users\alici\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alici\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alici\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a82a62df6739a93a29dfc13e147036d8a5eb9e62", @"/Views/Home/BootstrapStuff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b053270806fc4e241fa1c4bbb98ac0820f76f9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BootstrapStuff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3>This is my page for testing out Bootstrap stuff!</h3>

<div class=""accordion"" id=""MyAccordion"">
    <div class=""accordion-item"">
        <h2 class=""accordion-header""><button class=""accordion-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#ItemOne"">About The Book Store</button></h2>
        <div class=""accordion-collapse collapse"" id=""ItemOne"" data-bs-parent=""#MyAccordion"">
            <div class=""accordion-body"">The Book Store is an online platform for buying some of Professor Hilton's favorite books!</div>
        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
