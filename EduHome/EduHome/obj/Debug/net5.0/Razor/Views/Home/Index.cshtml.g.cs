#pragma checksum "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e8f48afaa2e6923dafdf6faa6ce4d19dd856aa565ccc6f4ec1c4775f7f1f340c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e8f48afaa2e6923dafdf6faa6ce4d19dd856aa565ccc6f4ec1c4775f7f1f340c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"715aff8afd0b78c8c85bfce44101158d535d8404c5188b985fc202944599b1d8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("section-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/event/event1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/event/event3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/event/event2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!-- Background Area Start -->\r\n<section id=\"slider-container\" class=\"slider-area two\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n");
#nullable restore
#line 10 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
         foreach (Slider slider in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Start Slingle Slide -->\r\n            <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 352, "\"", 410, 4);
            WriteAttributeValue("", 360, "background-image:", 360, 17, true);
            WriteAttributeValue(" ", 377, "url(../img/slider/", 378, 19, true);
#nullable restore
#line 13 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
WriteAttributeValue("", 396, slider.Image, 396, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 409, ")", 409, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-10 col-md-offset-1"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content text-center"">
                                        <h2>");
#nullable restore
#line 21 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
                                       Write(slider.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                                        <p>");
#nullable restore
#line 22 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
                                      Write(slider.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                        <a class=""default-btn"" href=""about.html"">Learn more</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Slider Content -->
            </div>
            <!-- End Slingle Slide -->
");
#nullable restore
#line 33 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- Background Area End -->\r\n<!-- Service Start -->\r\n<div class=\"service-area two pt-150 pb-150\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 41 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
             foreach (Service service in Model.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-service\">\r\n                        <h3><a href=\"teacher.html\">");
#nullable restore
#line 45 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
                                              Write(service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                        <p>");
#nullable restore
#line 46 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
                      Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 49 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<!-- Service End -->\r\n<!-- About Start -->\r\n");
#nullable restore
#line 56 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("About"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- About End -->
<!-- Courses Area Start -->
<div class=""courses-area two pt-150 pb-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section1.png"" alt=""section-title"">
                    <h2>COURSES WE OFFER</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 71 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
          foreach (Course course in Model.Courses)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                    <div class=\"single-course\">\r\n                        <div class=\"course-img\">\r\n                            <a href=\"course-details.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2822, "\"", 2852, 2);
            WriteAttributeValue("", 2828, "img/course/", 2828, 11, true);
#nullable restore
#line 77 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
WriteAttributeValue("", 2839, course.Image, 2839, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""course"">
                                <div class=""course-hover"">
                                    <i class=""fa fa-link""></i>
                                </div>
                            </a>
                        </div>
                        <div class=""course-content"">
                            <h3><a href=""course-details.html"">");
#nullable restore
#line 84 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
                                                         Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p>");
#nullable restore
#line 85 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
                          Write(course.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a class=\"default-btn\" href=\"course-details.html\">read more</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 90 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          
        </div>
    </div>
</div>
<!-- Courses Area End -->
<!-- Notice Start -->
<section class=""notice-area two pt-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video"">
                        <div class=""video-icon video-hover"">
                            <a class=""video-popup"" href=""https://www.youtube.com/watch?v=to6Ghf8UL7o"">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
                        <div class=""single-notice");
            WriteLiteral(@"-left mb-23 pb-20"">
                            <h4>5, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                            <h4>4, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left pb-70"">
                            <h4>3, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left mb-23 pb-20"">
                            <h4>5, June 20");
            WriteLiteral(@"17</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left hidden-sm mb-23 pb-20"">
                            <h4>4, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                        <div class=""single-notice-left pb-70"">
                            <h4>3, June 2017</h4>
                            <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->
<!-- Event Area Start -->
<div class=""eve");
            WriteLiteral("nt-area two text-center pt-100 pb-145\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-xs-12\">\r\n                <div class=\"section-title\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8f48afaa2e6923dafdf6faa6ce4d19dd856aa565ccc6f4ec1c4775f7f1f340c16726", async() => {
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
            WriteLiteral(@"
                    <h2>UPCOMMING EVENTS</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-sm-12 col-xs-12"">
                <div class=""single-event mb-35"">
                    <div class=""event-img"">
                        <a href=""event-details.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8f48afaa2e6923dafdf6faa6ce4d19dd856aa565ccc6f4ec1c4775f7f1f340c18212", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                    </div>
                    <div class=""event-content text-left"">
                        <h3>20 June 2017</h3>
                        <h4><a href=""event-details.html"">ADVANCE PHP WORKSHOP</a></h4>
                        <ul>
                            <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                            <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event hidden-sm hidden-xs"">
                    <div class=""event-img"">
                        <a href=""event-details.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8f48afaa2e6923dafdf6faa6ce4d19dd856aa565ccc6f4ec1c4775f7f1f340c20223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                    </div>
                    <div class=""event-content text-left"">
                        <h3>16 June 2017</h3>
                        <h4><a href=""event-details.html"">learning english history</a></h4>
                        <ul>
                            <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                            <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-12 col-xs-12"">
                <div class=""single-event mb-35"">
                    <div class=""event-img"">
                        <a href=""event-details.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8f48afaa2e6923dafdf6faa6ce4d19dd856aa565ccc6f4ec1c4775f7f1f340c22302", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                    </div>
                    <div class=""event-content text-left"">
                        <h3>18 June 2017</h3>
                        <h4><a href=""event-details.html"">DIGITAL MARKETING ANALYSIS</a></h4>
                        <ul>
                            <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                            <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event hidden-sm hidden-xs"">
                    <div class=""event-img"">
                        <a href=""event-details.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8f48afaa2e6923dafdf6faa6ce4d19dd856aa565ccc6f4ec1c4775f7f1f340c24319", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                    </div>
                    <div class=""event-content text-left"">
                        <h3>14 June 2017</h3>
                        <h4><a href=""event-details.html"">UI & UX DESIGNER MEETUP</a></h4>
                        <ul>
                            <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                            <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Event Area End -->
<!-- Testimonial Area Start -->
");
#nullable restore
#line 232 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Feedback"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Testimonial Area End -->
<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8f48afaa2e6923dafdf6faa6ce4d19dd856aa565ccc6f4ec1c4775f7f1f340c26800", async() => {
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
            WriteLiteral("\r\n                    <h2>LATEST FROM BLOG</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 246 "C:\Users\elsha\OneDrive\Desktop\EduHome\EduHome\EduHome\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Blogs",new {take=3}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog Area End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
