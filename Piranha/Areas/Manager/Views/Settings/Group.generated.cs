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

namespace Piranha.Areas.Manager.Views.Settings
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Settings/Group.cshtml")]
    public partial class Group : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.SettingModels.GroupEditModel>
    {
        public Group()
        {
        }
        public override void Execute()
        {
DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(document).ready(function () {\r\n            $(\'#Group_Name\').focus();" +
"\r\n        });\r\n    </script>\r\n");

});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 10 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
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

            
            #line 14 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 443), Tuple.Create("\"", 505)
            
            #line 15 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
, Tuple.Create(Tuple.Create("", 450), Tuple.Create<System.Object, System.Int32>(Url.Action("deletegroup", new { id = Model.Group.Id })
            
            #line default
            #line hidden
, 450), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(">");

            
            #line 15 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                                                                                            Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 590), Tuple.Create("\"", 621)
            
            #line 16 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
, Tuple.Create(Tuple.Create("", 597), Tuple.Create<System.Object, System.Int32>(Url.Action("grouplist")
            
            #line default
            #line hidden
, 597), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 16 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                                                           Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 702), Tuple.Create("\"", 758)
            
            #line 17 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
, Tuple.Create(Tuple.Create("", 709), Tuple.Create<System.Object, System.Int32>(Url.Action("group", new { id = Model.Group.Id })
            
            #line default
            #line hidden
, 709), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 17 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                                                                                       Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

            
            #line 23 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
   Html.BeginForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 24 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
Write(Html.HiddenFor(m => m.Group.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 25 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
Write(Html.HiddenFor(m => m.Group.IsNew));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 26 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
Write(Html.HiddenFor(m => m.Group.Created));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid_9\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 29 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
               Write(Html.LabelFor(m => m.Group.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                   Write(Html.TextBoxFor(m => m.Group.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 36 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
               Write(Html.ValidationMessageFor(m => m.Group.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 39 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
               Write(Html.LabelFor(m => m.Group.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 41 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                   Write(Html.TextAreaFor(m => m.Group.Description, 
                            new { @rows = 3, @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 45 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
               Write(Html.LabelFor(m => m.Group.ParentId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 47 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                   Write(Html.DropDownListFor(m => m.Group.ParentId, Model.Groups));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</d" +
"iv>\r\n<div");

WriteLiteral(" class=\"grid_3\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 55 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                          Write(Piranha.Resources.Settings.GroupMembers);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n");

            
            #line 57 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
            
            
            #line default
            #line hidden
            
            #line 57 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
             if (!Model.Group.IsNew) {

            
            #line default
            #line hidden
WriteLiteral("            <ul");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n");

            
            #line 59 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                
            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                 foreach (var user in Model.Members) {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2414), Tuple.Create("\"", 2462)
            
            #line 60 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
, Tuple.Create(Tuple.Create("", 2421), Tuple.Create<System.Object, System.Int32>(Url.Action("user", new { id = user.Id })
            
            #line default
            #line hidden
, 2421), false)
);

WriteLiteral(">");

            
            #line 60 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                                                                    Write(!String.IsNullOrEmpty(user.Name) ? user.Name : user.Login);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 61 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n");

            
            #line 63 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
            } else {

            
            #line default
            #line hidden
WriteLiteral("                <p><em>");

            
            #line 64 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
                  Write(Piranha.Resources.Settings.GroupMembersNew);

            
            #line default
            #line hidden
WriteLiteral("</em></p>\r\n");

            
            #line 65 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 69 "..\..\Areas\Manager\Views\Settings\Group.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
