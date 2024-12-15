using System;

namespace Design_Pattern.S;

public class NotificationService
{
    public NotificationService(string notificationMethod)
    {
        NotificationMethod = notificationMethod;
    }

    public string NotificationMethod { get; set; }

    public void NotifyCustomer()
    {
        if (NotificationMethod == "Email")
        {
            Console.WriteLine("Sending email to customer: Your order has been processed!");
        }
        else if (NotificationMethod == "SMS")
        {
            Console.WriteLine("Sending SMS to customer: Your order has been processed!");
        }
        else
        {
            Console.WriteLine("Unsupported notification method!");
        }
    }
}