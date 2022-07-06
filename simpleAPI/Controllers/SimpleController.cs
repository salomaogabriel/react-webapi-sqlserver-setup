using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simpleAPI.Data;
using simpleAPI.Models;

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
     [HttpPost]
    public async Task<IActionResult> Add(RequestModel request )
    {
        var simpleModel = new Simple() {Name = request.Name};
        _context.TableName.Add(simpleModel);
                await _context.SaveChangesAsync();
       return Ok(_context.TableName);
    }
    
}
