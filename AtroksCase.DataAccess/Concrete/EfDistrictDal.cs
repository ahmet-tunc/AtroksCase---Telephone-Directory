using AtroksCase.DataAccess.Abstract;
using AtroksCase.Entities.Concrete;
using Core.Constants;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtroksCase.DataAccess.Concrete
{
    public class EfDistrictDal : EfEntityRepositoryBase<District, AppDbContext>, IDistrictDal
    {
        public async Task<IDataResult<List<District>>> ReportWithByDescendingIdentificationNumberAsync(string identificationNumber)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var entityList = await context.Districts.Where(x => x.IdentificationNumber == identificationNumber).OrderByDescending(x=>x.IdentificationNumber).ToListAsync();
                return new SuccessDataResult<List<District>>(entityList,Message.ListedRecords);
            }
        }

        public async Task<IDataResult<List<IGrouping<bool, District>>>> ReportWithByGroupingLocationInfoAsync(double locationLatitude, double locationLongitude)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var entityList = await context.Districts.GroupBy(x => x.LocationLatitude == locationLatitude && x.LocationLongitude == locationLongitude).ToListAsync();
                return new SuccessDataResult<List<IGrouping<bool, District>>>(entityList, Message.ListedRecords);
            }
        }

        public async Task<IDataResult<List<District>>> ReportWithByIdentificationNumberAsync(string identificationNumber)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var entityList = await context.Districts.Where(x => x.IdentificationNumber == identificationNumber).ToListAsync();
                return new SuccessDataResult<List<District>>(entityList, Message.ListedRecords);
            }
        }
    }
}
