using EasyHelper.RetryHttpClient.Helper;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EasyHelper.RetryHttpClient.Extensions
{
    public static class HttpClientExtensionSend
    {
        /// <summary>
        /// Send retriable SEND request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="request">Represents a HTTP request message.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<HttpResponseMessage> RetrySendAsync(this HttpClient httpClient, HttpRequestMessage request, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.SendAsync(request), tryCount, interval);
        }

        /// <summary>
        /// Send retriable SEND request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="request">Represents a HTTP request message.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<HttpResponseMessage> RetrySendAsync(this HttpClient httpClient, HttpRequestMessage request,
            CancellationToken cancellationToken, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.SendAsync(request, cancellationToken), tryCount, interval);
        }

        /// <summary>
        /// Send retriable SEND request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="request">Represents a HTTP request message.</param>
        /// <param name="completionOption">An HTTP completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<HttpResponseMessage> RetrySendAsync(this HttpClient httpClient, HttpRequestMessage request, HttpCompletionOption completionOption, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.SendAsync(request, completionOption), tryCount, interval);
        }

        /// <summary>
        /// Send retriable SEND request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="request">Represents a HTTP request message.</param>
        /// <param name="completionOption">An HTTP completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<HttpResponseMessage> RetrySendAsync(this HttpClient httpClient, HttpRequestMessage request, HttpCompletionOption completionOption,
            CancellationToken cancellationToken, int tryCount, int interval)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.SendAsync(request, completionOption, cancellationToken), tryCount, interval);
        }
    }
}
