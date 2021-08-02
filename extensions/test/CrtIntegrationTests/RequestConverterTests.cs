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
using Amazon.Util;
using AWSSDK.Extensions.CrtIntegration;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace CrtIntegrationTests
{
    /// <summary>
    /// Tests for the mapping between the SDK's <see cref="IRequest" /> and CRT's <see cref="Aws.Crt.Http.HttpRequest"/>
    /// </summary>
    public class RequestConverterTests
    {
        [Fact]
        public void ConvertToCrtRequestTest()
        {
            var mock = new Mock<IRequest>();
            mock.SetupAllProperties();

            mock.SetupGet(x => x.Headers).Returns(new Dictionary<string, string>
            {
                { HeaderKeys.ContentLengthHeader, "13" },
                { HeaderKeys.ContentTypeHeader, "application/x-www-form-urlencoded"},
                { HeaderKeys.XAmzRegionSetHeader, "us-east-1" },    // should not be passed into CRT
                { HeaderKeys.XAmzSecurityTokenHeader, "token" }     // should not be passed into CRT
            });

            var sdkRequest = mock.Object;
            sdkRequest.HttpMethod = "POST";
            sdkRequest.ResourcePath = "/resource";
            sdkRequest.Content = Encoding.ASCII.GetBytes("Param1=value1");
            sdkRequest.Endpoint = new Uri("https://amazonaws.com/");

            var crtRequest = CrtHttpRequestConverter.ConvertToCrtRequest(sdkRequest);

            // Verify that all expected properties made it to the CRT request
            Assert.Equal("https://amazonaws.com/resource", crtRequest.Uri);
            Assert.Equal("POST", crtRequest.Method);
            Assert.Equal("Param1=value1", new StreamReader(crtRequest.BodyStream).ReadToEnd());

            // Verify that we're correctly stripping CRT-managed headers
            Assert.Equal(2, crtRequest.Headers.Length);
            Assert.Equal(HeaderKeys.ContentLengthHeader, crtRequest.Headers[0].Name);
            Assert.Equal("13", crtRequest.Headers[0].Value);
            Assert.Equal(HeaderKeys.ContentTypeHeader, crtRequest.Headers[1].Name);
            Assert.Equal("application/x-www-form-urlencoded", crtRequest.Headers[1].Value);
        }

        [Fact]
        public void CopyHeadersFromCrtRequestTest()
        {
            var crtRequest = new Aws.Crt.Http.HttpRequest
            {
                Headers = new[]
                {
                    new Aws.Crt.Http.HttpHeader("a", "a"),
                    new Aws.Crt.Http.HttpHeader("b", "b")
                }
            };

            var mock = new Mock<IRequest>();
            mock.SetupAllProperties();
            mock.SetupGet(x => x.Headers).Returns(new Dictionary<string, string>
            {
                { "c", "c" },   // this is only on the SDK request so we expect it to be replaced by "a" and "b" from CRT
            });
            var sdkRequest = mock.Object;

            CrtHttpRequestConverter.CopyHeadersFromCrtRequest(sdkRequest, crtRequest);

            // Verify that we've replaced the SDK request's headers with all of the CRT request's headers
            Assert.Equal(2, sdkRequest.Headers.Count);
            Assert.True(sdkRequest.Headers.ContainsKey("a"));
            Assert.True(sdkRequest.Headers.ContainsKey("b"));
            Assert.Equal("a", sdkRequest.Headers["a"]);
            Assert.Equal("b", sdkRequest.Headers["b"]);
        }

        [Fact]
        public void ExtractSignedHeadersTest()
        {
            var crtRequest = new Aws.Crt.Http.HttpRequest();
            crtRequest.Headers = new Aws.Crt.Http.HttpHeader[]
            {
                new Aws.Crt.Http.HttpHeader("a", "a"),
                new Aws.Crt.Http.HttpHeader("Authorization", "AWS4-ECDSA-P256-SHA256 Credential=accesskey/20210101/s3/aws4_request, " + 
                                            "SignedHeaders=host;x-amz-content-sha256;x-amz-date;x-amz-region-set;x-amz-security-token, Signature=signature"),
                new Aws.Crt.Http.HttpHeader("b", "b"),
            };

            var signedHeaders = CrtHttpRequestConverter.ExtractSignedHeaders(crtRequest);

            // Verify that we can extract the signed headers out of the CRT's 'Authorization' header, 
            // since we may use them directly later in the SDK
            Assert.Equal("host;x-amz-content-sha256;x-amz-date;x-amz-region-set;x-amz-security-token", signedHeaders);
        }
    }
}
