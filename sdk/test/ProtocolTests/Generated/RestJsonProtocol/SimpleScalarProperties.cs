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
    public class SimpleScalarProperties
    {
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonSimpleScalarPropertiesRequest()
        {
            var request = new SimpleScalarPropertiesRequest{
                Foo = "Foo",
                StringValue = "string",
                TrueBooleanValue = true,
                FalseBooleanValue = false,
                ByteValue = 1,
                ShortValue = 2,
                IntegerValue = 3,
                LongValue = 4,
                FloatValue = 5.5F,
                DoubleValue = 6.5,
            };
            var config = new AmazonRestJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedBody = "{\n    \"stringValue\": \"string\",\n    \"trueBooleanValue\": true,\n    \"falseBooleanValue\": false,\n    \"byteValue\": 1,\n    \"shortValue\": 2,\n    \"integerValue\": 3,\n    \"longValue\": 4,\n    \"floatValue\": 5.5,\n    \"DoubleDribble\": 6.5\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/SimpleScalarProperties", actualUri.AbsolutePath);
            Assert.AreEqual( "application/json", marshalledRequest.Headers["Content-Type"]);
            Assert.AreEqual( "Foo", marshalledRequest.Headers["X-Foo"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonDoesntSerializeNullStructureValuesRequest()
        {
            var request = new SimpleScalarPropertiesRequest{
                StringValue = null,
            };
            var config = new AmazonRestJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedBody = "{}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/SimpleScalarProperties", actualUri.AbsolutePath);
            Assert.AreEqual( "application/json", marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonSupportsNaNFloatInputsRequest()
        {
            var request = new SimpleScalarPropertiesRequest{
                FloatValue = float.NaN,
                DoubleValue = double.NaN,
            };
            var config = new AmazonRestJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedBody = "{\n    \"floatValue\": \"NaN\",\n    \"DoubleDribble\": \"NaN\"\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/SimpleScalarProperties", actualUri.AbsolutePath);
            Assert.AreEqual( "application/json", marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonSupportsInfinityFloatInputsRequest()
        {
            var request = new SimpleScalarPropertiesRequest{
                FloatValue = float.PositiveInfinity,
                DoubleValue = double.PositiveInfinity,
            };
            var config = new AmazonRestJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedBody = "{\n    \"floatValue\": \"Infinity\",\n    \"DoubleDribble\": \"Infinity\"\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/SimpleScalarProperties", actualUri.AbsolutePath);
            Assert.AreEqual( "application/json", marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonSupportsNegativeInfinityFloatInputsRequest()
        {
            var request = new SimpleScalarPropertiesRequest{
                FloatValue = float.NegativeInfinity,
                DoubleValue = double.NegativeInfinity,
            };
            var config = new AmazonRestJsonProtocolConfig{
              ServiceURL = "https://test.com/"
            };

            var marshaller = new SimpleScalarPropertiesRequestMarshaller();
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);
            var expectedBody = "{\n    \"floatValue\": \"-Infinity\",\n    \"DoubleDribble\": \"-Infinity\"\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/SimpleScalarProperties", actualUri.AbsolutePath);
            Assert.AreEqual( "application/json", marshalledRequest.Headers["Content-Type"]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonSimpleScalarPropertiesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"stringValue\": \"string\",\n    \"trueBooleanValue\": true,\n    \"falseBooleanValue\": false,\n    \"byteValue\": 1,\n    \"shortValue\": 2,\n    \"integerValue\": 3,\n    \"longValue\": 4,\n    \"floatValue\": 5.5,\n    \"DoubleDribble\": 6.5\n}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/json";
            webResponseData.Headers["X-Foo"] = "Foo";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new SimpleScalarPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarPropertiesResponse{
                Foo = "Foo",
                StringValue = "string",
                TrueBooleanValue = true,
                FalseBooleanValue = false,
                ByteValue = 1,
                ShortValue = 2,
                IntegerValue = 3,
                LongValue = 4,
                FloatValue = 5.5F,
                DoubleValue = 6.5,
            };
            var actualResponse = (SimpleScalarPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonDoesntDeserializeNullStructureValuesResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"stringValue\": null\n}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/json";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new SimpleScalarPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarPropertiesResponse{
            };
            var actualResponse = (SimpleScalarPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonSupportsNaNFloatInputsResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"floatValue\": \"NaN\",\n    \"DoubleDribble\": \"NaN\"\n}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/json";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new SimpleScalarPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarPropertiesResponse{
                FloatValue = float.NaN,
                DoubleValue = double.NaN,
            };
            var actualResponse = (SimpleScalarPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonSupportsInfinityFloatInputsResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"floatValue\": \"Infinity\",\n    \"DoubleDribble\": \"Infinity\"\n}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/json";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new SimpleScalarPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarPropertiesResponse{
                FloatValue = float.PositiveInfinity,
                DoubleValue = double.PositiveInfinity,
            };
            var actualResponse = (SimpleScalarPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
        }
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonSupportsNegativeInfinityFloatInputsResponse()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"floatValue\": \"-Infinity\",\n    \"DoubleDribble\": \"-Infinity\"\n}");
            var stream = new MemoryStream(bytes);
            var webResponseData = new WebResponseData();
            webResponseData.Headers["Content-Type"] = "application/json";
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);
            var unmarshalledResponse = new SimpleScalarPropertiesResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new SimpleScalarPropertiesResponse{
                FloatValue = float.NegativeInfinity,
                DoubleValue = double.NegativeInfinity,
            };
            var actualResponse = (SimpleScalarPropertiesResponse)unmarshalledResponse;
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual(200, ProtocolTestUtils.StatusCodeDictionary[context.ResponseData.StatusCode]);
        }
    }
}
