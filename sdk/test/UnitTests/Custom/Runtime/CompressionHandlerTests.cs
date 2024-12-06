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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.CloudWatch;
using Amazon.Runtime.Internal.Auth;
using Amazon.Util;
using Amazon.Runtime;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using System.Reflection;

namespace AWSSDK.UnitTests
{                                           
    [TestClass]
    public class CompressionHandlerTests
    {
#if BCL 
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataRow(null, null, CompressionEncodingAlgorithm.gzip, true)]
        [DataRow(true, 0L, CompressionEncodingAlgorithm.gzip, true)]
        [DataRow(false, 10000L, CompressionEncodingAlgorithm.gzip, true)]
        [DataRow(false, 0L, CompressionEncodingAlgorithm.NONE, true)]
        [DataRow(false, 0L, CompressionEncodingAlgorithm.gzip, false)]
        [DataTestMethod]
        public async Task TestCompressionCall(bool? disableCompression, long? minCompressionSize, CompressionEncodingAlgorithm encodingEnum, bool notCompressed)
        {
            var handler = new CompressionHandler();
            var mockHandler = new MockActionHandler();
            handler.InnerHandler = mockHandler;

            var executionContext = CreateTestContext(false);
            var request = executionContext.RequestContext.Request;
            var originalInput = AWSSDKUtils.GetRequestPayloadBytes(request);

            var clientConfig = executionContext.RequestContext.ClientConfig as AmazonCloudWatchConfig;
            Assert.IsTrue(clientConfig.RequestMinCompressionSizeBytes == 10240);

            request.CompressionAlgorithm = encodingEnum;

            if (disableCompression != null)
            {
                clientConfig.DisableRequestCompression = (bool) disableCompression;
            }

            if (minCompressionSize != null)
            {
                clientConfig.RequestMinCompressionSizeBytes = (long) minCompressionSize;
            }
            
            await handler.InvokeAsync<AmazonWebServiceResponse>(executionContext);
            
            var newInput = AWSSDKUtils.GetRequestPayloadBytes(request);

            Assert.IsNull(request.ContentStream);

            if (notCompressed)
            {
                Assert.IsNull(request.Content);
                CollectionAssert.AreEqual(originalInput, newInput);
            }
            else
            {
                Assert.IsNotNull(request.Content);
                CollectionAssert.AreNotEqual(originalInput, newInput);
            }
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataRow(null, null, CompressionEncodingAlgorithm.gzip, false)]
        [DataRow(true, 0L, CompressionEncodingAlgorithm.gzip, true)]
        [DataRow(false, 100000L, CompressionEncodingAlgorithm.gzip, false)]
        [DataRow(false, 0L, CompressionEncodingAlgorithm.NONE, true)]
        [DataRow(false, 0L, CompressionEncodingAlgorithm.gzip, false)]
        [DataTestMethod]
        public async Task TestStreamCompressionCall(bool? disableCompression, long? minCompressionSize, CompressionEncodingAlgorithm encodingEnum, bool notCompressed)
        {
            var handler = new CompressionHandler();
            var mockHandler = new MockActionHandler();
            handler.InnerHandler = mockHandler;

            var executionContext = CreateTestContext(true);
            var request = executionContext.RequestContext.Request;
            var originalInputLen = request.ContentStream.Length;

            var clientConfig = executionContext.RequestContext.ClientConfig as AmazonCloudWatchConfig;

            Assert.IsTrue(clientConfig.RequestMinCompressionSizeBytes == 10240);

            request.CompressionAlgorithm = encodingEnum;

            if (disableCompression != null)
            {
                clientConfig.DisableRequestCompression = (bool)disableCompression;
            }
            if (minCompressionSize != null)
            {
                clientConfig.RequestMinCompressionSizeBytes = (long)minCompressionSize;
            }

            await handler.InvokeAsync<AmazonWebServiceResponse>(executionContext);

            Assert.IsNull(request.Content);
            Assert.IsNotNull(request.ContentStream);
            Assert.AreEqual(originalInputLen, request.ContentStream.Length);

            if (notCompressed)
            {
                Assert.IsInstanceOfType(request.ContentStream, typeof(MemoryStream));
            }
            else
            {
                Assert.IsInstanceOfType(request.ContentStream, typeof(CompressionWrapperStream));
            }
        }
#endif

        private ExecutionContext CreateTestContext(bool isStreaming)
        {
            var random = new Random();

            var putMetricDataRequest = new PutMetricDataRequest()
            {
                Namespace = "compression-test",
                MetricData = new List<MetricDatum>()
                {
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow, Unit = StandardUnit.Count, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(2), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(4), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(6), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(8), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(10), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                }
            };

            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = putMetricDataRequest,
                Request = new PutMetricDataRequestMarshaller().Marshall(putMetricDataRequest),
                ClientConfig = new AmazonCloudWatchConfig(),
            };

            // Create and set the internal ServiceMetadata via reflection
            var serviceMetaData = Assembly.GetAssembly(requestContext.GetType()).CreateInstance("Amazon.Runtime.Internal.ServiceMetadata");
            requestContext.GetType().GetProperty("ServiceMetaData").SetValue(requestContext, serviceMetaData);

            var request = requestContext.Request;
            if (isStreaming)
            {
                request.ContentStream = new MemoryStream(AWSSDKUtils.GetRequestPayloadBytes(request));
            }

            return new ExecutionContext(requestContext, null);
        }
    }
}