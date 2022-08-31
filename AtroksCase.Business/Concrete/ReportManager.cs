using AtroksCase.Business.Abstract;
using AtroksCase.Business.Concrete.Base;
using AtroksCase.DataAccess.Abstract;
using AtroksCase.Entities.Concrete;

namespace AtroksCase.Business.Concrete
{
    public class ReportManager : BaseManager<Report>, IReportService
    {
        private readonly IReportDal _reportDal;

        public ReportManager(IReportDal reportDal) : base(reportDal)
        {
            _reportDal = reportDal;
        }
    }
}
