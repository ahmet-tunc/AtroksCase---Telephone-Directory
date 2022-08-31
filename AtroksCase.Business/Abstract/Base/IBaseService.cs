using Core.Entities.Abstract;
using Core.Utilities.Results.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AtroksCase.Business.Abstract.Base
{
    public interface IBaseService<T> where T : class, IEntity, new()
    {
        Task<IResult> AddAsync(T entity);
        Task<IResult> AddListAsync(List<T> entity);
        Task<IResult> UpdateAsync(T entity);
        Task<IResult> UpdateListAsync(List<T> entity);
        Task<IResult> DeleteWithByIdAsync(int id);
        Task<IDataResult<List<T>>> GetAllAsync();
        Task<IDataResult<T>> GetByIdAsync(int id);
    }
}
