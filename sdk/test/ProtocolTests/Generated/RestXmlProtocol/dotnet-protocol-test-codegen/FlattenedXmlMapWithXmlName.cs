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
    public class FlattenedXmlMapWithXmlName
    {
        /// <summary>
        /// Serializes flattened XML maps in requests that have xmlName on
        /// members
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void FlattenedXmlMapWithXmlNameRequest()
        {
            // Arrange
            var request = new FlattenedXmlMapWithXmlNameRequest
            {
                MyMap = new Dictionary<string, string>()
                {

                    { "a", "A" },
                    { "b", "B" },
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new FlattenedXmlMapWithXmlNameRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "<FlattenedXmlMapWithXmlNameRequest>\n    <KVP>\n        <K>a</K>\n        <V>A</V>\n    </KVP>\n    <KVP>\n        <K>b</K>\n        <V>B</V>\n    </KVP>\n</FlattenedXmlMapWithXmlNameRequest>";
            XmlTestUtils.AssertBody(marshalledRequest,expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/FlattenedXmlMapWithXmlName", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/xml".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes flattened XML maps in responses that have xmlName on
        /// members
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void FlattenedXmlMapWithXmlNameResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<FlattenedXmlMapWithXmlNameResponse>\n    <KVP>\n        <K>a</K>\n        <V>A</V>\n    </KVP>\n    <KVP>\n        <K>b</K>\n        <V>B</V>\n    </KVP>\n</FlattenedXmlMapWithXmlNameResponse>");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new FlattenedXmlMapWithXmlNameResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new FlattenedXmlMapWithXmlNameResponse
            {
                MyMap = new Dictionary<string, string>()
                {

                    { "a", "A" },
                    { "b", "B" },
                },
            };

            // Assert
            var actualResponse = (FlattenedXmlMapWithXmlNameResponse)unmarshalledResponse;
            Comparer.CompareObjects<FlattenedXmlMapWithXmlNameResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
