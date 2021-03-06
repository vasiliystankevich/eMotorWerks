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
    
    #line 1 "..\..\Accounts\Login\action.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    
    #line 2 "..\..\Accounts\Login\action.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Accounts\Login\action.cshtml"
    using System.Web.Optimization;
    
    #line default
    #line hidden
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 4 "..\..\Accounts\Login\action.cshtml"
    using Libraries.Core.Backend.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Accounts\Login\action.cshtml"
    using Translations;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Accounts/Login/action.cshtml")]
    public partial class _Accounts_Login_action_cshtml : System.Web.Mvc.WebViewPage<Modules.Core.Accounts.LoginModel>
    {
        public _Accounts_Login_action_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Accounts\Login\action.cshtml"
  
    Layout = "~/Login.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("pagetitle", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..\Accounts\Login\action.cshtml"
Write(I18NEngine.GetMvcHtmlString("modules.core.accounts.login", "title"));

            
            #line default
            #line hidden
WriteLiteral("    \r\n");

});

DefineSection("headscripts", () => {

WriteLiteral("\r\n");

            
            #line 16 "..\..\Accounts\Login\action.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Accounts\Login\action.cshtml"
     if (Model.IsVisibleRecaptcha)
    {
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\Accounts\Login\action.cshtml"
   Write(Html.JsScriptLink(new Uri("https://www.google.com/recaptcha/api.js")));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Accounts\Login\action.cshtml"
                                                                              
    }

            
            #line default
            #line hidden
});

DefineSection("stylesheet", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 23 "..\..\Accounts\Login\action.cshtml"
Write(Styles.Render("~/Modules/Accounts/Login/css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(" style=\"padding-top: 10vh\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-8\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row no-gutter\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"text-align-center\"");

WriteLiteral(">\r\n                    <h2>");

            
            #line 31 "..\..\Accounts\Login\action.cshtml"
                   Write(I18NEngine.GetMvcHtmlString("modules.core.accounts.login", "entrance"));

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                </div>\r\n");

            
            #line 33 "..\..\Accounts\Login\action.cshtml"
                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Accounts\Login\action.cshtml"
                 using (Html.BeginForm("Login", "Accounts", new {ViewBag.ReturnUrl }, FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group text-align-center\"");

WriteLiteral(">\r\n                        <h4>");

            
            #line 36 "..\..\Accounts\Login\action.cshtml"
                       Write(I18NEngine.GetMvcHtmlString("modules.core.accounts.login", "greeting"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

WriteLiteral("                        ");

            
            #line 37 "..\..\Accounts\Login\action.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class= "text-danger validation-summary" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"col-md-offset-3 col-md-6\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"control-label\"");

WriteAttribute("for", Tuple.Create(" for=\"", 1601), Tuple.Create("\"", 1632)
            
            #line 42 "..\..\Accounts\Login\action.cshtml"
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m=>m.Account)
            
            #line default
            #line hidden
, 1607), false)
);

WriteLiteral(">");

            
            #line 42 "..\..\Accounts\Login\action.cshtml"
                                                                                        Write(I18NEngine.GetMvcHtmlString("modules.core.accounts.login", "account"));

            
            #line default
            #line hidden
WriteLiteral("</label>                                \r\n                            </div>\r\n   " +
"                         <div");

WriteLiteral(" class=\"col-md-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 45 "..\..\Accounts\Login\action.cshtml"
                           Write(Html.TextBoxFor(m => m.Account, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 46 "..\..\Accounts\Login\action.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Account, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"             <div");

WriteLiteral(" class=\"row padding-top-15\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"control-label\"");

WriteAttribute("for", Tuple.Create(" for=\"", 2283), Tuple.Create("\"", 2315)
            
            #line 51 "..\..\Accounts\Login\action.cshtml"
, Tuple.Create(Tuple.Create("", 2289), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m=>m.Password)
            
            #line default
            #line hidden
, 2289), false)
);

WriteLiteral(">");

            
            #line 51 "..\..\Accounts\Login\action.cshtml"
                                                                                         Write(I18NEngine.GetMvcHtmlString("modules.core.accounts.login", "password"));

            
            #line default
            #line hidden
WriteLiteral("</label>                                \r\n                            </div>\r\n   " +
"                         <div");

WriteLiteral(" class=\"col-md-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 54 "..\..\Accounts\Login\action.cshtml"
                           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 55 "..\..\Accounts\Login\action.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("                                \r\n                            </div>             " +
"               \r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"row padding-top-15\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-offset-3 col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 60 "..\..\Accounts\Login\action.cshtml"
                           Write(Html.CheckBoxFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                <label");

WriteLiteral(" class=\"control-label\"");

WriteAttribute("for", Tuple.Create(" for=\"", 3116), Tuple.Create("\"", 3150)
            
            #line 61 "..\..\Accounts\Login\action.cshtml"
, Tuple.Create(Tuple.Create("", 3122), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m=>m.RememberMe)
            
            #line default
            #line hidden
, 3122), false)
);

WriteLiteral(" style=\"padding-left: 5px;\"");

WriteLiteral(">");

            
            #line 61 "..\..\Accounts\Login\action.cshtml"
                                                                                                                      Write(I18NEngine.GetMvcHtmlString("modules.core.accounts.login", "remember_me"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            </div>\r\n                        </div>\r\n   " +
"                     <div");

WriteLiteral(" class=\"row padding-top-15\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-offset-3 col-md-6\"");

WriteLiteral(">\r\n                                ");

WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"             <div");

WriteLiteral(" class=\"row padding-top-15\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-offset-3 col-md-9\"");

WriteLiteral(">\r\n");

            
            #line 71 "..\..\Accounts\Login\action.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 71 "..\..\Accounts\Login\action.cshtml"
                                 if (Model.IsVisibleRecaptcha)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <div");

WriteLiteral(" class=\"row padding-bottom-15\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"col-md-12 g-recaptcha\"");

WriteLiteral(" data-sitekey=\"6LeZOk0UAAAAAPU8E-Kw4YQPS21sJ4ddMkxWBwHC\"");

WriteLiteral("></div>\r\n                                    </div>\r\n");

            
            #line 76 "..\..\Accounts\Login\action.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4382), Tuple.Create("\"", 4465)
            
            #line 79 "..\..\Accounts\Login\action.cshtml"
, Tuple.Create(Tuple.Create("", 4390), Tuple.Create<System.Object, System.Int32>(I18NEngine.GetMvcHtmlString("modules.core.accounts.login", "button_login")
            
            #line default
            #line hidden
, 4390), false)
);

WriteLiteral(" class=\"btn btn-primary col-md-6\"");

WriteLiteral("/>\r\n                                    </div>\r\n                                <" +
"/div>\r\n                            </div>\r\n                        </div>\r\n     " +
"               </div>\r\n");

            
            #line 85 "..\..\Accounts\Login\action.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
