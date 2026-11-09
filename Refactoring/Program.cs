using Refactoring.Part_01.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {

          var aramex = new AramexCarrier();
          var aramexShipping = new ShippingCostCalculator(aramex);
          Console.WriteLine($"Aramex 2kg → {aramexShipping.Calculate(2)}");

          var fedEx = new FedExCarrier();
          var fedExShipping = new ShippingCostCalculator(fedEx);
          Console.WriteLine($"FedEx 2kg → {fedExShipping.Calculate(2)}");

            var repo = new SqlOrderRepository();
            var email = new SmtpEmailSender();
            
            var processor = new OrderProcessor(repo , email);
            processor.Process(1001, "customer@example.com");
            Console.WriteLine();

            var customerEmail = new Notification(new EmailNotification(),urgent: true,sendAt: DateTime.Today.AddHours(18));
            customerEmail.Send(
                "customer@example.com",
                "Your order ships tomorrow");


            var sms = new Notification(new SmsNotification(),urgent: true);
            sms.Send("+201000000000","OTP 4821");


        }
    }
}
