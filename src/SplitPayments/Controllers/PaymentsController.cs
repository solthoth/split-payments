using Microsoft.AspNetCore.Mvc;
using SplitPayments.Models;

namespace SplitPayments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        public IActionResult Get(string id)
        {

            return Ok(true);

        }

        [HttpPost]
        public IActionResult Post([FromBody]Payment payment)
        {

            return Ok();

        }
    }
}