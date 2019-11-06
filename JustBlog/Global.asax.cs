using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using JustBlog.Core;
namespace JustBlog
{
    //  public class MvcApplication : System.Web.HttpApplication  
    public class MvcApplication : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Load(new RepositoryModule());
            kernel.Bind<IBlogRepository>().To<BlogRepository>();

            return kernel;
        }
        protected override void OnApplicationStarted()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            base.OnApplicationStarted();
        }

        //protected void Application_Start()
        //{
        //    AreaRegistration.RegisterAllAreas();
        //    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //    BundleConfig.RegisterBundles(BundleTable.Bundles);
        //}
    }
}
