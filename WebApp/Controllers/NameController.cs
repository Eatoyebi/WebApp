using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostName([FromBody] NameRequest request)
        {
            return Ok(new { name = request.Name });
        }
    }

    public class NameRequest
    {
        public string Name { get; set; }
    }
}
