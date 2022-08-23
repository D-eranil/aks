#pragma checksum "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c03ed332274e36f0f934aba067560bb163a9ffc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_EditorTemplates_BillingAddressViewModel), @"mvc.1.0.view", @"/Views/Checkout/EditorTemplates/BillingAddressViewModel.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
using DancingGoat.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03ed332274e36f0f934aba067560bb163a9ffc3", @"/Views/Checkout/EditorTemplates/BillingAddressViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_EditorTemplates_BillingAddressViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.BillingAddressViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 5 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(HtmlLocalizer["Billing address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n\r\n<div data-addresstype=\'BillingAddress\' data-fields=\'[\"Line1\", \"Line2\", \"City\", \"PostalCode\"]\'>\r\n    ");
#nullable restore
#line 9 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.EditorFor(m => m.BillingAddressSelector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.BillingAddressLine1, HtmlLocalizer["e.g. street address, P.O.box, c/o"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.BillingAddressLine2, HtmlLocalizer["e.g. apartment, suite, unit, building"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.BillingAddressCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.ValidatedEditorFor(m => m.BillingAddressPostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 15 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Views\Checkout\EditorTemplates\BillingAddressViewModel.cshtml"
Write(Html.EditorFor(m => m.BillingAddressCountryStateSelector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.BillingAddressViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
