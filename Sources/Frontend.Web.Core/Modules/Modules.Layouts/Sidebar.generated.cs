﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
    
    #line 1 "..\..\Sidebar.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Sidebar.cshtml"
    using System.Web.Optimization;
    
    #line default
    #line hidden
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\Sidebar.cshtml"
    using Translations;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Sidebar.cshtml")]
    public partial class _Sidebar_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Sidebar_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<aside");

WriteLiteral(" id=\"sidebar-menu\"");

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"sidebar-menu_list\"");

WriteLiteral(">\r\n        <li");

WriteLiteral(" class=\"sidebar-menu_item active\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 207), Tuple.Create("\"", 242)
            
            #line 8 "..\..\Sidebar.cshtml"
, Tuple.Create(Tuple.Create("", 214), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Home")
            
            #line default
            #line hidden
, 214), false)
);

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-fw fa-home\"");

WriteLiteral("></i>                \r\n                <span>");

            
            #line 10 "..\..\Sidebar.cshtml"
                 Write(I18NEngine.GetString("modules.layouts.sidebar", "menu_item_home"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </a>\r\n        </li>\r\n\r\n        <li");

WriteLiteral(" class=\"sidebar-menu_item\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 498), Tuple.Create("\"", 539)
            
            #line 15 "..\..\Sidebar.cshtml"
, Tuple.Create(Tuple.Create("", 505), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "TotalRoles")
            
            #line default
            #line hidden
, 505), false)
);

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-fw fa-list\"");

WriteLiteral("></i>\r\n                <span>");

            
            #line 17 "..\..\Sidebar.cshtml"
                 Write(I18NEngine.GetString("modules.layouts.sidebar", "menu_item_manage_roles"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </a>\r\n        </li>\r\n\r\n        <li");

WriteLiteral(" class=\"sidebar-menu_item\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 787), Tuple.Create("\"", 828)
            
            #line 22 "..\..\Sidebar.cshtml"
, Tuple.Create(Tuple.Create("", 794), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "TotalUsers")
            
            #line default
            #line hidden
, 794), false)
);

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-fw fa-users\"");

WriteLiteral("></i>\r\n                <span>");

            
            #line 24 "..\..\Sidebar.cshtml"
                 Write(I18NEngine.GetString("modules.layouts.sidebar", "menu_item_manage_users"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </a>\r\n        </li>\r\n    </ul>\r\n</aside>  ");

        }
    }
}
#pragma warning restore 1591
