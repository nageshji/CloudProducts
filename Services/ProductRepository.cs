using CloudProducts.Models;
using System.Collections.Generic;

namespace CloudProducts.Services
{
    public class ProductRepository : IProductRepository
    {
        // Fields
        private readonly IProductService _productService;
        public ProductRepository(IProductService productService)
        {
            _productService = productService;
        }

        // Methods
        public IEnumerable<ProductDto> GetProducts()
        {
            return _productService.GetProducts();
        }
    }
}
