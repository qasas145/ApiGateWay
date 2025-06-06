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
        [HttpGet("get")]
        public IActionResult Get() {
            _logger.LogInformation("Hello get from the get method");
            return Ok("Hello from the student controller");
        }
        [HttpGet("getdata")]
        public IActionResult GetData()
        {
            _logger.LogInformation("My information");
            return Ok("Data of Muhammad Elsayed");
        }
        [HttpPost("create")]
        [Authorize]
        public IActionResult InsertData(string data)
        {
            _logger.LogInformation("data sent is {0}", data);
            return Ok(data);
        }

    }
}
