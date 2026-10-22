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

using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.UserAgent;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Runtime.Telemetry.Metrics.NoOp;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Util;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
#if !NETFRAMEWORK
using Amazon.Runtime.EventStreams;
using System.Net.Http;
#endif

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Equivalence tests for the HTTP adapter fast paths: response header copy, User-Agent generation,
    /// request Uri reuse, HttpMethod reuse, request header setting and telemetry recording.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class HttpAdapterTests
    {
        #region User-Agent

        // The User-Agent generation algorithm before the fast path was added.
        private static string ReferenceUserAgent(IEnumerable<string> components, IEnumerable<string> featureIds)
        {
            var componentSet = new List<string>();
            foreach (var c in components)
            {
                if (string.IsNullOrWhiteSpace(c)) continue;
                var trimmed = c.Trim();
                if (!componentSet.Contains(trimmed)) componentSet.Add(trimmed);
            }
            var featureSet = featureIds.Distinct().ToList();

            var metrics = string.Empty;
            if (featureSet.Count > 0)
            {
                metrics = ReferenceTruncate($"m/{string.Join(",", featureSet)}");
            }
            if (!string.IsNullOrEmpty(metrics))
            {
                return $"{string.Join(" ", componentSet)} {metrics}";
            }
            return string.Join(" ", componentSet);
        }

        private static string ReferenceTruncate(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            if (bytes.Length <= 1024)
                return input;

            var cutOffIndex = 1024;
            while (cutOffIndex > 0 && bytes[cutOffIndex - 1] != ',')
                cutOffIndex--;

            return Encoding.UTF8.GetString(bytes, 0, cutOffIndex - 1);
        }

        private static UserAgentDetails CreateDetails(IEnumerable<string> components, IEnumerable<string> featureIds)
        {
            var details = new UserAgentDetails();
            foreach (var c in components)
                details.AddUserAgentComponent(c);
            foreach (var f in featureIds)
                details.AddFeature(new UserAgentFeatureId(f));
            return details;
        }

        public static IEnumerable<object[]> UserAgentCases()
        {
            yield return new object[] { new string[0], new string[0] };
            yield return new object[] { new[] { "aws-sdk-dotnet-coreclr/4.0.0.0 ua/2.1 os/linux" }, new string[0] };
            yield return new object[] { new string[0], new[] { "E", "b" } };
            yield return new object[] { new[] { "aws-sdk-dotnet-coreclr/4.0.0.0 ua/2.1", "md/ClientAsync", "cfg/init-coll#1" }, new[] { "E", "b", "Z", "a" } };
            yield return new object[] { new[] { "  padded  ", "dup", "dup", " ", null, "" }, new[] { "E", "E", "F" } };
            // Over the 1024-byte limit: truncated at the last comma that fits.
            yield return new object[] { new[] { "ua" }, Enumerable.Range(0, 400).Select(i => "f" + i).ToArray() };
            // Multi-byte feature ids around the limit.
            yield return new object[] { new[] { "ua" }, Enumerable.Range(0, 200).Select(i => "é" + i).ToArray() };
            yield return new object[] { new[] { "ua" }, Enumerable.Range(0, 340).Select(i => "é").Concat(new[] { "x" }).ToArray() };
        }

        [TestMethod]
        [DynamicData(nameof(UserAgentCases))]
        public void GenerateUserAgentWithMetrics_MatchesReference(string[] components, string[] featureIds)
        {
            var details = CreateDetails(components, featureIds);
            Assert.AreEqual(ReferenceUserAgent(components, featureIds), details.GenerateUserAgentWithMetrics());
        }

        [TestMethod]
        [DynamicData(nameof(UserAgentCases))]
        public void GetOrGenerateUserAgentWithMetrics_ValueMatchesGenerate(string[] components, string[] featureIds)
        {
            var details = CreateDetails(components, featureIds);
            var generated = details.GetOrGenerateUserAgentWithMetrics(null);
            Assert.AreEqual(details.GenerateUserAgentWithMetrics(), generated.Value);

            // An equal set of components and features (new string instances) reuses the entry.
            var copy = CreateDetails(components.Select(c => c == null ? null : new string(c.ToCharArray())),
                                     featureIds.Select(f => new string(f.ToCharArray())));
            Assert.AreSame(generated, copy.GetOrGenerateUserAgentWithMetrics(generated));
        }

        [TestMethod]
        public void GetOrGenerateUserAgentWithMetrics_RegeneratesWhenInputsDiffer()
        {
            var baseline = CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "E", "b" });
            var cached = baseline.GetOrGenerateUserAgentWithMetrics(null);

            var variants = new[]
            {
                CreateDetails(new[] { "ua/2.1", "md/ClientSync" }, new[] { "E", "b" }),       // component value
                CreateDetails(new[] { "md/ClientAsync", "ua/2.1" }, new[] { "E", "b" }),      // component order
                CreateDetails(new[] { "ua/2.1" }, new[] { "E", "b" }),                        // component count
                CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "E", "c" }),      // feature value
                CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "b", "E" }),      // feature order
                CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "E", "b", "Z" }), // feature count
                CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new string[0]),           // no features
            };

            foreach (var variant in variants)
            {
                var result = variant.GetOrGenerateUserAgentWithMetrics(cached);
                Assert.AreNotSame(cached, result);
                Assert.AreEqual(variant.GenerateUserAgentWithMetrics(), result.Value);
                Assert.AreNotEqual(cached.Value, result.Value);
            }
        }

        [TestMethod]
        public void MergeFrom_MatchesAddComponentAndAddFeature()
        {
            var sources = new[]
            {
                CreateDetails(new string[0], new string[0]),
                CreateDetails(new[] { "custom-a", "custom-b" }, new[] { "C", "E" }),
                CreateDetails(new[] { "md/ClientAsync" }, new[] { "b" }),
            };

            foreach (var source in sources)
            {
                var expected = CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "E", "b" });
                expected.AddUserAgentComponent(source.GetCustomUserAgentComponents());
                foreach (var featureId in source.TrackedFeatureIds)
                    expected.AddFeature(featureId);

                var actual = CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "E", "b" });
                actual.MergeFrom(source);

                Assert.AreEqual(expected.GenerateUserAgentWithMetrics(), actual.GenerateUserAgentWithMetrics());
                CollectionAssert.AreEqual(expected.TrackedFeatureIds.ToList(), actual.TrackedFeatureIds.ToList());
                Assert.AreEqual(expected.GetCustomUserAgentComponents(), actual.GetCustomUserAgentComponents());
            }
        }

        #endregion

        #region Request Uri

        private static IRequest CreateRequest(string endpoint, string resourcePath)
        {
            return new DefaultRequest(new MockAmazonWebServiceRequest(), "TestService")
            {
                Endpoint = new Uri(endpoint),
                ResourcePath = resourcePath
            };
        }

        private static void AssertSameUri(Uri expected, Uri actual)
        {
            Assert.AreEqual(expected.OriginalString, actual.OriginalString);
            Assert.AreEqual(expected.AbsoluteUri, actual.AbsoluteUri);
            Assert.AreEqual(expected.PathAndQuery, actual.PathAndQuery);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void ComposeRequestUrl_MatchesComposeUrlAndReusesUnchangedUri()
        {
            var handler = new HttpHandler<Stream>(new HttpHandlerTests.MockHttpRequestFactory(), new object());

            var first = CreateRequest("https://dynamodb.us-east-1.amazonaws.com", "/");
            var firstUri = handler.ComposeRequestUrl(first);
            AssertSameUri(AmazonServiceClient.ComposeUrl(first), firstUri);

            var same = CreateRequest("https://dynamodb.us-east-1.amazonaws.com", "/");
            var sameUri = handler.ComposeRequestUrl(same);
            AssertSameUri(AmazonServiceClient.ComposeUrl(same), sameUri);
#if !NETFRAMEWORK
            Assert.AreSame(firstUri, sameUri);
#endif

            var other = CreateRequest("https://dynamodb.us-east-1.amazonaws.com", "/other");
            var otherUri = handler.ComposeRequestUrl(other);
            AssertSameUri(AmazonServiceClient.ComposeUrl(other), otherUri);
            Assert.AreNotSame(firstUri, otherUri);

            var otherEndpoint = CreateRequest("https://dynamodb.us-west-2.amazonaws.com", "/other");
            var otherEndpointUri = handler.ComposeRequestUrl(otherEndpoint);
            AssertSameUri(AmazonServiceClient.ComposeUrl(otherEndpoint), otherEndpointUri);
            Assert.AreNotSame(otherUri, otherEndpointUri);
        }

        [TestMethod]
        public void ComposeRequestUrl_MatchesComposeUrlForPathsQueriesAndSubResources()
        {
            var handler = new HttpHandler<Stream>(new HttpHandlerTests.MockHttpRequestFactory(), new object());

            var requests = new List<IRequest>();
            requests.Add(CreateRequest("https://bucket.s3.amazonaws.com", "/key%20with%20spaces"));
            requests.Add(CreateRequest("https://bucket.s3.amazonaws.com/", "key"));
            requests.Add(CreateRequest("https://bucket.s3.amazonaws.com", null));

            var withPathResource = CreateRequest("https://bucket.s3.amazonaws.com", "/{Key+}");
            withPathResource.AddPathResource("{Key+}", "a/b+c:d");
            requests.Add(withPathResource);

            var withSubResource = CreateRequest("https://bucket.s3.amazonaws.com", "/key");
            withSubResource.AddSubResource("versionId", "v1");
            withSubResource.AddSubResource("acl");
            requests.Add(withSubResource);

            var withQuery = CreateRequest("https://sqs.us-east-1.amazonaws.com", "/");
            withQuery.UseQueryString = true;
            withQuery.Parameters["Action"] = "ListQueues";
            withQuery.Parameters["Prefix"] = "a b";
            requests.Add(withQuery);

            // Each request twice so both the miss and the hit path are compared.
            foreach (var request in requests)
            {
                AssertSameUri(AmazonServiceClient.ComposeUrl(request), handler.ComposeRequestUrl(request));
                AssertSameUri(AmazonServiceClient.ComposeUrl(request), handler.ComposeRequestUrl(request));
            }
        }

#if NET8_0_OR_GREATER
        [TestMethod]
        public void ComposeRequestUrl_HonorsCanonicalizationSettingChanges()
        {
            var original = AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization;
            try
            {
                var handler = new HttpHandler<Stream>(new HttpHandlerTests.MockHttpRequestFactory(), new object());
                var request = CreateRequest("https://bucket.s3.amazonaws.com", "/foo/../bar.txt");

                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = false;
                var preserved = handler.ComposeRequestUrl(request);
                AssertSameUri(AmazonServiceClient.ComposeUrl(request), preserved);
                Assert.AreEqual("/foo/../bar.txt", preserved.AbsolutePath);

                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = true;
                var canonicalized = handler.ComposeRequestUrl(request);
                AssertSameUri(AmazonServiceClient.ComposeUrl(request), canonicalized);
                Assert.AreEqual("/bar.txt", canonicalized.AbsolutePath);

                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = false;
                Assert.AreEqual("/foo/../bar.txt", handler.ComposeRequestUrl(request).AbsolutePath);
            }
            finally
            {
                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = original;
            }
        }

        [TestMethod]
        public void CreateRequestUri_UsesPassedCanonicalizationFlagNotGlobalSetting()
        {
            var original = AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization;
            try
            {
                const string url = "https://bucket.s3.amazonaws.com/foo/../bar.txt";

                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = true;
                Assert.AreEqual("/foo/../bar.txt", AmazonServiceClient.CreateRequestUri(url, false).AbsolutePath);

                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = false;
                Assert.AreEqual("/bar.txt", AmazonServiceClient.CreateRequestUri(url, true).AbsolutePath);
            }
            finally
            {
                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = original;
            }
        }
#endif

        #endregion

#if !NETFRAMEWORK
        #region Response headers

        // The header copy algorithm before the fast path was added.
        private static void ReferenceCopyHeaders(HttpResponseMessage response, out string[] names, out Dictionary<string, string> values)
        {
            var headerNames = new List<string>();
            values = new Dictionary<string, string>(10, StringComparer.OrdinalIgnoreCase);

            foreach (var kvp in response.Headers)
            {
                headerNames.Add(kvp.Key);
                values.Add(kvp.Key, ReferenceFirstValue(response.Headers, kvp.Key));
            }

            if (response.Content != null)
            {
                foreach (var kvp in response.Content.Headers)
                {
                    if (!headerNames.Contains(kvp.Key))
                    {
                        headerNames.Add(kvp.Key);
                        values.Add(kvp.Key, ReferenceFirstValue(response.Content.Headers, kvp.Key));
                    }
                }
            }
            names = headerNames.ToArray();
        }

        private static string ReferenceFirstValue(System.Net.Http.Headers.HttpHeaders headers, string key)
        {
            if (headers.TryGetValues(key, out var headerValues))
                return headerValues.FirstOrDefault();
            return string.Empty;
        }

        private static HttpResponseMessage CreateResponse()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(Encoding.UTF8.GetBytes("{\"a\":1}"))
            };
            response.Headers.TryAddWithoutValidation("x-amzn-RequestId", "request-id-1");
            response.Headers.TryAddWithoutValidation("x-amz-crc32", "12345");
            response.Headers.TryAddWithoutValidation("x-multi", new[] { "first", "second" });
            response.Headers.TryAddWithoutValidation("x-comma", "a, b");
            response.Headers.TryAddWithoutValidation("x-empty", "");
            response.Headers.TryAddWithoutValidation("x-newline", "bad\r\nvalue");
            response.Headers.TryAddWithoutValidation("Date", "Mon, 05 Oct 2026 03:00:00 GMT");
            response.Headers.TryAddWithoutValidation("ETag", "\"abc\"");
            response.Headers.TryAddWithoutValidation("Cache-Control", "no-cache,   max-age=0");
            response.Headers.TryAddWithoutValidation("Age", "not-a-number");
            response.Headers.TryAddWithoutValidation("x-dup", "from-response");
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json") { CharSet = "utf-8" };
            response.Content.Headers.TryAddWithoutValidation("Content-Encoding", "gzip");
            response.Content.Headers.TryAddWithoutValidation("Expires", "Tue, 06 Oct 2026 03:00:00 GMT");
            response.Content.Headers.TryAddWithoutValidation("Last-Modified", "garbage");
            response.Content.Headers.TryAddWithoutValidation("x-content-custom", "content-value");
            response.Content.Headers.TryAddWithoutValidation("x-dup", "from-content");
            return response;
        }

        [TestMethod]
        public void HttpClientResponseData_HeadersMatchReference()
        {
            ReferenceCopyHeaders(PrepareLikeConstructor(CreateResponse()), out var expectedNames, out var expectedValues);
            var data = new HttpClientResponseData(CreateResponse());

            var names = data.GetHeaderNames();
            CollectionAssert.AreEqual(expectedNames, names);
            Assert.AreSame(names, data.GetHeaderNames());

            foreach (var name in expectedNames)
            {
                Assert.AreEqual(expectedValues[name], data.GetHeaderValue(name), name);
                Assert.AreEqual(expectedValues[name], data.GetHeaderValue(name.ToUpperInvariant()), name);
                Assert.AreEqual(expectedValues[name], data.GetHeaderValue(name.ToLowerInvariant()), name);
                Assert.IsTrue(data.IsHeaderPresent(name), name);
                Assert.IsTrue(data.IsHeaderPresent(name.ToUpperInvariant()), name);
            }

            Assert.AreEqual("request-id-1", data.GetHeaderValue("X-AMZN-REQUESTID"));
            Assert.AreEqual("first", data.GetHeaderValue("x-multi"));
            Assert.AreEqual("from-response", data.GetHeaderValue("x-dup"));
            Assert.AreEqual("content-value", data.GetHeaderValue("x-content-custom"));
            Assert.AreEqual("7", data.GetHeaderValue("Content-Length"));
            Assert.AreEqual(string.Empty, data.GetHeaderValue("x-missing"));
            Assert.IsFalse(data.IsHeaderPresent("x-missing"));
            Assert.IsFalse(data.IsHeaderPresent(null));
            Assert.AreEqual(7, data.ContentLength);
            Assert.AreEqual("application/json", data.ContentType);
        }

        [TestMethod]
        public void HttpClientResponseData_NoCustomHeadersMatchesReference()
        {
            Func<HttpResponseMessage> create = () => new HttpResponseMessage(HttpStatusCode.OK) { Content = new ByteArrayContent(new byte[0]) };
            ReferenceCopyHeaders(PrepareLikeConstructor(create()), out var expectedNames, out var expectedValues);
            var data = new HttpClientResponseData(create());

            CollectionAssert.AreEqual(expectedNames, data.GetHeaderNames());
            foreach (var name in expectedNames)
                Assert.AreEqual(expectedValues[name], data.GetHeaderValue(name));
        }

        [TestMethod]
        public void HttpClientResponseData_EventStreamConstructorHasNoHeaderNames()
        {
            var data = new HttpClientResponseData(new Dictionary<string, IEventStreamHeader>());
            Assert.IsNull(data.GetHeaderNames());
            Assert.AreEqual(string.Empty, data.GetHeaderValue("x-amzn-RequestId"));
            Assert.IsFalse(data.IsHeaderPresent("x-amzn-RequestId"));
        }

        // The constructor reads Content.Headers.ContentLength (which stores the computed length) before
        // copying headers; do the same before running the reference so both see the same header set.
        private static HttpResponseMessage PrepareLikeConstructor(HttpResponseMessage response)
        {
            _ = response.Content.Headers.ContentLength;
            _ = response.Content.Headers.ContentType;
            return response;
        }

        #endregion

        #region Request message

        [TestMethod]
        public void GetHttpMethod_ReusesStandardMethods()
        {
            Assert.AreSame(HttpMethod.Get, HttpWebRequestMessage.GetHttpMethod("GET"));
            Assert.AreSame(HttpMethod.Post, HttpWebRequestMessage.GetHttpMethod("POST"));
            Assert.AreSame(HttpMethod.Put, HttpWebRequestMessage.GetHttpMethod("PUT"));
            Assert.AreSame(HttpMethod.Delete, HttpWebRequestMessage.GetHttpMethod("DELETE"));
            Assert.AreSame(HttpMethod.Head, HttpWebRequestMessage.GetHttpMethod("HEAD"));
            Assert.AreSame(HttpMethod.Options, HttpWebRequestMessage.GetHttpMethod("OPTIONS"));

            foreach (var method in new[] { "GET", "POST", "PUT", "DELETE", "HEAD", "OPTIONS", "PATCH", "get", "Custom" })
            {
                var expected = new HttpMethod(method);
                var actual = HttpWebRequestMessage.GetHttpMethod(method);
                Assert.AreEqual(expected, actual);
                Assert.AreEqual(expected.Method, actual.Method);
            }
            // Null falls through to the HttpMethod constructor, whose exception type depends on the runtime
            // (ArgumentException on netcoreapp3.1, ArgumentNullException on net472 and .NET 5+).
            var expectedException = CaptureException(() => new HttpMethod(null));
            var actualException = CaptureException(() => HttpWebRequestMessage.GetHttpMethod(null));
            Assert.IsNotNull(expectedException);
            Assert.IsNotNull(actualException);
            Assert.AreEqual(expectedException.GetType(), actualException.GetType());
        }

        private static Exception CaptureException(Action action)
        {
            try { action(); }
            catch (Exception e) { return e; }
            return null;
        }

        [TestMethod]
        public void HttpWebRequestMessage_MethodRoundTrips()
        {
            using (var message = new HttpWebRequestMessage(new HttpClient(), new Uri("https://example.com"), new MockClientConfig()))
            {
                message.Method = "POST";
                Assert.AreEqual("POST", message.Method);
                Assert.AreSame(HttpMethod.Post, message.Request.Method);

                message.Method = "PATCH";
                Assert.AreEqual("PATCH", message.Method);
            }
        }

        [TestMethod]
        public void SetRequestHeaders_SameResultForDictionaryAndOtherDictionaryTypes()
        {
            var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Host", "example.com" },
                { "X-Amz-Date", "20261005T030000Z" },
                { "User-Agent", "aws-sdk-dotnet-coreclr/4.0 ua/2.1 md/ClientAsync m/E,b" },
                { "Authorization", "AWS4-HMAC-SHA256 Credential=AKID/20261005/us-east-1/dynamodb/aws4_request, SignedHeaders=host, Signature=abc" },
                { "amz-sdk-request", "attempt=1; max=3" },
                { "Content-Type", "application/x-amz-json-1.0" },
                { "Content-Length", "10" },
                { "content-md5", "abc" },
                { "Expires", "Tue, 06 Oct 2026 03:00:00 GMT" },
            };

            using (var fromDictionary = new HttpWebRequestMessage(new HttpClient(), new Uri("https://example.com"), new MockClientConfig()))
            using (var fromSorted = new HttpWebRequestMessage(new HttpClient(), new Uri("https://example.com"), new MockClientConfig()))
            {
                fromDictionary.SetRequestHeaders(headers);
                fromSorted.SetRequestHeaders(new SortedDictionary<string, string>(headers, StringComparer.OrdinalIgnoreCase));

                Func<HttpWebRequestMessage, Dictionary<string, string>> snapshot = m =>
                    m.Request.Headers.ToDictionary(h => h.Key, h => string.Join("|", h.Value));

                var expected = snapshot(fromSorted);
                var actual = snapshot(fromDictionary);
                CollectionAssert.AreEquivalent(expected.ToList(), actual.ToList());

                Assert.AreEqual(5, actual.Count);
                Assert.AreEqual("example.com", fromDictionary.Request.Headers.Host);
                foreach (var contentHeader in new[] { "Content-Type", "Content-Length", "content-md5", "Expires" })
                    Assert.IsFalse(actual.Keys.Any(k => string.Equals(k, contentHeader, StringComparison.OrdinalIgnoreCase)), contentHeader);
            }
        }

        #endregion
