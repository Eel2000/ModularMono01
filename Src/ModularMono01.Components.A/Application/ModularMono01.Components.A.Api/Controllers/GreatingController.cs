using Microsoft.AspNetCore.Mvc;

namespace ModularMono01.Components.A.Api.Controllers
{
    [ApiController]
    [Route("api/a/[controller]")]
    public class GreatingController : ControllerBase
    {

        [HttpGet]
        public IActionResult SayHello() => Ok("Hellom from component A");
    }
}
