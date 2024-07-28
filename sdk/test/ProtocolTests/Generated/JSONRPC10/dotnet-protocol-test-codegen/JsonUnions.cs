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
using Amazon.JSONRPC10;
using Amazon.JSONRPC10.Model;
using Amazon.JSONRPC10.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.JsonRpc10
{
    [TestClass]
    public class JsonUnions
    {
        /// <summary>
        /// Serializes a string union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeStringUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    StringValue = "foo"
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"stringValue\": \"foo\"\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a boolean union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeBooleanUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    BooleanValue = true
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"booleanValue\": true\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a number union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeNumberUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    NumberValue = 1
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"numberValue\": 1\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a blob union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeBlobUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    BlobValue = new MemoryStream(Encoding.UTF8.GetBytes("foo"))
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"blobValue\": \"Zm9v\"\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a timestamp union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeTimestampUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    TimestampValue = ProtocolTestConstants.epoch.AddSeconds(1398796238)
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"timestampValue\": 1398796238\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes an enum union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeEnumUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    EnumValue = "Foo"
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"enumValue\": \"Foo\"\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes an intEnum union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeIntEnumUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    IntEnumValue = 1
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"intEnumValue\": 1\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a list union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeListUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    ListValue =  new List<string>()
                    {
                        "foo",
                        "bar",
                    }
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"listValue\": [\"foo\", \"bar\"]\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a map union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeMapUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    MapValue = new Dictionary<string, string>()
                    {

                        { "foo", "bar" },
                        { "spam", "eggs" },
                    }
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"mapValue\": {\n            \"foo\": \"bar\",\n            \"spam\": \"eggs\"\n        }\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a structure union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10SerializeStructureUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    StructureValue = new GreetingStruct
                    {
                        Hi = "hello",
                    }
                },
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonUnionsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"contents\": {\n        \"structureValue\": {\n            \"hi\": \"hello\"\n        }\n    }\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Deserializes a string union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeStringUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"stringValue\": \"foo\"\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    StringValue = "foo"
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes a boolean union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeBooleanUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"booleanValue\": true\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    BooleanValue = true
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes a number union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeNumberUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"numberValue\": 1\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    NumberValue = 1
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes a blob union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeBlobUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"blobValue\": \"Zm9v\"\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    BlobValue = new MemoryStream(Encoding.UTF8.GetBytes("foo"))
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes a timestamp union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeTimestampUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"timestampValue\": 1398796238\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    TimestampValue = ProtocolTestConstants.epoch.AddSeconds(1398796238)
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes an enum union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeEnumUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"enumValue\": \"Foo\"\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    EnumValue = "Foo"
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes an intEnum union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeIntEnumUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"intEnumValue\": 1\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    IntEnumValue = 1
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes a list union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeListUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"listValue\": [\"foo\", \"bar\"]\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    ListValue =  new List<string>()
                    {
                        "foo",
                        "bar",
                    }
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes a map union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeMapUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"mapValue\": {\n            \"foo\": \"bar\",\n            \"spam\": \"eggs\"\n        }\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    MapValue = new Dictionary<string, string>()
                    {

                        { "foo", "bar" },
                        { "spam", "eggs" },
                    }
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Deserializes a structure union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeStructureUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"structureValue\": {\n            \"hi\": \"hello\"\n        }\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    StructureValue = new GreetingStruct
                    {
                        Hi = "hello",
                    }
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ignores an unrecognized __type property
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeIgnoreTypeResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n        \"__type\": \"aws.protocoltests.json10#MyUnion\",\n        \"structureValue\": {\n            \"hi\": \"hello\"\n        }\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    StructureValue = new GreetingStruct
                    {
                        Hi = "hello",
                    }
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Allows for `: null` to be set for all unset fields
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public void AwsJson10DeserializeAllowNullsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.0";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"contents\": {\n      \"stringValue\": null,\n      \"booleanValue\": null,\n      \"numberValue\": null,\n      \"blobValue\": null,\n      \"timestampValue\": null,\n      \"enumValue\": null,\n      \"intEnumValue\": null,\n      \"listValue\": null,\n      \"mapValue\": null,\n      \"structureValue\": {\n          \"hi\": \"hello\"\n      }\n    }\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonUnionsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonUnionsResponse
            {
                Contents = new MyUnion{
                    StructureValue = new GreetingStruct
                    {
                        Hi = "hello",
                    }
                },
            };

            // Assert
            var actualResponse = (JsonUnionsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonUnionsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
