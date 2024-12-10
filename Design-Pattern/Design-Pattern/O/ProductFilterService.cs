namespace Design_Pattern.O;

public class ProductFilterService
{
    public IEnumerable<Product> FilterByType(IEnumerable<Product> products, ProductType type)
    {
        foreach (Product product in products)
        {
            if (product.Type == type)
                yield return product;
        }
    }

    public IEnumerable<Product> FilterByPrice(IEnumerable<Product> products, double price)
    {
        foreach (Product product in products)
        {
            if (product.Price < price)
                yield return product;
        }
    }

    public IEnumerable<Product> FilterByTypeAndByPrice(IEnumerable<Product> products, ProductType type,
        double price)
    {
        foreach (Product product in products)
        {
            if (product.Price < price && product.Type == type)
                yield return product;
        }
    }
}