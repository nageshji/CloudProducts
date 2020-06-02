using System.Net.Http;

namespace CloudProducts.Services
{
    public interface IHttpService
    {
        public HttpResponseMessage GetResponse(string url);
    }
}
