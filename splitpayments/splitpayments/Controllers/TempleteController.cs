using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using splitpayments.Data;

namespace splitpayments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempleteController : ControllerBase
    {
        public IActionResult Post([FromBody]PaymentTemplete paymentTemplete)
        {
            SplitPaymentsMemoryRepository repository = new SplitPaymentsMemoryRepository();
            repository.Add(paymentTemplete);
            return Ok();
        }

    }
}