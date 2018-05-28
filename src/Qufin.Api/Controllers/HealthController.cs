using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace Qufin.Api.Controllers
{
    [ApiVersionNeutral]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Ping() => Ok();

        [HttpGet]
        public IActionResult AppVersion() => Ok(Assembly.GetExecutingAssembly().GetName().Version);
    }
}