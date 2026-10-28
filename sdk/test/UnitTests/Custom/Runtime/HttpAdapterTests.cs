﻿/*
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
using Amazon.Runtime.Telemetry.Metrics.NoOp;
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
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class HttpAdapterTests
    {
        private static UserAgentDetails CreateDetails(IEnumerable<string> components, IEnumerable<string> featureIds)
        {
            var details = new UserAgentDetails();
            foreach (var c in components)
                details.AddUserAgentComponent(c);
            foreach (var f in featureIds)
                details.AddFeature(new UserAgentFeatureId(f));
            return details;
        }

        private static HttpHandler<Stream> CreateHandler()
        {
            var handler = new HttpHandler<Stream>(CreateFactory(), new object());
            _ = new RuntimePipeline(handler);
            return handler;
        }

        private static string GenerateAndAssertReuse(string[] components, string[] featureIds)
        {
            var details = CreateDetails(components, featureIds);
            var generated = details.GetOrGenerateUserAgentWithMetrics(null);
            Assert.AreEqual(details.GenerateUserAgentWithMetrics(), generated.Value);

            var copy = CreateDetails(components.Select(c => c == null ? null : new string(c.ToCharArray())),
                                     featureIds.Select(f => new string(f.ToCharArray())));
            Assert.AreSame(generated, copy.GetOrGenerateUserAgentWithMetrics(generated));
            return generated.Value;
        }

        [TestMethod]
        [DataRow(new string[0], new string[0], "")]
        [DataRow(new[] { "aws-sdk-dotnet-coreclr/4.0.0.0 ua/2.1 os/linux" }, new string[0], "aws-sdk-dotnet-coreclr/4.0.0.0 ua/2.1 os/linux")]
        [DataRow(new string[0], new[] { "E", "b" }, " m/E,b")]
        [DataRow(new[] { "aws-sdk-dotnet-coreclr/4.0.0.0 ua/2.1", "md/ClientAsync", "cfg/init-coll#1" }, new[] { "E", "b", "Z", "a" },
            "aws-sdk-dotnet-coreclr/4.0.0.0 ua/2.1 md/ClientAsync cfg/init-coll#1 m/E,b,Z,a")]
        [DataRow(new[] { "  padded  ", "dup", "dup", " ", null, "" }, new[] { "E", "E", "F" }, "padded dup m/E,F")]
        [DataRow(new[] { "ua" }, new[] { "é", "é", "x" }, "ua m/é,x")]
        public void UserAgentMatchesExpectedAndReusesEqualInputs(string[] components, string[] featureIds, string expected)
        {
            Assert.AreEqual(expected, GenerateAndAssertReuse(components, featureIds));
        }

        [TestMethod]
        [DataRow(400, "f", 1024, " m/f0,f1,", ",f224,f225")]
        [DataRow(200, "é", 834, " m/é0,é1,", ",é186,é187")]
        public void UserAgentTruncatesFeaturesAtLastCommaWithin1024Bytes(int count, string prefix, int expectedLength, string expectedStart, string expectedEnd)
        {
            var featureIds = Enumerable.Range(0, count).Select(i => prefix + i).ToArray();
            var actual = GenerateAndAssertReuse(new[] { "ua" }, featureIds);

            Assert.AreEqual(expectedLength, actual.Length);
            StringAssert.StartsWith(actual, "ua" + expectedStart);
            StringAssert.EndsWith(actual, expectedEnd);
            Assert.IsTrue(Encoding.UTF8.GetByteCount(actual.Substring("ua ".Length)) <= 1024);
        }

        [TestMethod]
        public void GetOrGenerateUserAgentWithMetrics_RegeneratesWhenInputsDiffer()
        {
            var cached = CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "E", "b" }).GetOrGenerateUserAgentWithMetrics(null);
            var variants = new[]
            {
                CreateDetails(new[] { "ua/2.1", "md/ClientSync" }, new[] { "E", "b" }),
                CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "E", "c" }),
                CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "b", "E" }),
                CreateDetails(new[] { "ua/2.1", "md/ClientAsync" }, new[] { "E", "b", "Z" }),
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
        public void GetUserAgent_ReusesOneEntryPerShapeWhenAlternating()
        {
            var handler = CreateHandler();
            var shapes = new[]
            {
                new { Components = new[] { "ua/2.1", "md/ClientSync" }, Features = new[] { "E" }, Expected = "ua/2.1 md/ClientSync m/E" },
                new { Components = new[] { "ua/2.1", "md/ClientAsync" }, Features = new[] { "E" }, Expected = "ua/2.1 md/ClientAsync m/E" },
                new { Components = new[] { "ua/2.1", "md/ClientAsync" }, Features = new[] { "E", "C" }, Expected = "ua/2.1 md/ClientAsync m/E,C" },
            };
            var first = shapes.Select(s => handler.GetUserAgent(CreateDetails(s.Components, s.Features))).ToArray();
            CollectionAssert.AreEqual(shapes.Select(s => s.Expected).ToArray(), first);

            for (int round = 0; round < 3; round++)
                for (int i = 0; i < shapes.Length; i++)
                    Assert.AreSame(first[i], handler.GetUserAgent(CreateDetails(shapes[i].Components, shapes[i].Features)));
        }

        [TestMethod]
        public void GetUserAgent_MatchesGenerateWithMoreShapesThanEntries()
        {
            var handler = CreateHandler();
            for (int round = 0; round < 3; round++)
            {
                for (int shape = 0; shape < 9; shape++)
                {
                    var details = CreateDetails(new[] { "ua/2.1", "md/shape" + shape }, new[] { "E" });
                    Assert.AreEqual(details.GenerateUserAgentWithMetrics(), handler.GetUserAgent(details));
                }
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

        [TestMethod]
        public void UserAgentHeaderMatchesGenerateAcrossRequests()
        {
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            var handler = CreateHandler();
            Func<IExecutionContext> create = () =>
            {
                var context = CreateListBucketsContext(config);
                context.RequestContext.UserAgentDetails.AddUserAgentComponent("ua/2.1");
                return context;
            };

            var first = create();
            first.RequestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.RETRY_MODE_STANDARD);
            handler.InvokeSync(first);
            var firstHeader = first.RequestContext.Request.Headers[HeaderKeys.UserAgentHeader];
            Assert.AreEqual("ua/2.1 m/E", firstHeader);

            var same = create();
            same.RequestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.RETRY_MODE_STANDARD);
            handler.InvokeSync(same);
            Assert.AreSame(firstHeader, same.RequestContext.Request.Headers[HeaderKeys.UserAgentHeader]);

            var different = create();
            var originalDetails = ((IAmazonWebServiceRequest)different.RequestContext.OriginalRequest).UserAgentDetails;
            originalDetails.AddUserAgentComponent("custom");
            originalDetails.AddFeature(UserAgentFeatureId.PAGINATOR);
            different.RequestContext.UserAgentDetails.AddFeature(UserAgentFeatureId.SIGV4A_SIGNING);
            handler.InvokeSync(different);
            Assert.AreEqual($"ua/2.1 custom m/{UserAgentFeatureId.SIGV4A_SIGNING.Value},{UserAgentFeatureId.PAGINATOR.Value}",
                different.RequestContext.Request.Headers[HeaderKeys.UserAgentHeader]);
        }

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
            var withPathResource = CreateRequest("https://bucket.s3.amazonaws.com", "/{Key+}");
            withPathResource.AddPathResource("{Key+}", "a/b+c:d");
            var withSubResource = CreateRequest("https://bucket.s3.amazonaws.com", "/key");
            withSubResource.AddSubResource("versionId", "v1");
            withSubResource.AddSubResource("acl");
            var withQuery = CreateRequest("https://sqs.us-east-1.amazonaws.com", "/");
            withQuery.UseQueryString = true;
            withQuery.Parameters["Action"] = "ListQueues";
            withQuery.Parameters["Prefix"] = "a b";

            var requests = new[]
            {
                CreateRequest("https://dynamodb.us-east-1.amazonaws.com", "/"),
                CreateRequest("https://dynamodb.us-east-1.amazonaws.com", "/"),
                CreateRequest("https://dynamodb.us-east-1.amazonaws.com", "/other"),
                CreateRequest("https://dynamodb.us-west-2.amazonaws.com", "/other"),
                CreateRequest("https://bucket.s3.amazonaws.com", "/key%20with%20spaces"),
                CreateRequest("https://bucket.s3.amazonaws.com/", "key"),
                CreateRequest("https://bucket.s3.amazonaws.com", null),
                withPathResource,
                withSubResource,
                withQuery,
            };

#if NETFRAMEWORK
            const bool reusesUri = false;
#else
            const bool reusesUri = true;
#endif
            var handler = CreateHandler();
            Uri previous = null;
            foreach (var request in requests)
            {
                var expected = AmazonServiceClient.ComposeUrl(request);
                var first = handler.ComposeRequestUrl(request);
                var second = handler.ComposeRequestUrl(request);
                AssertSameUri(expected, first);
                AssertSameUri(expected, second);
                Assert.AreEqual(reusesUri && previous?.OriginalString == expected.OriginalString, ReferenceEquals(previous, first));
                Assert.AreEqual(reusesUri, ReferenceEquals(first, second));
                previous = first;
            }
        }

#if NET8_0_OR_GREATER
        [TestMethod]
        public void ComposeRequestUrl_HonorsCanonicalizationSettingChanges()
        {
            var original = AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization;
            try
            {
                var handler = CreateHandler();
                var request = CreateRequest("https://bucket.s3.amazonaws.com", "/foo/../bar.txt");
                foreach (var disable in new[] { false, true, false })
                {
                    AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = disable;
                    var uri = handler.ComposeRequestUrl(request);
                    AssertSameUri(AmazonServiceClient.ComposeUrl(request), uri);
                    Assert.AreEqual(disable ? "/bar.txt" : "/foo/../bar.txt", uri.AbsolutePath);
                }
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

#if !NETFRAMEWORK
        // Response header copy before this change.
        private static void ReferenceCopyHeaders(HttpResponseMessage response, out string[] names, out Dictionary<string, string> values)
        {
            var headerNames = new List<string>();
            values = new Dictionary<string, string>(10, StringComparer.OrdinalIgnoreCase);
            foreach (var headers in new System.Net.Http.Headers.HttpHeaders[] { response.Headers, response.Content.Headers })
            {
                foreach (var kvp in headers)
                {
                    if (headerNames.Contains(kvp.Key))
                        continue;
                    headerNames.Add(kvp.Key);
                    values.Add(kvp.Key, headers.TryGetValues(kvp.Key, out var headerValues) ? headerValues.FirstOrDefault() : string.Empty);
                }
            }
            names = headerNames.ToArray();
        }

        private static HttpResponseMessage CreateResponse(bool customHeaders)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(Encoding.UTF8.GetBytes("{\"a\":1}"))
            };
            if (customHeaders)
            {
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
            }
            // The constructor reads these first, which adds the computed Content-Length; the reference must see it too.
            _ = response.Content.Headers.ContentLength;
            _ = response.Content.Headers.ContentType;
            return response;
        }

        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void HttpClientResponseData_HeadersMatchReference(bool customHeaders)
        {
            ReferenceCopyHeaders(CreateResponse(customHeaders), out var expectedNames, out var expectedValues);
            var data = new HttpClientResponseData(CreateResponse(customHeaders));

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
            Assert.AreEqual("7", data.GetHeaderValue("Content-Length"));
            Assert.AreEqual(7, data.ContentLength);
            Assert.AreEqual(string.Empty, data.GetHeaderValue("x-missing"));
            Assert.IsFalse(data.IsHeaderPresent("x-missing"));
            Assert.IsFalse(data.IsHeaderPresent(null));

            if (customHeaders)
            {
                Assert.AreEqual("request-id-1", data.GetHeaderValue("X-AMZN-REQUESTID"));
                Assert.AreEqual("first", data.GetHeaderValue("x-multi"));
                Assert.AreEqual("from-response", data.GetHeaderValue("x-dup"));
                Assert.AreEqual("content-value", data.GetHeaderValue("x-content-custom"));
                Assert.AreEqual("application/json", data.ContentType);
            }
        }

        [TestMethod]
        public void HttpClientResponseData_CaseOnlyNameCollisionKeepsResponseHeader()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = new ByteArrayContent(new byte[0]) };
            response.Headers.TryAddWithoutValidation("x-amz-dup", "from-response");
            response.Content.Headers.TryAddWithoutValidation("X-Amz-Dup", "from-content");

            var data = new HttpClientResponseData(response);

            Assert.AreEqual("from-response", data.GetHeaderValue("X-AMZ-DUP"));
            Assert.AreEqual("x-amz-dup", data.GetHeaderNames().Single(n => string.Equals(n, "x-amz-dup", StringComparison.OrdinalIgnoreCase)));
        }

        [TestMethod]
        public void HttpClientResponseData_EventStreamConstructorHasNoHeaderNames()
        {
            var data = new HttpClientResponseData(new Dictionary<string, IEventStreamHeader>());
            Assert.IsNull(data.GetHeaderNames());
            Assert.AreEqual(string.Empty, data.GetHeaderValue("x-amzn-RequestId"));
            Assert.IsFalse(data.IsHeaderPresent("x-amzn-RequestId"));
        }

        [TestMethod]
        public void GetHttpMethod_ReusesStandardMethods()
        {
            foreach (var method in new[] { HttpMethod.Get, HttpMethod.Post, HttpMethod.Put, HttpMethod.Delete, HttpMethod.Head, HttpMethod.Options })
                Assert.AreSame(method, HttpWebRequestMessage.GetHttpMethod(method.Method));

            foreach (var method in new[] { "PATCH", "get", "Custom" })
            {
                var actual = HttpWebRequestMessage.GetHttpMethod(method);
                Assert.AreEqual(new HttpMethod(method), actual);
                Assert.AreEqual(new HttpMethod(method).Method, actual.Method);
            }

            // Null goes to the HttpMethod constructor, whose exception type differs by runtime.
            var expectedException = CaptureException(() => new HttpMethod(null));
            Assert.IsNotNull(expectedException);
            Assert.AreEqual(expectedException.GetType(), CaptureException(() => HttpWebRequestMessage.GetHttpMethod(null))?.GetType());
        }

        private static Exception CaptureException(Action action)
        {
            try { action(); }
            catch (Exception e) { return e; }
            return null;
        }

        private static HttpWebRequestMessage CreateRequestMessage()
        {
            return new HttpWebRequestMessage(new HttpClient(), new Uri("https://example.com"), new MockClientConfig());
        }

        [TestMethod]
        public void HttpWebRequestMessage_MethodRoundTrips()
        {
            using (var message = CreateRequestMessage())
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

            using (var fromDictionary = CreateRequestMessage())
            using (var fromSorted = CreateRequestMessage())
            {
                fromDictionary.SetRequestHeaders(headers);
                fromSorted.SetRequestHeaders(new SortedDictionary<string, string>(headers, StringComparer.OrdinalIgnoreCase));

                Func<HttpWebRequestMessage, List<KeyValuePair<string, string>>> snapshot = m =>
                    m.Request.Headers.Select(h => new KeyValuePair<string, string>(h.Key, string.Join("|", h.Value))).ToList();
                var actual = snapshot(fromDictionary);
                CollectionAssert.AreEquivalent(snapshot(fromSorted), actual);

                Assert.AreEqual(5, actual.Count);
                Assert.AreEqual("example.com", fromDictionary.Request.Headers.Host);
                foreach (var contentHeader in new[] { "Content-Type", "Content-Length", "content-md5", "Expires" })
                    Assert.IsFalse(actual.Any(h => string.Equals(h.Key, contentHeader, StringComparison.OrdinalIgnoreCase)), contentHeader);
            }
        }
#endif

        private static IExecutionContext CreateListBucketsContext(AmazonS3Config config, bool enableMetrics = true)
        {
            var listBucketsRequest = new ListBucketsRequest();
            var request = new ListBucketsRequestMarshaller().Marshall(listBucketsRequest);
            request.Endpoint = new Uri("https://s3.amazonaws.com");
            return new ExecutionContext(
                new RequestContext(enableMetrics, new NullSigner())
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
        [DataRow(true, true)]
        [DataRow(true, false)]
        [DataRow(false, true)]
        [DataRow(false, false)]
        public void RecordsHttpTelemetryWithCustomAndNoOpProviders(bool customMeter, bool customTracer)
        {
            var meterProvider = new RecordingMeterProvider();
            var tracerProvider = new RecordingTracerProvider();
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            if (customMeter)
                config.TelemetryProvider.RegisterMeterProvider(meterProvider);
            else
                Assert.IsInstanceOfType(config.TelemetryProvider.MeterProvider, typeof(NoOpMeterProvider));
            if (customTracer)
                config.TelemetryProvider.RegisterTracerProvider(tracerProvider);

            var context = CreateListBucketsContext(config);
            CreateHandler().InvokeSync(context);

            Assert.AreEqual(HttpStatusCode.OK, context.ResponseContext.HttpResponse.StatusCode);
            Assert.IsTrue(context.RequestContext.Request.Headers.ContainsKey(HeaderKeys.UserAgentHeader));
            if (customMeter)
            {
                Assert.AreEqual(25.0, meterProvider.Records.Single(r => r.Name == TelemetryConstants.HTTPBytesReceivedMetricName).Value);
                Assert.AreEqual(1, meterProvider.Records.Count(r => r.Name == TelemetryConstants.CallAttemptDurationMetricName));
            }
            if (customTracer)
            {
                var span = tracerProvider.Spans.Single(s => s.Name == TelemetryConstants.HTTPRequestSpanName);
                Assert.AreEqual("GET", span.Attributes[TelemetryConstants.HTTPMethodAttributeKey]);
                Assert.AreEqual(200, span.Attributes[TelemetryConstants.HTTPStatusCodeAttributeKey]);
                Assert.AreEqual(25L, span.Attributes[TelemetryConstants.HTTPResponseContentLengthAttributeKey]);
            }
        }

        private static IExecutionContext CreatePutContentContext(bool enableMetrics)
        {
            var context = CreateListBucketsContext(new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() }, enableMetrics);
            // The async NetFramework mock serves the response named by the endpoint host.
            context.RequestContext.Request.Endpoint = new Uri("http://ListBuckets");
            context.RequestContext.Request.HttpMethod = "PUT";
            context.RequestContext.Request.Content = Encoding.UTF8.GetBytes("payload");
            return context;
        }

        private static void AssertRequestSize(IExecutionContext context, bool enableMetrics)
        {
            var properties = context.RequestContext.Metrics.Properties;
            Assert.AreEqual(enableMetrics, properties.ContainsKey(Metric.RequestSize));
            if (enableMetrics)
                Assert.AreEqual(7, properties[Metric.RequestSize].Single());
        }

        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void RecordsRequestSizeOnlyWhenRequestMetricsEnabled(bool enableMetrics)
        {
            var context = CreatePutContentContext(enableMetrics);
            CreateHandler().InvokeSync(context);
            AssertRequestSize(context, enableMetrics);
        }

#if NETFRAMEWORK
        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async System.Threading.Tasks.Task RecordsRequestSizeOnlyWhenRequestMetricsEnabledAsync(bool enableMetrics)
        {
            var context = CreatePutContentContext(enableMetrics);
            await CreateHandler().InvokeAsync<ListBucketsResponse>(context);
            AssertRequestSize(context, enableMetrics);
        }
#endif
    }
}
