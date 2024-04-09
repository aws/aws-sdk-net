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
using System.Text;

namespace AWSSDK.ProtocolTests.RestJson
{
    [TestClass]
    public class TestPayloadBlob
    {
        /// <summary>
        /// Serializes a payload targeting an empty blob
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonHttpWithEmptyBlobPayloadRequest()
        {
            // Arrange
            var request = new TestPayloadBlobRequest
            {
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new TestPayloadBlobRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/blob_payload", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/octet-stream".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a payload targeting a blob
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonTestPayloadBlobRequest()
        {
            // Arrange
            var request = new TestPayloadBlobRequest
            {
                ContentType = "image/jpg",
                Data = new MemoryStream(Encoding.UTF8.GetBytes("1234")),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new TestPayloadBlobRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "1234";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/blob_payload", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("image/jpg".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

    }
}
