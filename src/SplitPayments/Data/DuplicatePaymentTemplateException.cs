using System;
using System.Runtime.Serialization;

namespace SplitPayments.Data
{
    [Serializable]
    public class DuplicatePaymentTemplateException : Exception
    {
        public DuplicatePaymentTemplateException()
        {
        }

        public DuplicatePaymentTemplateException(string message) : base(message)
        {
        }

        public DuplicatePaymentTemplateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicatePaymentTemplateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}