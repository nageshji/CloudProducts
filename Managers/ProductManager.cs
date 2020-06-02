
namespace CloudProducts.Managers
{
    public static class ProductManager
    {
        public static double? GetProductPrice(double? price)
        {
            if (price != null)
                return price + price * 0.2;
            return 0;
        }
    }
}
