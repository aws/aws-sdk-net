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
    public class JsonTimestamps
    {
        /// <summary>
        /// Tests how normal timestamps are serialized
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsRequest()
        {
            // Arrange
            var request = new JsonTimestampsRequest
            {
                Normal = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonTimestampsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"normal\": 1398796238\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/JsonTimestamps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Ensures that the timestampFormat of date-time works like normal
        /// timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithDateTimeFormatRequest()
        {
            // Arrange
            var request = new JsonTimestampsRequest
            {
                DateTime = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonTimestampsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"dateTime\": \"2014-04-29T18:30:38Z\"\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/JsonTimestamps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Ensures that the timestampFormat of date-time on the target shape
        /// works like normal timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithDateTimeOnTargetFormatRequest()
        {
            // Arrange
            var request = new JsonTimestampsRequest
            {
                DateTimeOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonTimestampsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"dateTimeOnTarget\": \"2014-04-29T18:30:38Z\"\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/JsonTimestamps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Ensures that the timestampFormat of epoch-seconds works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithEpochSecondsFormatRequest()
        {
            // Arrange
            var request = new JsonTimestampsRequest
            {
                EpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonTimestampsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"epochSeconds\": 1398796238\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/JsonTimestamps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Ensures that the timestampFormat of epoch-seconds on the target
        /// shape works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithEpochSecondsOnTargetFormatRequest()
        {
            // Arrange
            var request = new JsonTimestampsRequest
            {
                EpochSecondsOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonTimestampsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"epochSecondsOnTarget\": 1398796238\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/JsonTimestamps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Ensures that the timestampFormat of http-date works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithHttpDateFormatRequest()
        {
            // Arrange
            var request = new JsonTimestampsRequest
            {
                HttpDate = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonTimestampsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"httpDate\": \"Tue, 29 Apr 2014 18:30:38 GMT\"\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/JsonTimestamps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Ensures that the timestampFormat of http-date on the target shape
        /// works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithHttpDateOnTargetFormatRequest()
        {
            // Arrange
            var request = new JsonTimestampsRequest
            {
                HttpDateOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new JsonTimestampsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "{\n    \"httpDateOnTarget\": \"Tue, 29 Apr 2014 18:30:38 GMT\"\n}";
            JsonProtocolUtils.AssertBody(marshalledRequest, expectedBody);
            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/JsonTimestamps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/json".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Tests how normal timestamps are serialized
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"normal\": 1398796238\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonTimestampsResponse
            {
                Normal = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (JsonTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of date-time works like normal
        /// timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithDateTimeFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"dateTime\": \"2014-04-29T18:30:38Z\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonTimestampsResponse
            {
                DateTime = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (JsonTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of date-time on the target shape
        /// works like normal timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithDateTimeOnTargetFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"dateTimeOnTarget\": \"2014-04-29T18:30:38Z\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonTimestampsResponse
            {
                DateTimeOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (JsonTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of epoch-seconds works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithEpochSecondsFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"epochSeconds\": 1398796238\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonTimestampsResponse
            {
                EpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (JsonTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of epoch-seconds on the target
        /// shape works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithEpochSecondsOnTargetFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"epochSecondsOnTarget\": 1398796238\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonTimestampsResponse
            {
                EpochSecondsOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (JsonTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of http-date works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithHttpDateFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"httpDate\": \"Tue, 29 Apr 2014 18:30:38 GMT\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonTimestampsResponse
            {
                HttpDate = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (JsonTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of http-date on the target shape
        /// works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public void RestJsonJsonTimestampsWithHttpDateOnTargetFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\n    \"httpDateOnTarget\": \"Tue, 29 Apr 2014 18:30:38 GMT\"\n}");
            var stream = new MemoryStream(bytes);
            var context = new JsonUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new JsonTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new JsonTimestampsResponse
            {
                HttpDateOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (JsonTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<JsonTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
