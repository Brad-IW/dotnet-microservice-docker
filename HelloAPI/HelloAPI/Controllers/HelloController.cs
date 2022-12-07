using Microsoft.AspNetCore.Mvc;

namespace HelloAPI.Controllers;

[ApiController]
[Route("api/hello")]
public class HelloController : Controller
{
    [HttpGet]
    public string Get()
    {
        return "Hello!";
    }

    [HttpGet("{name}")]
    public string Get(string name)
    {
        return $"Hello {name}!";
    }
}
