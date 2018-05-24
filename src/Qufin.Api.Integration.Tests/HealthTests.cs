using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using Newtonsoft.Json;
using Xunit;

namespace Qufin.Api.Integration.Tests
{
    public class HealthTests : IClassFixture<QufinFixture>
    {
        public HealthTests(QufinFixture fixture)
        {
            _client = fixture.Client;
        }

        [Fact]
        public async void TestPing()
        {
            var result = await _client.GetAsync($"{ControllerUri}/ping");
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        public async void TestAppVersion()
        {
            var result = await _client.GetAsync($"{ControllerUri}/appVersion");
            result.EnsureSuccessStatusCode();
            
            var content = await result.Content.ReadAsStringAsync();
            var version = JsonConvert.DeserializeObject<Version>(content);
            
            Assert.Equal(Assembly.GetExecutingAssembly().GetName().Version, version);
        }

        private readonly HttpClient _client;
        private const string ControllerUri = "/api/v1/health";
    }
}