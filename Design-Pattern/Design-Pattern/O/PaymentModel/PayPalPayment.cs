using System;
using Design_Pattern.O.Interfaces;

namespace Design_Pattern.O.PaymentModel;

public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount:C}...");
    }
}