using IMSProducer.Models;
using IMSProducer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IMSProducer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImsController : ControllerBase
    {
        private readonly ProducerService _producerService;

        public ImsController(ProducerService producerService)
        {
            _producerService = producerService;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInventory([FromBody] ImsUpdateRequest request)
        {
            var message = JsonSerializer.Serialize(request);

            await _producerService.ProduceAsync("InventoryUpdates", message);

            return Ok("Inventory Updated Successfully...");
        }
    }
}
