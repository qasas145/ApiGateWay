using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Student.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        public StudentController(ILogger<StudentController> logger) => _logger = logger;

        [HttpGet("getdata")]
        public IActionResult GetData() => Ok("Name : 'Muhammad'");

        [HttpPost("create")]
        [Authorize]
        public IActionResult InsertData(string data) => Ok(data);


        [HttpPost("createdata")]
        public IActionResult InsertDataWithoutAuth(string data) => Ok(data);
    }
}
