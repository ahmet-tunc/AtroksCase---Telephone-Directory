using AtroksCase.Business.Abstract;
using AtroksCase.Business.Concrete.Base;
using AtroksCase.DataAccess.Abstract;
using AtroksCase.Entities.Concrete;
using Core.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtroksCase.Business.Concrete
{
    public class DistrictManager : BaseManager<District>, IDistrictService
    {
        private readonly IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal) : base(districtDal)
        {
            _districtDal = districtDal;
        }

        public override async Task<IResult> AddAsync(District entity)
        {
            var checkData = await _districtDal.GetAsync(x => x.FirstName == entity.FirstName && x.LastName == entity.LastName && x.IdentificationNumber == entity.IdentificationNumber);
            if (checkData.Data != null)
            {
                if (checkData.Data.LocationLatitude == entity.LocationLatitude && checkData.Data.LocationLongitude == entity.LocationLongitude)
                {
                    return new ErrorResult(Message.AddedFailedForExistingRecord);
                }
            }
            return await base.AddAsync(entity);
        }


        public Task<IDataResult<List<District>>> ReportWithByDescendingIdentificationNumberAsync(string identificationNumber)
        {
            return _districtDal.ReportWithByDescendingIdentificationNumberAsync(identificationNumber);
        }

        public Task<IDataResult<List<IGrouping<bool, District>>>> ReportWithByGroupingLocationInfoAsync(double locationLatitude, double locationLongitude)
        {
            return _districtDal.ReportWithByGroupingLocationInfoAsync(locationLatitude, locationLongitude);
        }

        public Task<IDataResult<List<District>>> ReportWithByIdentificationNumberAsync(string identificationNumber)
        {
            return _districtDal.ReportWithByIdentificationNumberAsync(identificationNumber);
        }
    }
}
