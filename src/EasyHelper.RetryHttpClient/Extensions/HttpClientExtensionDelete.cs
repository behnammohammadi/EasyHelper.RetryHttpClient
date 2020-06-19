using EasyHelper.RetryHttpClient.Helper;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EasyHelper.RetryHttpClient.Extensions
{
    public static class HttpClientExtensionDelete
    {
        /// <summary>
        /// Send retriable DELETE request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static Task<HttpResponseMessage> RetryDeleteAsync(this HttpClient httpClient, string requestUri, int tryCount, int interval = 0)
        {
            return RetryProvider.Retry
                (() => httpClient.DeleteAsync(requestUri), tryCount, interval);
        }

        /// <summary>
        /// Send retriable DELETE request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static Task<HttpResponseMessage> RetryDeleteAsync(this HttpClient httpClient, Uri requestUri, int tryCount, int interval = 0)
        {
            return RetryProvider.Retry
                (() => httpClient.DeleteAsync(requestUri), tryCount, interval);
        }

        /// <summary>
        /// Send retriable DELETE request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static Task<HttpResponseMessage> RetryDeleteAsync(this HttpClient httpClient, string requestUri, CancellationToken cancellationToken, int tryCount, int interval = 0)
        {
            return RetryProvider.Retry
                (() => httpClient.DeleteAsync(requestUri, cancellationToken), tryCount, interval);
        }

        /// <summary>
        /// Send retriable DELETE request to the specified parameters as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="tryCount">Max try count if SuccessStatusCode equal to false</param>
        /// <param name="interval">Interval between calls in millisecond</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static Task<HttpResponseMessage> RetryDeleteAsync(this HttpClient httpClient, Uri requestUri, CancellationToken cancellationToken, int tryCount, int interval = 0)
        {
            return RetryProvider.Retry
                (() => httpClient.DeleteAsync(requestUri, cancellationToken), tryCount, interval);
        }

    }
}
