using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Models
{
    public class NinjectResolver : IDependencyResolver
    {
        private IKernel Kernel;

        public NinjectResolver(IKernel kernel)
        {
            Kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
           return Kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }
    }
}