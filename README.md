# EasyHelper.RetryHttpClient
![Nuget](https://img.shields.io/nuget/v/EasyHelper.RetryHttpClient)
![Nuget](https://img.shields.io/nuget/dt/EasyHelper.RetryHttpClient)
========

Retries can be an effective way to handle api call failures with HttpClient that occur with cross-component communication in a system.

Installation and usage
----------------------

All you need to do is just install a [NuGet package](https://www.nuget.org/packages/EasyHelper.RetryHttpClient/)
from the package manager console:
```
PM> Install-Package EasyHelper.RetryHttpClient
```
or through .NET CLI utility:
```
$ dotnet add package EasyHelper.RetryHttpClient
```

Now you can use extensions in your code:
```csharp
using EasyHelper.RetryHttpClient.Extensions;
```
```csharp
var client = _httpClientFactory.CreateClient();
var result = await client.RetryGetAsync("https://github.com", 5, 3000));
```
that attempt to call 3 times in case of failure with 5000 millisecond interval.

# Available methods
```
RetryDeleteAsync(Uri, CancellationToken, int tryCount, int interval)
RetryDeleteAsync(String, CancellationToken, int tryCount, int interval)
RetryDeleteAsync(String, int tryCount, int interval)
RetryDeleteAsync(Uri, int tryCount, int interval)
RetryGetAsync(Uri, CancellationToken, int tryCount, int interval)
RetryGetAsync(Uri, HttpCompletionOption, CancellationToken, int tryCount, int interval)
RetryGetAsync(String, HttpCompletionOption, CancellationToken, int tryCount, int interval)
RetryGetAsync(Uri, HttpCompletionOption, int tryCount, int interval)
RetryGetAsync(String, int tryCount, int interval)
RetryPostAsync(Uri, HttpContent, CancellationToken, int tryCount, int interval)
RetryPostAsync(String, HttpContent, CancellationToken, int tryCount, int interval)
RetryPostAsync(String, HttpContent, int tryCount, int interval)
RetryPostAsync(Uri, HttpContent, int tryCount, int interval)
RetryPutAsync(Uri, HttpContent, CancellationToken, int tryCount, int interval)
RetryPutAsync(String, HttpContent, int tryCount, int interval)
RetryPutAsync(Uri, HttpContent, int tryCount, int interval)
RetryPutAsync(String, HttpContent, CancellationToken, int tryCount, int interval)
RetrySendAsync(HttpRequestMessage, CancellationToken, int tryCount, int interval)
RetrySendAsync(HttpRequestMessage, HttpCompletionOption, CancellationToken, int tryCount, int interval)
RetrySendAsync(HttpRequestMessage, int tryCount, int interval)
RetrySendAsync(HttpRequestMessage, HttpCompletionOption, int tryCount, int interval)
```
