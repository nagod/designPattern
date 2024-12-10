
namespace Design_Pattern;

public static class Program
{
    private static void Main(string[] args)
    {
        Product skateboard = new Product("skateboard", 49.99, ProductType.Allgemein);
        Product schwarzbrot = new Product("schwarzbrot", 2.99, ProductType.Backware);
        Product milch = new Product("milch", 1.99, ProductType.MilchProdukt);
        
        BASE.Order baseOrder = new BASE.Order();
        
        // Zahlungsmethode und Benachrichtigung festlegen
        baseOrder.SetPaymentMethod("CreditCard");
        baseOrder.SetNotificationMethod("Email");
        
        // Produkte hinzufügen
        baseOrder.AddProduct(skateboard);
        baseOrder.AddProduct(schwarzbrot);
        baseOrder.AddProduct(milch);
        
        // Bestellung verarbeiten
        baseOrder.ProcessOrder();

        // 
        S.Order order = new S.Order();
        
        // // Produkte hinzufügen
        order.AddProduct(skateboard);
        order.AddProduct(schwarzbrot);
        order.AddProduct(milch);
        
        // Zahlungsmethode und Benachrichtigung festlegen
        S.NotificationService notificationService = new S.NotificationService("Email");
        S.OrderProcessor orderProcessor = new S.OrderProcessor(notificationService, "PayPal");
        
        // Bestellung verarbeiten
        orderProcessor.ProcessOrder(order);


        O.Order oOder = new O.Order();
        
        // // Produkte hinzufügen
        oOder.AddProduct(skateboard);
        oOder.AddProduct(schwarzbrot);
        oOder.AddProduct(milch);

        O.NotificationService oNotificationService = new O.NotificationService("Email");
        O.Interfaces.IPaymentProcessor paypalPayment = new O.PaymentModel.PayPalPayment();
        O.OrderProcessor oOrderProcessor = new O.OrderProcessor(oNotificationService, paypalPayment);
        
        oOrderProcessor.ProcessOrder(oOder);

    }
}

