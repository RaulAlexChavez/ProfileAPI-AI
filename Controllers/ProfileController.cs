using Microsoft.AspNetCore.Mvc;

namespace ProfileAPI_AI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase {

    [HttpGet(Name = "GetProfile")]
    public ActionResult<string> Get() {
        return Ok("This is my profile!");
    }
}
