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
    public class SparseJsonMaps
    {
        /// <summary>
        /// Serializes JSON maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonSparseJsonMapsRequest()
        {
            // Arrange
            var request = new SparseJsonMapsRequest
            {
                SparseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "foo", new GreetingStruct
                    {
                        Hi = "there",
                    } },
                    { "baz", new GreetingStruct
                    {
                        Hi = "bye",
                    } },
                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SparseJsonMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"sparseStructMap\": {\n        \"foo\": {\n            \"hi\": \"there\"\n        },\n        \"baz\": {\n            \"hi\": \"bye\"\n        }\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/SparseJsonMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes JSON map values in sparse maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonSerializesSparseNullMapValuesRequest()
        {
            // Arrange
            var request = new SparseJsonMapsRequest
            {
                SparseBooleanMap = new Dictionary<string, bool?>()
                {

                    { "x", null },
                },
                SparseNumberMap = new Dictionary<string, int?>()
                {

                    { "x", null },
                },
                SparseStringMap = new Dictionary<string, string>()
                {

                    { "x", null },
                },
                SparseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "x", null },
                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SparseJsonMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"sparseBooleanMap\": {\n        \"x\": null\n    },\n    \"sparseNumberMap\": {\n        \"x\": null\n    },\n    \"sparseStringMap\": {\n        \"x\": null\n    },\n    \"sparseStructMap\": {\n        \"x\": null\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/SparseJsonMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Ensure that 0 and false are sent over the wire in all maps and
        /// lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonSerializesZeroValuesInSparseMapsRequest()
        {
            // Arrange
            var request = new SparseJsonMapsRequest
            {
                SparseNumberMap = new Dictionary<string, int?>()
                {

                    { "x", 0 },
                },
                SparseBooleanMap = new Dictionary<string, bool?>()
                {

                    { "x", false },
                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SparseJsonMapsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"sparseNumberMap\": {\n        \"x\": 0\n    },\n    \"sparseBooleanMap\": {\n        \"x\": false\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/SparseJsonMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Deserializes JSON maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonSparseJsonMapsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"sparseStructMap\": {\n        \"foo\": {\n            \"hi\": \"there\"\n        },\n        \"baz\": {\n            \"hi\": \"bye\"\n        }\n   }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new SparseJsonMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SparseJsonMapsResponse
            {
                SparseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "foo", new GreetingStruct
                    {
                        Hi = "there",
                    } },
                    { "baz", new GreetingStruct
                    {
                        Hi = "bye",
                    } },
                },
            };

            // Assert
            var actualResponse = (SparseJsonMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<SparseJsonMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes null JSON map values
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonDeserializesSparseNullMapValuesResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"sparseBooleanMap\": {\n        \"x\": null\n    },\n    \"sparseNumberMap\": {\n        \"x\": null\n    },\n    \"sparseStringMap\": {\n        \"x\": null\n    },\n    \"sparseStructMap\": {\n        \"x\": null\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new SparseJsonMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SparseJsonMapsResponse
            {
                SparseBooleanMap = new Dictionary<string, bool?>()
                {

                    { "x", null },
                },
                SparseNumberMap = new Dictionary<string, int?>()
                {

                    { "x", null },
                },
                SparseStringMap = new Dictionary<string, string>()
                {

                    { "x", null },
                },
                SparseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "x", null },
                },
            };

            // Assert
            var actualResponse = (SparseJsonMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<SparseJsonMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensure that 0 and false are sent over the wire in all maps and
        /// lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonDeserializesZeroValuesInSparseMapsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"sparseNumberMap\": {\n        \"x\": 0\n    },\n    \"sparseBooleanMap\": {\n        \"x\": false\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new SparseJsonMapsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SparseJsonMapsResponse
            {
                SparseNumberMap = new Dictionary<string, int?>()
                {

                    { "x", 0 },
                },
                SparseBooleanMap = new Dictionary<string, bool?>()
                {

                    { "x", false },
                },
            };

            // Assert
            var actualResponse = (SparseJsonMapsResponse)unmarshalledResponse;
            Comparer.CompareObjects<SparseJsonMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
