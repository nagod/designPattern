
using System;
using Design_Pattern.O.Interfaces;

namespace Design_Pattern.O;

public class OrderProcessor
{
    private readonly NotificationService _notificationService;
    private readonly IPaymentProcessor _paymentProcessor;

    public OrderProcessor(NotificationService notificationService, IPaymentProcessor paymentProcessor)
    {
        _notificationService = notificationService;
        _paymentProcessor = paymentProcessor;
    }
    

    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Processing order...");
        _paymentProcessor.ProcessPayment(order.TotalAmount);
        _notificationService.NotifyCustomer();
        Console.WriteLine($"Order processed successfully for {order.Products.Count} items.");

    }
}
