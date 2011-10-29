using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CheckMate.Infrastructure.Bootstrapper;
using CheckMate.Services;
using CheckMate.Services.Implementations;
using CheckMate.UI.Web.Controllers;
using LightCore;
using LightCore.Integration.Web.Mvc;

namespace CheckMate
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            var builder = new ContainerBuilder();

            var servicesBootstrapperTask = new ServicesBootstrapperTask();
            ((IBootstrapperTask)servicesBootstrapperTask).Execute(builder);

            IContainer container = builder.Build();
            ControllerBuilder.Current.SetControllerFactory(new ControllerFactory(container));


            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}