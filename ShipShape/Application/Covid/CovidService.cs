using Azure;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ShipShape.Application.Covid
{
    public class CovidService : ICovidService
    {
        public CovidService() { }

        public async Task<string> GetAsync(string countryCode)
        {
            using (HttpClient httpClient = new())
            {
                var requestContent = new FormUrlEncodedContent(new[] {
    new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded"),
    new KeyValuePair<string, string>("grant_type", "client_credentials"),
    new KeyValuePair<string, string>("client_id", "fEucMZOmKgYSHDfVRlknC6sGtFkT2M7p"),
    new KeyValuePair<string, string>("client_secret", "JE2G5d5oI7cFWSaC"),
});
                using HttpResponseMessage response = await httpClient.PostAsync("https://test.api.amadeus.com/v1/security/oauth2/token", requestContent);

                var jsonResponse = await response.Content.ReadAsStringAsync();

                var token = JObject.Parse(jsonResponse)["access_token"].ToString();


                using (var httpClient2 = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), $"https://test.api.amadeus.com/v2/duty-of-care/diseases/covid19-area-report?countryCode={countryCode}&language=EN"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "application/json");
                        request.Headers.TryAddWithoutValidation("Authorization", "Bearer KzVXtRwUyLODqJFqyAnbFaGlrciy");

                        var response2 = await httpClient.SendAsync(request);
                        var countryResult = await response2.Content.ReadAsStringAsync();

                        //TODO get nested object
                        //var riskLevel = JObject.Parse(jsonResponse)["diseaseRiskLevel"].ToString(); 

                        return countryResult;
                    }

                }
            }
        }
    }
}