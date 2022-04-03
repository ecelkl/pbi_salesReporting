#pragma checksum "C:\Users\10121229\Downloads\PowerBIDeviad\MySolution\SalesReporting\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f17fe4d6ff246184501e8a26df725ee369c9c0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\10121229\Downloads\PowerBIDeviad\MySolution\SalesReporting\Views\_ViewImports.cshtml"
using SalesReporting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\10121229\Downloads\PowerBIDeviad\MySolution\SalesReporting\Views\_ViewImports.cshtml"
using SalesReporting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f17fe4d6ff246184501e8a26df725ee369c9c0e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4739c6fabdf0b41f892c5a2c6f37b3d82db3554f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PowerBiEmbed.ViewModels.WorkspaceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class='container-fluid'>
    <div class='row'>
        <div id=""left-nav"" class='col-sm-2'>
            <div>
                <div class='navbar-header navbar-toggle' data-toggle='collapse' data-target='.reports-collapse'>
                    Reports
                </div>
                <div id='reports-menu' class='navbar-collapse reports-collapse'>
                    <ul id='reports-list' class='nav navbar-nav'></ul>
                </div>
                <div class='navbar-header navbar-toggle' data-toggle='collapse' data-target='.datasets-collapse'>
                    Datasets Q&amp;A
                </div>
                <div id='datasets-menu' class='navbar-collapse datasets-collapse'>
                    <ul id='datasets-list' class='nav navbar-nav'></ul>
                </div>
            </div>
        </div>
        <div id=""content-box"" class='col-sm-10'>
            <div id=""embed-container""></div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t<script src=\"https://cdn.jsdelivr.net/npm/powerbi-client@2.17.2/dist/powerbi.min.js\"></script>\r\n\t<script>\r\n\t\tvar reports = ");
#nullable restore
#line 30 "C:\Users\10121229\Downloads\PowerBIDeviad\MySolution\SalesReporting\Views\Home\Index.cshtml"
                 Write(Html.Raw(Model.ReportsJson));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\tvar datasets = ");
#nullable restore
#line 31 "C:\Users\10121229\Downloads\PowerBIDeviad\MySolution\SalesReporting\Views\Home\Index.cshtml"
                  Write(Html.Raw(Model.DatasetsJson));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\tvar embedToken = \"");
#nullable restore
#line 32 "C:\Users\10121229\Downloads\PowerBIDeviad\MySolution\SalesReporting\Views\Home\Index.cshtml"
                     Write(Model.EmbedToken);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n\t</script>\r\n    <script src=\"~\\js\\embed.js\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PowerBiEmbed.ViewModels.WorkspaceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591