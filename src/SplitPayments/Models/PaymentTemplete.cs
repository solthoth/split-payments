using System.Collections.Generic;

namespace SplitPayments.Models
{
    public class PaymentTemplete
    {
        public string Id { get; set; }
        public List<Payee> Splits { get; set; }
    }
}
