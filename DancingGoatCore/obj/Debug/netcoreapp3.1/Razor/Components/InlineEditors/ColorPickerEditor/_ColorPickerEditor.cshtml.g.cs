#pragma checksum "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Components\InlineEditors\ColorPickerEditor\_ColorPickerEditor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d32d111232aeb0ff4d5ea738ad603fbff5697632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_InlineEditors_ColorPickerEditor__ColorPickerEditor), @"mvc.1.0.view", @"/Components/InlineEditors/ColorPickerEditor/_ColorPickerEditor.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d32d111232aeb0ff4d5ea738ad603fbff5697632", @"/Components/InlineEditors/ColorPickerEditor/_ColorPickerEditor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    #nullable restore
    public class Components_InlineEditors_ColorPickerEditor__ColorPickerEditor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.InlineEditors.ColorPickerEditorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Components\InlineEditors\ColorPickerEditor\_ColorPickerEditor.cshtml"
 using (Html.Kentico().BeginInlineEditor("color-picker-editor", Model.PropertyName, new { @class = "color-picker-editor" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""inline-editor-btn-group"">
        <ul class=""inline-editor-btn-group-actions"">
            <li>
                <button id=""first-color-btn"" type=""button"">
                    <i class=""color-btn first-color""></i>
                </button>
            </li>
            <li>
                <button id=""second-color-btn"" type=""button"">
                    <i class=""color-btn second-color""></i>
                </button>
            </li>
            <li>
                <button id=""third-color-btn"" type=""button"">
                    <i class=""color-btn third-color""></i>
                </button>
            </li>
        </ul>
    </div>
");
#nullable restore
#line 24 "C:\inetpub\wwwroot\AKS13ks\DancingGoatCore\Components\InlineEditors\ColorPickerEditor\_ColorPickerEditor.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.InlineEditors.ColorPickerEditorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
