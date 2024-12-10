using Design_Pattern.BASE;

namespace Design_Pattern.S;

public class ShoppingList
{
    public List<Product> Products { get; private set; } = new List<Product>();

    public double TotalAmount { get; private set; }

    public void AddProduct(Product p)
    {
        Products.Add(p);
        TotalAmount += p.Price;
    }

    public void RemoveProduct(Product p)
    {
        if (Products.Count == 0) return;

        Product? foundItem = Products.Find(x => x.Equals(p));
        if (foundItem == null)
        {
            Console.WriteLine("Item could not be removed, because it was not present in your shopping list. ");
            return;
        }

        int removedItemsCount = Products.RemoveAll(x => x.Equals(p));
        TotalAmount -= removedItemsCount * foundItem.Price;
        Console.WriteLine($"{p.Name} has been deleted {removedItemsCount}-times.\nNew total amount {TotalAmount}\n");
    }
}