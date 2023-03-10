using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Rest.Controllers;

public class ClientController : Controller
{
    [HttpPost]
    [Route("[controller]/")]
    public async Task<IActionResult> PostClient([FromBody] ClientViewModel client)
    {
        Serilog.Log.Information($"PostClient method called: {client.Name}");

        return Ok();
    }

    [HttpGet]
    [Route("[controller]/")]
    public async Task<IActionResult> GetClient([FromQuery] string name)
    {
        Serilog.Log.Information($"GetClient method called. With the parameter name={name}");

        return Ok();
    }
}
