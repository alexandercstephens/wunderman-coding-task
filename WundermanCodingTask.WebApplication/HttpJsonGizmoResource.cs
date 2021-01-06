using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WundermanCodingTask.WebApplication.Models;

namespace WundermanCodingTask.WebApplication
{
    /// <summary>
    /// Resource that fetches gizmos via an HTTP endpoint that returns data in JSON format.
    /// </summary>
    public class HttpJsonGizmoResource : IGizmoResource
    {
        private readonly string _url;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public HttpJsonGizmoResource(string url, JsonSerializerOptions jsonSerializerOptions)
        {
            _url = url;
            _jsonSerializerOptions = jsonSerializerOptions;
        }

        public async Task<IEnumerable<GizmoModel>> Fetch()
        {
            var client = new HttpClient();
            var httpResponse = await client.GetAsync(_url);
            var jsonString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<GizmoModel[]>(jsonString, _jsonSerializerOptions);
        }
    }
}
