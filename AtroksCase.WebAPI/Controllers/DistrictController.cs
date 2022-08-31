using AtroksCase.Business.Abstract;
using AtroksCase.Entities.Concrete;
using AtroksCase.WebAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AtroksCase.WebAPI.Controllers
{
    [ApiController]
    public class DistrictController : BaseController<District>
    {
        private readonly IDistrictService _districtService;
        public DistrictController(IDistrictService districtService) : base(districtService)
        {
            _districtService = districtService;
        }

        [HttpPost("ReportWithByDescendingIdentificationNumberAsync")]
        public async Task<IActionResult> ReportWithByDescendingIdentificationNumberAsync(string identificationNumber)
        {
            var result = await _districtService.ReportWithByDescendingIdentificationNumberAsync(identificationNumber);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("ReportWithByGroupingLocationInfoAsync")]
        public async Task<IActionResult> ReportWithByGroupingLocationInfoAsync(double locationLatitude, double locationLongitude)
        {
            var result = await _districtService.ReportWithByGroupingLocationInfoAsync(locationLatitude, locationLongitude);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("ReportWithByIdentificationNumberAsync")]
        public async Task<IActionResult> ReportWithByIdentificationNumberAsync(string identificationNumber)
        {
            var result = await _districtService.ReportWithByIdentificationNumberAsync(identificationNumber);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
