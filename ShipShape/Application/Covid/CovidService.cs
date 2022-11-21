using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace ShipShape.Application.Covid
{
    public class CovidService : ICovidService
    {
        public CovidService() { }

        public async Task<string> GetAsync()
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
                return token;
            }
        }
    }
}