using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Payment.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PaymentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello Muhammad Elsayed Elqasas");
            Console.ForegroundColor = ConsoleColor.White;
            return Ok("Hello From the payment project");
        }
    }
}
