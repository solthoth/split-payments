using SplitPayments.Models;
using System.Collections.Generic;

namespace SplitPayments.Data
{
    public class SplitPaymentsMemoryRepository : ISplitPaymentsRepository
    {
        private List<PaymentTemplate> paymentTempletes;
        public SplitPaymentsMemoryRepository()
        {
           paymentTempletes = new List<PaymentTemplate>();
        }
        public void Add(PaymentTemplate paymentTemplete)
        {
            paymentTempletes.Add(paymentTemplete);
        }
    }
}
