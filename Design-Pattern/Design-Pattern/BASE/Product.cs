namespace Design_Pattern.BASE;

public enum ProductType
{
    Allgemein,
    MilchProdukt,
    Backware,
}

public class Product(string name, double price, ProductType productType)
{
    public string Name { get; } = name;
    public double Price { get; } = price;
    public ProductType Type { get; } = productType;
    

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Type: {Type}";
    }
}