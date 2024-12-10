using System.Collections.Generic;

namespace Design_Pattern.S;

public class Order
{
    public void AddProduct(Product product)
    {
        Products.Add(product);
        TotalAmount += product.Price;
    }

    public List<Product> Products { get; } = new List<Product>();

    public double TotalAmount { get; private set; }
}