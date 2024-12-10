namespace Design_Pattern.S;

public class PaymentService
{
    private readonly string _paymentMethod;

    public PaymentService(string paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }
    
    public void PayOrder(double totalAmount)
    {
        Console.WriteLine("Processing Order...");

        if (_paymentMethod.Equals("PayPal"))
        {
            Console.WriteLine("Processing PayPal payment");
        }
        else if (_paymentMethod.Equals("CreditCard"))
        {
            Console.WriteLine("Processing credit card payment");
        }
        else
        {
            Console.WriteLine("Unknown payment method. Process failed");
        }

        Console.WriteLine($"You have paid {totalAmount:C}\n");
    }
}