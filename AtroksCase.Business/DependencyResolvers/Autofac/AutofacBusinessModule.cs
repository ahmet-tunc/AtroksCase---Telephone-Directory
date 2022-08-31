using AtroksCase.Business.Abstract;
using AtroksCase.Business.Concrete;
using AtroksCase.DataAccess.Abstract;
using AtroksCase.DataAccess.Concrete;
using Autofac;

namespace AtroksCase.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DistrictManager>().As<IDistrictService>();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>();

            builder.RegisterType<ReportManager>().As<IReportService>();
            builder.RegisterType<EfReportDal>().As<IReportDal>();
        }
    }
}
