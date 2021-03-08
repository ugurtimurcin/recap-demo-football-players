using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClubManager>().As<IClubService>().SingleInstance();
            builder.RegisterType<EfClubDal>().As<IClubDal>().SingleInstance();

            builder.RegisterType<PlayerManager>().As<IPlayerService>().SingleInstance();
            builder.RegisterType<EfPlayerDal>().As<IPlayerDal>().SingleInstance();

            builder.RegisterType<PositionManager>().As<IPositionService>().SingleInstance();
            builder.RegisterType<EfPositionDal>().As<IPositionDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

           
        }
    }
}
