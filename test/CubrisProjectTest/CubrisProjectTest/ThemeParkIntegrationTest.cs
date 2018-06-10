using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CubrisProjectTest
{
    public class ThemeParkIntegrationTest
    {
        [Fact]
        public async Task Test_Get_All()
        {
            var client = new TestClientProvider().Client;

            var response = await client.GetAsync("/api/ThemeParks/1");

            response.EnsureSuccessStatusCode();

            Assert.NotEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
