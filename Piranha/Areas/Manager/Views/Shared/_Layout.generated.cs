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

namespace Piranha.Areas.Manager.Views.Shared
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Shared/_Layout.cshtml")]
    public partial class Layout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Layout()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"content-type\"");

WriteLiteral(" content=\"text/html; charset=utf-8\"");

WriteLiteral("/>\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0\"");

WriteLiteral(">\r\n    <title>");

            
            #line 6 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 248), Tuple.Create("\"", 300)
, Tuple.Create(Tuple.Create("", 255), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/img/icon.ico")
, 255), false)
);

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(">\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 344), Tuple.Create("\"", 396)
, Tuple.Create(Tuple.Create("", 351), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/img/icon.ico")
, 351), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral("> \r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 450), Tuple.Create("\"", 512)
, Tuple.Create(Tuple.Create("", 457), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/css/ext/chosen.min.css")
, 457), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral("/>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 559), Tuple.Create("\"", 637)
, Tuple.Create(Tuple.Create("", 566), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/css/ext/jquery-ui-1.9.2.custom.min.css")
, 566), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 685), Tuple.Create("\"", 742)
, Tuple.Create(Tuple.Create("", 692), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/css/style.min.css")
, 692), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral("/>\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 816), Tuple.Create("\"", 881)
, Tuple.Create(Tuple.Create("", 822), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/ext/jquery-1.7.2.min.js")
, 822), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 928), Tuple.Create("\"", 987)
, Tuple.Create(Tuple.Create("", 934), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/jquery.manager.js")
, 934), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1034), Tuple.Create("\"", 1100)
, Tuple.Create(Tuple.Create("", 1040), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/ext/chosen.jquery.min.js")
, 1040), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var siteroot = \"");

            
            #line 18 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
                   Write(Url.Content("~/"));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n        var apikey = \"");

            
            #line 19 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
                 Write(Html.APIKey("FE868D4F-797C-4E60-B876-64E6FC2424AA"));

            
            #line default
            #line hidden
WriteLiteral(@""";
        siteroot += !siteroot.endsWith(""/"") ? ""/"" : """";

        $(document).ready(function () {
            $("".message"").click(function () { $(this).fadeOut(""medium""); });

            $("".chzn-select"").chosen().trigger(""liszt:updated"");
        });
    </script>
");

            
            #line 28 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
     if (!String.IsNullOrEmpty(ViewBag.Message)) {

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        setTimeout(function () {\r\n            $(\".sys-message\").slideUp();\r\n  " +
"      }, 2000);\r\n    </script>\r\n");

            
            #line 34 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 35 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
Write(RenderSection("Head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"top\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container_12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"grid_12 header\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"home\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1938), Tuple.Create("\"", 1973)
            
            #line 41 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 1945), Tuple.Create<System.Object, System.Int32>(Url.Action("index", "page")
            
            #line default
            #line hidden
, 1945), false)
);

WriteLiteral(">\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2001), Tuple.Create("\"", 2052)
, Tuple.Create(Tuple.Create("", 2007), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/img/logo.png")
, 2007), false)
);

WriteLiteral(" alt=\"Piranha CMS\"");

WriteLiteral(" /></a>\r\n                <a");

WriteLiteral(" class=\"public-site\"");

WriteLiteral(" target=\"preview\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2135), Tuple.Create("\"", 2183)
            
            #line 43 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2142), Tuple.Create<System.Object, System.Int32>(Piranha.WebPages.WebPiranha.GetSiteUrl()
            
            #line default
            #line hidden
, 2142), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
               Write(Piranha.WebPages.WebPiranha.GetSiteUrl());

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("                ");

            
            #line 45 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
           Write(Html.Partial("Partial/Menu"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container_12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral("><h1>");

            
            #line 51 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
                                Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1></div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"body\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container_12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"grid_12 toolbar-container\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 57 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
           Write(RenderSection("Toolbar", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 59 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
             if (!String.IsNullOrEmpty(ViewBag.Message)) {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"grid_12 sys-message\"");

WriteLiteral(">\r\n                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2812), Tuple.Create("\"", 2899)
, Tuple.Create(Tuple.Create("", 2820), Tuple.Create("box", 2820), true)
            
            #line 61 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2823), Tuple.Create<System.Object, System.Int32>(!String.IsNullOrEmpty(ViewBag.MessageCss) ? " " + ViewBag.MessageCss : ""
            
            #line default
            #line hidden
, 2823), false)
);

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"ico\"");

WriteLiteral("></div><p>");

            
            #line 63 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
                                             Write(ViewBag.Message);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 67 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"content left\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 69 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"boxSysMsg\"");

WriteLiteral(" class=\"floatbox\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bg\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2");

WriteLiteral(" id=\"SysMsgTitle\"");

WriteLiteral("></h2></div>\r\n            <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" id=\"SysMsgBody\"");

WriteLiteral("></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"boxDialog\"");

WriteLiteral(" class=\"floatbox\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bg\"");

WriteLiteral(" style=\"background-color: transparent\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(" style=\"min-width: 510px;min-height:260px;\"");

WriteLiteral(">\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 87 "..\..\Areas\Manager\Views\Shared\_Layout.cshtml"
Write(RenderSection("Foot", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
