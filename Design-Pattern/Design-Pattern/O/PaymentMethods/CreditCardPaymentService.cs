namespace Design_Pattern.O.PaymentMethods;

public class CreditCardPaymentService :  IPaymentService
{
    /// <inheritdoc />
    public void PayOrder(double amount)
    {
        Console.WriteLine("Processing Order...");
        Console.WriteLine("Processing credit card payment");
    }
}