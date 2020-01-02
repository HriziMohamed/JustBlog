using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using JustBlog.Core;
using JustBlog.Providers;
using System;

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

            kernel.Bind<IAuthProvider>().To<AuthProvider>();

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


        //public static void fizzBuzz(int n)
        //{

        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (i % 5 == 0 && i % 3 == 0)
        //        {
        //            Console.WriteLine("FizzBuzz");
        //            continue;
        //        }
        //        if (i % 5 == 0)
        //        {
        //            Console.WriteLine("Buzz");
        //            continue;
        //        }
        //        if (i % 3 == 0)
        //        {
        //            Console.WriteLine("Fizz");
        //            continue;
        //        }

        //        Console.WriteLine(i);
        //    }
        //}
    }
}
