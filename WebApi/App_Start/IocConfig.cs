using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using GraphQL;
using GraphQL.Http;
using Owin;
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
            //container.Singleton<ISchema>(new StarWarsSchema(new FuncDependencyResolver(type => container.Get(type))));
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