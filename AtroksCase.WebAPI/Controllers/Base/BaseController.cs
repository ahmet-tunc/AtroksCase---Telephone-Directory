using AtroksCase.Business.Abstract.Base;
using Core.Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AtroksCase.WebAPI.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<T> : ControllerBase
        where T : class, IEntity, new()
    {
        private readonly IBaseService<T> _baseService;
        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }


        [HttpGet("GetAllAsync")]
        public virtual async Task<IActionResult> GetAllAsync()
        {
            var result = await _baseService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetByIdAsync")]
        public virtual async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _baseService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("AddAsync")]
        public virtual async Task<IActionResult> AddAsync([FromBody] T entity)
        {
            var result = await _baseService.AddAsync(entity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("AddListAsync")]
        public virtual async Task<IActionResult> AddListAsync([FromBody] List<T> entityList)
        {
            var result = await _baseService.AddListAsync(entityList);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPut("UpdateAsync")]
        public virtual async Task<IActionResult> UpdateAsync([FromBody] T entity)
        {
            var result = await _baseService.UpdateAsync(entity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpDelete("DeleteAsync")]
        public virtual async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _baseService.DeleteWithByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
