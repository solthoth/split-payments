using SplitPayments.Models;

namespace SplitPayments.Data
{
    public interface ISplitPaymentsRepository
    {
        void Add(PaymentTemplate paymentTemplete);
        PaymentTemplate Get(string id);
    }
}