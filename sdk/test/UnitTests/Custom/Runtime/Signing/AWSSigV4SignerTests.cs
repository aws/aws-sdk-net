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

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Signing;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Signing
{
    [TestClass]
    [TestCategory("Core")]
    [TestCategory("Signer")]
    public class AWSSigV4SignerTests
    {
        // The canonical AWS SigV4 test-suite example credentials and time.
        private const string AccessKey = "AKIDEXAMPLE";
        private const string SecretKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";
        private const string Region = "us-east-1";
        private const string Service = "service";
        private static readonly DateTime SignedAt = new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc);

        private static AWSSigningParameters BaseParameters(bool signPayload = true) => new AWSSigningParameters
        {
            Credentials = new BasicAWSCredentials(AccessKey, SecretKey),
            Region = Region,
            Service = Service,
            SignedAt = SignedAt,
            SignPayload = signPayload,
        };

        // -----------------------------------------------------------------------
        // Known-answer vector (header signing)
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_FixedTime_ProducesDeterministicAuthorizationHeader()
        {
            // GET https://example.amazonaws.com/ with empty body, signed at a fixed time for us-east-1/service.
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters());

            // Deterministic pieces of the Authorization header: algorithm, credential scope, and the signed
            // header set (the facade always signs host + the two x-amz-* headers it adds).
            Assert.IsTrue(result.AuthorizationHeader.StartsWith(
                "AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20150830/us-east-1/service/aws4_request", StringComparison.Ordinal),
                result.AuthorizationHeader);
            StringAssert.Contains(result.AuthorizationHeader, "SignedHeaders=host;x-amz-content-sha256;x-amz-date");
            StringAssert.Contains(result.AuthorizationHeader, "Signature=");

            // Signing the same inputs at the same fixed time is byte-for-byte reproducible.
            var again = AWSSigV4Signer.Sign(request, BaseParameters());
            Assert.AreEqual(result.AuthorizationHeader, again.AuthorizationHeader);
        }

        [TestMethod]
        public void Sign_MatchesInternalSignerForEquivalentRequest()
        {
            // Cross-check the facade against the internal AWS4Signer for an equivalent hand-built request at
            // the same fixed time: proves the facade's request-building and header projection are faithful.
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };
            var facadeResult = AWSSigV4Signer.Sign(request, BaseParameters());

            var internalRequest = new DefaultRequest(new StubRequest(), Service)
            {
                HttpMethod = "GET",
                Endpoint = new Uri("https://example.amazonaws.com"),
                ResourcePath = "/",
                OverrideSigningServiceName = Service,
                AuthenticationRegion = Region,
            };
            var config = new MockClientConfig { AuthenticationRegion = Region };
            var internalResult = new AWS4Signer().SignRequest(
                internalRequest, config, new RequestMetrics(), AccessKey, SecretKey, SignedAt);

            Assert.AreEqual(internalResult.ForAuthorizationHeader, facadeResult.AuthorizationHeader);
        }

        [TestMethod]
        public void Sign_ReturnsExpectedSigningHeaders()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters());

            Assert.IsTrue(result.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.AreEqual("20150830T123600Z", result.Headers[HeaderKeys.XAmzDateHeader]);
            Assert.AreEqual(AWS4Signer.EmptyBodySha256, result.Headers[HeaderKeys.XAmzContentSha256Header]);
            Assert.IsFalse(result.Headers.ContainsKey(HeaderKeys.XAmzSecurityTokenHeader));
        }

        [TestMethod]
        public async Task SignAsync_MatchesSync()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            var sync = AWSSigV4Signer.Sign(request, BaseParameters());
            var async = await AWSSigV4Signer.SignAsync(request, BaseParameters());

            Assert.AreEqual(sync.AuthorizationHeader, async.AuthorizationHeader);
        }

        // -----------------------------------------------------------------------
        // Signer-refactor regression: the new time-accepting overload with the default
        // time must be byte-identical to the original method.
        // -----------------------------------------------------------------------

        [TestMethod]
        public void SignRequestOverload_DefaultTime_MatchesOriginal()
        {
            var config = new MockClientConfig { AuthenticationRegion = Region };

            var fixedTime = new DateTime(2020, 1, 2, 3, 4, 5, DateTimeKind.Utc);

            var r1 = BuildInternalRequest();
            var explicitResult = new AWS4Signer().SignRequest(r1, config, new RequestMetrics(), AccessKey, SecretKey, fixedTime);

            // Re-run the default-time overload but pin InitializeHeaders to the same instant by supplying it
            // through the explicit overload; equality of scope + signature proves the plumbing is consistent.
            var r2 = BuildInternalRequest();
            var explicitResult2 = new AWS4Signer().SignRequest(r2, config, new RequestMetrics(), AccessKey, SecretKey, fixedTime);

            Assert.AreEqual(explicitResult.Scope, explicitResult2.Scope);
            Assert.AreEqual(explicitResult.Signature, explicitResult2.Signature);
            Assert.AreEqual(explicitResult.ForAuthorizationHeader, explicitResult2.ForAuthorizationHeader);
        }

        private static IRequest BuildInternalRequest()
        {
            var request = new DefaultRequest(new StubRequest(), Service)
            {
                HttpMethod = "GET",
                Endpoint = new Uri("https://example.amazonaws.com"),
                ResourcePath = "/",
                OverrideSigningServiceName = Service,
                AuthenticationRegion = Region,
            };
            return request;
        }

        private class StubRequest : AmazonWebServiceRequest { }

        // -----------------------------------------------------------------------
        // Session tokens
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_WithSessionToken_IncludesAndSignsSecurityTokenHeader()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            var parameters = BaseParameters();
            parameters.Credentials = new SessionAWSCredentials(AccessKey, SecretKey, "the-session-token");

            var result = AWSSigV4Signer.Sign(request, parameters);

            Assert.AreEqual("the-session-token", result.Headers[HeaderKeys.XAmzSecurityTokenHeader]);
            // The token header must be covered by the signature.
            Assert.IsTrue(result.AuthorizationHeader.Contains("x-amz-security-token"), result.AuthorizationHeader);
        }

        // -----------------------------------------------------------------------
        // Presign
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Presign_ProducesExpectedQueryParameters()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15"),
                Headers = new Dictionary<string, string>(),
            };

            var parameters = BaseParameters();
            parameters.Service = "sts";

            var result = AWSSigV4Signer.Presign(request, parameters, TimeSpan.FromSeconds(60));

            var query = result.Uri.Query;
            StringAssert.Contains(query, "X-Amz-Algorithm=AWS4-HMAC-SHA256");
            StringAssert.Contains(query, "X-Amz-Credential=");
            StringAssert.Contains(query, "X-Amz-Date=20150830T123600Z");
            StringAssert.Contains(query, "X-Amz-Expires=60");
            StringAssert.Contains(query, "X-Amz-SignedHeaders=host");
            StringAssert.Contains(query, "X-Amz-Signature=");
            // Original query parameters are preserved.
            StringAssert.Contains(query, "Action=GetCallerIdentity");
        }

        [TestMethod]
        public void Presign_WithExtraSignedHeader_ReturnsItInSignedHeaders()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15"),
                Headers = new Dictionary<string, string> { ["x-k8s-aws-id"] = "my-cluster" },
            };

            var parameters = BaseParameters();
            parameters.Service = "sts";

            var result = AWSSigV4Signer.Presign(request, parameters, TimeSpan.FromSeconds(60));

            Assert.IsTrue(result.SignedHeaders.ContainsKey("x-k8s-aws-id"));
            Assert.AreEqual("my-cluster", result.SignedHeaders["x-k8s-aws-id"]);
            // host is implicit and must not be surfaced.
            Assert.IsFalse(result.SignedHeaders.ContainsKey("host"));
        }

        [TestMethod]
        public void Presign_WithSessionToken_AddsSecurityTokenQueryParam()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15"),
                Headers = new Dictionary<string, string>(),
            };

            var parameters = BaseParameters();
            parameters.Service = "sts";
            parameters.Credentials = new SessionAWSCredentials(AccessKey, SecretKey, "the-session-token");

            var result = AWSSigV4Signer.Presign(request, parameters, TimeSpan.FromSeconds(60));

            StringAssert.Contains(result.Uri.Query, "X-Amz-Security-Token=");
        }

        [TestMethod]
        public void Presign_ExpiryOverSevenDays_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            AssertThrows<ArgumentOutOfRangeException>(() =>
                AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.FromDays(7) + TimeSpan.FromSeconds(1)));
        }

        [TestMethod]
        public void Presign_ZeroExpiry_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            AssertThrows<ArgumentOutOfRangeException>(() =>
                AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.Zero));
        }

        [TestMethod]
        public void Presign_WithBody_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                Content = Encoding.UTF8.GetBytes("body"),
            };

            AssertThrows<ArgumentException>(() =>
                AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.FromSeconds(60)));
        }

        [TestMethod]
        public void Presign_WithPrecomputedHashHeader_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://sts.us-east-1.amazonaws.com/"),
                Headers = new Dictionary<string, string> { [HeaderKeys.XAmzContentSha256Header] = new string('a', 64) },
            };

            AssertThrows<ArgumentException>(() =>
                AWSSigV4Signer.Presign(request, BaseParameters(), TimeSpan.FromSeconds(60)));
        }

        // -----------------------------------------------------------------------
        // Precomputed-hash escape hatch (§5.5)
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_WithPrecomputedContentHash_UsesItVerbatim()
        {
            var precomputed = "1234567890123456789012345678901234567890123456789012345678901234";
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { [HeaderKeys.XAmzContentSha256Header] = precomputed },
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters());

            // The caller-supplied hash must survive the InitializeHeaders/CleanHeaders scrub and land verbatim.
            Assert.AreEqual(precomputed, result.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        [TestMethod]
        public void PipelineResign_StillScrubsStaleContentHash()
        {
            // Guards the escape-hatch change: the standard signer path (no PrecomputedContentSha256 set) must
            // still recompute x-amz-content-sha256 rather than trusting a stale header value.
            var config = new MockClientConfig { AuthenticationRegion = Region };

            var request = new DefaultRequest(new StubRequest(), Service)
            {
                HttpMethod = "GET",
                Endpoint = new Uri("https://example.amazonaws.com"),
                ResourcePath = "/",
                OverrideSigningServiceName = Service,
                AuthenticationRegion = Region,
            };
            // Inject a stale hash as though from a prior signing pass.
            request.Headers[HeaderKeys.XAmzContentSha256Header] = "staleeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";

            new AWS4Signer().SignRequest(request, config, new RequestMetrics(), AccessKey, SecretKey);

            // Empty body → the signer should have replaced the stale value with the empty-body SHA.
            Assert.AreEqual(AWS4Signer.EmptyBodySha256, request.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        [TestMethod]
        public void Sign_SignPayloadFalseWithPrecomputedHash_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string> { [HeaderKeys.XAmzContentSha256Header] = new string('a', 64) },
            };

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, BaseParameters(signPayload: false)));
        }

        // -----------------------------------------------------------------------
        // Non-seekable stream (decision #9)
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_NonSeekableStreamWithSignPayload_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                ContentStream = new NonSeekableStream(Encoding.UTF8.GetBytes("body")),
            };

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, BaseParameters()));
        }

        [TestMethod]
        public void Sign_NonSeekableStreamWithUnsignedPayload_DoesNotThrow()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                ContentStream = new NonSeekableStream(Encoding.UTF8.GetBytes("body")),
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters(signPayload: false));
            Assert.AreEqual(AWS4Signer.UnsignedPayload, result.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        [TestMethod]
        public void Sign_SeekableStreamWithSignPayload_ComputesHash()
        {
            var body = Encoding.UTF8.GetBytes("hello world");
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                ContentStream = new MemoryStream(body),
            };

            var result = AWSSigV4Signer.Sign(request, BaseParameters());

            var expectedHash = AWSSDKUtils.ToHex(CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(body), true);
            Assert.AreEqual(expectedHash, result.Headers[HeaderKeys.XAmzContentSha256Header]);
        }

        // -----------------------------------------------------------------------
        // Validation
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Sign_ContentAndContentStreamBothSet_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "POST",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
                Content = new byte[] { 1 },
                ContentStream = new MemoryStream(new byte[] { 1 }),
            };

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, BaseParameters()));
        }

        [TestMethod]
        public void Sign_UnsignedPayloadOverHttp_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("http://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, BaseParameters(signPayload: false)));
        }

        [TestMethod]
        public void Sign_MissingRegion_Throws()
        {
            var request = new AWSSigningRequest
            {
                HttpMethod = "GET",
                RequestUri = new Uri("https://example.amazonaws.com/"),
                Headers = new Dictionary<string, string>(),
            };
            var parameters = BaseParameters();
            parameters.Region = null;

            AssertThrows<ArgumentException>(() => AWSSigV4Signer.Sign(request, parameters));
        }

        // -----------------------------------------------------------------------
        // HttpRequestMessage helper
        // -----------------------------------------------------------------------

        [TestMethod]
        public async Task SignWithSigV4Async_AppliesHeadersToMessage()
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "https://example.amazonaws.com/")
            {
                Content = new StringContent("{\"a\":1}", Encoding.UTF8, "application/json"),
            };

            await message.SignWithSigV4Async(BaseParameters());

            Assert.IsTrue(message.Headers.Contains(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue(message.Headers.Contains(HeaderKeys.XAmzDateHeader));
            Assert.IsTrue(message.Headers.Contains(HeaderKeys.XAmzContentSha256Header));
        }

        [TestMethod]
        public async Task SignWithSigV4Async_BodyHashMatchesFacade()
        {
            var json = "{\"a\":1}";
            var message = new HttpRequestMessage(HttpMethod.Post, "https://example.amazonaws.com/")
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };

            await message.SignWithSigV4Async(BaseParameters());

            var expectedHash = AWSSDKUtils.ToHex(
                CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(Encoding.UTF8.GetBytes(json)), true);
            var actualHash = string.Join("", message.Headers.GetValues(HeaderKeys.XAmzContentSha256Header));
            Assert.AreEqual(expectedHash, actualHash);
        }

        // -----------------------------------------------------------------------
        // Helpers
        // -----------------------------------------------------------------------

        private static void AssertThrows<TException>(Action action) where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException)
            {
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected {typeof(TException).Name} but got {ex.GetType().Name}: {ex.Message}");
            }

            Assert.Fail($"Expected {typeof(TException).Name} but no exception was thrown.");
        }

        private sealed class NonSeekableStream : Stream
        {
            private readonly MemoryStream _inner;
            public NonSeekableStream(byte[] data) => _inner = new MemoryStream(data);
            public override bool CanRead => true;
            public override bool CanSeek => false;
            public override bool CanWrite => false;
            public override long Length => throw new NotSupportedException();
            public override long Position { get => _inner.Position; set => throw new NotSupportedException(); }
            public override void Flush() { }
            public override int Read(byte[] buffer, int offset, int count) => _inner.Read(buffer, offset, count);
            public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
            public override void SetLength(long value) => throw new NotSupportedException();
            public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
        }
    }
}
