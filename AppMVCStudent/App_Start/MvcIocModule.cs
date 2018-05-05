using AppMVCStudent.Business.Logic;
using AppMVCStudent.Business.Logic.Autofac;
using AppMVCStudent.Common.Logic.Logger;
using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace AppMVCStudent.App_Start
{
    public class MvcIocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterSource(new ViewRegistrationSource());

            builder.RegisterType<ALog4NetLogger>()
                .As<ILogger>()
                .InstancePerRequest();

            builder.RegisterType<StudentService>()
                .As<IStudentService>()
                .InstancePerRequest();

            builder.RegisterType<HttpClient>()
                .InstancePerRequest();

            builder.RegisterModule(new BusinessIocModule());

            base.Load(builder);
        }
    }
}