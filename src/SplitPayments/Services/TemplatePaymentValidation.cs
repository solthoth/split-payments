using SplitPayments.Models;

namespace SplitPayments.Services
{
    public class TemplatePaymentValidation : ITemplateValidation
    {
        public bool ValidateNewTemplate(PaymentTemplate paymentTemplate)
        {
            return !string.IsNullOrWhiteSpace(paymentTemplate.Id) && paymentTemplate.Splits.Count>0 ;
        }
    }
}
