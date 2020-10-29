using System;

namespace SOLID_2_OCP
{
    class Program
    {

        static void Main(string[] args)
        {
            PaymentService paymentService = new PaymentService();
            paymentService.Pay(PaymentService.PaymentType.Cash);
            paymentService.Pay(PaymentService.PaymentType.Visa);

            Console.WriteLine("----------OCP--------");
            IPaymentService paymentServiceRefactored;
            paymentServiceRefactored = new CashPaymentService();
            paymentServiceRefactored.Pay();
            paymentServiceRefactored = new VisaPaymentService();
            paymentServiceRefactored.Pay();
            paymentServiceRefactored = new PayPalPaymentService();
            paymentServiceRefactored.Pay();
            Console.ReadLine();
        }
    }
}
