using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UserApiTest
{
    public abstract class RequestBase
    {
        public abstract HttpRequestMessage CreateRequestMessage();
        
        public virtual HttpRequestMessage CreateRequest<T>(T obj, string url, HttpMethod method)
        {
            var request = new HttpRequestMessage(method, url);
            request.Headers.Add("Accept", "application/json");
            request.Content = new StringContent(JsonConvert.SerializeObject(obj));
            return request;
        }
        
        
    }
    
    public static class HttpRequestExtension
    {
        public static async Task<T> ConvertToResponse<T>(this HttpResponseMessage response) where T : class
        {
            var buffer = await response.Content.ReadAsByteArrayAsync();
            var ourResponse = JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(buffer, 0, buffer.Length));
            return ourResponse;
        }
    }
}