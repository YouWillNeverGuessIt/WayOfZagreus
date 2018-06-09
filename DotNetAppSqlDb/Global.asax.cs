using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DotNetAppSqlDb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private const string ERROR_PAGE_LOCATION = "Views/Error/General";
        private const string NOT_FOUND_PAGE_LOCATION = "/Views/Error/Page404";


        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var config = WebConfigurationManager.OpenWebConfiguration("~/Web.config");
            var customErrors = config.GetSection("system.web/customErrors") as CustomErrorsSection;

            if (customErrors != null && customErrors.Mode == CustomErrorsMode.On)
            {
                var app = (HttpApplication)sender;
                Exception lastError = app.Server.GetLastError();
                var httpEx = lastError as HttpException;

                if (httpEx != null)
                {
                    int httpErrorCode = httpEx.GetHttpCode();

                    string redirect = customErrors.DefaultRedirect;

                    foreach (CustomError error in customErrors.Errors)
                    {
                        if (error.StatusCode == httpErrorCode)
                        {
                            redirect = error.Redirect;
                        }
                    }

                    app.Server.ClearError();
                    app.Context.Response.StatusCode = httpErrorCode;
                    Server.TransferRequest(redirect, false);
                }
            }
        }

    }
}
