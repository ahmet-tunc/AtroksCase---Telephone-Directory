using AtroksCase.DataAccess.Abstract;
using AtroksCase.Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace AtroksCase.DataAccess.Concrete
{
    public class EfReportDal : EfEntityRepositoryBase<Report, AppDbContext>, IReportDal
    {
    }
}
