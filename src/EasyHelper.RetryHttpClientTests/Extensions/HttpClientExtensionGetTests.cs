using Moq;
using Moq.Protected;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EasyHelper.RetryHttpClient.Extensions.Tests
{
    public class HttpClientExtensionGetTests
    {
        [Fact()]
        public async Task RetryGetAsyncFailTest()
        {
            // Arrange
            var client = GetHttpClient(false);
            int retryCount = 3;
            int interval = 5000;

            // Act
            var watch = new Stopwatch();
            watch.Start();
            var result = await client.RetryGetAsync("https://google.com", retryCount, interval);
            watch.Stop();

            // Assert
            Assert.False(result.IsSuccessStatusCode);
            Assert.True(watch.ElapsedMilliseconds >= interval * retryCount);
        }

        [Fact()]
        public async Task RetryGetAsyncSuccessTest()
        {
            // Arrange
            var client = GetHttpClient(true);
            int retryCount = 3;
            int interval = 5000;

            // Act
            var watch = new Stopwatch();
            watch.Start();
            var result = await client.RetryGetAsync("https://google.com", retryCount, interval);
            watch.Stop();

            // Assert
            Assert.True(result.IsSuccessStatusCode);
            Assert.True(watch.ElapsedMilliseconds < interval * retryCount);
        }
        private HttpClient GetHttpClient(bool success)
        {
            var mockHandler = new Mock<HttpMessageHandler>();

            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage(success ? HttpStatusCode.OK : HttpStatusCode.BadGateway));

            return new HttpClient(mockHandler.Object);
        }
    }
}