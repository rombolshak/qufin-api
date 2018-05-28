using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace Qufin.Api.Controllers
{
    // [ApiVersionNeutral]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Ping() => Ok();

        [HttpGet]
        public IActionResult AppVersion() => Ok(Assembly.GetExecutingAssembly().GetName().Version);
    }
}