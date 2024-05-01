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
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.RestXml
{
    [TestClass]
    public class NoInputAndNoOutput
    {
        /// <summary>
        /// No input serializes no payload
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void NoInputAndNoOutputRequest()
        {
            // Arrange
            var request = new NoInputAndNoOutputRequest
            {
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new NoInputAndNoOutputRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/NoInputAndNoOutput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
        }

        /// <summary>
        /// No output serializes no payload
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void NoInputAndNoOutputResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new NoInputAndNoOutputResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new NoInputAndNoOutputResponse
            {
            };

            // Assert
            var actualResponse = (NoInputAndNoOutputResponse)unmarshalledResponse;
            Comparer.CompareObjects<NoInputAndNoOutputResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
