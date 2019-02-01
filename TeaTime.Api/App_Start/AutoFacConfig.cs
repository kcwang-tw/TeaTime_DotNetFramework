using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace TeaTime.Api.App_Start
{
    internal static class AutofacConfig
    {
        internal static void Register()
        {
            var builder = new ContainerBuilder();

            // Get HttpConfiguration
            var config = GlobalConfiguration.Configuration;

            // Register Web API controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // 註冊Repository層的Interface與實做對應
            var repositories = Assembly.Load("Teatime.Sqlite");
            builder.RegisterAssemblyTypes(repositories).AsImplementedInterfaces();

            // Set the dependency resolver to be Autofac
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}