using Design_Pattern.BASE;
using Design_Pattern.S;
using ShoppingList = Design_Pattern.BASE.ShoppingList;
using ShoppinList_S = Design_Pattern.S.ShoppingList;


namespace Design_Pattern;

public static class Program
{
    private static void Main(string[] args)
    {
        Product skateboard = new Product("skateboard", 49.99, ProductType.Allgemein);
        Product schwarzbrot = new Product("schwarzbrot", 2.99, ProductType.Backware);
        Product milch = new Product("milch", 1.99, ProductType.MilchProdukt);

        /* BASE
        ShoppingList shoppingList = new ShoppingList("PayPal");
        
        // lets go shopping
        shoppingList.AddProduct(skateboard);
        shoppingList.AddProduct(schwarzbrot);
        shoppingList.AddProduct(milch);
        shoppingList.CreateInvoice();
        
        shoppingList.RemoveProduct(skateboard);
        shoppingList.CreateInvoice();
        
        shoppingList.PayOrder();
        shoppingList.CreateInvoice();
        
        */

        /*
        ShoppinList_S shoppingListS = new ShoppinList_S();
        PaymentService paymentService = new PaymentService("PayPal");
        InvoiceService invoiceService = new InvoiceService();
        
        
        shoppingListS.AddProduct(skateboard);
        shoppingListS.AddProduct(schwarzbrot);
        shoppingListS.AddProduct(milch);
        
        invoiceService.CreateInvoice(shoppingListS.Products);
        paymentService.PayOrder(shoppingListS.TotalAmount);
        */
        
        /* O
         * 
         */
        
        ShoppinList_S shoppingListS = new ShoppinList_S();
        PaymentService paymentService = new PaymentService("PayPal");
        InvoiceService invoiceService = new InvoiceService();
    }
}