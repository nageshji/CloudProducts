using CloudProducts.Models;
using System.Collections.Generic;

namespace CloudProducts.Services
{
    public interface IProductService 
    {
        public IEnumerable<ProductDto> GetProducts();
    }
}
