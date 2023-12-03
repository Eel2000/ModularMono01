using Microsoft.AspNetCore.Mvc;

namespace ModularMono01.Components.B.Controllers
{
    [ApiController]
    [Route("api/b/[controller]")]
    public class GreatingController : ControllerBase
    {
        [HttpGet]
        public IActionResult SayHello() => Ok("Hello from component B");
    }
}
