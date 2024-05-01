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
using Amazon.RestXmlProtocol;
using Amazon.RestXmlProtocol.Model;
using Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.RestXml
{
    [TestClass]
    public class HttpRequestWithLabels
    {
        /// <summary>
        /// Sends a GET request that uses URI label bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void InputWithHeadersAndAllParamsRequest()
        {
            // Arrange
            var request = new HttpRequestWithLabelsRequest
            {
                String = "string",
                Short = 1,
                Integer = 2,
                Long = 3,
                Float = 4.1F,
                Double = 5.1,
                Boolean = true,
                Timestamp = ProtocolTestConstants.epoch.AddSeconds(1576540098),
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new HttpRequestWithLabelsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/HttpRequestWithLabels/string/1/2/3/4.1/5.1/true/2019-12-16T23%3A48%3A18Z", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
        }

        /// <summary>
        /// Sends a GET request that uses URI label bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void HttpRequestLabelEscapingRequest()
        {
            // Arrange
            var request = new HttpRequestWithLabelsRequest
            {
                String = " %:/?#[]@!$&'()*+,;=😹",
                Short = 1,
                Integer = 2,
                Long = 3,
                Float = 4.1F,
                Double = 5.1,
                Boolean = true,
                Timestamp = ProtocolTestConstants.epoch.AddSeconds(1576540098),
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new HttpRequestWithLabelsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/HttpRequestWithLabels/%20%25%3A%2F%3F%23%5B%5D%40%21%24%26%27%28%29%2A%2B%2C%3B%3D%F0%9F%98%B9/1/2/3/4.1/5.1/true/2019-12-16T23%3A48%3A18Z", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
        }

    }
}
