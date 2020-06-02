using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CloudProducts.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _client;
        public HttpService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("http://alltheclouds.com.au/api/");            
            _client.Timeout = new TimeSpan(0, 0, 30);
            _client.DefaultRequestHeaders.Clear();
        }

        public HttpResponseMessage GetResponse(string url)
        {
            var request = new HttpRequestMessage(
               HttpMethod.Get,
               url);

            //Service configuration should be updated in config settings.
            request.Headers.Add("api-key", "API-960XBLU1RX2PC4X");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result;
        }
    }
}
