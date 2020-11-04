using ApiResult.Interfaces;
using Newtonsoft.Json;

namespace ApiResult
{
    public class ApiResult<TResult> : IApiResult<TResult>
    {

        [JsonConstructor]
        public ApiResult(bool success, TResult data, string message = null)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public ApiResult(bool success, TResult data)
        {
            Success = success;
            Message = null;
            Data = data;
        }

        public ApiResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        protected ApiResult() { }

        public bool Success { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TResult Data { get; private set; }
    }
}
