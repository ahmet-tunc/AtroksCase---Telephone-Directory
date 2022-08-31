using Core.Utilities.Results.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AtroksCase.WebUI.Helpers.ApiRequestHelper.Abstract
{
    public interface IApiRequestService
    {
        public Task<IDataResult<T>> GetByIdRequest<T>(string apiUrl, int id);
        public Task<IDataResult<List<T>>> GetRequestList<T>(string apiUrl);
        public Task<TOut> PostRequest<TIn, TOut>(string apiUrl, TIn postModel);
        public Task<IResult> PutRequest<T>(string apiUrl, T putModel);
        public Task<IResult> DeleteRequest<T>(string apiUrl, int id);
        public Task<TOut> GetRequestWithoutParameters<TOut>(string apiUrl);
    }
}
