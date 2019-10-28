using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SplitPayments.Services;
using SplitPayments.Models;


namespace SplitPayments.UnitTests.Services
{
    [TestFixture]
   public class TemplateValidationTests
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("     ")]
        public void Given_IdWithInvalidValue_WhenValidingNewTemplate_ThenReturnsFalse(string id)
        {
            var service = new TemplatePaymentValidation();
            var foo = new PaymentTemplate();
            foo.Id = id;
            var result = service.ValidateNewTemplate(foo);
            Assert.IsFalse(result);

        }
        [Test]
        public void Given_ValidPaymentTemplate_WhenValidingNewTemplate_ThenReturnsTrue()
        {
            var service = new TemplatePaymentValidation();
            var foo = new PaymentTemplate();
            foo.Id = "hello";
            foo.Splits.Add(new Payee());
            var result = service.ValidateNewTemplate(foo);
            Assert.IsTrue(result);

        }
    
    }
}
