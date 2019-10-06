using Autofac;
using Autofac.Integration.WebApi;
using Service.Layer.Interface;
using Service.Layer.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace RecibosTest.App_Start
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Get Connection String
            var connString = ConfigurationManager.ConnectionStrings[database].ConnectionString;

            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<MonedaService>().As<IMonedaService>().WithParameter(connStringParam, connString).InstancePerRequest();
            builder.RegisterType<ProveedorService>().As<IProveedorService>().WithParameter(connStringParam, connString).InstancePerRequest();
            builder.RegisterType<ReciboService>().As<IReciboService>().WithParameter(connStringParam, connString).InstancePerRequest();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>().WithParameter(connStringParam, connString).InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }

        private const string connStringParam = "connectionString";
        private const string database = "database";
    }
}