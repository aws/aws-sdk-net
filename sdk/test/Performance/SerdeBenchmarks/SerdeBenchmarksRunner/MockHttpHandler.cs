/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Net;
using System.Net.Http;
using Amazon.Runtime;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// A mock HttpMessageHandler that returns a pre-configured response without network I/O.
/// Used for E2E benchmarks to exercise the full SDK client pipeline (credentials, signing,
/// serialization, HTTP dispatch, deserialization) without actual service calls.
/// </summary>
public class MockHttpHandler : HttpMessageHandler
{
    private readonly byte[] _responseBody;
    private readonly string _contentType;
    private readonly HttpStatusCode _statusCode;
    private readonly Dictionary<string, string> _responseHeaders;

    public MockHttpHandler(byte[] responseBody, string contentType, HttpStatusCode statusCode = HttpStatusCode.OK, Dictionary<string, string>? responseHeaders = null)
    {
        _responseBody = responseBody;
        _contentType = contentType;
        _statusCode = statusCode;
        _responseHeaders = responseHeaders ?? new Dictionary<string, string>();
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        // Drain the request content to simulate the serialization cost.
        // In production, HttpClient calls content.SerializeToStreamAsync(networkStream) which
        // for ReadOnlyMemoryContent writes the span directly without allocating a byte[] copy.
        // CopyToAsync(Stream.Null) mirrors this behavior without network I/O.
        if (request.Content != null)
            await request.Content.CopyToAsync(Stream.Null, cancellationToken).ConfigureAwait(false);

        var response = new HttpResponseMessage(_statusCode)
        {
            Content = new ByteArrayContent(_responseBody)
        };
        response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(_contentType);

        foreach (var header in _responseHeaders)
        {
            response.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }

        // Add required AWS headers
        if (!response.Headers.Contains("x-amzn-RequestId"))
            response.Headers.TryAddWithoutValidation("x-amzn-RequestId", "benchmark-request-id");

        return response;
    }

    /// <summary>The canned response as raw HTTP/1.1 bytes, for the fixture server in the https transport.</summary>
    public byte[] BuildRawResponse()
    {
        var sb = new System.Text.StringBuilder();
        sb.Append($"HTTP/1.1 {(int)_statusCode} {_statusCode}\r\n");
        sb.Append($"Content-Type: {_contentType}\r\n");
        sb.Append($"Content-Length: {_responseBody.Length}\r\n");
        foreach (var h in _responseHeaders)
        {
            if (h.Key.Equals("Content-Length", StringComparison.OrdinalIgnoreCase) || h.Key.Equals("Content-Type", StringComparison.OrdinalIgnoreCase)) continue;
            sb.Append($"{h.Key}: {h.Value}\r\n");
        }
        if (!_responseHeaders.ContainsKey("x-amzn-RequestId")) sb.Append("x-amzn-RequestId: benchmark-request-id\r\n");
        sb.Append("\r\n");
        var head = System.Text.Encoding.ASCII.GetBytes(sb.ToString());
        var all = new byte[head.Length + _responseBody.Length];
        head.CopyTo(all, 0);
        _responseBody.CopyTo(all, head.Length);
        return all;
    }
}

/// <summary>
/// HttpClientFactory that creates an HttpClient backed by a MockHttpHandler.
/// Inject via ClientConfig.HttpClientFactory to bypass real HTTP.
/// With --cpu-time --transport https, the client instead sends the calls to the fixture server
/// (see <see cref="HttpsLoopback"/>), which serves the handler's canned response.
/// </summary>
public class MockHttpClientFactory : HttpClientFactory
{
    // Stub: created up front. https: created on first use from the service client's config.
    private HttpClient? _client;

    public MockHttpClientFactory(MockHttpHandler handler)
    {
        if (BenchmarkTransport.Kind == BenchmarkTransportKind.Https)
            HttpsLoopback.PostFixture(handler.BuildRawResponse());
        else
            _client = new HttpClient(handler);
    }

    public override HttpClient CreateHttpClient(IClientConfig clientConfig)
    {
        if (_client != null)
            return _client;
        var created = HttpsLoopback.CreateClient(clientConfig);
        return Interlocked.CompareExchange(ref _client, created, null) ?? created;
    }
    public override bool UseSDKHttpClientCaching(IClientConfig clientConfig) => false;
    public override bool DisposeHttpClientsAfterUse(IClientConfig clientConfig) => false;
    public override string GetConfigUniqueString(IClientConfig clientConfig) => "mock-benchmark";
}
