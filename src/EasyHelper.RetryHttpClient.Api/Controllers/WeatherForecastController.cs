using EasyHelper.RetryHttpClient.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyHelper.RetryHttpClient.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public WeatherForecastController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<dynamic> Get()
        {
            var client = _httpClientFactory.CreateClient();
            var result = (await client.RetryDeleteAsync("https://webhook.site/6b39c76e-e661-44a5-9e7f-859c10802d22", 5, 3000));
            return result.IsSuccessStatusCode.ToString();

        }
    }
}
