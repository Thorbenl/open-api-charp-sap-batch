# Org.OpenAPITools.Api.BatchRequestsApi

All URIs are relative to *https://localhost/service-root*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchPost**](BatchRequestsApi.md#batchpost) | **POST** /$batch | Send a group of requests |

<a id="batchpost"></a>
# **BatchPost**
> string BatchPost ()

Send a group of requests

Group multiple requests into a single request payload, see [Batch Processing (OData Version 2.0)](https://www.odata.org/documentation/odata-version-2-0/batch-processing/).  *Please note that \"Try it out\" is not supported for this request.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BatchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/service-root";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BatchRequestsApi(httpClient, config, httpClientHandler);

            try
            {
                // Send a group of requests
                string result = apiInstance.BatchPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchRequestsApi.BatchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a group of requests
    ApiResponse<string> response = apiInstance.BatchPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchRequestsApi.BatchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/mixed;boundary=request-separator
 - **Accept**: multipart/mixed, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Batch response |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

