using System;
using System.Collections.Generic;

namespace Design_Pattern.BASE;

public class Order
{
    private readonly List<Product> _products = new List<Product>();
    private double _totalAmount;
    private string _paymentMethod;
    private string _notificationMethod;

    // Produkt zur Bestellung hinzufügen
    public void AddProduct(Product product)
    {
        _products.Add(product);
        _totalAmount += product.Price;
    }

    public void SetPaymentMethod(string method)
    {
        _paymentMethod = method;
    }

    public void SetNotificationMethod(string method)
    {
        _notificationMethod = method;
    }

    public void ProcessOrder()
    {
        Console.WriteLine("Processing order...");

        if (_paymentMethod == "CreditCard")
        {
            Console.WriteLine($"Processing credit card payment of {_totalAmount:C}...");
        }
        else if (_paymentMethod == "PayPal")
        {
            Console.WriteLine($"Processing PayPal payment of {_totalAmount:C}...");
        }
        else
        {
            Console.WriteLine("Unsupported payment method!");
            return;
        }

        if (_notificationMethod == "Email")
        {
            Console.WriteLine("Sending email to customer: Your order has been processed!");
        }
        else if (_notificationMethod == "SMS")
        {
            Console.WriteLine("Sending SMS to customer: Your order has been processed!");
        }
        else
        {
            Console.WriteLine("Unsupported notification method!");
            return;
        }

        Console.WriteLine($"Order processed successfully for {_products.Count} items.");
    }
}