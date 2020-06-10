using AutoMapper;
using CloudProducts.Models;
using CloudProducts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CloudProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductRepository _productRepository;
        private readonly ILogger<ProductsController> _logger;
        private IMapper _mapper;
       
        public ProductsController(ILogger<ProductsController> logger, 
            IProductRepository productRepository, 
            IMapper mapper)
        {
            _productRepository = productRepository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _mapper.Map<List<Product>>(_productRepository.GetProducts());           
        }        
    }
}