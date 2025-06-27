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
using AWSSDK.Extensions.CborProtocol.Internal;
using AWSSDK.ProtocolTests;
using AWSSDK.ProtocolTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon.RpcV2Protocol;
using Amazon.RpcV2Protocol.Model;
using Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWSSDK.ProtocolTests.RpcV2Protocol
{
    [TestClass]
    public class RpcV2CborLists
    {
        /// <summary>
        /// Serializes RpcV2 Cbor lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborListsRequest()
        {
            // Arrange
            var request = new RpcV2CborListsRequest
            {
                StringList =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                StringSet =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                IntegerList =  new List<int>()
                {
                    1,
                    2,
                },
                BooleanList =  new List<bool>()
                {
                    true,
                    false,
                },
                TimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                },
                EnumList =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                NestedStringList =  new List<List<string>>()
                {
                     new List<string>()
                    {
                        "foo",
                        "bar",
                    },
                     new List<string>()
                    {
                        "baz",
                        "qux",
                    },
                },
                StructureList =  new List<StructureListMember>()
                {
                    new StructureListMember
                    {
                        A = "1",
                        B = "2",
                    },
                    new StructureListMember
                    {
                        A = "3",
                        B = "4",
                    },
                },
                BlobList =  new List<MemoryStream>()
                {
                    new MemoryStream(Encoding.UTF8.GetBytes("foo")),
                    new MemoryStream(Encoding.UTF8.GetBytes("bar")),
                },
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborListsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v2pzdHJpbmdMaXN0gmNmb29jYmFyaXN0cmluZ1NldIJjZm9vY2JhcmtpbnRlZ2VyTGlzdIIBAmtib29sZWFuTGlzdIL19G10aW1lc3RhbXBMaXN0gsH7QdTX+/OAAADB+0HU1/vzgAAAaGVudW1MaXN0gmNGb29hMGtpbnRFbnVtTGlzdIIBAnBuZXN0ZWRTdHJpbmdMaXN0goJjZm9vY2JhcoJjYmF6Y3F1eG1zdHJ1Y3R1cmVMaXN0gqJhYWExYWJhMqJhYWEzYWJhNGhibG9iTGlzdIJDZm9vQ2Jhcv8=";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborLists", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes empty JSON lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborListsEmptyRequest()
        {
            // Arrange
            var request = new RpcV2CborListsRequest
            {
                StringList =  new List<string>()
                {
                },
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborListsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "v2pzdHJpbmdMaXN0n///";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborLists", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes empty JSON definite length lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2Protocol")]
        public void RpcV2CborListsEmptyUsingDefiniteLengthRequest()
        {
            // Arrange
            var request = new RpcV2CborListsRequest
            {
                StringList =  new List<string>()
                {
                },
            };
            var config = new AmazonRpcV2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new RpcV2CborListsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "oWpzdHJpbmdMaXN0gA==";
            CborProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/service/RpcV2Protocol/operation/RpcV2CborLists", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), marshalledRequest.Headers["smithy-protocol"].Replace(" ",""));
        }

    }
}
