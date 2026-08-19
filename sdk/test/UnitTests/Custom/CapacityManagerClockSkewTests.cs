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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using AWSSDK.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Reflection;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class CapacityManagerClockSkewTests
    {    
        private const int MAX_RETRIES = 2;

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ClockSkewRetriesConsumeRetryCapacity()
        {
            var config = new AmazonS3Config
            {
                ServiceURL = @"https://s3-clockskew-capacity-test.amazonaws.com",
                MaxErrorRetry = MAX_RETRIES
            };

            var retryPolicy = new DefaultRetryPolicy(config);
            var retryHandler = new RetryHandler(retryPolicy);
            var tester = new MockActionHandler();
            var pipeline = new RuntimePipeline(tester);
            pipeline.AddHandler(retryHandler);

            var info = typeof(DefaultRetryPolicy).GetField("_capacityManagerInstance", BindingFlags.NonPublic | BindingFlags.Static);
            var capacityManager = (CapacityManager)info.GetValue(null);
            var availableCapacityBefore = capacityManager.GetRetryCapacity(config.ServiceURL).AvailableCapacity;

            tester.Reset();
            tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException("clock skew", ErrorType.Sender,
                    "RequestTimeTooSkewed", "Test123", HttpStatusCode.Forbidden);
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext(config);
                // Clock Skew Correction specification: skew is recorded in the HttpHandler; this
                // RetryHandler-only pipeline has none, so seed the > 4-minute candidate the retry gate
                // reads so the clock skew error is retried.
                request.RequestContext.ContextAttributes[ClockSkewPipelineHelper.AttemptSkewCandidateKey] =
                    TimeSpan.FromMinutes(-7);
                pipeline.InvokeSync(request);
            },
            typeof(AmazonServiceException));

            // The clock skew error is retried until max attempts...
            Assert.AreEqual(MAX_RETRIES + 1, tester.CallCount);

            // ...and each retry now consumes retry capacity (the specification removed the clock-skew
            // capacity bypass), so available capacity has decreased from before the request.
            var availableCapacityAfter = capacityManager.GetRetryCapacity(config.ServiceURL).AvailableCapacity;
            Assert.IsTrue(availableCapacityAfter < availableCapacityBefore,
                $"Expected capacity to decrease. Before={availableCapacityBefore}, After={availableCapacityAfter}");
        }

        private static IExecutionContext CreateTestContext(ClientConfig config)
        {
            var putObjectRequest = new PutObjectRequest
            {
                Key = "TestKey",
                BucketName = "TestBucket",
                ContentBody = "Test Content"
            };

            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = putObjectRequest,
                Request = new PutObjectRequestMarshaller().Marshall(putObjectRequest),
                Unmarshaller = PutObjectResponseUnmarshaller.Instance,
                ClientConfig = config
            };

            var serviceMetaData = Assembly.GetAssembly(requestContext.GetType()).CreateInstance("Amazon.Runtime.Internal.ServiceMetadata");
            requestContext.GetType().GetProperty("ServiceMetaData").SetValue(requestContext, serviceMetaData);
            requestContext.Request.Endpoint = new Uri(config.ServiceURL);

#if NETFRAMEWORK
            var putObjectResponse = MockWebResponse.CreateFromResource("PutObjectResponse.txt")
                as HttpWebResponse;
            return new Amazon.Runtime.Internal.ExecutionContext(requestContext,
                new ResponseContext
                {
                    HttpResponse = new HttpWebRequestResponseData(putObjectResponse)
                });
#else
            var putObjectResponse = MockWebResponse.CreateFromResource("PutObjectResponse.txt")
                as System.Net.Http.HttpResponseMessage;
            return new Amazon.Runtime.Internal.ExecutionContext(requestContext,
                new ResponseContext
                {
                    HttpResponse = new HttpClientResponseData(putObjectResponse)
                });
#endif
        }
    }
}
