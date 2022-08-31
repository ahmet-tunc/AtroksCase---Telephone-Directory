using AtroksCase.Business.Abstract.Base;
using AtroksCase.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtroksCase.Business.Abstract
{
    public interface IDistrictService:IBaseService<District>
    {
        public Task<IDataResult<List<District>>> ReportWithByIdentificationNumberAsync(string identificationNumber);
        public Task<IDataResult<List<District>>> ReportWithByDescendingIdentificationNumberAsync(string identificationNumber);
        public Task<IDataResult<List<IGrouping<bool, District>>>> ReportWithByGroupingLocationInfoAsync(double locationLatitude, double locationLongitude);
    }
}
