namespace Design_Pattern.O.PaymentMethods;

public class PayPalPaymentService: IPaymentService
{
    /// <inheritdoc />
    public void PayOrder(double amount)
    {
        Console.WriteLine("Processing Order...");
        Console.WriteLine("Processing PayPal payment");
    }
}