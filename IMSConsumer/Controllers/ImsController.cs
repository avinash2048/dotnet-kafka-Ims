using IMSConsumer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IMSConsumer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImsController : ControllerBase
   
        {
            private readonly ILogger _logger;

            public ImsController(ILogger logger)
            {
                _logger = logger;
            }

            [HttpPost]
            public IActionResult ProcessInventoryUpdate([FromBody] ImsUpdateRequest request)
            {
                return Ok("Inventory update processed successfully.");
            }
        }
    }

