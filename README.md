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

Now you can use SelectorAttribute in your code:
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
RetryDeleteAsync(Uri, CancellationToken)
RetryDeleteAsync(String, CancellationToken)
RetryDeleteAsync(String)
RetryDeleteAsync(Uri)
RetryGetAsync(Uri, CancellationToken)
RetryGetAsync(Uri, HttpCompletionOption, CancellationToken)
RetryGetAsync(String, HttpCompletionOption, CancellationToken)
RetryGetAsync(Uri, HttpCompletionOption)
RetryGetAsync(String)
RetryPostAsync(Uri, HttpContent, CancellationToken)
RetryPostAsync(String, HttpContent, CancellationToken)
RetryPostAsync(String, HttpContent)
RetryPostAsync(Uri, HttpContent)
RetryPutAsync(Uri, HttpContent, CancellationToken)
RetryPutAsync(String, HttpContent)
RetryPutAsync(Uri, HttpContent)
RetryPutAsync(String, HttpContent, CancellationToken)
RetrySendAsync(HttpRequestMessage, CancellationToken)
RetrySendAsync(HttpRequestMessage, HttpCompletionOption, CancellationToken)
RetrySendAsync(HttpRequestMessage)
RetrySendAsync(HttpRequestMessage, HttpCompletionOption)
```
