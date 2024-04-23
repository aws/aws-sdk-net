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
    public class NoInputAndNoOutput
    {
        /// <summary>
        /// No input serializes no additional query params
        /// </summary>
        /*
        * This test either requires a breaking change and will be addressed
        * in V4, or has a backlog item to be fixed in the future. Please
        * refer to the VNextTests list to see which it is.
        * */
        [Ignore]
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsQuery")]
        public void QueryNoInputAndNoOutputRequest()
        {
            // Arrange
            var request = new NoInputAndNoOutputRequest
            {
            };
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new NoInputAndNoOutputRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=NoInputAndNoOutput&Version=2020-01-08");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Empty output. Note that no assertion is made on the output body
        /// itself.
        /// </summary>
        // This test requires a breaking change, and will be addressed in V4
        [Ignore]
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public void QueryNoInputAndNoOutputResponse()
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
