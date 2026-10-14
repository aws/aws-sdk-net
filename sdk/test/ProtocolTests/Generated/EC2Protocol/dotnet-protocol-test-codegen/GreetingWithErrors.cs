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

/*
 * Do not modify this file. This file is generated.
 */
using AWSSDK.ProtocolTests;
using AWSSDK.ProtocolTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon.EC2Protocol;
using Amazon.EC2Protocol.Model;
using Amazon.EC2Protocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.AwsEc2
{
    [TestClass]
    public class GreetingWithErrors
    {
        /// <summary>
        /// Ensures that operations with errors successfully know how to
        /// deserialize the successful response
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public async Task Ec2GreetingWithErrorsResponse()
        {
            // Arrange
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonEC2ProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<GreetingWithErrorsResponse xmlns=\"https://example.com/\">\n    <greeting>Hello</greeting>\n    <requestId>requestid</requestId>\n</GreetingWithErrorsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest()).ConfigureAwait(false);
            var expectedResponse = new GreetingWithErrorsResponse
            {
                Greeting = "Hello",
            };

            // Assert
            Comparer.CompareObjects<GreetingWithErrorsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses simple XML errors
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("AwsEc2")]
        public async Task Ec2InvalidGreetingErrorErrorResponse()
        {
            // Arrange
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonEC2ProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400),
                Body = Encoding.ASCII.GetBytes("<Response>\n    <Errors>\n        <Error>\n            <Code>InvalidGreeting</Code>\n            <Message>Hi</Message>\n        </Error>\n    </Errors>\n    <RequestID>foo-id</RequestID>\n</Response>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<InvalidGreetingException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400), errorResponse.StatusCode);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("AwsEc2")]
        public async Task Ec2ComplexErrorErrorResponse()
        {
            // Arrange
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonEC2ProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400),
                Body = Encoding.ASCII.GetBytes("<Response>\n    <Errors>\n        <Error>\n            <Code>ComplexError</Code>\n            <Message>Hi</Message>\n            <TopLevel>Top level</TopLevel>\n            <Nested>\n                <Foo>bar</Foo>\n            </Nested>\n        </Error>\n    </Errors>\n    <RequestID>foo-id</RequestID>\n</Response>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<ComplexErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400), errorResponse.StatusCode);
        }

    }
}
