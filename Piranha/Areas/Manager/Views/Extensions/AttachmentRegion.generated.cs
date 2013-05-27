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

namespace Piranha.Areas.Manager.Views.Extensions
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Extensions/AttachmentRegion.cshtml")]
    public partial class AttachmentRegion : System.Web.Mvc.WebViewPage<Piranha.Extend.Regions.AttachmentRegion>
    {
        public AttachmentRegion()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
  
    Layout = "";
    
    var btnAttach = ViewData.TemplateInfo.GetFullHtmlFieldId("btnAttach") ;
    var tblId = ViewData.TemplateInfo.GetFullHtmlFieldId("tblAttachments") ;
    var boxId = ViewData.TemplateInfo.GetFullHtmlFieldId("box") ;
    var thumbUrl = Piranha.WebPages.WebPiranha.ApplicationPath + Piranha.Application.Current.Handlers.GetUrlPrefix("THUMBNAIL") + "/";

    var varObj = @ViewData.TemplateInfo.GetFullHtmlFieldId("obj") ;

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    var thumbpath = \'");

            
            #line 13 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                Write(Url.GetThumbnailBaseUrl());

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n    if (!extensions)\r\n        var extensions = {};\r\n    if (!extensions.");

            
            #line 17 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
               Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(")\r\n        extensions.");

            
            #line 18 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
              Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(" = {\r\n            count: ");

            
            #line 19 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
               Write(Model.Items.Count);

            
            #line default
            #line hidden
WriteLiteral(",\r\n            add: function(data) {\r\n                $(\'#");

            
            #line 21 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
               Write(tblId);

            
            #line default
            #line hidden
WriteLiteral("\').append(\r\n                    \'<tr>\' +\r\n                        \'<td>\' +\r\n     " +
"                       \'<input type=\"hidden\" name=\"");

            
            #line 24 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                                    Write(ViewData.TemplateInfo.HtmlFieldPrefix);

            
            #line default
            #line hidden
WriteLiteral(".Items[\' + extensions.");

            
            #line 24 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                                                                                                  Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".count + \'].Id\" value=\"\' + data.Id + \'\" />\' +\r\n                            \'<inpu" +
"t type=\"hidden\" name=\"");

            
            #line 25 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                                    Write(ViewData.TemplateInfo.HtmlFieldPrefix);

            
            #line default
            #line hidden
WriteLiteral(".Items[\' + extensions.");

            
            #line 25 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                                                                                                  Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".count + \'].Updated\" value=\"\' + data.Updated + \'\" />\' +\r\n                        " +
"    \'<input type=\"hidden\" name=\"");

            
            #line 26 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                                    Write(ViewData.TemplateInfo.HtmlFieldPrefix);

            
            #line default
            #line hidden
WriteLiteral(".Items[\' + extensions.");

            
            #line 26 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                                                                                                  Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".count + \'].DisplayName\" value=\"\' + data.DisplayName + \'\" />\' +\r\n                " +
"            \'<input type=\"hidden\" name=\"");

            
            #line 27 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                                    Write(ViewData.TemplateInfo.HtmlFieldPrefix);

            
            #line default
            #line hidden
WriteLiteral(".Items[\' + extensions.");

            
            #line 27 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                                                                                                  Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".count + \'].Type\" value=\"\' + data.Type + \'\" />\' +\r\n                            \'<" +
"img src=\"");

            
            #line 28 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                  Write(thumbUrl);

            
            #line default
            #line hidden
WriteLiteral(@"' + data.Id + '/50"" /></td>' +
                        '<td>' +
                            data.DisplayName +
                            '<div class=""list-info""></div></td>' +
                        '<td>' + data.Type + '</td>' +
                        '<td class=""buttons three"">' +
                            '<a class=""icon up marg""></a>' +
                            '<a class=""icon down marg""></a>' +
                            '<a class=""icon delete""></a></td>' +
                    '</tr>');

                extensions.");

            
            #line 39 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                       Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".count++;\r\n            },\r\n            delete: function(e) {\r\n                $(e" +
").remove();\r\n                extensions.");

            
            #line 43 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                       Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".updateSeqnos();\r\n            },\r\n            updateSeqnos: function() {\r\n       " +
"         var rows = $(\'#");

            
            #line 46 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                          Write(tblId);

            
            #line default
            #line hidden
