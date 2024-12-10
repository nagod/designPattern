using System;
using Design_Pattern.O.Interfaces;

namespace Design_Pattern.O.PaymentModel;

public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount:C}...");
    }
}