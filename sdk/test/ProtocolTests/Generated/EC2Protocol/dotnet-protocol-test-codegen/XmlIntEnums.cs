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

namespace AWSSDK.ProtocolTests.AwsEc2
{
    [TestClass]
    public class XmlIntEnums
    {
        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public void Ec2XmlIntEnumsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlIntEnumsResponse xmlns=\"https://example.com/\">\n    <intEnum1>1</intEnum1>\n    <intEnum2>2</intEnum2>\n    <intEnum3>3</intEnum3>\n    <intEnumList>\n        <member>1</member>\n        <member>2</member>\n    </intEnumList>\n    <intEnumSet>\n        <member>1</member>\n        <member>2</member>\n    </intEnumSet>\n    <intEnumMap>\n        <entry>\n            <key>a</key>\n            <value>1</value>\n        </entry>\n        <entry>\n            <key>b</key>\n            <value>2</value>\n        </entry>\n    </intEnumMap>\n    <requestId>requestid</requestId>\n</XmlIntEnumsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlIntEnumsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlIntEnumsResponse
            {
                IntEnum1 = 1,
                IntEnum2 = 2,
                IntEnum3 = 3,
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumSet =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumMap = new Dictionary<string, int>()
                {

                    { "a", 1 },
                    { "b", 2 },
                },
            };

            // Assert
            var actualResponse = (XmlIntEnumsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlIntEnumsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
