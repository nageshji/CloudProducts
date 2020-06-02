using CloudProducts.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CloudProducts.Services
{
    public class ProductService : IProductService
    {
        private readonly IHttpService _httpService;

        public ProductService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public IEnumerable<ProductDto> GetProducts()
        {
            IList<ProductDto> products = null;
            var response = _httpService.GetResponse("Products");
            if (response.IsSuccessStatusCode)
            {
                Task<string> task = response.Content.ReadAsStringAsync();
                task.Wait();
                products = JsonConvert.DeserializeObject<List<ProductDto>>(task.Result);
            }
            return products;
        }
    }
}
