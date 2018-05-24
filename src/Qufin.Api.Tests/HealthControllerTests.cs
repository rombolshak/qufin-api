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
            Assert.Equal(typeof(OkResult), result.GetType());
        }

        [Fact]
        public void TestApiVersion()
        {
            var controller = new HealthController();
            var result = controller.AppVersion();
            Assert.Equal(typeof(OkResult), result.GetType());
        }
    }
}