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
    public class RecursiveXmlShapes
    {
        /// <summary>
        /// Serializes recursive structures
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public void QueryRecursiveShapesResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<RecursiveXmlShapesResponse xmlns=\"https://example.com/\">\n    <RecursiveXmlShapesResult>\n        <nested>\n            <foo>Foo1</foo>\n            <nested>\n                <bar>Bar1</bar>\n                <recursiveMember>\n                    <foo>Foo2</foo>\n                    <nested>\n                        <bar>Bar2</bar>\n                    </nested>\n                </recursiveMember>\n            </nested>\n        </nested>\n    </RecursiveXmlShapesResult>\n</RecursiveXmlShapesResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new RecursiveXmlShapesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new RecursiveXmlShapesResponse
            {
                Nested = new RecursiveXmlShapesOutputNested1
                {
                    Foo = "Foo1",
                    Nested = new RecursiveXmlShapesOutputNested2
                    {
                        Bar = "Bar1",
                        RecursiveMember = new RecursiveXmlShapesOutputNested1
                        {
                            Foo = "Foo2",
                            Nested = new RecursiveXmlShapesOutputNested2
                            {
                                Bar = "Bar2",
                            },
                        },
                    },
                },
            };

            // Assert
            var actualResponse = (RecursiveXmlShapesResponse)unmarshalledResponse;
            Comparer.CompareObjects<RecursiveXmlShapesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
