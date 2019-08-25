using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace splitpayments.Controllers
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