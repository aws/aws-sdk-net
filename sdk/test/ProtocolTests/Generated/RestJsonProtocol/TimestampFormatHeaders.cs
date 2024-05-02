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
    public class TimestampFormatHeaders
    {
        /// <summary>
        /// Tests how timestamp request headers are serialized
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonTimestampFormatHeadersRequest()
        {
            // Arrange
            var request = new TimestampFormatHeadersRequest
            {
                MemberEpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                MemberHttpDate = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                MemberDateTime = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                DefaultFormat = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                TargetEpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                TargetHttpDate = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                TargetDateTime = ProtocolTestConstants.epoch.AddSeconds(1576540098),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new TimestampFormatHeadersRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/TimestampFormatHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("Mon, 16 Dec 2019 23:48:18 GMT".Replace(" ",""), marshalledRequest.Headers["X-defaultFormat"].Replace(" ",""));
            Assert.AreEqual("2019-12-16T23:48:18Z".Replace(" ",""), marshalledRequest.Headers["X-memberDateTime"].Replace(" ",""));
            Assert.AreEqual("1576540098".Replace(" ",""), marshalledRequest.Headers["X-memberEpochSeconds"].Replace(" ",""));
            Assert.AreEqual("Mon, 16 Dec 2019 23:48:18 GMT".Replace(" ",""), marshalledRequest.Headers["X-memberHttpDate"].Replace(" ",""));
            Assert.AreEqual("2019-12-16T23:48:18Z".Replace(" ",""), marshalledRequest.Headers["X-targetDateTime"].Replace(" ",""));
            Assert.AreEqual("1576540098".Replace(" ",""), marshalledRequest.Headers["X-targetEpochSeconds"].Replace(" ",""));
            Assert.AreEqual("Mon, 16 Dec 2019 23:48:18 GMT".Replace(" ",""), marshalledRequest.Headers["X-targetHttpDate"].Replace(" ",""));
        }

        /// <summary>
        /// Tests how timestamp response headers are serialized
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonTimestampFormatHeadersResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["X-defaultFormat"] = "Mon, 16 Dec 2019 23:48:18 GMT";
            webResponseData.Headers["X-memberDateTime"] = "2019-12-16T23:48:18Z";
            webResponseData.Headers["X-memberEpochSeconds"] = "1576540098";
            webResponseData.Headers["X-memberHttpDate"] = "Mon, 16 Dec 2019 23:48:18 GMT";
            webResponseData.Headers["X-targetDateTime"] = "2019-12-16T23:48:18Z";
            webResponseData.Headers["X-targetEpochSeconds"] = "1576540098";
            webResponseData.Headers["X-targetHttpDate"] = "Mon, 16 Dec 2019 23:48:18 GMT";
            byte[] bytes = Encoding.ASCII.GetBytes("");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new TimestampFormatHeadersResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new TimestampFormatHeadersResponse
            {
                MemberEpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                MemberHttpDate = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                MemberDateTime = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                DefaultFormat = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                TargetEpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                TargetHttpDate = ProtocolTestConstants.epoch.AddSeconds(1576540098),
                TargetDateTime = ProtocolTestConstants.epoch.AddSeconds(1576540098),
            };

            // Assert
            var actualResponse = (TimestampFormatHeadersResponse)unmarshalledResponse;
            Comparer.CompareObjects<TimestampFormatHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
