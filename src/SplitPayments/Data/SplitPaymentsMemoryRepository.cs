using SplitPayments.Models;
using System;
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
            if (!Exists(paymentTemplete))
            {
                paymentTempletes.Add(paymentTemplete);
            }
            else 
            {
                throw new DuplicatePaymentTemplateException("PaymentTemplate already exists");
            }
        }

        private bool Exists(PaymentTemplate paymentTemplete)
        {
            return !string.IsNullOrEmpty(Get(paymentTemplete.Id).Id);
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
