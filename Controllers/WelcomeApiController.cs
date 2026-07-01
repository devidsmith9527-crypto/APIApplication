using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIApplication.Controllers
{
    [ApiController]
    [Route("api/Welcome")]
    public class WelcomeApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var response = new { greeting = "Welcome to Web API" };
            return Ok(response);
        }
    }
}