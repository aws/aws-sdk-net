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
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Runtime.Telemetry.Metrics.NoOp;
using Amazon.Runtime.Telemetry.Tracing.NoOp;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class UserAgentTests
    {
        [DataTestMethod]
        [DataRow("SHA1", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "Z", "b", "X")]
        [DataRow("SHA1", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "Z", "c", "X")]
        [DataRow("SHA1", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "a", "b", "")]
        [DataRow("SHA1", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "a", "c", "")]

        [DataRow("SHA256", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "Z", "b", "Y")]
        [DataRow("SHA256", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "Z", "c", "Y")]
        [DataRow("SHA256", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "a", "b", "")]
        [DataRow("SHA256", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "a", "c", "")]

        [DataRow("CRC32", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "Z", "b", "U")]
        [DataRow("CRC32", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "Z", "c", "U")]
        [DataRow("CRC32", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "a", "b", "")]
        [DataRow("CRC32", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "a", "c", "")]

        [DataRow("CRC32C", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "Z", "b", "V")]
        [DataRow("CRC32C", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "Z", "c", "V")]
        [DataRow("CRC32C", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "a", "b", "")]
        [DataRow("CRC32C", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "a", "c", "")]

        [DataRow("CRC64NVME", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "Z", "b", "W")]
        [DataRow("CRC64NVME", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "Z", "c", "W")]
        [DataRow("CRC64NVME", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "a", "b", "")]
        [DataRow("CRC64NVME", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "a", "c", "")]
        public void Test_AddsFeatureIdsToUserAgent(
            string checksumAlgorithm,
            RequestChecksumCalculation requestChecksumCalculation,
            ResponseChecksumValidation responseChecksumValidation,
            string requestFeatureId,
            string responseFeatureId,
            string selectedChecksumFeatureId
        )
        {
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "test-bucket",
                Key = "test-key",
                ContentBody = "test-content",
                ChecksumAlgorithm = checksumAlgorithm
            };
            var config = new AmazonS3Config
            {
                RequestChecksumCalculation = requestChecksumCalculation,
                ResponseChecksumValidation = responseChecksumValidation
            };
            var request = RunMockRequest(putObjectRequest, config, PutObjectRequestMarshaller.Instance, PutObjectResponseUnmarshaller.Instance);

            request.Headers.TryGetValue(HeaderKeys.UserAgentHeader, out string userAgentHeader);
            Assert.IsNotNull(userAgentHeader);

            var metricsSection = userAgentHeader.Split(' ').First(part => part.StartsWith("m/")).Remove(0, 2);

            Assert.IsTrue(metricsSection.Contains(requestFeatureId));
            Assert.IsTrue(metricsSection.Contains(responseFeatureId));
            Assert.IsTrue(metricsSection.Contains(selectedChecksumFeatureId));
        }

        [TestMethod]
        public void TestUserAgentAdditionForPaginators()
        {
            var listObjectsV2Request = new ListObjectsV2Request
            {
                BucketName = "test"
            };
            PaginatorUtils.SetUserAgentAdditionOnRequest(listObjectsV2Request);
            var request = RunMockRequest(listObjectsV2Request, new AmazonS3Config(), ListObjectsV2RequestMarshaller.Instance, ListObjectsV2ResponseUnmarshaller.Instance);

            request.Headers.TryGetValue(HeaderKeys.UserAgentHeader, out string userAgentHeader);
            Assert.IsNotNull(userAgentHeader);

            var metricsSection = userAgentHeader.Split(' ').First(part => part.StartsWith("m/")).Remove(0, 2);

            Assert.IsTrue(metricsSection.Contains(UserAgentFeatureId.PAGINATOR.Value));
        }

        [TestMethod]
        public void RunningMultipleRequestsUsingTheSameRequestObject_ShouldntDuplicateTheUserAgentDetails()
        {
            var listObjectsV2Request = new ListObjectsV2Request
            {
                BucketName = "test"
            };

            RunMockRequest(listObjectsV2Request, new AmazonS3Config(), ListObjectsV2RequestMarshaller.Instance, ListObjectsV2ResponseUnmarshaller.Instance);
            RunMockRequest(listObjectsV2Request, new AmazonS3Config(), ListObjectsV2RequestMarshaller.Instance, ListObjectsV2ResponseUnmarshaller.Instance);
            var request = RunMockRequest(listObjectsV2Request, new AmazonS3Config(), ListObjectsV2RequestMarshaller.Instance, ListObjectsV2ResponseUnmarshaller.Instance);

            request.Headers.TryGetValue(HeaderKeys.UserAgentHeader, out string userAgentHeader);
            Assert.IsNotNull(userAgentHeader);

            Assert.AreEqual(Regex.Matches(userAgentHeader, "md/ClientSync").Count, 1);
            Assert.AreEqual(Regex.Matches(userAgentHeader, "cfg/init-coll#").Count, 1);
        }

        [DataTestMethod]
        [DataRow(RequestRetryMode.Standard, "E")]
        [DataRow(RequestRetryMode.Adaptive, "F")]
        public void Test_AddsRetryModeToUserAgent(RequestRetryMode retryMode, string expectedRetryModeString)
        {
            var config = new AmazonS3Config { RetryMode = retryMode };

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "test-bucket",
                Key = "test-key",
                ContentBody = "test-content",
            };
            var request = RunMockRequest(putObjectRequest, config, new PutObjectRequestMarshaller(), new PutObjectResponseUnmarshaller());

            request.Headers.TryGetValue(HeaderKeys.UserAgentHeader, out string userAgentHeader);
            Assert.IsNotNull(userAgentHeader);

            var metricsSection = userAgentHeader.Split(' ').First(part => part.StartsWith("m/")).Remove(0, 2);
            Assert.IsTrue(metricsSection.Contains(expectedRetryModeString));
        }

        [DataTestMethod]
        [DataRow(true, "cfg/init-coll#1")]
        [DataRow(false, "cfg/init-coll#0")]
        public void Test_AddsInitializeCollectionsToUserAgent(bool initializeCollections, string expectedString)
        {
            AWSConfigs.InitializeCollections = initializeCollections;

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "test-bucket",
                Key = "test-key",
                ContentBody = "test-content",
            };

            var config = new AmazonS3Config();
            var request = RunMockRequest(putObjectRequest, config, new PutObjectRequestMarshaller(), new PutObjectResponseUnmarshaller());

            request.Headers.TryGetValue(HeaderKeys.UserAgentHeader, out string userAgentHeader);
            Assert.IsNotNull(userAgentHeader);

            var userAgentParts = userAgentHeader.Split(' ');

            Assert.IsTrue(userAgentParts.Contains(expectedString));
        }

        [TestMethod]
        public void Test_AddsCustomUserAgentAddition()
        {
            var userAgentAddition = "custom-feature/1.0";
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "test-bucket",
                Key = "test-key",
                ContentBody = "test-content",
            };

            ((IAmazonWebServiceRequest)putObjectRequest).UserAgentDetails.AddUserAgentComponent(userAgentAddition);

            var config = new AmazonS3Config();
            var request = RunMockRequest(putObjectRequest, config, new PutObjectRequestMarshaller(), new PutObjectResponseUnmarshaller());

            request.Headers.TryGetValue(HeaderKeys.UserAgentHeader, out string userAgentHeader);
            Assert.IsNotNull(userAgentHeader);

            var userAgentParts = userAgentHeader.Split(' ');

            Assert.IsTrue(userAgentParts.Contains(userAgentAddition));
        }

        [TestMethod]
        public void ObservabilityFeatureIds_NoInUserAgentByDefault()
        {
            var config = new AmazonS3Config();
            var request = RunMockRequest(new ListBucketsRequest(), config, new ListBucketsRequestMarshaller(), new ListBucketsResponseUnmarshaller());

            request.Headers.TryGetValue(HeaderKeys.UserAgentHeader, out string userAgentHeader);
            Assert.IsNotNull(userAgentHeader);
            var metricsSection = userAgentHeader.Split(' ').First(part => part.StartsWith("m/")).Remove(0, 2);

            Assert.IsFalse(metricsSection.Contains(UserAgentFeatureId.OBSERVABILITY_TRACING.Value));
            Assert.IsFalse(metricsSection.Contains(UserAgentFeatureId.OBSERVABILITY_METRICS.Value));
        }

        [TestMethod]
        public void WhenUsingCustomMeterProvider_MetricsFeatureIdAddedToUserAgent()
        {
            var config = new AmazonS3Config();

            config.TelemetryProvider.RegisterMeterProvider(new TempMeterProvider());

            var request = RunMockRequest(new ListBucketsRequest(), config, new ListBucketsRequestMarshaller(), new ListBucketsResponseUnmarshaller());

            request.Headers.TryGetValue(HeaderKeys.UserAgentHeader, out string userAgentHeader);
            Assert.IsNotNull(userAgentHeader);
            var metricsSection = userAgentHeader.Split(' ').First(part => part.StartsWith("m/")).Remove(0, 2);

            Assert.IsTrue(metricsSection.Contains(UserAgentFeatureId.OBSERVABILITY_METRICS.Value));
        }

        [TestMethod]
        public void WhenUsingCustomTracerProvider_TracingFeatureIdAddedToUserAgent()
        {
            var config = new AmazonS3Config();
            config.TelemetryProvider.RegisterTracerProvider(new TempTracerProvider());

            var request = RunMockRequest(new ListBucketsRequest(), config, new ListBucketsRequestMarshaller(), new ListBucketsResponseUnmarshaller());

            request.Headers.TryGetValue(HeaderKeys.UserAgentHeader, out string userAgentHeader);
            Assert.IsNotNull(userAgentHeader);
            var metricsSection = userAgentHeader.Split(' ').First(part => part.StartsWith("m/")).Remove(0, 2);

            Assert.IsTrue(metricsSection.Contains(UserAgentFeatureId.OBSERVABILITY_TRACING.Value));
        }

        [DataTestMethod]
        [DataRow(false, HeaderKeys.UserAgentHeader)]     // Use standard header
        [DataRow(true, HeaderKeys.XAmzUserAgentHeader)]  // Use alternate header
        public void Test_CorrectUserAgentHeaderKeyIsUsed(bool useAlternateHeader, string expectedHeaderKey)
        {
            var config = new AmazonS3Config { UseAlternateUserAgentHeader = useAlternateHeader };

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "test-bucket",
                Key = "test-key",
                ContentBody = "test-content",
            };
            var request = RunMockRequest(putObjectRequest, config, new PutObjectRequestMarshaller(), new PutObjectResponseUnmarshaller());

            // Verify the correct header key is used
            Assert.IsTrue(request.Headers.ContainsKey(expectedHeaderKey));
            Assert.IsFalse(request.Headers.ContainsKey(useAlternateHeader ? HeaderKeys.UserAgentHeader : HeaderKeys.XAmzUserAgentHeader));
        }

        [TestMethod]
        public void AddFeature_ShouldStoreFeatureId()
        {
            var userAgentDetails = new UserAgentDetails();
            userAgentDetails.AddFeature(UserAgentFeatureId.S3_TRANSFER);
            userAgentDetails.AddFeature(UserAgentFeatureId.S3_EXPRESS_BUCKET);

            var trackedFeatures = userAgentDetails.TrackedFeatureIds;
            Assert.IsTrue(trackedFeatures.Contains(UserAgentFeatureId.S3_EXPRESS_BUCKET.Value));
            Assert.IsTrue(trackedFeatures.Contains(UserAgentFeatureId.S3_TRANSFER.Value));
        }

        [TestMethod]
        public void GenerateUserAgentWithMetrics_ShouldContainStoredFeatureIds()
        {
            var userAgentDetails = new UserAgentDetails();
            userAgentDetails.AddFeature(UserAgentFeatureId.RETRY_MODE_ADAPTIVE);
            userAgentDetails.AddFeature(UserAgentFeatureId.PAGINATOR);

            string result = userAgentDetails.GenerateUserAgentWithMetrics();

            Assert.IsTrue(result.Contains(UserAgentFeatureId.RETRY_MODE_ADAPTIVE.Value));
            Assert.IsTrue(result.Contains(UserAgentFeatureId.PAGINATOR.Value));
        }

        [TestMethod]
        public void GenerateUserAgentWithMetrics_ShouldTruncateTo1KB()
        {
            var userAgentDetails = new UserAgentDetails();

            // Generate feature IDs that exceed 1024 bytes
            for (int i = 0; i < 500; i++)
            {
                userAgentDetails.AddFeature(new UserAgentFeatureId(i + "ID"));
            }
            string result = userAgentDetails.GenerateUserAgentWithMetrics();

            Assert.IsTrue(Encoding.UTF8.GetByteCount(result) <= 1024);
            Assert.IsTrue(result.EndsWith("ID")); // Ensure truncation preserves valid feature IDs and does not cut in the middle of an ID
        }

        [TestMethod]
        public void GenerateUserAgentWithMetrics_ShouldReturnEmptyWhenNoFeatures()
        {
            var userAgentDetails = new UserAgentDetails();
            string result = userAgentDetails.GenerateUserAgentWithMetrics();
            Assert.AreEqual(string.Empty, result);
        }

        private IRequest RunMockRequest(AmazonWebServiceRequest request, AmazonS3Config config,
            IMarshaller<IRequest, AmazonWebServiceRequest> marshaller,
            ResponseUnmarshaller unmarshaller)
        {
            var requestInspector = new RequestInspectorHandler();
            var factory = new HttpHandlerTests.MockHttpRequestFactory();
            var httpHandler = new HttpHandler<Stream>(factory, new object());

            RetryPolicy retryPolicy = null;
            if (config.RetryMode == RequestRetryMode.Adaptive)
                retryPolicy = new AmazonS3AdaptiveRetryPolicy(config);
            else
                retryPolicy = new AmazonS3StandardRetryPolicy(config);

            var retryHandler = new RetryHandler(retryPolicy);

            var pipeline = new RuntimePipeline(new List<IPipelineHandler>
            {
                httpHandler,
                requestInspector,
                retryHandler,
                new ChecksumHandler(),
                new AmazonS3PostMarshallHandler(),
                new AmazonS3EndpointResolver(),
                new Marshaller(),
                new AmazonS3PreMarshallHandler()
            });

            var executionContext = new ExecutionContext(
                new RequestContext(true, new NullSigner())
                {
                    ClientConfig = config,
                    Marshaller = marshaller,
                    OriginalRequest = request,
                    Request = marshaller.Marshall(request),
                    Unmarshaller = unmarshaller
                },
                new ResponseContext()
            );

            pipeline.InvokeSync(executionContext);

            return requestInspector.LastRequest;
        }

        public class RequestInspectorHandler : PipelineHandler
        {
            public IRequest LastRequest { get; private set; }

            public override void InvokeSync(IExecutionContext executionContext)
            {
                executionContext.RequestContext.Request.Endpoint = new Uri(@"http://PutObject");
                base.InvokeSync(executionContext);
                LastRequest = executionContext.RequestContext.Request;
            }
        }

        public class TempMeterProvider : MeterProvider
        {
            public override Meter GetMeter(string scope, Attributes attributes = null)
            {
                return new NoOpMeter();
            }
        }

        public class TempTracerProvider : TracerProvider
        {
            public override Tracer GetTracer(string scope)
            {
                return new NoOpTracer();
            }
        }
    }
}
