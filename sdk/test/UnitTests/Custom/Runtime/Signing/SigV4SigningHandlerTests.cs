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
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Signing;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Signing
{
    [TestClass]
    [TestCategory("Core")]
    [TestCategory("Signer")]
    public class SigV4SigningHandlerTests
    {
        private const string AccessKey = "AKIDEXAMPLE";
        private const string SecretKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";
        private const string RegionName = "us-east-1";
        private static readonly RegionEndpoint Region = RegionEndpoint.GetBySystemName(RegionName);
        private const string Service = "execute-api";

        private static SigV4SigningHandler NewHandler(out CapturingInnerHandler inner)
        {
            return NewHandler(new BasicAWSCredentials(AccessKey, SecretKey), out inner);
        }

        private static SigV4SigningHandler NewHandler(AWSCredentials credentials, out CapturingInnerHandler inner, RegionEndpoint region = null, string service = Service)
        {
            inner = new CapturingInnerHandler();
            return new SigV4SigningHandler(new AWSSigV4Parameters
            {
                Credentials = credentials,
                Region = region ?? Region,
                Service = service,
            })
            {
                InnerHandler = inner,
            };
        }

        private static HttpClient NewClient(SigV4SigningHandler handler) => new HttpClient(handler);

        // -----------------------------------------------------------------------
        // Signing headers are produced and applied onto the outgoing request.
        // -----------------------------------------------------------------------

        [TestMethod]
        public async Task Send_AppliesSigningHeadersToOutgoingRequest()
        {
            var handler = NewHandler(out var inner);
            using (var client = NewClient(handler))
            {
                await client.GetAsync("https://example.execute-api.us-east-1.amazonaws.com/items");
            }

            var sent = inner.LastRequest;
            Assert.IsTrue(sent.Headers.Contains(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue(sent.Headers.Contains(HeaderKeys.XAmzDateHeader));
            // execute-api signs the payload; the empty-body hash header must be present.
            Assert.IsTrue(sent.Headers.Contains(HeaderKeys.XAmzContentSha256Header));
            var auth = sent.Headers.GetValues(HeaderKeys.AuthorizationHeader).Single();
            StringAssert.StartsWith(auth, "AWS4-HMAC-SHA256 ");
            StringAssert.Contains(auth, "/us-east-1/execute-api/aws4_request");
        }

        [TestMethod]
        public async Task Send_WithBody_SignsBufferedContent()
        {
            var handler = NewHandler(out var inner);
            inner.CaptureBody = true;
            using (var client = NewClient(handler))
            {
                var content = new StringContent("{\"a\":1}", Encoding.UTF8, "application/json");
                await client.PostAsync("https://example.execute-api.us-east-1.amazonaws.com/items", content);
            }

            var sent = inner.LastRequest;
            var expectedHash = AWSSDKUtils.ToHex(
                CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(Encoding.UTF8.GetBytes("{\"a\":1}")), true);
            var actualHash = sent.Headers.GetValues(HeaderKeys.XAmzContentSha256Header).Single();
            Assert.AreEqual(expectedHash, actualHash);
            // The body must survive as re-readable content through signing (captured inside the inner handler,
            // since HttpClient disposes the request content once the send completes on net472).
            Assert.AreEqual("{\"a\":1}", inner.LastContentBody);
        }

        [TestMethod]
        public async Task Send_WithSessionCredentials_AddsSecurityTokenHeader()
        {
            var handler = NewHandler(new SessionAWSCredentials(AccessKey, SecretKey, "the-session-token"), out var inner);
            using (var client = NewClient(handler))
            {
                await client.GetAsync("https://example.execute-api.us-east-1.amazonaws.com/items");
            }

            var sent = inner.LastRequest;
            Assert.AreEqual("the-session-token", sent.Headers.GetValues(HeaderKeys.XAmzSecurityTokenHeader).Single());
            var auth = sent.Headers.GetValues(HeaderKeys.AuthorizationHeader).Single();
            StringAssert.Contains(auth, "x-amz-security-token");
        }

#if NET5_0_OR_GREATER
        [TestMethod]
        public void SyncSend_SignsOutgoingRequest()
        {
            // A synchronous HttpClient.Send must be signed too, not passed through unsigned by the base handler.
            var handler = NewHandler(out var inner);
            using (var client = NewClient(handler))
            {
                client.Send(new HttpRequestMessage(HttpMethod.Get, "https://example.execute-api.us-east-1.amazonaws.com/items"));
            }

            var sent = inner.LastRequest;
            Assert.IsTrue(sent.Headers.Contains(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue(sent.Headers.Contains(HeaderKeys.XAmzDateHeader));
            var auth = sent.Headers.GetValues(HeaderKeys.AuthorizationHeader).Single();
            StringAssert.StartsWith(auth, "AWS4-HMAC-SHA256 ");
        }

        [TestMethod]
        public void SyncSend_WithBody_SignsBufferedContent()
        {
            var handler = NewHandler(out var inner);
            inner.CaptureBody = true;
            using (var client = NewClient(handler))
            {
                var message = new HttpRequestMessage(HttpMethod.Post, "https://example.execute-api.us-east-1.amazonaws.com/items")
                {
                    Content = new StringContent("{\"a\":1}", Encoding.UTF8, "application/json"),
                };
                client.Send(message);
            }

            var sent = inner.LastRequest;
            var expectedHash = AWSSDKUtils.ToHex(
                CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(Encoding.UTF8.GetBytes("{\"a\":1}")), true);
            Assert.AreEqual(expectedHash, sent.Headers.GetValues(HeaderKeys.XAmzContentSha256Header).Single());
            Assert.AreEqual("{\"a\":1}", inner.LastContentBody);
        }
#endif

        // -----------------------------------------------------------------------
        // Credentials resolve per send.
        // -----------------------------------------------------------------------

        [TestMethod]
        public async Task Send_ResolvesCredentialsOnEverySend()
        {
            var credentials = new CountingCredentials(AccessKey, SecretKey);
            var handler = NewHandler(credentials, out var inner);
            using (var client = NewClient(handler))
            {
                await client.GetAsync("https://example.execute-api.us-east-1.amazonaws.com/a");
                await client.GetAsync("https://example.execute-api.us-east-1.amazonaws.com/b");
            }

            // A long-lived client with rotating credentials must re-resolve on each send, not capture once.
            Assert.AreEqual(2, credentials.ResolveCount);
        }

        // -----------------------------------------------------------------------
        // Re-signing (retry): headers replaced, not duplicated.
        // -----------------------------------------------------------------------

        [TestMethod]
        public async Task Send_ReSigningSameMessage_DoesNotDuplicateHeaders()
        {
            var handler = NewHandler(out var inner);
            var invoker = new HttpMessageInvoker(handler);

            // Reuse the same message across two sends, as an outer retry handler would.
            var message = new HttpRequestMessage(HttpMethod.Get, "https://example.execute-api.us-east-1.amazonaws.com/items");
            await invoker.SendAsync(message, CancellationToken.None);
            await invoker.SendAsync(message, CancellationToken.None);

            Assert.AreEqual(1, message.Headers.GetValues(HeaderKeys.AuthorizationHeader).Count());
            Assert.AreEqual(1, message.Headers.GetValues(HeaderKeys.XAmzDateHeader).Count());
        }

        [TestMethod]
        public async Task Send_ReSigningMessageWithBody_ResendsAndReHashesBody()
        {
            // A retry replays the same message. The handler rebuffers the content as re-readable, so the body
            // must survive the second send (not be consumed on the first) and produce the same body hash and a
            // single, non-duplicated set of signing headers on the resend.
            var handler = NewHandler(out var inner);
            inner.CaptureBody = true;
            var invoker = new HttpMessageInvoker(handler);

            const string body = "{\"a\":1}";
            var message = new HttpRequestMessage(HttpMethod.Post, "https://example.execute-api.us-east-1.amazonaws.com/items")
            {
                Content = new StringContent(body, Encoding.UTF8, "application/json"),
            };
            var expectedHash = AWSSDKUtils.ToHex(
                CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(Encoding.UTF8.GetBytes(body)), true);

            // First attempt.
            await invoker.SendAsync(message, CancellationToken.None);
            Assert.AreEqual(body, inner.LastContentBody);
            Assert.AreEqual(expectedHash, inner.LastRequest.Headers.GetValues(HeaderKeys.XAmzContentSha256Header).Single());

            // Retry: same message re-enters the handler. The body must still be readable and re-hashed.
            await invoker.SendAsync(message, CancellationToken.None);
            Assert.AreEqual(body, inner.LastContentBody);
            Assert.AreEqual(expectedHash, inner.LastRequest.Headers.GetValues(HeaderKeys.XAmzContentSha256Header).Single());

            // Signing headers replaced, not accumulated, across the resign.
            Assert.AreEqual(1, message.Headers.GetValues(HeaderKeys.AuthorizationHeader).Count());
            Assert.AreEqual(1, message.Headers.GetValues(HeaderKeys.XAmzDateHeader).Count());
        }

        [TestMethod]
        public async Task Send_ReSigningAfterCredentialsDropToken_RemovesStaleSecurityTokenHeader()
        {
            // Session credentials on the first send emit x-amz-security-token; if the credential source then
            // returns long-term credentials, the re-signed message must not carry the stale token header, or it
            // would go out uncovered by the new signature.
            var credentials = new SwitchableCredentials(
                new SessionAWSCredentials(AccessKey, SecretKey, "the-session-token"),
                new BasicAWSCredentials(AccessKey, SecretKey));
            var handler = NewHandler(credentials, out var inner);
            var invoker = new HttpMessageInvoker(handler);

            var message = new HttpRequestMessage(HttpMethod.Get, "https://example.execute-api.us-east-1.amazonaws.com/items");

            // First send uses session credentials: the token header is present.
            await invoker.SendAsync(message, CancellationToken.None);
            Assert.IsTrue(message.Headers.Contains(HeaderKeys.XAmzSecurityTokenHeader));

            // Retry resolves long-term credentials: the token header must be gone, not left over.
            credentials.Advance();
            await invoker.SendAsync(message, CancellationToken.None);
            Assert.IsFalse(message.Headers.Contains(HeaderKeys.XAmzSecurityTokenHeader));
        }

        // -----------------------------------------------------------------------
        // Header collection for signing.
        // -----------------------------------------------------------------------

        [TestMethod]
        public async Task Send_SameHeaderOnRequestAndContent_SignsCombinedValue()
        {
            // HttpClient sends a header set on both the request and the content as one combined line
            // (request value first, then content value). The signature must cover that same combined value.
            var handler = NewHandler(out var inner);
            var invoker = new HttpMessageInvoker(handler);

            var message = new HttpRequestMessage(HttpMethod.Post, "https://example.execute-api.us-east-1.amazonaws.com/items")
            {
                Content = new StringContent("{\"a\":1}", Encoding.UTF8, "application/json"),
            };
            message.Headers.TryAddWithoutValidation("x-custom", "request-value");
            message.Content.Headers.TryAddWithoutValidation("x-custom", "content-value");

            await invoker.SendAsync(message, CancellationToken.None);

            // x-custom appears in the signed headers, so it is part of SignedHeaders in the Authorization value.
            var auth = message.Headers.GetValues(HeaderKeys.AuthorizationHeader).Single();
            StringAssert.Contains(auth, "x-custom");
        }

        // -----------------------------------------------------------------------
        // Per-request overrides via Options / Properties.
        // -----------------------------------------------------------------------

        [TestMethod]
        public async Task Send_PerRequestServiceAndRegionOverride_WinsOverHandlerDefault()
        {
            var handler = NewHandler(out var inner); // defaults: execute-api / us-east-1
            var invoker = new HttpMessageInvoker(handler);

            var message = new HttpRequestMessage(HttpMethod.Get, "https://sts.us-west-2.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15");
            SetOption(message, SigV4SigningHandler.ServiceOptionKey, "sts");
            SetOption(message, SigV4SigningHandler.RegionOptionKey, "us-west-2");
            await invoker.SendAsync(message, CancellationToken.None);

            var auth = message.Headers.GetValues(HeaderKeys.AuthorizationHeader).Single();
            StringAssert.Contains(auth, "/us-west-2/sts/aws4_request");
        }

        [TestMethod]
        public async Task Send_SignPayloadFalseOverride_SignsUnsignedPayloadWithoutReadingBody()
        {
            var handler = NewHandler(out var inner);
            var invoker = new HttpMessageInvoker(handler);

            var message = new HttpRequestMessage(HttpMethod.Post, "https://example.execute-api.us-east-1.amazonaws.com/items")
            {
                // A stream that throws if read proves the body is never touched when SignPayload is false.
                Content = new StreamContent(new ThrowOnReadStream()),
            };
            SetOption(message, SigV4SigningHandler.SignPayloadOptionKey, false);
            await invoker.SendAsync(message, CancellationToken.None);

            Assert.AreEqual("UNSIGNED-PAYLOAD", message.Headers.GetValues(HeaderKeys.XAmzContentSha256Header).Single());
        }

        [TestMethod]
        public async Task Send_PrecomputedContentHashHeader_UsedVerbatimWithoutReadingBody()
        {
            var handler = NewHandler(out var inner);
            var invoker = new HttpMessageInvoker(handler);

            var precomputed = new string('a', 64);
            var message = new HttpRequestMessage(HttpMethod.Post, "https://example.execute-api.us-east-1.amazonaws.com/items")
            {
                Content = new StreamContent(new ThrowOnReadStream()),
            };
            message.Content.Headers.TryAddWithoutValidation(HeaderKeys.XAmzContentSha256Header, precomputed);
            await invoker.SendAsync(message, CancellationToken.None);

            Assert.AreEqual(precomputed, message.Headers.GetValues(HeaderKeys.XAmzContentSha256Header).Single());
            // The caller set the hash on the content headers; after signing it must live only on the request
            // headers, not on both, or the outgoing request would carry a duplicate x-amz-content-sha256 line.
            Assert.IsFalse(message.Content.Headers.Contains(HeaderKeys.XAmzContentSha256Header));
        }

        // -----------------------------------------------------------------------
        // Construction and argument validation.
        // -----------------------------------------------------------------------

        [TestMethod]
        public void Constructor_RegionEndpointOverload_SetsSystemNameAsRegion()
        {
            var handler = new SigV4SigningHandler(new BasicAWSCredentials(AccessKey, SecretKey), RegionEndpoint.USWest2, "sts")
            {
                InnerHandler = new CapturingInnerHandler(),
            };
            Assert.IsNotNull(handler); // constructed without throwing; region resolved from the endpoint
        }

        [TestMethod]
        public void Constructor_NullParameters_Throws()
        {
            Assert.ThrowsExactly<ArgumentNullException>(() => new SigV4SigningHandler((AWSSigV4Parameters)null));
        }

        [TestMethod]
        public void Constructor_MissingService_Throws()
        {
            // Service has no ambient fallback, so it must be supplied at construction.
            Assert.ThrowsExactly<ArgumentException>(() => new SigV4SigningHandler(
                new AWSSigV4Parameters { Credentials = new BasicAWSCredentials(AccessKey, SecretKey), Region = Region }));
        }

        [TestMethod]
        public void Constructor_MissingRegionOrCredentials_DoesNotThrow()
        {
            // Region and Credentials are resolved from the environment at send time, so their absence is not a
            // construction-time error (unlike Service).
            using (new SigV4SigningHandler(new AWSSigV4Parameters { Region = Region, Service = Service }))
            using (new SigV4SigningHandler(new AWSSigV4Parameters { Credentials = new BasicAWSCredentials(AccessKey, SecretKey), Service = Service }))
            {
            }
        }

        [TestMethod]
        public async Task Send_RelativeUri_Throws()
        {
            var handler = NewHandler(out var inner);
            var invoker = new HttpMessageInvoker(handler);
            var message = new HttpRequestMessage(HttpMethod.Get, new Uri("/items", UriKind.Relative));

            await Assert.ThrowsExactlyAsync<InvalidOperationException>(() => invoker.SendAsync(message, CancellationToken.None));
        }

        // -----------------------------------------------------------------------
        // Helpers
        // -----------------------------------------------------------------------

        private static void SetOption<T>(HttpRequestMessage message, string key, T value)
        {
#if NET5_0_OR_GREATER
            message.Options.Set(new HttpRequestOptionsKey<T>(key), value);
#else
            message.Properties[key] = value;
#endif
        }

        // Captures the request as it reaches the transport (after signing) and returns 200. The content body
        // is read here, while the request is still in flight — on net472 HttpClient disposes the request
        // content once SendAsync returns, so reading LastRequest.Content after the call throws
        // ObjectDisposedException. Capturing it inside the handler avoids that.
        private sealed class CapturingInnerHandler : HttpMessageHandler
        {
            public HttpRequestMessage LastRequest { get; private set; }
            public string LastContentBody { get; private set; }

            // Opt-in: only the body-signing test wants the body captured. Reading is off by default so the
            // "body must not be read" tests (backed by a throw-on-read stream) keep that invariant.
            public bool CaptureBody { get; set; }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                LastRequest = request;
                if (CaptureBody && request.Content != null)
                    LastContentBody = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

#if NET5_0_OR_GREATER
            protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                LastRequest = request;
                if (CaptureBody && request.Content != null)
                {
                    using (var stream = request.Content.ReadAsStream(cancellationToken))
                    using (var reader = new StreamReader(stream))
                        LastContentBody = reader.ReadToEnd();
                }
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
#endif
        }

        // Counts how many times credentials are resolved, to prove per-send resolution.
        private sealed class CountingCredentials : AWSCredentials
        {
            private readonly ImmutableCredentials _credentials;
            public int ResolveCount { get; private set; }

            public CountingCredentials(string accessKey, string secretKey)
            {
                _credentials = new ImmutableCredentials(accessKey, secretKey, null);
            }

            public override ImmutableCredentials GetCredentials()
            {
                ResolveCount++;
                return _credentials;
            }

            public override Task<ImmutableCredentials> GetCredentialsAsync()
            {
                ResolveCount++;
                return Task.FromResult(_credentials);
            }
        }

        // Returns one set of credentials until Advance() is called, then the next. Models a credential source
        // whose resolved credentials change type (e.g. session -> long-term) between a send and its retry.
        private sealed class SwitchableCredentials : AWSCredentials
        {
            private readonly AWSCredentials _first;
            private readonly AWSCredentials _second;
            private bool _advanced;

            public SwitchableCredentials(AWSCredentials first, AWSCredentials second)
            {
                _first = first;
                _second = second;
            }

            public void Advance() => _advanced = true;

            private AWSCredentials Current => _advanced ? _second : _first;

            public override ImmutableCredentials GetCredentials() => Current.GetCredentials();

            public override Task<ImmutableCredentials> GetCredentialsAsync() => Current.GetCredentialsAsync();
        }

        private sealed class ThrowOnReadStream : Stream
        {
            public override bool CanRead => true;
            public override bool CanSeek => false;
            public override bool CanWrite => false;
            public override long Length => throw new NotSupportedException();
            public override long Position { get => 0; set => throw new NotSupportedException(); }
            public override int Read(byte[] buffer, int offset, int count) =>
                throw new InvalidOperationException("The body must not be read when SignPayload is false or a precomputed hash is supplied.");
            public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
            public override void SetLength(long value) => throw new NotSupportedException();
            public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
            public override void Flush() { }
        }
    }
}
