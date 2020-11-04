using FluentValidation.Results;
using System;
using System.Linq;

namespace ApiResult.Builders
{
    namespace ApiResult.Builders
    {
        public class ApiResultBuilder : IApiResult
        {
            private bool _success;
            private string _message;
            private object _data;

            public IApiResult<TResult> Sucess<TResult>(TResult source, string message = null)
            {
                _success = true;
                _data = source;
                _message = message;

                return new ApiResult<TResult>(_success, (TResult)_data, _message);
            }

            public IApiResult<TResult> Error<TResult>(TResult source, string message = null)
            {
                _success = false;
                _data = source;
                _message = message;

                return new ApiResult<TResult>(_success, (TResult)_data, _message);
            }

            public IApiResult<TResult> From<TResult>(TResult source)
            {
                if (typeof(TResult) != typeof(ValidationResult))
                    throw new NotImplementedException($"Error when handling type {typeof(TResult)}.");

                FromValidationResult(source);
                return new ApiResult<TResult>(_success, (TResult)_data, _message);
            }

            private void FromValidationResult<TResult>(TResult source)
            {
                var validation = (ValidationResult)(object)source;

                _success = validation.IsValid;

                if(validation.Errors.Any())
                    _message = string.Join("\n", validation.Errors.Select(error => error.ErrorMessage));

                _data = null;
            }

        }
    }

}
