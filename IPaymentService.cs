using System;

namespace SOLID_2_OCP
{
    public interface IPaymentService {
        void Pay();
    }
    public class CashPaymentService : IPaymentService
    {
        public void Pay()
        {
            Console.WriteLine($"Cash payment -10");
        }
    }
    public class VisaPaymentService : IPaymentService
    {
        public void Pay()
        {
            Console.WriteLine($"Visa payment -20");
        }
    }
    public class PayPalPaymentService : IPaymentService
    {
        public void Pay()
        {
            Console.WriteLine($"PayPal payment -30");
        }
    }
}
