using Amazon.Runtime;

namespace AWSSDK.Benchmarks.MockedDynamoDB;

internal sealed class MockHttpClientFactory : HttpClientFactory
{
    private readonly DynamoDBResponseProvider _responseProvider;

    public MockHttpClientFactory(DynamoDBResponseProvider responseProvider)
    {
        _responseProvider = responseProvider;
    }

    public override HttpClient CreateHttpClient(IClientConfig clientConfig)
    {
        var handler = new MockHttpMessageHandler(_responseProvider);
        return new HttpClient(handler, disposeHandler: true);
    }

    public override bool UseSDKHttpClientCaching(IClientConfig clientConfig) => false;
}

internal sealed class MockHttpMessageHandler : HttpMessageHandler
{
    private readonly DynamoDBResponseProvider _responseProvider;

    public MockHttpMessageHandler(DynamoDBResponseProvider responseProvider)
    {
        _responseProvider = responseProvider;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var target = request.Headers.TryGetValues("X-Amz-Target", out var values)
            ? values.FirstOrDefault() ?? string.Empty
            : string.Empty;

        var response = _responseProvider.CreateResponse(target);
        response.RequestMessage = request;
        return Task.FromResult(response);
    }
}
