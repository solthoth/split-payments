using SplitPayments.Models;

namespace SplitPayments.Services
{
    public class TemplatePaymentValidation : ITemplateValidation
    {
        public bool ValidateNewTemplate(PaymentTemplate paymentTemplate)
        {
            return HasIdentifier(paymentTemplate) && HasPaymentSplits(paymentTemplate);
        }

        private static bool HasPaymentSplits(PaymentTemplate paymentTemplate)
        {
            return paymentTemplate.Splits.Count > 0;
        }

        private static bool HasIdentifier(PaymentTemplate paymentTemplate)
        {
            return !string.IsNullOrWhiteSpace(paymentTemplate.Id);
        }
    }
}
