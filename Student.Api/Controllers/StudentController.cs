using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Student.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Authorize]
        public IActionResult Get() {
            _logger.LogInformation("Hello get from the get method");
            return Ok("Hello from the student controller");
         }

    }
}
