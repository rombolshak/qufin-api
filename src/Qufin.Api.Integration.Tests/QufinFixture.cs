using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Qufin.Api.Integration.Tests
{
    public class QufinFixture : IDisposable
    {
        public QufinFixture()
        {
            var builder = new WebHostBuilder()
                          .UseEnvironment("Development")
                          .UseStartup(typeof(Startup));

            var server = new TestServer(builder);
            Client = server.CreateClient();
        }
        
        public HttpClient Client { get; }

        public void Dispose()
        {
            Client?.Dispose();
        }
    }
}