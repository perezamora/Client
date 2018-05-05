using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVCStudent.App_Start
{
    public class IocConfig
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new MvcIocModule());

            var container = builder.Build();

            var resolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);
        
            return container;
        }
    }
}