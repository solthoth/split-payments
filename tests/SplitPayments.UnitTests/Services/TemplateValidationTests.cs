using FluentAssertions;
using NUnit.Framework;
using SplitPayments.Models;
using SplitPayments.Services;
using System;

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
