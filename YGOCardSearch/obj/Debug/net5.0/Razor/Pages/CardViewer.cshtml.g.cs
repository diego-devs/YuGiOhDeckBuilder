#pragma checksum "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27e7dc599c0680c5406ddc6005338672c02a0cbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(YGOCardSearch.Pages.Pages_CardViewer), @"mvc.1.0.razor-page", @"/Pages/CardViewer.cshtml")]
namespace YGOCardSearch.Pages
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
#line 1 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\_ViewImports.cshtml"
using YGOCardSearch;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27e7dc599c0680c5406ddc6005338672c02a0cbc", @"/Pages/CardViewer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b504ec1f8bf0c6550099d3b3d7f7ea17bb99249", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_CardViewer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
  
    ViewData["Title"] = "CardViewer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card mb-3\" style=\"max-width: auto;\">\r\n    <div class=\"row no-gutters\">\r\n        <div class=\"col-md-4\">  \r\n            <div class=\"inner\"><img");
            BeginWriteAttribute("src", " src=\"", 254, "\"", 294, 1);
#nullable restore
#line 11 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
WriteAttributeValue("", 260, Model.Card.CardImages[0].ImageUrl, 260, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img"" alt=""imagehere""></div>
                
        </div>
        <div class=""col-md-8"">
            <div class=""card-body""> 
                <table class=""table table-dark table"">
                    <tr>
                        <td>
                            <p class=""card-text"">");
#nullable restore
#line 19 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                            Write(Model.Card.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </td>\r\n                        <td>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                            Write(Model.Card.Attribute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </td>\r\n                        <td>\r\n                            <p class=\"text-white\">");
#nullable restore
#line 25 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                             Write(Model.Card.Race);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </td>\r\n\r\n                    </tr>\r\n                </table>\r\n                <h5 class=\"card-title text-center\">");
#nullable restore
#line 30 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                              Write(Model.Card.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                \r\n                <p class=\"card-text\">");
#nullable restore
#line 32 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                Write(Model.Card.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\"><small class=\"text-muted\">$ ");
#nullable restore
#line 33 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                                            Write(Model.Card.CardPrices[0].TcgplayerPrice.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD</small></p>\r\n                <div class=\"card\">\r\n");
#nullable restore
#line 35 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                      
                        foreach (var set in Model.Card.CardSets)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card mb-4\" style=\"max-width: auto;\">\r\n                                <div class=\"row d-table-row\">\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 40 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                                    Write(set.SetName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 41 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                                    Write(set.SetRarity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 42 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                                    Write(set.SetPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 46 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                           
                        }

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"flex-xl-row\">Card Id: ");
#nullable restore
#line 51 "C:\Users\d_dia\source\repos\YuGiOhTCG\YGOCardSearch\Pages\CardViewer.cshtml"
                                             Write(Model.Card.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n               \r\n                \r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YGOCardSearch.Pages.CardViewerModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YGOCardSearch.Pages.CardViewerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YGOCardSearch.Pages.CardViewerModel>)PageContext?.ViewData;
        public YGOCardSearch.Pages.CardViewerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
