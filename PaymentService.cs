using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_2_OCP
{
    public partial class PaymentService
    {
       public void Pay(PaymentType paymentType)
        {
            if (paymentType == PaymentType.Cash)
            {
                Console.WriteLine($"Cash payment -10");
            }
            if (paymentType == PaymentType.Visa)
            {
                Console.WriteLine($"Visa payment -20");
            }
        }
    }
}
