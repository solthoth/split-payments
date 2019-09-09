using Microsoft.AspNetCore.Mvc;
using SplitPayments.Data;
using SplitPayments.Models;

namespace SplitPayments.Controllers
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