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
using Amazon.S3;
using Amazon.Util;
using AWSSDK.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Reflection;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class CapacityManagerClockSkewTests : RuntimePipelineTestBase<RetryHandler>
    {    
        private const int THROTTLED_RETRIES = 4;        
        private const int MAX_RETRIES = 2;

        private static ClientConfig config;        

        [ClassInitialize]
        public static void Initialize(TestContext t)
        {
            config = new AmazonS3Config
            {
                ServiceURL = @"https://s3.amazonaws.com",
                MaxErrorRetry = 2
            };
                                    
            //Setup pipeline
            Handler = new RetryHandler(new DefaultRetryPolicy(config));
            RuntimePipeline.AddHandler(Handler);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestCapacityUsedForClockSkew()
        {        
            var info = typeof(DefaultRetryPolicy).GetField("_capacityManagerInstance", BindingFlags.NonPublic | BindingFlags.Static);
            var capacityManager = (CapacityManager)info.GetValue(null);
            var availableCapacity = capacityManager.GetRetryCapacity(config.ServiceURL).AvailableCapacity;

            //Loop that will typically reduce capacity
            for (var i = 0; i < THROTTLED_RETRIES / 2; i++)
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    //Throw a clock skew error
                    throw new AmazonServiceException(string.Format("Failed message ({0} + )", DateTime.UtcNow.AddDays(callCount).ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat)),
                        ErrorType.Sender, "RequestTimeTooSkewed", "Test123", HttpStatusCode.BadRequest);
                };

                Utils.AssertExceptionExpected(() =>
                {
                    var request = CreateTestContext();
                    RuntimePipeline.InvokeSync(request);
                },
                typeof(AmazonServiceException));
                Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
            }

            //Verify that the clock skew errors did not decrease any capacity
            Assert.AreEqual(availableCapacity, capacityManager.GetRetryCapacity(config.ServiceURL).AvailableCapacity);
        }
    }
}
