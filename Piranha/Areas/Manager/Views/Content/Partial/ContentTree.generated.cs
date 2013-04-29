﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Content.Partial
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Content/Partial/ContentTree.cshtml")]
    public partial class ContentTree : System.Web.Mvc.WebViewPage<List<Piranha.Models.Content>>
    {
        public ContentTree()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
 foreach (var content in Model) {

            
            #line default
            #line hidden
WriteLiteral("    <li");

WriteAttribute("class", Tuple.Create(" class=\"", 79), Tuple.Create("\"", 200)
            
            #line 3 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
, Tuple.Create(Tuple.Create("", 87), Tuple.Create<System.Object, System.Int32>(content.ChildContent.Count > 0 ? (content.HasChild(ViewBag.Expanded) ? "expanded" : "collapsed") : "collapsed"
            
            #line default
            #line hidden
, 87), false)
);

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"buttons\"");

WriteLiteral(">\r\n");

            
            #line 5 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
            
            
            #line default
            #line hidden
            
            #line 5 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
             if (content.IsFolder) {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 288), Tuple.Create("\"", 352)
            
            #line 6 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
, Tuple.Create(Tuple.Create("", 295), Tuple.Create<System.Object, System.Int32>(Url.Action("insert", "content", new { id = content.Id })
            
            #line default
            #line hidden
, 295), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 353), Tuple.Create("\"", 397)
            
            #line 6 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
        , Tuple.Create(Tuple.Create("", 361), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Global.ToolbarAdd
            
            #line default
            #line hidden
, 361), false)
);

WriteLiteral(" class=\"icon add marg\"");

WriteLiteral("></a>\r\n");

WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 441), Tuple.Create("\"", 511)
            
            #line 7 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
, Tuple.Create(Tuple.Create("", 448), Tuple.Create<System.Object, System.Int32>(Url.Action("insertfolder", "content", new { id = content.Id })
            
            #line default
            #line hidden
, 448), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 512), Tuple.Create("\"", 563)
            
            #line 7 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
              , Tuple.Create(Tuple.Create("", 520), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Content.ToolbarAddFolder
            
            #line default
            #line hidden
, 520), false)
);

WriteLiteral(" class=\"icon add-folder marg\"");

WriteLiteral("></a>\r\n");

            
            #line 8 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 9 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
             if (content.ChildContent.Count == 0 && User.HasAccess("ADMIN_CONTENT_PUBLISH")) {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 725), Tuple.Create("\"", 789)
            
            #line 10 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
, Tuple.Create(Tuple.Create("", 732), Tuple.Create<System.Object, System.Int32>(Url.Action("delete", "content", new { id = content.Id })
            
            #line default
            #line hidden
, 732), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 790), Tuple.Create("\"", 835)
            
            #line 10 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
        , Tuple.Create(Tuple.Create("", 798), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Content.ListDelete
            
            #line default
            #line hidden
, 798), false)
);

WriteAttribute("class", Tuple.Create(" \r\n                class=\"", 836), Tuple.Create("\"", 951)
, Tuple.Create(Tuple.Create("", 862), Tuple.Create("icon", 862), true)
, Tuple.Create(Tuple.Create(" ", 866), Tuple.Create("delete", 867), true)
            
            #line 11 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
, Tuple.Create(Tuple.Create(" ", 873), Tuple.Create<System.Object, System.Int32>(content.IsImage ? "media-image" : (content.IsFolder ? "media-folder" : "")
            
            #line default
            #line hidden
, 874), false)
);

WriteLiteral("></a>\r\n");

            
            #line 12 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </span>\r\n        <span");

WriteLiteral(" class=\"date\"");

WriteLiteral(">");

            
            #line 14 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
                      Write(content.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span");

WriteLiteral(" class=\"date\"");

WriteLiteral(">");

            
            #line 15 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
                      Write(content.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span");

WriteLiteral(" class=\"title\"");

WriteLiteral(">");

            
            #line 16 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
                             if (content.ChildContent.Count > 0) {
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"action\"");

WriteLiteral("></span>");

            
            #line 16 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
                                                                                              }
            
            #line default
            #line hidden
WriteLiteral("<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1238), Tuple.Create("\"", 1300)
            
            #line 16 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
                        , Tuple.Create(Tuple.Create("", 1245), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", "content", new { id = content.Id })
            
            #line default
            #line hidden
, 1245), false)
);

WriteLiteral(">\r\n            <img");

WriteLiteral(" class=\"thumb\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1334), Tuple.Create("\"", 1376)
            
            #line 17 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
, Tuple.Create(Tuple.Create("", 1340), Tuple.Create<System.Object, System.Int32>(Url.GetThumbnailUrl(content.Id, 32)
            
            #line default
            #line hidden
, 1340), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1377), Tuple.Create("\"", 1405)
            
            #line 17 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
, Tuple.Create(Tuple.Create("", 1383), Tuple.Create<System.Object, System.Int32>(content.AlternateText
            
            #line default
            #line hidden
, 1383), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("            ");

            
            #line 18 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
       Write(content.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"list-info\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
           Write(Html.Raw(content.LastPublished == DateTime.MinValue ? "<span class=info-unpublished></span>" : (content.Updated > content.LastPublished ? "<span class=info-draft></span>" : "")));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div></a></span>\r\n");

            
            #line 22 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
        
            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
         if (content.ChildContent.Count > 0) {

            
            #line default
            #line hidden
WriteLiteral("        <ul>\r\n");

WriteLiteral("            ");

            
            #line 24 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
       Write(Html.Partial("Partial/ContentTree", content.ChildContent));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </ul>\r\n");

            
            #line 26 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </li>\r\n");

            
            #line 28 "..\..\Areas\Manager\Views\Content\Partial\ContentTree.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
