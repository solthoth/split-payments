using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
