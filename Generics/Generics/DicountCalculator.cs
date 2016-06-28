
namespace Generics
{
    public class DicountCalculator<TProduct> where TProduct : Product
    {
        public double CalculateDiscount(TProduct product)
        {
            return product.Price;
        } 
    }
}
