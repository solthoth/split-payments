using Microsoft.AspNetCore.Mvc;
using SplitPayments.Data;
using SplitPayments.Models;
using SplitPayments.Services;
using System;

namespace SplitPayments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private readonly ISplitPaymentsRepository repository;
        private readonly ITemplateValidation validation;

        public TemplateController(ISplitPaymentsRepository repository, ITemplateValidation validation)
        {
            this.repository = repository;
            this.validation = validation;
        }

        [HttpPost]
        public IActionResult Post([FromBody]PaymentTemplate paymentTemplate)
        {
            if (validation.ValidateNewTemplate(paymentTemplate))
            {
                return SavePaymentTemplate(paymentTemplate);
            }
            return BadRequest();
        }

        private IActionResult SavePaymentTemplate(PaymentTemplate paymentTemplate)
        {
            try
            {
                repository.Add(paymentTemplate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult Get (string id)
        {
            var paymentTemplate = repository.Get(id);
            if(string.IsNullOrEmpty(paymentTemplate.Id))
            {
                return BadRequest();
            }
            return Ok(paymentTemplate);

        }

    }
}