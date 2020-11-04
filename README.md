# Api.Result

<a href="https://www.nuget.org/packages/Api.Result/">
<img src="https://img.shields.io/nuget/v/Api.Result.svg?style=flat" />
</a>
   
NuGet feeds
- Official releases: https://www.nuget.org/packages/Api.Result/

Api.Result is a basic package created to encapsulate, standardize and facilitate the return of results with messages, errors or data for communication between server to server, server to client or between application layers such as ASP.NET Core Web API.


## Dependencies
.NET Standard 2.0+

You can check supported frameworks here:

https://docs.microsoft.com/pt-br/dotnet/standard/net-standard

## Instalation
This package is available through Nuget Packages: https://www.nuget.org/packages/Api.Result

**Nuget**
```
Install-Package Api.Result

```

**.NET CLI**
```
dotnet add package Api.Result

```

# How to Use
To use with DI and `IServiceCollection` instance:

```c#
// Startup.cs
using ApiResult.Extensions;

//...
    public void ConfigureServices(IServiceCollection services)
    {
        //...
        services.AddApiResult();
        //...
    }
//...

```

```c#
// AppService.cs
using ApiResult;

//...
   public class MyAppService 
    {
        private readonly IApiResult _apiResult;
        
        public MyAppService(IApiResult apiResult)
        {
            _apiResult = apiResult;
        }
  
        public IApiResult<MyDTO> MyMethod()
        {
            try
            {
                var result = otherServiceInstance.GetMyDTOReturn();
        
                return _apiResult.Success(result);

            }
            catch (Exception e)
            {

                return _apiResult.Error(e.message);
            }

        }

    }
//...

```

## License

```
MIT License

Copyright (c) 2020 Rafael Viegas

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

```