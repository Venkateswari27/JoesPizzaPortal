#pragma checksum "D:\git\Joes_Pizza_System\Joes_Pizza_Shop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29f8795c296256f99730e593d2622909bbb3f8e1"
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
#line 1 "D:\git\Joes_Pizza_System\Joes_Pizza_Shop\Views\_ViewImports.cshtml"
using Joes_Pizza_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\git\Joes_Pizza_System\Joes_Pizza_Shop\Views\_ViewImports.cshtml"
using Joes_Pizza_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f8795c296256f99730e593d2622909bbb3f8e1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea82c73f70be642baf902288224ace454a8a345", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("static-layout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\git\Joes_Pizza_System\Joes_Pizza_Shop\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29f8795c296256f99730e593d2622909bbb3f8e14513", async() => {
                WriteLiteral("\n    <title>Joe\'s Pizza</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29f8795c296256f99730e593d2622909bbb3f8e15508", async() => {
                WriteLiteral(@"

    <div class=""boxed-page"">
        <div class=""hero"">
            <div class=""container"">
                <div class=""row d-flex align-items-center"">
                    <div class=""col-lg-6 hero-left"">
                        <h1 class=""display-4 mb-5"">We Love <br>Delicious Foods!</h1>
                        <div class=""mb-2"">
                            <a class=""btn btn-primary btn-shadow btn-lg"" href=""/Home/Menu"" role=""button"">Explore Menu</a>
                        </div>

                        <ul class=""hero-info list-unstyled d-flex text-center mb-0"">
                            <li class=""border-right"">
                                <span class=""lnr lnr-rocket""></span>
                                <h5>
                                    Fast Delivery
                                </h5>
                            </li>
                            <li class=""border-right"">
                                <span class=""lnr lnr-leaf""></span>
                                <h5>
          ");
                WriteLiteral("                          Fresh Food\n                                </h5>\n                            </li>\n                            <li");
                BeginWriteAttribute("class", " class=\"", 1365, "\"", 1373, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <span class=""lnr lnr-bubble""></span>
                                <h5>
                                    24/7 Support
                                </h5>
                            </li>
                        </ul>

                    </div>
                    <div class=""col-lg-6 hero-right"">
                        <div class=""owl-carousel owl-theme hero-carousel"">
                            <div class=""item"">
                                <img class=""img-fluid"" src=""/img/pizza-1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 1914, "\"", 1920, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                            </div>\n                            <div class=\"item\">\n                                <img class=\"img-fluid\" src=\"/img/pizza-2.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2082, "\"", 2088, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                            </div>\n                            <div class=\"item\">\n                                <img class=\"img-fluid\" src=\"/img/pizza-3.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2250, "\"", 2256, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>		<!-- About Section -->
        <section id=""gtco-about"" class=""bg-white section-padding mt-5 mb-5"">
            <div class=""container"">
                <div class=""section-content"">
                    <div class=""row"">
                        <div class=""col-sm-5 img-bg d-flex shadow align-items-center justify-content-center justify-content-md-end img-2"" style=""background-image: url(/img/pizza-2.jpg);"">
                        </div>
                        <div class=""col-sm-7 py-5 pl-md-0 pl-4"">
                            <div class=""heading-section pl-lg-5 ml-md-5"">
                                <span class=""subheading"">
                                    About
                                </span>
                                <h2>
                                    Welcome to Joe's Pizza
                                </h2>
                   ");
                WriteLiteral(@"         </div>
                            <div class=""pl-lg-5 ml-md-5"">
                                <p>
                                    It attracts with its original interior but above all the quality of the dishes served. Carefully prepared dishes are characterized by freshness and a lot of ingredients. Visit us and discover the world of unparalleled flavors. The atmospheric interior will allow you to relax and fully reflect the delicious taste of our dishes.
                                </p>                               
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End of About Section -->		<!-- Special Dishes Section -->
        <section id=""gtco-special-dishes"" class=""bg-grey section-padding"">
            <div class=""container"">
                <div class=""section-content"">
                    <div class=""heading-section text-center"">
                        <span class=""");
                WriteLiteral(@"subheading"">
                            Specialties
                        </span>
                        <h2>
                            Special Dishes
                        </h2>
                    </div>
                    <div class=""row mt-5"" id=""first-meal"">
                        <div class=""col-lg-5 col-md-6 align-self-center py-5"">
                            <h2 class=""special-number"">01.</h2>
                            <div class=""dishes-text"">
                                <h3><span>Chicken</span><br> Mushrooms</h3>
                                <p class=""pt-3"">Baked Chicken breast, Mushrooms, Mozzarella Cheese, American Cheese & Dynamite Sauce.</p>
                                <h3 class=""special-dishes-price"">$ 15.99</h3>
                                <a href=""#"" class=""btn-primary mt-3"">Order Now</a>
                            </div>
                        </div>
                        <div class=""col-lg-5 offset-lg-2 col-md-6 align-self-center mt-4 mt-md-0"">
              ");
                WriteLiteral("              <img src=\"/PizzaImages/Chicken Mushrooms.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 5388, "\"", 5394, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid shadow w-100"">
                        </div>
                    </div>
                    <div class=""row mt-5"" id=""second-meal"">
                        <div class=""col-lg-5 col-md-6 align-self-center order-2 order-md-1 mt-4 mt-md-0"">
                            <img src=""/PizzaImages/Veggie.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5714, "\"", 5720, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid shadow w-100"">
                        </div>
                        <div class=""col-lg-5 offset-lg-2 col-md-6 align-self-center order-1 order-md-2 py-5"">
                            <h2 class=""special-number"">02.</h2>
                            <div class=""dishes-text"">
                                <h3><span>Veggie</span><br> Pizza</h3>
                                <p class=""pt-3"">Red Peppers, Onions, Mushrooms, Black Olives, basil, Mozzarella & Signature Tomato Sauce.</p>
                                <h3 class=""special-dishes-price"">$ 14.99</h3>
                                <a href=""#"" class=""btn-primary mt-3"">Order Now <span><i class=""fa fa-long-arrow-right""></i></span></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End of Special Dishes Section -->		
   </div> 
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