WriteLiteral(@" tr') ;

                for (var n = 1; n < rows.length; n++) {
                    $(rows.get(n)).find('input, textarea').attr('id', function (i, val) {
                        if (val)
                            return val.replace(/Items_\d+/, 'Items_' + (n - 1));
                    });
                    $(rows.get(n)).find('input, textarea').attr('name', function (i, val) {
                        if (val)
                            return val.replace(/Items\[\d+/, 'Items[' + (n - 1));
                    });
                    $(rows.get(n)).find('label').attr('for', function (i, val) {
                        if (val)
                            return val.replace(/Items_\d+/, 'Items_' + (n -1));
                    });
                }
            },
            moveUp: function(e) {
                if (e.parent().children().index(e) > 1) {
                    e.insertBefore(e.prev());
                    extensions.");

            
            #line 66 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                           Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(@".updateSeqnos();
                }
            },
            moveDown: function(e) {
                if (e.parent().children().index(e) < e.parent().children().length - 1) {
                    e.insertAfter(e.next());
                    extensions.");

            
            #line 72 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                           Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".updateSeqnos();\r\n                }\r\n            }\r\n        };\r\n\r\n    $(document)" +
".ready(function () {\r\n        new piranha.media(\'");

            
            #line 78 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                      Write(btnAttach);

            
            #line default
            #line hidden
WriteLiteral("\', \'");

            
            #line 78 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                    Write(boxId);

            
            #line default
            #line hidden
WriteLiteral("\', extensions.");

            
            #line 78 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                                                         Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".add);\r\n\r\n        $(\'#");

            
            #line 80 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
       Write(tblId);

            
            #line default
            #line hidden
WriteLiteral(" .delete\').live(\'click\', function() {\r\n            extensions.");

            
            #line 81 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                   Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".delete($(this).parent().parent());\r\n            return false;\r\n        });\r\n    " +
"    $(\'#");

            
            #line 84 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
       Write(tblId);

            
            #line default
            #line hidden
WriteLiteral(" .up\').live(\'click\', function() {\r\n            extensions.");

            
            #line 85 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                   Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".moveUp($(this).parent().parent());\r\n            return false;\r\n        });\r\n    " +
"    $(\'#");

            
            #line 88 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
       Write(tblId);

            
            #line default
            #line hidden
WriteLiteral(" .down\').live(\'click\', function() {\r\n            extensions.");

            
            #line 89 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                   Write(varObj);

            
            #line default
            #line hidden
WriteLiteral(".moveDown($(this).parent().parent());\r\n            return false;\r\n        });\r\n\r\n" +
"    });\r\n</script>\r\n<table");

WriteAttribute("id", Tuple.Create(" id=\"", 4403), Tuple.Create("\"", 4414)
            
            #line 95 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
, Tuple.Create(Tuple.Create("", 4408), Tuple.Create<System.Object, System.Int32>(tblId
            
            #line default
            #line hidden
, 4408), false)
);

WriteLiteral(" class=\"list attachments\"");

WriteLiteral(">\r\n    <tbody>\r\n        <tr>\r\n            <td");

WriteLiteral(" class=\"thumb\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("id", Tuple.Create(" id=\"", 4520), Tuple.Create("\"", 4535)
            
            #line 99 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
, Tuple.Create(Tuple.Create("", 4525), Tuple.Create<System.Object, System.Int32>(btnAttach
            
            #line default
            #line hidden
, 4525), false)
);

WriteLiteral(" class=\"add\"");

WriteLiteral("></a>\r\n            </td>\r\n            <td");

WriteLiteral(" colspan=\"4\"");

WriteLiteral(">\r\n                <p><i>");

            
            #line 102 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
                 Write(Piranha.Resources.Page.AttachmentDescription);

            
            #line default
            #line hidden
WriteLiteral("</i></p>\r\n            </td>\r\n        </tr>\r\n");

WriteLiteral("        ");

            
            #line 105 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
   Write(Html.EditorFor(m => m.Items));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </tbody>\r\n</table>\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 4782), Tuple.Create("\"", 4793)
            
            #line 108 "..\..\Areas\Manager\Views\Extensions\AttachmentRegion.cshtml"
, Tuple.Create(Tuple.Create("", 4787), Tuple.Create<System.Object, System.Int32>(boxId
            
            #line default
            #line hidden
, 4787), false)
);

WriteLiteral(" class=\"floatbox\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bg\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(" style=\"min-width:510px;min-height:260px;\"");

WriteLiteral(">\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
