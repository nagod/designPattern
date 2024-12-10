using System;
using Design_Pattern.O.Interfaces;

namespace Design_Pattern.O.PaymentModel;

public class ApplePayPayment : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing ApplePay payment of {amount:C}...");
    }
}