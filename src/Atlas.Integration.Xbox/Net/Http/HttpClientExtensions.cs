using System.Net.Http;
using System.Threading.Tasks;

namespace Atlas.Integration.Xbox.Net.Http
{
    public static class HttpClientExtensions
    {
        public static async Task<T> GetAsync<T>(this HttpClient client, string requestUri)
        {
            HttpResponseMessage Response = await client.GetAsync(requestUri);

            Response.EnsureSuccessStatusCode();

            return await Response.Content.ReadAsJsonAsync<T>();
        }
    }
}
