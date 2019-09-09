using SplitPayments.Models;
using System.Collections.Generic;

namespace SplitPayments.Data
{
    public class SplitPaymentsMemoryRepository
    {

        private List<PaymentTemplete> paymentTempletes;
        public SplitPaymentsMemoryRepository()
        {
           paymentTempletes = new List<PaymentTemplete>();
        }

        public void Add(PaymentTemplete paymentTemplete)
        {
            paymentTempletes.Add(paymentTemplete);
        }
    }
}
