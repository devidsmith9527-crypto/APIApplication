using Microsoft.AspNetCore.Mvc;

namespace APIApplication.Controllers;

[ApiController]// ត្រួតពិនថា Controller នេះគឺជា API Controller
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