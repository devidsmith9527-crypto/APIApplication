using Microsoft.AspNetCore.Mvc;

namespace APIApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WelcomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var response = new { greeting = "Welcome to Web API" };
        return Ok(response);
    }
}