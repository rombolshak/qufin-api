using Microsoft.AspNetCore.Mvc;
using Qufin.Api.Controllers;
using Xunit;

namespace Qufin.Api.Tests
{
    public class HealthControllerTests
    {
        [Fact]
        public void TestPing()
        {
            var controller = new HealthController();
            var result = controller.Ping();
            Assert.Equal(true, result is StatusCodeResult);
            Assert.Equal(200, ((StatusCodeResult)result).StatusCode);
        }
    }
}