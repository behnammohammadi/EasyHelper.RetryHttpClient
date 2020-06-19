using EasyHelper.RetryHttpClient.Helper;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EasyHelper.RetryHttpClient.Extensions
{
    public static class HttpClientExtensionPut
    {
        /// <summary>
        /// Send retriable PUT request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<HttpResponseMessage> RetryPutAsync(this HttpClient httpClient, string requestUri, HttpContent content, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.PutAsync(requestUri, content), tryCount, interval);
        }

        /// <summary>
        /// Send retriable PUT request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<HttpResponseMessage> RetryPutAsync(this HttpClient httpClient, Uri requestUri, HttpContent content, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.PutAsync(requestUri, content), tryCount, interval);
        }

        /// <summary>
        /// Send retriable PUT request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<HttpResponseMessage> RetryPutAsync(this HttpClient httpClient, string requestUri, HttpContent content,
            CancellationToken cancellationToken, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.PutAsync(requestUri, content, cancellationToken), tryCount, interval);
        }

        /// <summary>
        /// Send retriable PUT request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<HttpResponseMessage> RetryPutAsync(this HttpClient httpClient, Uri requestUri, HttpContent content,
            CancellationToken cancellationToken, int tryCount, int interval = 0)
        {
            return await RetryProvider.Retry
                (async () => await httpClient.PutAsync(requestUri, content, cancellationToken), tryCount, interval);
        }
    }
}
