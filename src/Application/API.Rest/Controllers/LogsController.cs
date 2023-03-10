using Microsoft.AspNetCore.Mvc;

namespace API.Rest.Controllers;

public class LogsController : Controller
{
    [HttpPost]
    [Route("[controller]/")]
    public IActionResult InsertLog()
    {
        return Ok();
    }

    [HttpGet]
    [Route("[controller]/")]
    public IActionResult GetLogs()
    {
        return Ok();
    }
}
