namespace Design_Pattern.O;

public class ShoppingList
{
    private readonly List<Product> _products;
    private readonly ProductFilterService _productFilterService = new ProductFilterService();
    
    private ShoppingList()
    {
        _products = new List<Product>();
    }

    private ShoppingList(List<Product> items)
    {
        _products = items;
    }

    public static ShoppingList Create(List<Product> items) => new ShoppingList(items);
    public static ShoppingList Empty() => new ShoppingList();

    public void AddProduct(Product product) => _products.Add(product);
    public void RemoveProduct(Product product) => _products.Remove(product);

    public override string ToString()
    {
        return string.Join(Environment.NewLine, _products);
    }

    public ShoppingList GetItemsByType(ProductType type)
    {
        List<Product> result = new List<Product>();
        foreach (Product product in _productFilterService.FilterByType(_products, type))
        {
            result.Add(product);
        }

        return Create(result);
    }
    
    public ShoppingList GetItemsByPrice(double price)
    {
        List<Product> result = new List<Product>();
        foreach (Product product in _productFilterService.FilterByPrice(_products, price))
        {
            result.Add(product);
        }

        return Create(result);
    }
}