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

namespace Piranha.Areas.Manager.Views.Category
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Category/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.CategoryModels.EditModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 3 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteLiteral(" class=\"save submit\"");

WriteLiteral(">");

            
            #line 7 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 274), Tuple.Create("\"", 334)
            
            #line 8 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 281), Tuple.Create<System.Object, System.Int32>(Url.Action("delete", new { id = Model.Category.Id })
            
            #line default
            #line hidden
, 281), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(">");

            
            #line 8 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                                                                                          Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 419), Tuple.Create("\"", 458)
            
            #line 9 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 426), Tuple.Create<System.Object, System.Int32>(Url.Action("index", "category")
            
            #line default
            #line hidden
, 426), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 9 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                                                                   Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 539), Tuple.Create("\"", 597)
            
            #line 10 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 546), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", new { id = Model.Category.Id })
            
            #line default
            #line hidden
, 546), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 10 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                                                                                         Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

            
            #line 16 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
   Html.BeginForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Category.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 18 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Category.PermalinkId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Category.IsNew));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 20 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Category.Created));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Category.CreatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 22 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.IsNew));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 23 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 24 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 25 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.Created));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 26 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.CreatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 29 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
               Write(Html.LabelFor(m => m.Category.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.Category.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 36 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Category.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li");

WriteLiteral(" class=\"protected\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 39 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
               Write(Html.LabelFor(m => m.Category.Permalink));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 40 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                	
            
            #line default
            #line hidden
            
            #line 40 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                  if (!Model.Category.IsNew) {

            
            #line default
            #line hidden
WriteLiteral("                    <p>");

            
            #line 41 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                  Write(Piranha.WebPages.WebPiranha.GetSiteUrl());

            
            #line default
            #line hidden
            
            #line 41 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                                                           Write(Url.GetPermalink(Model.Category.Permalink).ToLower());

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 42 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                    } else {

            
            #line default
            #line hidden
WriteLiteral("                    <p><i>");

            
            #line 43 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                     Write(Piranha.Resources.Category.PermalinkDescription);

            
            #line default
            #line hidden
WriteLiteral("</i></p>\r\n");

            
            #line 44 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 46 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.Permalink.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <a");

WriteLiteral(" class=\"locked\"");

WriteLiteral("></a>\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 50 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
               Write(Html.LabelFor(m => m.Category.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 52 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                   Write(Html.TextAreaFor(m => m.Category.Description));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 55 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
               Write(Html.LabelFor(m => m.Category.ParentId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 57 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                   Write(Html.DropDownListFor(m => m.Category.ParentId, Model.Categories));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n");

            
            #line 62 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 62 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
     if (Model.Extensions.Count > 0) {
        
            
            #line default
            #line hidden
            
            #line 63 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
   Write(Html.EditorFor(m => m.Extensions));

            
            #line default
            #line hidden
            
            #line 63 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
                                          
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 66 "..\..\Areas\Manager\Views\Category\Edit.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
