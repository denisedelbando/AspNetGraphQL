using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Data.Schema;
using Data.Services;
using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using Owin;
using System;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi
{
    public class IocConfig
    {
        /// <summary>
        /// For more info see
        /// :http://docs.autofac.org/en/latest/integration/mvc.html
        /// </summary>
        public static void RegisterDependencies(IAppBuilder app)
        {
            #region Create the builder 
            var builder = new ContainerBuilder();
            #endregion

            
            #region Register all controllers for the assembly
            // NOTE that ASP.NET MVC requests controllers by their concrete types, 
            // so registering them As<IController>() is incorrect. 
            // Also, if you register controllers manually and choose to specify 
            // lifetimes, you must register them as InstancePerDependency() or 
            // InstancePerHttpRequest() - ASP.NET MVC will throw an exception if 
            // you try to reuse a controller instance for multiple requests. 
            builder.RegisterControllers(typeof(Global).Assembly);
            #endregion

            #region Register all web api controllers for the assembly
            builder.RegisterApiControllers(typeof(Global).Assembly);
            #endregion

            #region Register modules
            //builder.RegisterModule(new BusinessLogicInstaller());
            //builder.RegisterModule(new ReposInstaller());
            //builder.RegisterModule(new ServicesInstaller());
            #endregion

            #region GraphQL
            builder.RegisterInstance(new DocumentExecuter()).As<IDocumentExecuter>();
            builder.RegisterInstance(new DocumentWriter(true)).As<IDocumentWriter>();
            builder.RegisterAssemblyTypes(typeof(CompanyService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces()
               .InstancePerRequest();

            builder.RegisterType<CompanyQuery>().AsSelf();
            builder.RegisterType<CompanyType>().AsSelf();
            builder.RegisterType<DrugType>().AsSelf();
            
            builder.RegisterType<CompanySchema>().As<ISchema>().InstancePerRequest();

            builder.Register<GraphQL.IDependencyResolver>(c =>
            {
                var context = c.Resolve<IComponentContext>();
                return new FuncDependencyResolver(type => context.Resolve(type));
            });

            #endregion

            builder.RegisterModule<AutofacWebTypesModule>();

            #region Set the dependency resolver to be Autofac
            var container = builder.Build();
            //for MVC
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //for WebApi
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            
            #endregion
        }
    }
}