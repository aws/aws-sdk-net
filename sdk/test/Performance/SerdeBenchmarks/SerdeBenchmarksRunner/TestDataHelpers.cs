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

using Amazon.Runtime.Internal;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// Shared helpers for the serde benchmarks. Payloads come from the generated ModelFixtures classes.
/// </summary>
public static class TestDataHelpers
{
    /// <summary>
    /// Builds the response data an unmarshaller sees for a fixture body: request id, content length
    /// and type, plus any response headers the model defines for the case.
    /// </summary>
    public static WebResponseData CreateResponseData(byte[] body, string contentType, IReadOnlyDictionary<string, string>? modelHeaders = null)
    {
        var wr = new WebResponseData { ContentType = contentType };
        wr.Headers["x-amzn-RequestId"] = "test-id";
        wr.Headers["Content-Length"] = body.Length.ToString();
        wr.Headers["Content-Type"] = contentType;
        if (modelHeaders != null)
        {
            foreach (var kv in modelHeaders)
                wr.Headers[kv.Key] = kv.Value;
        }
        return wr;
    }

    /// <summary>
    /// Returns the marshalled request body length and disposes the request, mirroring what the
    /// production pipeline does after marshalling. Disposing matters when the request body is backed
    /// by a pooled buffer: it returns that buffer and keeps the pool warm, so the [MemoryDiagnoser]
    /// numbers reflect the real per-request cost instead of a fresh allocation every iteration.
    /// Works whether or not the marshaller used a pooled buffer.
    /// </summary>
    public static long GetContentLengthAndDispose(IRequest request)
    {
        try
        {
            if (request.Content != null)
                return request.Content.Length;
            if (request.ContentStream != null && request.ContentStream.CanSeek)
                return request.ContentStream.Length;
            return 0;
        }
        finally
        {
            request.Dispose();
        }
    }
}
