using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using SplitPayments.Controllers;
using SplitPayments.Data;
using SplitPayments.Models;
using SplitPayments.Services;

namespace SplitPayments.UnitTests.Controllers
{
    [TestFixture]
    public class TemplateControllerTests
    {
        [Test]
        public void Given_Empty_PaymentTemplate_When_Submitting_Then_Returns_BadRequestResult()
        {
            //Arrange - Given
            var controller = CreateTemplateController();
            var paymentTemplate = new PaymentTemplate();
            //Act - When
            var result = controller.Post(paymentTemplate);
            //Assert - Then
            Assert.IsInstanceOf<BadRequestResult>(result);
        }

        [TestCase("Hello")]
        [TestCase("Hello     ")]
        [TestCase("      Hello")]
        [TestCase("      Hello       ")]
        public void Given_PaymentTemplate_With_Id_And_A_Split_When_Submitting_Then_Returns_OkResult(string id)
        {
            //Arrange - Given
            var controller = CreateTemplateController();
            var paymentTemplate = new PaymentTemplate
            {
                Id = id
            };
            paymentTemplate.Splits.Add(new Payee());
            //Act - When
            var result = controller.Post(paymentTemplate);
            //Assert - Then
            Assert.IsInstanceOf<OkResult>(result);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("      ")]
        public void Given_PaymentTemplate_With_Id_Null_Or_Empty_When_Submitting_Then_Returns_BadRequestResult(string id)
        {
            //Arrange - Given
            var controller = CreateTemplateController();
            var paymentTemplate = new PaymentTemplate();
            paymentTemplate.Id = id;
            //Act - When
            var result = controller.Post(paymentTemplate);
            //Assert - Then
            Assert.IsInstanceOf<BadRequestResult>(result);
        }
        [Test]
        public void Give_Nothing_WhenGetting_APaymentTemplate_Thenreturns_Badrequest()
        {
            var controller = CreateTemplateController();
            var result = controller.Get(null);
            Assert.IsInstanceOf<BadRequestResult>(result);

        }
        [Test]
        public void Given_Id_WhenGetting_APaymentTemplate_Thenreturns_OKObjectResult()
        {
            var controller = CreateTemplateController("okay");
            var result = controller.Get("okay");
            Assert.IsInstanceOf<OkObjectResult>(result);

        }
        [Test]
        public void Given_Id_WhenGetting_APaymentTemplate_Thenreturns_APaymentTemplatewithId()
        {

            var controller = CreateTemplateController("okay");
            var result = controller.Get("okay") as OkObjectResult;
            var paymentTemplate = result.Value as PaymentTemplate;
            Assert.IsFalse(string.IsNullOrWhiteSpace(paymentTemplate.Id));
            

        }
        [Test]
        public void Given_ABadId_WhenGetting_PaymentTemplate_Thenreturns_BadRequestResult()
        {
            var controller = CreateTemplateController("okay");
            var result = controller.Get("bad");
            Assert.IsInstanceOf<BadRequestResult>(result);

        }
        private TemplateController CreateTemplateController(string id = null)
        {
            var validator = new TemplatePaymentValidation();
            var repository = new SplitPaymentsMemoryRepository();
            if (id != null)
            {
                repository.Add(new PaymentTemplate { Id = id });
            }
            return new TemplateController(repository, validator);
        }

    }
}
