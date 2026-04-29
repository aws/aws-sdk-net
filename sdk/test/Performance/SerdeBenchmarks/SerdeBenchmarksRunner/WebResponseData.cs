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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.Internal.Transform;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// Mock IWebResponseData implementation for serde benchmarks.
/// Used to provide HTTP response headers/status to unmarshallers without making real HTTP calls.
/// </summary>
public class WebResponseData : IWebResponseData
{
    public WebResponseData()
    {
        ContentType = "application/json";
        StatusCode = HttpStatusCode.OK;
        IsSuccessStatusCode = true;
        Headers = new Dictionary<string, string>();
    }

    public Dictionary<string, string> Headers { get; set; }
    public string ContentType { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public bool IsSuccessStatusCode { get; set; }
    public long ContentLength { get; set; }

    public string[] GetHeaderNames() => Headers.Keys.ToArray();
    public bool IsHeaderPresent(string headerName) => Headers.ContainsKey(headerName);
    public string GetHeaderValue(string headerName) => Headers.TryGetValue(headerName, out var value) ? value : null!;
    public IEventStreamHeader GetEventStreamHeader(string headerName) => null!;
    public bool IsEventHeaderPresent(string headerName) => false;

    public IHttpResponseBody ResponseBody => new MockHttpResponseBody();
}

/// <summary>
/// Mock HTTP response body that returns an empty stream.
/// </summary>
public class MockHttpResponseBody : IHttpResponseBody
{
    private readonly MemoryStream _emptyStream = new();

    public void Dispose() => _emptyStream.Dispose();
    public Stream OpenResponse() => _emptyStream;
    public Task<Stream> OpenResponseAsync() => Task.FromResult<Stream>(_emptyStream);
}