#endif

        #region Telemetry

        private static IExecutionContext CreateListBucketsContext(AmazonS3Config config)
        {
            var listBucketsRequest = new ListBucketsRequest();
            var request = new ListBucketsRequestMarshaller().Marshall(listBucketsRequest);
            request.Endpoint = new Uri("https://s3.amazonaws.com");
            return new ExecutionContext(
                new RequestContext(true, new NullSigner())
                {
                    ClientConfig = config,
                    Marshaller = new ListBucketsRequestMarshaller(),
                    OriginalRequest = listBucketsRequest,
                    Request = request,
                    Unmarshaller = new ListBucketsResponseUnmarshaller()
                },
                new ResponseContext());
        }

        private static HttpHandlerTests.MockHttpRequestFactory CreateFactory()
        {
            return new HttpHandlerTests.MockHttpRequestFactory
            {
#if NETFRAMEWORK
                ResponseCreator = _ => MockWebResponse.Create(HttpStatusCode.OK, new Dictionary<string, string> { { "Content-Length", "25" } }, "<ListAllMyBucketsResult/>")
#else
                ResponseCreator = _ => new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(Encoding.UTF8.GetBytes("<ListAllMyBucketsResult/>"))
                }
#endif
            };
        }

        [TestMethod]
        public void RecordsHttpMetricsAndSpanAttributesWithCustomProviders()
        {
            var meterProvider = new RecordingMeterProvider();
            var tracerProvider = new RecordingTracerProvider();
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            config.TelemetryProvider.RegisterMeterProvider(meterProvider);
            config.TelemetryProvider.RegisterTracerProvider(tracerProvider);

            var handler = new HttpHandler<Stream>(CreateFactory(), new object());
            _ = new RuntimePipeline(handler);
            handler.InvokeSync(CreateListBucketsContext(config));

            var received = meterProvider.Records.Single(r => r.Name == TelemetryConstants.HTTPBytesReceivedMetricName);
            Assert.AreEqual(25.0, received.Value);
            Assert.AreEqual(1, meterProvider.Records.Count(r => r.Name == TelemetryConstants.CallAttemptDurationMetricName));

            var span = tracerProvider.Spans.Single(s => s.Name == TelemetryConstants.HTTPRequestSpanName);
            Assert.AreEqual("GET", span.Attributes[TelemetryConstants.HTTPMethodAttributeKey]);
            Assert.AreEqual(200, span.Attributes[TelemetryConstants.HTTPStatusCodeAttributeKey]);
            Assert.AreEqual(25L, span.Attributes[TelemetryConstants.HTTPResponseContentLengthAttributeKey]);
        }

        [TestMethod]
        public void RecordsHttpMetricsWithCustomMeterProviderOnly()
        {
            var meterProvider = new RecordingMeterProvider();
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            config.TelemetryProvider.RegisterMeterProvider(meterProvider);

            var handler = new HttpHandler<Stream>(CreateFactory(), new object());
            _ = new RuntimePipeline(handler);
            handler.InvokeSync(CreateListBucketsContext(config));

            Assert.AreEqual(1, meterProvider.Records.Count(r => r.Name == TelemetryConstants.HTTPBytesReceivedMetricName));
            Assert.AreEqual(1, meterProvider.Records.Count(r => r.Name == TelemetryConstants.CallAttemptDurationMetricName));
        }

        [TestMethod]
        public void RecordsSpanAttributesWithCustomTracerProviderOnly()
        {
            var tracerProvider = new RecordingTracerProvider();
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            config.TelemetryProvider.RegisterTracerProvider(tracerProvider);
            Assert.IsInstanceOfType(config.TelemetryProvider.MeterProvider, typeof(NoOpMeterProvider));

            var handler = new HttpHandler<Stream>(CreateFactory(), new object());
            _ = new RuntimePipeline(handler);
            handler.InvokeSync(CreateListBucketsContext(config));

            var span = tracerProvider.Spans.Single(s => s.Name == TelemetryConstants.HTTPRequestSpanName);
            Assert.AreEqual(200, span.Attributes[TelemetryConstants.HTTPStatusCodeAttributeKey]);
            Assert.AreEqual(25L, span.Attributes[TelemetryConstants.HTTPResponseContentLengthAttributeKey]);
        }

        [TestMethod]
        public void SucceedsWithNoOpProviders()
        {
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            var handler = new HttpHandler<Stream>(CreateFactory(), new object());
            _ = new RuntimePipeline(handler);
            var context = CreateListBucketsContext(config);
            handler.InvokeSync(context);

            Assert.AreEqual(HttpStatusCode.OK, context.ResponseContext.HttpResponse.StatusCode);
            Assert.IsTrue(context.RequestContext.Request.Headers.ContainsKey(HeaderKeys.UserAgentHeader));
        }

        private static IExecutionContext CreatePutContentContext(bool enableMetrics)
        {
            var listBucketsRequest = new ListBucketsRequest();
            var request = new ListBucketsRequestMarshaller().Marshall(listBucketsRequest);
            // The async NetFramework mock serves the response named by the endpoint host.
            request.Endpoint = new Uri("http://ListBuckets");
            request.HttpMethod = "PUT";
            request.Content = Encoding.UTF8.GetBytes("payload");
            return new ExecutionContext(
                new RequestContext(enableMetrics, new NullSigner())
                {
                    ClientConfig = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() },
                    Marshaller = new ListBucketsRequestMarshaller(),
                    OriginalRequest = listBucketsRequest,
                    Request = request,
                    Unmarshaller = new ListBucketsResponseUnmarshaller()
                },
                new ResponseContext());
        }

        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void RecordsRequestSizeOnlyWhenRequestMetricsEnabled(bool enableMetrics)
        {
            var handler = new HttpHandler<Stream>(CreateFactory(), new object());
            _ = new RuntimePipeline(handler);
            var context = CreatePutContentContext(enableMetrics);
            handler.InvokeSync(context);

            var properties = context.RequestContext.Metrics.Properties;
            Assert.AreEqual(enableMetrics, properties.ContainsKey(Metric.RequestSize));
            if (enableMetrics)
                Assert.AreEqual(7, properties[Metric.RequestSize].Single());
        }

