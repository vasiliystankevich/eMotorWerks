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
    
    #line 1 "..\..\TotalRoles\Index.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    
    #line 2 "..\..\TotalRoles\Index.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 3 "..\..\TotalRoles\Index.cshtml"
    using System.Web.Optimization;
    
    #line default
    #line hidden
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 4 "..\..\TotalRoles\Index.cshtml"
    using Translations;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/TotalRoles/Index.cshtml")]
    public partial class _TotalRoles_Index_cshtml : System.Web.Mvc.WebViewPage<Modules.Site.TotalRoles.TotalRolesModel>
    {
        public _TotalRoles_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\TotalRoles\Index.cshtml"
  
    Layout = "~/TotalPages.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("pagetitle", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..\TotalRoles\Index.cshtml"
Write(I18NEngine.GetMvcHtmlString("modules.site.totalroles.index", "title"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("bodyscripts", () => {

WriteLiteral(@"
    <script>
        $(document).ready(function() {
            $('#dataTables-total-roles').DataTable({
                responsive: true
            });
        });
    </script>  
    <script>

        $(document).ready(function () {

            $('#dataTables-total-roles').on('click', '.btn-delete-role', function(e) {
                    var roleId = $(e.currentTarget).data('role-id');
                    localStorage.setItem(""delete-role-id"", roleId);
                });

            $('#confirmDeleteRole').on('click', '.btn-yes', function (e) {
                var data = $(e.relatedTarget).data();
                console.log(data);
                $.Site.Libraries.Common.Preloader.Show();
                $.Site.Libraries.WebApi.Common.ExecuteAction({
                    uri: $(""#webapi-identity-removerole"").attr(""href""),
                    data:
                    {
                        Role: localStorage.getItem(""delete-role-id"")
                    },
                    onAfterAction: function () { window.location.reload(false);}
                });
            });

        });

    </script>
");

});

WriteLiteral("\r\n<a");

WriteLiteral(" id=\"webapi-identity-removerole\"");

WriteLiteral(" class=\"hidden\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1540), Tuple.Create("\"", 1572)
, Tuple.Create(Tuple.Create("", 1547), Tuple.Create<System.Object, System.Int32>(Href("~/api/identity/removerole")
, 1547), false)
);

WriteLiteral("></a>\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n    \r\n    <div");

WriteLiteral(" id=\"confirmDeleteRole\"");

WriteLiteral(" class=\"col-md-offset-2 col-md-8 modal fade\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-label=\"Cancel\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">×</span>\r\n                    </button>                    \r\n                   " +
" <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(">");

            
            #line 63 "..\..\TotalRoles\Index.cshtml"
                                       Write(I18NEngine.GetMvcHtmlString("modules.site.totalroles.index", "confirmdeleterole_modal_title"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"modal-body text-align-center\"");

WriteLiteral(">");

            
            #line 65 "..\..\TotalRoles\Index.cshtml"
                                                     Write(I18NEngine.GetMvcHtmlString("modules.site.totalroles.index", "confirmdeleterole_modal_message"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" class=\"btn btn-primary btn-yes\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">");

            
            #line 67 "..\..\TotalRoles\Index.cshtml"
                                                                                          Write(I18NEngine.GetMvcHtmlString("modules.site.totalroles.index", "confirmdeleterole_modal_button_yes"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                    <a");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-label=\"Cancel\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">");

            
            #line 68 "..\..\TotalRoles\Index.cshtml"
                                                                                                      Write(I18NEngine.GetMvcHtmlString("modules.site.totalroles.index", "confirmdeleterole_modal_button_cancel"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>    \r" +
"\n    \r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-9 text-align-center h4\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 80 "..\..\TotalRoles\Index.cshtml"
                       Write(I18NEngine.GetMvcHtmlString("modules.site.totalroles.index", "name_table"));

            
            #line default
            #line hidden
WriteLiteral("                            \r\n                        </div>                     " +
"   \r\n                        <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"col-md-offset-7 col-md-5\"");

WriteLiteral(">\r\n                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3574), Tuple.Create("\"", 3614)
            
            #line 85 "..\..\TotalRoles\Index.cshtml"
, Tuple.Create(Tuple.Create("", 3581), Tuple.Create<System.Object, System.Int32>(Url.Action("Add", "DetailsRole")
            
            #line default
            #line hidden
, 3581), false)
);

WriteLiteral(" class=\"btn btn-primary col-md-12 text-align-left\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"fa fa-fw fa-plus\"");

WriteLiteral(">");

            
            #line 86 "..\..\TotalRoles\Index.cshtml"
                                                               Write(I18NEngine.GetMvcHtmlString("modules.site.totalroles.index", "button_new"));

            
            #line default
            #line hidden
WriteLiteral(@"</i>
                                    </a>                                                                
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.panel-heading -->
                <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n                    <table");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" class=\"table table-striped table-bordered table-hover\"");

WriteLiteral(" id=\"dataTables-total-roles\"");

WriteLiteral(">\r\n                        <thead>\r\n                            <tr>\r\n           " +
"                     <th");

WriteLiteral(" class=\"col-md-6 text-align-center\"");

WriteLiteral(">");

            
            #line 98 "..\..\TotalRoles\Index.cshtml"
                                                                  Write(I18NEngine.GetMvcHtmlString("modules.site.totalroles.index", "th_name"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th");

WriteLiteral(" class=\"col-md-6 text-align-center\"");

WriteLiteral("></th>\r\n                            </tr>\r\n                        </thead>\r\n    " +
"                    <tbody>\r\n");

            
            #line 103 "..\..\TotalRoles\Index.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 103 "..\..\TotalRoles\Index.cshtml"
                               var index = 0;
            
            #line default
            #line hidden
WriteLiteral("    \r\n");

            
            #line 104 "..\..\TotalRoles\Index.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 104 "..\..\TotalRoles\Index.cshtml"
                             foreach (var role in Model.Roles)
                            {
                                index++;
                                var trClass = index % 2 == 1 ? "even" : "odd";

            
            #line default
            #line hidden
WriteLiteral("                                <tr");

WriteAttribute("class", Tuple.Create(" class=\"", 4993), Tuple.Create("\"", 5016)
            
            #line 108 "..\..\TotalRoles\Index.cshtml"
, Tuple.Create(Tuple.Create("", 5001), Tuple.Create<System.Object, System.Int32>(trClass
            
            #line default
            #line hidden
, 5001), false)
, Tuple.Create(Tuple.Create(" ", 5009), Tuple.Create("gradeA", 5010), true)
);

WriteLiteral(">\r\n                                    <td");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">");

            
            #line 109 "..\..\TotalRoles\Index.cshtml"
                                                    Write(role);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td");

WriteLiteral(" class=\"col-md-6 text-align-center\"");

WriteLiteral(">\r\n                                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5208), Tuple.Create("\"", 5286)
            
            #line 111 "..\..\TotalRoles\Index.cshtml"
, Tuple.Create(Tuple.Create("", 5215), Tuple.Create<System.Object, System.Int32>(Url.Action("Update", "DetailsRole", new {roleName = Url.Encode(role)})
            
            #line default
            #line hidden
, 5215), false)
);

WriteLiteral(" class=\"blue\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"fa fa-fw fa-pencil\"");

WriteLiteral("></i>\r\n                                        </a>\r\n                            " +
"            <a");

WriteLiteral(" class=\"red btn-delete-role\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#confirmDeleteRole\"");

WriteLiteral(" data-role-id=\"");

            
            #line 114 "..\..\TotalRoles\Index.cshtml"
                                                                                                                                     Write(role);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"fa fa-fw fa-trash-o\"");

WriteLiteral("></i>\r\n                                        </a>\r\n                            " +
"        </td>\r\n                                </tr>                            " +
"\r\n");

            
            #line 119 "..\..\TotalRoles\Index.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral(@"                        </tbody>
                    </table>
                    <!-- /.table-responsive -->
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>

</div>");

        }
    }
}
#pragma warning restore 1591
