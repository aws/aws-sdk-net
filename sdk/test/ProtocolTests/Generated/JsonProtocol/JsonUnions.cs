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
using Amazon.JsonProtocol;
using Amazon.JsonProtocol.Model;
using Amazon.JsonProtocol.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.JsonProtocol
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11SerializeStringUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    StringValue = "foo"
                },
            };
            var config = new AmazonJsonProtocolConfig
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
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a boolean union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11SerializeBooleanUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    BooleanValue = true
                },
            };
            var config = new AmazonJsonProtocolConfig
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
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a number union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11SerializeNumberUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    NumberValue = 1
                },
            };
            var config = new AmazonJsonProtocolConfig
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
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a blob union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11SerializeBlobUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    BlobValue = new MemoryStream(Encoding.UTF8.GetBytes("foo"))
                },
            };
            var config = new AmazonJsonProtocolConfig
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
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a timestamp union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11SerializeTimestampUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    TimestampValue = ProtocolTestConstants.epoch.AddSeconds(1398796238)
                },
            };
            var config = new AmazonJsonProtocolConfig
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
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes an enum union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11SerializeEnumUnionValueRequest()
        {
            // Arrange
            var request = new JsonUnionsRequest
            {
                Contents = new MyUnion{
                    EnumValue = "Foo"
                },
            };
            var config = new AmazonJsonProtocolConfig
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
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a list union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11SerializeListUnionValueRequest()
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
            var config = new AmazonJsonProtocolConfig
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
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a map union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11SerializeMapUnionValueRequest()
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
            var config = new AmazonJsonProtocolConfig
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
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes a structure union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11SerializeStructureUnionValueRequest()
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
            var config = new AmazonJsonProtocolConfig
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
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonUnions".Replace(" ",""), marshalledRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Deserializes a string union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeStringUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeBooleanUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeNumberUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeBlobUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeTimestampUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeEnumUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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
        /// Deserializes a list union value
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeListUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeMapUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeStructureUnionValueResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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
        [TestCategory("JsonProtocol")]
        public void AwsJson11DeserializeIgnoreTypeResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/x-amz-json-1.1";
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

    }
}
