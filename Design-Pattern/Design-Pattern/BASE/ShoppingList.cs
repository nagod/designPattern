namespace Design_Pattern.BASE;

public class ShoppingList
{
    private readonly string _paymentMethod;

    public ShoppingList(string paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public List<Product> Products { get; } = new List<Product>();
    
    public double TotalAmount { get; private set; }

    public void AddProduct(Product p)
    {
        Products.Add(p);
        TotalAmount += p.Price;
    }

    public void RemoveProduct(Product p)
    {
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

    public void PayOrder()
    {
        Console.WriteLine("Processing Order...");
        Console.WriteLine("Processing PayPal payment");
        Console.WriteLine("Please log in to PayPal to complete the process\n");

        switch (_paymentMethod)
        {
            case "PayPal":
                Console.WriteLine("Processing PayPal payment");
                // Hier stellen wir uns mega komplexe logik vor
                break;
            case "CreditCard":
                Console.WriteLine("Processing credit card payment");
                // Hier stellen wir uns mega komplexe logik vor
                break;
            default:
                Console.WriteLine("Unknown payment method. Process failed");
                // Hier stellen wir uns mega komplexe logik vor
                break;
        }

        Console.WriteLine($" You have paid {TotalAmount:C}\n");
    }

    public void CreateInvoice()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("Could not create an invoice, because your shopping list is empty.\n");
            return;
        }

        Products.ForEach(Console.WriteLine);
        Console.WriteLine($"Your currently have to pay {TotalAmount:C}\n");
    }
}