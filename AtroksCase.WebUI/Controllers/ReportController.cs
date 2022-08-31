using AtroksCase.WebUI.Helpers.ApiRequestHelper.Abstract;
using AtroksCase.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace AtroksCase.WebUI.Controllers
{
    [Route("Report")]
    public class ReportController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IApiRequestService _apiRequestService;
        public ReportController(IApiRequestService apiRequestService, IConfiguration configuration)
        {
            _configuration = configuration;
            _apiRequestService = apiRequestService;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("ReportWithByIdentificationNumber")]
        public IActionResult ReportWithByIdentificationNumber()
        {
            return View();
        }

        [HttpPost("ReportWithByIdentificationNumber")]
        public async Task<IActionResult> ReportWithByIdentificationNumber(DistrictInputWithByIdentificationNumberModel model)
        {
            var result = await _apiRequestService.PostRequest<DistrictInputWithByIdentificationNumberModel, DistrictModel>(_configuration["ApiUrl"] + "Report/ReportWithByIdentificationNumberAsync", model);
            return View(result);
        }


        [HttpGet("ReportWithByDescendingIdentificationNumber")]
        public IActionResult ReportWithByDescendingIdentificationNumber()
        {
            return View();
        }

        [HttpPost("ReportWithByDescendingIdentificationNumber")]
        public async Task<IActionResult> ReportWithByDescendingIdentificationNumber(DistrictInputWithByIdentificationNumberModel model)
        {
            var result = await _apiRequestService.PostRequest<DistrictInputWithByIdentificationNumberModel, DistrictModel>(_configuration["ApiUrl"] + "Report/ReportWithByDescendingIdentificationNumberAsync", model);
            return View(result);
        }


        [HttpGet("ReportWithByGroupingLocationInfo")]
        public IActionResult ReportWithByGroupingLocationInfo()
        {
            return View();
        }

        [HttpPost("ReportWithByGroupingLocationInfo")]
        public async Task<IActionResult> ReportWithByGroupingLocationInfo(DistrictInputWithByLocationInfoModel model)
        {
            var result = await _apiRequestService.PostRequest<DistrictInputWithByLocationInfoModel, DistrictModel>(_configuration["ApiUrl"] + "Report/ReportWithByDescendingIdentificationNumberAsync", model);
            return View(result);
        }

    }
}
