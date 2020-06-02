using AutoMapper;
using CloudProducts.Managers;

namespace CloudProducts.Models
{
    public class ProductMapperProfile: Profile
    {
        public ProductMapperProfile()
        {
            CreateMap<ProductDto, Product>()
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => ProductManager.GetProductPrice(src.UnitPrice)));
        }        
    }
}