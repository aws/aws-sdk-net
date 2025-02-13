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
    public class FlattenedXmlMapWithXmlName
    {
        /// <summary>
        /// Serializes flattened XML maps in responses that have xmlName on
        /// members
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public void QueryQueryFlattenedXmlMapWithXmlNameResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<FlattenedXmlMapWithXmlNameResponse xmlns=\"https://example.com/\">\n    <FlattenedXmlMapWithXmlNameResult>\n        <KVP>\n            <K>a</K>\n            <V>A</V>\n        </KVP>\n        <KVP>\n            <K>b</K>\n            <V>B</V>\n        </KVP>\n    </FlattenedXmlMapWithXmlNameResult>\n</FlattenedXmlMapWithXmlNameResponse>");
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
