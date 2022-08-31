using AtroksCase.Business.Abstract.Base;
using Core.DataAccess;
using Core.Entities.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AtroksCase.Business.Concrete.Base
{
    public class BaseManager<T> : IBaseService<T> where T : class, IEntity, new()
    {
        private readonly IEntityRepository<T> _entityRepository;

        public BaseManager(IEntityRepository<T> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public virtual async Task<IResult> AddAsync(T entity)
        {
            var result = await _entityRepository.AddAsync(entity);
            if (result.Success)
                return new SuccessResult(result.Message);

            return new ErrorResult(result.Message);
        }

        public virtual async Task<IResult> AddListAsync(List<T> entity)
        {
            var result = await _entityRepository.AddListAsync(entity);
            if (result.Success)
                return new SuccessResult(result.Message);

            return new ErrorResult(result.Message);
        }

        public virtual async Task<IResult> UpdateAsync(T entity)
        {
            var result = await _entityRepository.UpdateAsync(entity);
            if (result.Success)
                return new SuccessResult(result.Message);

            return new ErrorResult(result.Message);
        }


        public virtual async Task<IResult> UpdateListAsync(List<T> entity)
        {
            var result = await _entityRepository.UpdateListAsync(entity);
            if (result.Success)
                return new SuccessResult(result.Message);

            return new ErrorResult(result.Message);
        }


        public virtual async Task<IDataResult<List<T>>> GetAllAsync()
        {
            var result = await _entityRepository.GetAllAsync();
            if (result.Success)
                return new SuccessDataResult<List<T>>(result.Data, result.Message);

            return new ErrorDataResult<List<T>>(result.Message);
        }

        public virtual async Task<IResult> DeleteWithByIdAsync(int id)
        {
            var result = await _entityRepository.DeleteByIdAsync(x=>x.Id == id);
            if (result.Success)
                return new SuccessResult(result.Message);

            return new ErrorResult(result.Message);
        }

        public virtual async Task<IDataResult<T>> GetByIdAsync(int id)
        {
            var result = await _entityRepository.GetAsync(x=>x.Id == id);
            if (result.Success)
                return new SuccessDataResult<T>(result.Data, result.Message);

            return new ErrorDataResult<T>(result.Message);
        }
    }
}
