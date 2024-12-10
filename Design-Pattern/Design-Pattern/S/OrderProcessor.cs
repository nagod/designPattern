
using System;

namespace Design_Pattern.S;

public class OrderProcessor
{
    private readonly NotificationService _notificationService;
    private readonly string _paymentMethod;

    public OrderProcessor(NotificationService notificationService, string paymentMethod)
    {
        _notificationService = notificationService;
        _paymentMethod = paymentMethod;
    }
    

    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Processing order...");

        if (_paymentMethod == "CreditCard")
        {
            Console.WriteLine($"Processing credit card payment of {order.TotalAmount:C}...");
        }
        else if (_paymentMethod == "PayPal")
        {
            Console.WriteLine($"Processing PayPal payment of {order.TotalAmount:C}...");
        }
        else
        {
            Console.WriteLine("Unsupported payment method!");
            return;
        }
        _notificationService.NotifyCustomer();
        Console.WriteLine($"Order processed successfully for {order.Products.Count} items.");
    }
}


