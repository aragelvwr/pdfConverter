#pragma checksum "D:\Projects\Pets_projects\PdfConverter\PdfConverter\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f883e15db194f5dd08ff50abf68e5b90270e5473"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#line 2 "D:\Projects\Pets_projects\PdfConverter\PdfConverter\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f883e15db194f5dd08ff50abf68e5b90270e5473", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"111bd4b89de50cbe23b553cff7b45687afa779a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\Pets_projects\PdfConverter\PdfConverter\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Convert JPG to PDF";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("links", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f883e15db194f5dd08ff50abf68e5b90270e54734443", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""home-contents"">
    <div class=""demi-35 drop-area drop-area-ex not-active-content"">Отпускааай!!!</div>
    <span class=""medium-50"">JPG в PDF</span>
    <span class=""light-40"">Конвертируйте ваши изображения в формат PDF</span>
    <input type=""file"" id=""file-input"" accept=""image/jpeg"" multiple />
    <label class=""button border-shadow"" for=""file-input"">
        <span class=""button-animation demi-35"">");
#nullable restore
#line 18 "D:\Projects\Pets_projects\PdfConverter\PdfConverter\Views\Home\Home.cshtml"
                                          Write(Localizer["SelectButton"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
    </label>
    <span class=""light-25"">или перетащите изображения JPG сюда</span>
</div>



<div class=""contents not-active-content"">
    <div class=""demi-35 drop-area not-active-content"">Отпускааай!!!</div>
    <div class=""icon-bar"">
        <div class=""border-shadow add""></div>
        <div class=""border-shadow sort-ascending""></div>
        <div class=""counter"">
            <span class=""demi-15"">0</span>
        </div>
    </div>
</div>

<div class=""convert-settings not-active-content"">
    <span class=""demi-30 h1-text"">ПАРАМЕТРЫ ИЗОБРАЖЕНИЯ В PDF</span>
    <span class=""medium-25"">Выберите ориентацию страницы</span>
    <div class=""box-container"">
        <div class=""orientation-box active border-shadow"" data-orientation=""vertical"">
            <svg width=""40"" height=""60"" viewBox=""0 0 40 60"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                <rect x=""1.5"" y=""1.5"" width=""37"" height=""57"" stroke=""#151D20"" stroke-width=""3"" />
            </svg>
            <span");
            WriteLiteral(@" class=""light-25 vertical-text"">Вертикальная</span>
        </div>
        <div class=""orientation-box not-active border-shadow"" data-orientation=""horizontal"">
            <svg width=""60"" height=""40"" viewBox=""0 0 60 40"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                <rect x=""58.5"" y=""1.5"" width=""37"" height=""57"" transform=""rotate(90 58.5 1.5)"" stroke=""#151D20"" stroke-width=""3"" />
            </svg>
            <span class=""light-25 horizontal-text"">Горизонтальная</span>
        </div>
    </div>

    <span class=""medium-25"">Размер страницы</span>
    <select class=""select-css light-20"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f883e15db194f5dd08ff50abf68e5b90270e54738155", async() => {
                WriteLiteral("A4 (297*210 мм)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </select>

    <span class=""medium-25"">Поле</span>

    <div class=""box-container field-box"">
        <div class=""orientation-box border-shadow active"" data-type-field=""standart"">
            <svg width=""60"" height=""60"" viewBox=""0 0 60 60"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                <mask id=""mask0"" mask-type=""alpha"" maskUnits=""userSpaceOnUse"" x=""0"" y=""0"" width=""60"" height=""60"">
                    <rect width=""60"" height=""60"" fill=""#C4C4C4"" />
                </mask>
                <g mask=""url(#mask0)"">
                    <rect x=""1"" y=""1"" width=""58"" height=""57.7235"" rx=""1"" fill=""white"" stroke=""black"" stroke-width=""2"" />
                    <path d=""M6.98055 50.2193L16.8692 39.6224C17.2519 39.2123 17.8971 39.1972 18.2986 39.5889L28.8321 49.8657C29.4686 50.4867 29.0386 51.5674 28.1494 51.5813L17.2794 51.7517L7.72734 51.9014C6.84562 51.9152 6.37892 50.864 6.98055 50.2193Z"" fill=""white"" stroke=""black"" stroke-width=""2"" />
                    <path d=""M33.0154 51.7558L52.");
            WriteLiteral(@"0161 51.7558C53.8288 51.7558 54.7065 49.5376 53.3846 48.2973L36.1067 32.0859C35.3115 31.3398 34.0651 31.3681 33.3047 32.1497L24.7204 40.9724"" stroke=""black"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" />
                </g>
            </svg>
            <span class=""light-25 vertical-text"">Без полей</span>
        </div>
        <div class=""orientation-box border-shadow not-active"" data-type-field=""small"">
            <svg width=""60"" height=""60"" viewBox=""0 0 60 60"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                <mask id=""mask0"" mask-type=""alpha"" maskUnits=""userSpaceOnUse"" x=""0"" y=""0"" width=""60"" height=""60"">
                    <rect width=""60"" height=""60"" fill=""#C4C4C4"" />
                </mask>
                <g mask=""url(#mask0)"">
                    <rect width=""60"" height=""60"" fill=""#151D20"" />
                    <rect x=""6"" y=""6"" width=""48"" height=""47.7696"" rx=""1"" fill=""white"" stroke=""black"" stroke-width=""2"" />
                    <path d=""M11.4737 4");
            WriteLiteral(@"6.3901L18.947 38.3816C19.3297 37.9715 19.9749 37.9563 20.3764 38.3481L28.3371 46.1147C28.9736 46.7357 28.5436 47.8164 27.6544 47.8304L19.3969 47.9598L12.2205 48.0722C11.3388 48.0861 10.8721 47.0348 11.4737 46.3901Z"" stroke=""black"" stroke-width=""2"" />
                    <path d=""M32.5128 48.1298L47.5044 48.1298C49.3171 48.1298 50.1948 45.9116 48.8729 44.6713L35.3276 31.9622C34.5324 31.2161 33.2861 31.2444 32.5257 32.026L25.6004 39.1436"" stroke=""black"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" />
                </g>
            </svg>
            <span class=""light-25 vertical-text"">Маленькое</span>
        </div>
        <div class=""orientation-box border-shadow not-active"" data-type-field=""amount"">
            <svg width=""60"" height=""60"" viewBox=""0 0 60 60"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                <rect width=""60"" height=""60"" fill=""#151D20"" />
                <rect x=""11"" y=""11"" width=""38"" height=""37.8157"" rx=""1"" fill=""white"" stroke=""black"" stroke-width=");
            WriteLiteral(@"""2"" />
                <path d=""M15.9669 42.561L21.0248 37.1407C21.4076 36.7306 22.0527 36.7155 22.4543 37.1072L27.8421 42.3637C28.4786 42.9847 28.0486 44.0654 27.1594 44.0794L21.5144 44.1678L16.7137 44.2431C15.8319 44.2569 15.3653 43.2057 15.9669 42.561Z"" stroke=""black"" stroke-width=""2"" />
                <path d=""M32.0103 44.5038L42.9927 44.5038C44.8053 44.5038 45.6831 42.2856 44.3611 41.0453L34.5486 31.8385C33.7534 31.0924 32.5071 31.1208 31.7467 31.9023L26.4804 37.3149"" stroke=""black"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" />
            </svg>
            <span class=""light-25 vertical-text"">Большое</span>
        </div>
    </div>
    <div>
        <input class=""custom-checkbox"" type=""checkbox"" name=""files"" />
        <span class=""medium-25"">Объединить все изображения в один PDF-файл</span>
    </div>

    <div class=""button-gradient"">
        <div class=""button border-shadow custom-button"">
            <div class=""button-animation"">
                <span class=""d");
            WriteLiteral(@"emi-30"">Конвертувати в PDF</span>
                <svg width=""30"" height=""30"" viewBox=""0 0 30 30"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <path d=""M15.75 20.3075V10.4425C15.75 10.1798 16.0636 10.044 16.2552 10.2236L21.5165 15.1561C21.643 15.2747 21.643 15.4753 21.5165 15.5939L16.2552 20.5264C16.0636 20.706 15.75 20.5702 15.75 20.3075Z"" fill=""#FCE130"" stroke=""#FCE130"" stroke-width=""2"" />
                    <rect x=""7.5"" y=""13.5"" width=""12"" height=""3.75"" rx=""0.8"" fill=""#FCE130"" />
                    <circle r=""14"" transform=""matrix(-1 0 0 1 15 15)"" stroke=""#FCE130"" stroke-width=""2"" />
                </svg>
            </div>
        </div>
    </div>

    <div id=""button-field"">

    </div>


</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f883e15db194f5dd08ff50abf68e5b90270e547314459", async() => {
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
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
