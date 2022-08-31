using AtroksCase.WebUI.Helpers.ApiRequestHelper.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AtroksCase.WebUI.Helpers.ApiRequestHelper.Concrete
{
    public class ApiRequestManager : IApiRequestService
    {
        public async Task<IDataResult<T>> GetByIdRequest<T>(string apiUrl, int id)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(apiUrl + "?id=" + id);
                var response = result.Content.ReadAsStringAsync().Result;
                DataResult<T> resultContent = JsonConvert.DeserializeObject<DataResult<T>>(response);
                return resultContent;
            }
        }

        public virtual async Task<IDataResult<List<T>>> GetRequestList<T>(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(apiUrl);
                var response = result.Content.ReadAsStringAsync().Result;
                DataResult<List<T>> resultContent = JsonConvert.DeserializeObject<DataResult<List<T>>>(response);
                return resultContent;
            }
        }

        public virtual async Task<TOut> PostRequest<TIn, TOut>(string apiUrl, TIn postModel)
        {
            using (var client = new HttpClient())
            {
                var result = await client.PostAsJsonAsync(apiUrl, postModel);
                var response = result.Content.ReadAsStringAsync().Result;
                TOut model = JsonConvert.DeserializeObject<TOut>(response);
                return model;
            }
        }


        public virtual async Task<TOut> GetRequestWithoutParameters<TOut>(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(apiUrl);
                var response = result.Content.ReadAsStringAsync().Result;
                TOut model = JsonConvert.DeserializeObject<TOut>(response);
                return model;
            }
        }



        public virtual async Task<IResult> PutRequest<T>(string apiUrl, T putModel)
        {
            using (var client = new HttpClient())
            {
                var result = await client.PutAsJsonAsync(apiUrl, putModel);
                var response = result.Content.ReadAsStringAsync().Result;
                Result resultContent = JsonConvert.DeserializeObject<Result>(response);
                return resultContent;
            }
        }

        public async Task<IResult> DeleteRequest<T>(string apiUrl, int id)
        {
            using (var client = new HttpClient())
            {
                var result = await client.DeleteAsync(apiUrl + "?id=" + id);
                var response = result.Content.ReadAsStringAsync().Result;
                Result resultContent = JsonConvert.DeserializeObject<Result>(response);
                return resultContent;
            }
        }
    }
}
