using EasyHelper.RetryHttpClient.Helper;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EasyHelper.RetryHttpClient.Extensions
{
    public static class HttpClientExtensionGet
    {
        /// <summary>
        /// Send retriable GET request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> RetryGetAsync(this HttpClient httpClient, string requestUri, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.GetAsync(requestUri), tryCount, interval);
        }

        /// <summary>
        /// Send retriable GET request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> RetryGetAsync(this HttpClient httpClient, Uri requestUri, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.GetAsync(requestUri), tryCount, interval);
        }

        /// <summary>
        /// Send retriable GET request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="completionOption">An HTTP completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> RetryGetAsync(this HttpClient httpClient, string requestUri, HttpCompletionOption completionOption, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.GetAsync(requestUri, completionOption), tryCount, interval);
        }

        /// <summary>
        /// Send retriable GET request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="completionOption">An HTTP completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> RetryGetAsync(this HttpClient httpClient, Uri requestUri, HttpCompletionOption completionOption, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.GetAsync(requestUri, completionOption), tryCount, interval);
        }

        /// <summary>
        /// Send retriable GET request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> RetryGetAsync(this HttpClient httpClient, string requestUri, CancellationToken cancellationToken, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.GetAsync(requestUri, cancellationToken), tryCount, interval);
        }

        /// <summary>
        /// Send retriable GET request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> RetryGetAsync(this HttpClient httpClient, Uri requestUri, CancellationToken cancellationToken, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.GetAsync(requestUri, cancellationToken), tryCount, interval);
        }

        /// <summary>
        /// Send retriable GET request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="completionOption">An HTTP completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> RetryGetAsync(this HttpClient httpClient, string requestUri, HttpCompletionOption completionOption,
            CancellationToken cancellationToken, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.GetAsync(requestUri, completionOption, cancellationToken), tryCount, interval);
        }

        /// <summary>
        /// Send retriable GET request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="completionOption">An HTTP completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> RetryGetAsync(this HttpClient httpClient, Uri requestUri, HttpCompletionOption completionOption,
            CancellationToken cancellationToken, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.GetAsync(requestUri, completionOption, cancellationToken), tryCount, interval);
        }

    }
}
