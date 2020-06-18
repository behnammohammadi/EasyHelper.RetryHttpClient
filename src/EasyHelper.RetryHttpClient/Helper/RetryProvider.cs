using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyHelper.RetryHttpClient.Helper
{
    internal static class RetryProvider
    {
        /// <summary>
        /// Retry specified HttpCall.
        /// </summary>
        /// <param name="func">Code to be called</param>
        /// <param name="retryCount">Retry count if failure happened</param>
        /// <param name="interval">Interval between retries</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<T> Retry<T>(Func<Task<T>> func, int retryCount, int interval) where T : HttpResponseMessage
        {
            T result = null;
            try
            {
                result = await func().ConfigureAwait(false);

                if (result.IsSuccessStatusCode)
                {
                    return result;
                }
            }
            catch
            {
                if (retryCount == 0)
                {
                    throw;
                }
            }

            for (int i = 1; i <= retryCount; i++)
            {
                try
                {
                    await Task.Delay(interval).ConfigureAwait(false);
                    result = await func().ConfigureAwait(false);
                    if (result.IsSuccessStatusCode)
                    {
                        break;
                    }
                }
                catch
                {
                    if (i == retryCount)
                    {
                        throw;
                    }
                }
            }

            return result;
        }
    }
}
