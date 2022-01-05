using Ninject;
using Sample.Domains.Applications;
using Sample.Domains.Domains;
using Sample.Models;
using Sample.Repositories.Inquiry;
using Sample.UseCases.Inquiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Sample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IKernel kernel = new StandardKernel();
            kernel.Bind<IInquiryRepository>().To<InquiryRepository>();
            kernel.Bind<ISendInquiryUserCase>().To<SendInquiryInterractor>();
            DependencyResolver.SetResolver(new NinjectResolver(kernel));
        }
    }
}
