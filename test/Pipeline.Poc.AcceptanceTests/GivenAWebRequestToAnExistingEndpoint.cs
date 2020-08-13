using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Pipeline.Poc.AcceptanceTests
{
    public class GivenAWebRequestToAnExistingEndpoint
    {
        [Fact]
        public async Task UponCallingIt_ShouldRespondSuccessfully()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44346/weatherforecast");
            response.EnsureSuccessStatusCode();
        }
    }
}
