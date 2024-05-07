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
using AWSSDK_DotNet35.UnitTests.TestTools;
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

namespace AWSSDK.ProtocolTests.AwsEc2
{
    [TestClass]
    public class HostWithPathOperation
    {
        /// <summary>
        /// Custom endpoints supplied by users can have paths
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2QueryHostWithPathRequest()
        {
            // Arrange
            var request = new HostWithPathOperationRequest
            {
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://example.com/custom"
            };

            var marshaller = new HostWithPathOperationRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=HostWithPathOperation&Version=2020-01-08");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/custom/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
        }

    }
}
