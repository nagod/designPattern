using Design_Pattern.BASE;

namespace Design_Pattern.S;

public class InvoiceService
{
    public void CreateInvoice(List<Product> products)
    {
        if (products.Count == 0)
        {
            Console.WriteLine("Could not create an invoice, because your shopping list is empty.\n");
            return;
        }

        Console.WriteLine("----Your Invoice---");
        products.ForEach(Console.WriteLine);
        Console.WriteLine("-------------------");
    }

    public void SendInvoiceMail()
    {
        // do stuff
    }
}