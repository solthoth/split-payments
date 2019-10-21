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

        public PaymentTemplate Get(string id)
        {
            for (int i = 0; i < paymentTempletes.Count; i++)
            {
                if(paymentTempletes[i].Id == id)
                {
                    return paymentTempletes[i];

                }
            }
            return new PaymentTemplate();

        }
    }
}
