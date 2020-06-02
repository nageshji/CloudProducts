
namespace CloudProducts.Models
{
    public class ProductDto
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? UnitPrice { get; set; }
        public double? MaximumQuantity { get; set; }
    }
}
