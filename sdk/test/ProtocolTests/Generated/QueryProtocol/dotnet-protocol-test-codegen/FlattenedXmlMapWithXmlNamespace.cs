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
using Amazon.QueryProtocol;
using Amazon.QueryProtocol.Model;
using Amazon.QueryProtocol.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.AwsQuery
{
    [TestClass]
    public class FlattenedXmlMapWithXmlNamespace
    {
        /// <summary>
        /// Serializes flattened XML maps in responses that have xmlNamespace
        /// and xmlName on members
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public void QueryQueryFlattenedXmlMapWithXmlNamespaceResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<FlattenedXmlMapWithXmlNamespaceResponse xmlns=\"https://example.com/\">\n    <FlattenedXmlMapWithXmlNamespaceResult>\n        <KVP xmlns=\"https://the-member.example.com\">\n            <K xmlns=\"https://the-key.example.com\">a</K>\n            <V xmlns=\"https://the-value.example.com\">A</V>\n        </KVP>\n        <KVP xmlns=\"https://the-member.example.com\">\n            <K xmlns=\"https://the-key.example.com\">b</K>\n            <V xmlns=\"https://the-value.example.com\">B</V>\n        </KVP>\n    </FlattenedXmlMapWithXmlNamespaceResult>\n</FlattenedXmlMapWithXmlNamespaceResponse>");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new FlattenedXmlMapWithXmlNamespaceResponse
            {
                MyMap = new Dictionary<string, string>()
                {

                    { "a", "A" },
                    { "b", "B" },
                },
            };

            // Assert
            var actualResponse = (FlattenedXmlMapWithXmlNamespaceResponse)unmarshalledResponse;
            Comparer.CompareObjects<FlattenedXmlMapWithXmlNamespaceResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
