using Autofac;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Autofac.Extras.DynamicProxy;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacDepencyResolvers:Module
    {
       protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).
                AsImplementedInterfaces();
                //.EnableInterfaceInterceptors(new ProxyGenerationOptions()
                //{
                //    Selector =new AspectInterceptorSelector()
                //}).SingleInstance();

        }
    }
}
