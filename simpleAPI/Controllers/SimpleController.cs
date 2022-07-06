using Microsoft.AspNetCore.Mvc;
using simpleAPI.Data;

namespace simpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SimpleController : ControllerBase
{

    private readonly SimpleContext _context; 
    public SimpleController(SimpleContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
       return Ok(_context.TableName);
    }
}
