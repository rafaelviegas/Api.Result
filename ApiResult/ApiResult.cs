
namespace ApiResult
{

        public class ApiResult<TResult> : IApiResult<TResult>
        {
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

            public bool Success { get; private set; }
            public string Message { get; private set; }
            public TResult Data { get; private set; }
        }

    
}
