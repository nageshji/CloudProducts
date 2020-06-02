using CloudProducts.Models;
using System.Collections.Generic;

namespace CloudProducts.Services
{
    public interface IProductRepository
    {
        public IEnumerable<ProductDto> GetProducts();        
    }
}
