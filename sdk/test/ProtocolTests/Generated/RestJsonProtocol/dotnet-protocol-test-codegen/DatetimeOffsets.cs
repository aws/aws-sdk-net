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
using Amazon.RestJsonProtocol;
using Amazon.RestJsonProtocol.Model;
using Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AWSSDK.ProtocolTests.RestJson
{
    [TestClass]
    public class DatetimeOffsets
    {
        /// <summary>
        /// Ensures that clients can correctly parse datetime (timestamps)
        /// with offsets
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonDateTimeWithNegativeOffsetResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            byte[] bytes = Encoding.ASCII.GetBytes("      {\n          \"datetime\": \"2019-12-16T22:48:18-01:00\"\n      }\n");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new DatetimeOffsetsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new DatetimeOffsetsResponse
            {
                Datetime = ProtocolTestConstants.epoch.AddSeconds(1576540098),
            };

            // Assert
            var actualResponse = (DatetimeOffsetsResponse)unmarshalledResponse;
            Comparer.CompareObjects<DatetimeOffsetsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that clients can correctly parse datetime (timestamps)
        /// with offsets
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonDateTimeWithPositiveOffsetResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            byte[] bytes = Encoding.ASCII.GetBytes("      {\n          \"datetime\": \"2019-12-17T00:48:18+01:00\"\n      }\n");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new DatetimeOffsetsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new DatetimeOffsetsResponse
            {
                Datetime = ProtocolTestConstants.epoch.AddSeconds(1576540098),
            };

            // Assert
            var actualResponse = (DatetimeOffsetsResponse)unmarshalledResponse;
            Comparer.CompareObjects<DatetimeOffsetsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
