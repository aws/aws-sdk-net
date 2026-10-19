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
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.AwsEc2
{
    [TestClass]
    public class EndpointWithHostLabelOperation
    {
        /// <summary>
        /// Operations can prepend to the given host if they define the
        /// endpoint trait, and can use the host label trait to define
        /// further customization based on user input.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public async Task Ec2QueryEndpointTraitWithHostLabelRequest()
        {
            // Arrange
            var request = new EndpointWithHostLabelOperationRequest
            {
                Label = "bar",
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://example.com/",
              MaxErrorRetry = 0,
            };

            using var client = new AmazonEC2ProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            await client.EndpointWithHostLabelOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "Action=EndpointWithHostLabelOperation&Version=2020-01-08&Label=bar";
            QueryTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("foo.bar.example.com", actualRequest.RequestUri.Host);
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8", actualRequest.Headers["Content-Type"]);
        }

    }
}
