using SplitPayments.Models;

namespace SplitPayments.Services
{
    public interface ITemplateValidation
    {
        bool ValidateNewTemplate(PaymentTemplate paymentTemplate);
    }
}