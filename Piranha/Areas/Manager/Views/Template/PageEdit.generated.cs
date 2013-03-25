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

namespace Piranha.Areas.Manager.Views.Template
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Template/PageEdit.cshtml")]
    public partial class PageEdit : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.TemplateModels.PageEditModel>
    {
        public PageEdit()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
  
    ViewBag.Selected = "Settings" ;
    ViewBag.SelectedTab = "PageType" ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 195), Tuple.Create("\"", 277)
            
            #line 7 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 201), Tuple.Create<System.Object, System.Int32>(Url.Content("~/r.ashx/piranha/areas/manager/content/js/jquery.template.js")
            
            #line default
            #line hidden
, 201), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 324), Tuple.Create("\"", 412)
            
            #line 8 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 330), Tuple.Create<System.Object, System.Int32>(Url.Content("~/r.ashx/piranha/areas/manager/content/js/jquery.regiontemplate.js")
            
            #line default
            #line hidden
, 330), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 459), Tuple.Create("\"", 535)
            
            #line 9 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 465), Tuple.Create<System.Object, System.Int32>(Url.Content("~/r.ashx/piranha/areas/manager/content/js/ext/json2.js")
            
            #line default
            #line hidden
, 465), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        /**\r\n         * This var is needed by the regiontemplate script.\r\n    " +
"     */\r\n        var templateid = \'");

            
            #line 14 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                     Write(Model.Template.Id);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n    </script>\r\n");

});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 18 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
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

            
            #line 22 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 956), Tuple.Create("\"", 1020)
            
            #line 23 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 963), Tuple.Create<System.Object, System.Int32>(Url.Action("deletepage", new { id = Model.Template.Id })
            
            #line default
            #line hidden
, 963), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(" title=\"\"");

WriteLiteral(">");

            
            #line 23 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                                                       Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1114), Tuple.Create("\"", 1144)
            
            #line 24 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1121), Tuple.Create<System.Object, System.Int32>(Url.Action("pagelist")
            
            #line default
            #line hidden
, 1121), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 24 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                          Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1225), Tuple.Create("\"", 1283)
            
            #line 25 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1232), Tuple.Create<System.Object, System.Int32>(Url.Action("page", new { id = Model.Template.Id })
            
            #line default
            #line hidden
, 1232), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 25 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                                         Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

WriteLiteral("\r\n");

            
            #line 32 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
   Html.BeginForm("page", "template") ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 34 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 35 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.IsNew));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 36 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.IsSiteTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 37 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Created));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Updated));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 39 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.CreatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 40 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.UpdatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" class=\"grid_9\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box expandable\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 44 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>");

            
            #line 47 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 49 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 50 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>");

            
            #line 52 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 54 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextAreaFor(m => m.Template.Description, 
                            new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n            <ul");

WriteLiteral(" class=\"form optional\"");

WriteLiteral(">               \r\n                <li>");

            
            #line 59 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Preview));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 61 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextAreaFor(m => m.Template.Preview, new { @rows = 8} ));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>                \r\n            </ul>\r\n        </div>\r" +
"\n    </div>\r\n    <div");

WriteLiteral(" class=\"box content-editor\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 67 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Regions);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" class=\"list region-editor\"");

WriteLiteral(">\r\n                <tbody>\r\n                    <tr>\r\n                        <th" +
">");

            
            #line 72 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th>");

            
            #line 73 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                       Write(Piranha.Resources.Global.InternalId);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th>");

            
            #line 74 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                       Write(Piranha.Resources.Global.Type);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n");

WriteLiteral("                    ");

            
            #line 77 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.EditorFor(m => m.Regions));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <tr");

WriteLiteral(" class=\"dark\"");

WriteLiteral(">\r\n                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionName\"");

WriteLiteral(" /></div>\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionInternalId\"");

WriteLiteral(" /></div>\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 89 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                           Write(Html.DropDownList("newregionType",
                                    new SelectList(Model.RegionTypes, "Type", "Name")));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"buttons four\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" id=\"btnAddRegion\"");

WriteLiteral(" class=\"btn marg-big\"");

WriteLiteral(">");

            
            #line 93 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                                                      Write(Piranha.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </td>\r\n                    </tr>\r\n            " +
"    </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 101 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Advanced);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>");

            
            #line 104 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Controller));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"right\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 106 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.CheckBoxFor(m => m.Template.ShowController));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"input short\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 108 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Controller, 
                            new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n                <li>");

            
            #line 111 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Redirect));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"right\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 113 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.CheckBoxFor(m => m.Template.ShowRedirect));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"input short\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 115 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Redirect, 
                            new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</d" +
"iv>\r\n<div");

WriteLiteral(" class=\"grid_3\"");

WriteLiteral(">\r\n");

            
            #line 123 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 123 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
     if (!Model.Template.IsNew && !String.IsNullOrEmpty(Model.Template.Preview.ToHtmlString())) {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"box pagetemplate\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 125 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Page.HtmlPreview);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"edit\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 128 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
           Write(Model.Template.Preview);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 132 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 134 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                          Write(Piranha.Resources.Global.Properties);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"region_data\"");

WriteLiteral("></div>\r\n            <ul");

WriteLiteral(" id=\"properties\"");

WriteLiteral(" class=\"list buttons\"");

WriteLiteral(">\r\n");

            
            #line 138 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 138 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                 foreach (var property in Model.Template.Properties) {

            
            #line default
            #line hidden
WriteLiteral("                <li><span>");

            
            #line 139 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                     Write(property);

            
            #line default
            #line hidden
WriteLiteral("</span><button");

WriteLiteral(" class=\"btn delete right remove-region\"");

WriteLiteral("></button></li>\r\n");

            
            #line 140 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" id=\"po_name\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 6482), Tuple.Create("\"", 6543)
            
            #line 143 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
, Tuple.Create(Tuple.Create("", 6496), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Template.PropertyPlaceholder
            
            #line default
            #line hidden
, 6496), false)
);

WriteLiteral(" /></div>\r\n            <button");

WriteLiteral(" id=\"po_add\"");

WriteLiteral(" class=\"btn right\"");

WriteLiteral(">");

            
            #line 144 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
                                             Write(Piranha.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n         </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 149 "..\..\Areas\Manager\Views\Template\PageEdit.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
