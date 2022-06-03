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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using AWSSDK.UnitTests.Mocking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RecursionDetectionTests
    {
        public static IRequest RunMockRequest(string lambdaFunctionName, string traceId, IDictionary<string, string> requestHeaders)
        {
            var savedLambdaFunctionName = Environment.GetEnvironmentVariable(EnvironmentVariables.AWS_LAMBDA_FUNCTION_NAME);
            var savedTraceId = Environment.GetEnvironmentVariable(EnvironmentVariables._X_AMZN_TRACE_ID);
            try
            {
                Environment.SetEnvironmentVariable(EnvironmentVariables.AWS_LAMBDA_FUNCTION_NAME, lambdaFunctionName);
                Environment.SetEnvironmentVariable(EnvironmentVariables._X_AMZN_TRACE_ID, traceId);

                var config = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USWest2,
                };

                var request = new PutObjectRequest
                {
                    BucketName = "test",
                    Key = "test"
                };

                foreach (var header in requestHeaders)
                {
                    request.Headers[header.Key] = header.Value;
                }

                return TestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance, null, config, new AWS4Signer());
            }
            finally
            {
                Environment.SetEnvironmentVariable(EnvironmentVariables.AWS_LAMBDA_FUNCTION_NAME, savedLambdaFunctionName);
                Environment.SetEnvironmentVariable(EnvironmentVariables._X_AMZN_TRACE_ID, savedTraceId);
            }
        }

        public void ValidateHeaders(IDictionary<string, string> requestHeaders, IDictionary<string, string> expectedHeaders)
        {
            foreach(var header in expectedHeaders)
            {
                Assert.IsTrue(requestHeaders.ContainsKey(header.Key));
                Assert.AreEqual(requestHeaders[header.Key], header.Value);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void WhenFunctionNameAndTraceIdAreNotSet_NoTraceIdHeaderSent()
        {
            var requestHeaders = new Dictionary<string, string>();
            var internalRequest = RunMockRequest(null, null, requestHeaders);

            var expectedHeaders = new Dictionary<string, string>();
            ValidateHeaders(internalRequest.Headers, expectedHeaders);            
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void WhenFunctionNameIsSetAndTraceIdIsSet_TraceIdHeaderSent()
        {
            var requestHeaders = new Dictionary<string, string>();
            var internalRequest = RunMockRequest("some-function", 
                    "Root=1-5759e988-bd862e3fe1be46a994272793;Parent=53995c3f42cd8ad8;Sampled=1;lineage=a87bd80c:0,68fd508a:5,c512fbe3:2", 
                    requestHeaders);

            var expectedHeaders = new Dictionary<string, string>();
            expectedHeaders.Add(HeaderKeys.XAmznTraceIdHeader, 
                "Root=1-5759e988-bd862e3fe1be46a994272793;Parent=53995c3f42cd8ad8;Sampled=1;lineage=a87bd80c:0,68fd508a:5,c512fbe3:2");
            ValidateHeaders(internalRequest.Headers, expectedHeaders);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void WhenFunctionNameIsNotSetAndTraceIdIsSet_TraceIdHeaderMustNotBeSent()
        {
            var requestHeaders = new Dictionary<string, string>();
            var internalRequest = RunMockRequest(null,
                    "Root=1-5759e988-bd862e3fe1be46a994272793;Parent=53995c3f42cd8ad8;Sampled=1;lineage=a87bd80c:0,68fd508a:5,c512fbe3:2",
                    requestHeaders);

            var expectedHeaders = new Dictionary<string, string>();            
            ValidateHeaders(internalRequest.Headers, expectedHeaders);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void WhenFunctionNameIsSetAndTraceIdIsSet_TraceIdHeaderKeepsValue()
        {
            var requestHeaders = new Dictionary<string, string>();
            requestHeaders.Add(HeaderKeys.XAmznTraceIdHeader,
                "OriginalValue");
            var internalRequest = RunMockRequest("some-function",
                    "EnvValue",
                    requestHeaders);

            var expectedHeaders = new Dictionary<string, string>();
            expectedHeaders.Add(HeaderKeys.XAmznTraceIdHeader,
                "OriginalValue");
            ValidateHeaders(internalRequest.Headers, expectedHeaders);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void WhenFunctionNameIsSetAndTraceIdHasControlCharacters_TraceIdHeaderMustBeEncoded()
        {
            var requestHeaders = new Dictionary<string, string>();            
            var internalRequest = RunMockRequest("some-function",
                    "first\nsecond",
                    requestHeaders);

            var expectedHeaders = new Dictionary<string, string>();
            expectedHeaders.Add(HeaderKeys.XAmznTraceIdHeader,
                "first%0Asecond");
            ValidateHeaders(internalRequest.Headers, expectedHeaders);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void WhenFunctionNameIsSetAndTraceIdHasNonAlphaNumericCharacters_TraceIdHeaderIsNotEncoded()
        {
            var requestHeaders = new Dictionary<string, string>();
            var internalRequest = RunMockRequest("some-function",
                    "test123-=;:+&[]{}\"'",
                    requestHeaders);

            var expectedHeaders = new Dictionary<string, string>();
            expectedHeaders.Add(HeaderKeys.XAmznTraceIdHeader,
                "test123-=;:+&[]{}\"'");
            ValidateHeaders(internalRequest.Headers, expectedHeaders);
        }
    }
}