#if NETFRAMEWORK
        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async System.Threading.Tasks.Task RecordsRequestSizeOnlyWhenRequestMetricsEnabledAsync(bool enableMetrics)
        {
            var handler = new HttpHandler<Stream>(CreateFactory(), new object());
            _ = new RuntimePipeline(handler);
            var context = CreatePutContentContext(enableMetrics);
            await handler.InvokeAsync<ListBucketsResponse>(context);

            var properties = context.RequestContext.Metrics.Properties;
            Assert.AreEqual(enableMetrics, properties.ContainsKey(Metric.RequestSize));
            if (enableMetrics)
                Assert.AreEqual(7, properties[Metric.RequestSize].Single());
        }
#endif

        [TestMethod]
        public void UserAgentHeaderMatchesGenerateAcrossRequests()
        {
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            var handler = new HttpHandler<Stream>(CreateFactory(), new object());
            _ = new RuntimePipeline(handler);

            var first = CreateListBucketsContext(config);
            first.RequestContext.UserAgentDetails.AddUserAgentComponent("ua/2.1");
            first.RequestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.RETRY_MODE_STANDARD);
            handler.InvokeSync(first);
            var firstHeader = first.RequestContext.Request.Headers[HeaderKeys.UserAgentHeader];
            Assert.AreEqual("ua/2.1 m/E", firstHeader);

            var same = CreateListBucketsContext(config);
            same.RequestContext.UserAgentDetails.AddUserAgentComponent("ua/2.1");
            same.RequestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.RETRY_MODE_STANDARD);
            handler.InvokeSync(same);
            Assert.AreSame(firstHeader, same.RequestContext.Request.Headers[HeaderKeys.UserAgentHeader]);

            var different = CreateListBucketsContext(config);
            different.RequestContext.UserAgentDetails.AddUserAgentComponent("ua/2.1");
            ((IAmazonWebServiceRequest)different.RequestContext.OriginalRequest).UserAgentDetails.AddUserAgentComponent("custom");
            ((IAmazonWebServiceRequest)different.RequestContext.OriginalRequest).UserAgentDetails.AddFeature(UserAgentFeatureId.PAGINATOR);
            different.RequestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.SIGV4A_SIGNING);
            handler.InvokeSync(different);
            Assert.AreEqual($"ua/2.1 custom m/{UserAgentFeatureId.SIGV4A_SIGNING.Value},{UserAgentFeatureId.PAGINATOR.Value}",
                different.RequestContext.Request.Headers[HeaderKeys.UserAgentHeader]);
        }

        private class RecordingMeterProvider : MeterProvider
        {
            public List<(string Name, double Value)> Records { get; } = new List<(string, double)>();

            public override Meter GetMeter(string scope, Attributes attributes = null)
            {
                return new RecordingMeter(this);
            }

            private class RecordingMeter : Meter
            {
                private readonly RecordingMeterProvider _provider;
                public RecordingMeter(RecordingMeterProvider provider) { _provider = provider; }

                public override UpDownCounter<T> CreateUpDownCounter<T>(string name, string units = null, string description = null)
                {
                    return new NoOpMeter().CreateUpDownCounter<T>(name, units, description);
                }

                public override MonotonicCounter<T> CreateMonotonicCounter<T>(string name, string units = null, string description = null)
                {
                    return new RecordingCounter<T>(_provider, name);
                }

                public override Histogram<T> CreateHistogram<T>(string name, string units = null, string description = null)
                {
                    return new RecordingHistogram<T>(_provider, name);
                }
            }

            private class RecordingCounter<T> : MonotonicCounter<T> where T : struct
            {
                private readonly RecordingMeterProvider _provider;
                private readonly string _name;
                public RecordingCounter(RecordingMeterProvider provider, string name) { _provider = provider; _name = name; }

                public override void Add(T value, Attributes attributes = null)
                {
                    _provider.Records.Add((_name, Convert.ToDouble(value)));
                }
            }

            private class RecordingHistogram<T> : Histogram<T> where T : struct
            {
                private readonly RecordingMeterProvider _provider;
                private readonly string _name;
                public RecordingHistogram(RecordingMeterProvider provider, string name) { _provider = provider; _name = name; }

                public override void Record(T value, Attributes attributes = null)
                {
                    _provider.Records.Add((_name, Convert.ToDouble(value)));
                }
            }
        }

        private class RecordingTracerProvider : TracerProvider
        {
            public List<RecordingSpan> Spans { get; } = new List<RecordingSpan>();

            public override Tracer GetTracer(string scope)
            {
                return new RecordingTracer(this);
            }

            private class RecordingTracer : Tracer
            {
                private readonly RecordingTracerProvider _provider;
                public RecordingTracer(RecordingTracerProvider provider) { _provider = provider; }

                public override TraceSpan CreateSpan(string name, Attributes initialAttributes = null, SpanKind spanKind = SpanKind.INTERNAL, SpanContext parentContext = null)
                {
                    var span = new RecordingSpan(name);
                    _provider.Spans.Add(span);
                    return span;
                }
            }
        }

        private class RecordingSpan : TraceSpan
        {
            public RecordingSpan(string name) { Name = name; }

            public Dictionary<string, object> Attributes { get; } = new Dictionary<string, object>();

            public override void EmitEvent(string name, Attributes attributes = null) { }
            public override void SetAttribute(string key, object value) { Attributes[key] = value; }
            public override void SetStatus(SpanStatus status) { }
            public override void RecordException(Exception exception, Attributes attributes = null) { }
            public override void End() { }
        }

        #endregion
    }
}
