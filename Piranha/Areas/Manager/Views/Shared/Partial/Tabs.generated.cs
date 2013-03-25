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

namespace Piranha.Areas.Manager.Views.Shared.Partial
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
    
    #line 1 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
    using Piranha.WebPages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Shared/Partial/Tabs.cshtml")]
    public partial class Tabs : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Tabs()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
  
    IList<Manager.MenuItem> items = null ;
    
    foreach (var group in Manager.Menu) {
        if (group.IsActive()) {
            items = group.ItemsForUser() ;
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
 if (items != null) {

            
            #line default
            #line hidden
WriteLiteral("<ul");

WriteLiteral(" class=\"tabs\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
     foreach (var item in items) {

            
            #line default
            #line hidden
WriteLiteral("    <li><a");

            
            #line 14 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
      Write(item.IsActive() ? " class=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(" href=\"");

            
            #line 14 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
                                                       Write(Url.Action(item.Action, item.Controller, new { @id = "" }));

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 14 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
                                                                                                                    Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 15 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n");

            
            #line 18 "..\..\Areas\Manager\Views\Shared\Partial\Tabs.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
