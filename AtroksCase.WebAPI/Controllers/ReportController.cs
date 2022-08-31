using AtroksCase.Business.Abstract;
using AtroksCase.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AtroksCase.WebAPI.Controllers
{
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _reportService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetByIdAsync")]
        public virtual async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _reportService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("AddAsync")]
        public virtual async Task<IActionResult> AddAsync([FromBody] Report entity)
        {
            var result = await _reportService.AddAsync(entity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
