﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using Frapid.Config;
    
    #line 1 "..\..\Views\FileManager\Index.cshtml"
    using Frapid.Configuration;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FileManager/Index.cshtml")]
    public partial class _Views_FileManager_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_FileManager_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\FileManager\Index.cshtml"
  
    ViewBag.Title = "Edit Layout";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/Scripts/vakata-jstree/dist/themes/default/style.min.css\"");

WriteLiteral(" />\r\n<script");

WriteLiteral(" src=\"/Scripts/vakata-jstree/dist/jstree.min.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/ace-1.2.2/src-min-noconflict/ace.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/ajax-file-upload.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/validator.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/form.js\"");

WriteLiteral("></script>\r\n<link");

WriteLiteral(" href=\"/Areas/Frapid.Config/Content/FileManager/Index.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n<script");

WriteLiteral(" src=\"/Scripts/less/less.min.js\"");

WriteLiteral("></script>\r\n    <div");

WriteLiteral(" class=\"ui stackable divided grid\"");

WriteLiteral(" style=\"height: 100%;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"thirteen wide full height column attached segment\"");

WriteLiteral(" data-target=\"editor\"");

WriteLiteral(" id=\"ActionContainer\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"action buttons\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui stackable grid\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"twelve wide column\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"ui basic icon buttons\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" data-container=\"\"");

WriteLiteral(" data-path=\"\"");

WriteLiteral(" id=\"SaveButton\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"save icon\"");

WriteLiteral("></i>\r\n                                Save\r\n                            </button" +
">\r\n                            <button");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" id=\"UploadButton\"");

WriteLiteral(" data-container=\"\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"upload icon\"");

WriteLiteral("></i>\r\n                                Upload\r\n                            </butt" +
"on>\r\n                            <button");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" onclick=\"$(\'#FileModal\').modal(\'show\');\"");

WriteLiteral(" data-container=\"\"");

WriteLiteral(" id=\"CreateFileButton\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"file icon\"");

WriteLiteral("></i>\r\n                                Create File\r\n                            <" +
"/button>\r\n                            <button");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" onclick=\"$(\'#FolderModal\').modal(\'show\');\"");

WriteLiteral(" data-container=\"\"");

WriteLiteral(" id=\"CreateDirectoryButton\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"folder icon\"");

WriteLiteral("></i>\r\n                                Create Folder\r\n                           " +
" </button>\r\n                            <button");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" data-path=\"\"");

WriteLiteral(" onclick=\"deleteItem(this);\"");

WriteLiteral(" id=\"DeleteButton\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"minus square icon\"");

WriteLiteral("></i>\r\n                                Delete\r\n                            </butt" +
"on>\r\n\r\n                            <button");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" onclick=\"toggleEditorTheme()\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"unhide icon\"");

WriteLiteral("></i>\r\n                                Change Contrast\r\n                         " +
"   </button>\r\n                        </div>\r\n                    </div>\r\n      " +
"          </div>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"viewer\"");

WriteLiteral(" class=\"ui attached segment\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" class=\"ui image\"");

WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <div");

WriteLiteral(" id=\"editor\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"ui three wide full height right floated column attached segment\"");

WriteLiteral(" style=\"overflow: auto;\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui header\"");

WriteLiteral(">\r\n                Edit Tenant Files\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" class=\"tree container vpad8\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui violet medium ribbon label\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-theme=\"\"");

WriteLiteral(">");

            
            #line 64 "..\..\Views\FileManager\Index.cshtml"
                                   Write(TenantConvention.GetDomain());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n                <div");

WriteLiteral(" id=\"container\"");

WriteLiteral(" class=\"vpad8\"");

WriteLiteral("></div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n");

            
            #line 73 "..\..\Views\FileManager\Index.cshtml"
Write(Html.Partial("~/Areas/Frapid.Config/Views/FileManager/Shared/UploadModal.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 74 "..\..\Views\FileManager\Index.cshtml"
Write(Html.Partial("~/Areas/Frapid.Config/Views/FileManager/Shared/FileModal.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 75 "..\..\Views\FileManager\Index.cshtml"
Write(Html.Partial("~/Areas/Frapid.Config/Views/FileManager/Shared/FolderModal.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n<script");

WriteLiteral(" src=\"/Areas/Frapid.Config/Scripts/FileManager/Index.js\"");

WriteLiteral("></script>");

        }
    }
}
#pragma warning restore 1591