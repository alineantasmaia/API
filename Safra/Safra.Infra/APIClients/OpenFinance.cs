using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Safra.Infra.APIClients
{
    public class OpenFinance
    {
        public OpenFinance()
        {
            HttpClient httoClientFinance = new()
            {
                BaseAddress = new Uri("https://yfapi.net/")
            };
            httoClientFinance.DefaultRequestHeaders.Add("X-API-KEY", "eiFrJEk9Ql2od2ocG0TzR7JgV3mL4R2c2KPV1fES");
            httoClientFinance.DefaultRequestHeaders.Add("accept", "application/json");

            RunAsync(httoClientFinance).GetAwaiter().GetResult();

        }

        private static async Task RunAsync(HttpClient httpClient)
        {
            var response = await httpClient.GetAsync("/v7/finance/options/AAPL");
            var responseBody = await response.Content.ReadAsStringAsync();
        }
    }
}
