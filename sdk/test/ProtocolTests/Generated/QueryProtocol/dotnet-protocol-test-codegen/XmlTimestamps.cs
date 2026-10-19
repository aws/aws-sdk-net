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
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.AwsQuery
{
    [TestClass]
    public class XmlTimestamps
    {
        /// <summary>
        /// Tests how normal timestamps are serialized
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryXmlTimestampsResponse()
        {
            // Arrange
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <XmlTimestampsResult>\n        <normal>2014-04-29T18:30:38Z</normal>\n    </XmlTimestampsResult>\n</XmlTimestampsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlTimestampsAsync(new XmlTimestampsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlTimestampsResponse
            {
                Normal = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of date-time works like normal
        /// timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryXmlTimestampsWithDateTimeFormatResponse()
        {
            // Arrange
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <XmlTimestampsResult>\n        <dateTime>2014-04-29T18:30:38Z</dateTime>\n    </XmlTimestampsResult>\n</XmlTimestampsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlTimestampsAsync(new XmlTimestampsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlTimestampsResponse
            {
                DateTime = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of date-time on the target shape
        /// works like normal timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryXmlTimestampsWithDateTimeOnTargetFormatResponse()
        {
            // Arrange
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <XmlTimestampsResult>\n        <dateTimeOnTarget>2014-04-29T18:30:38Z</dateTimeOnTarget>\n    </XmlTimestampsResult>\n</XmlTimestampsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlTimestampsAsync(new XmlTimestampsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlTimestampsResponse
            {
                DateTimeOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of epoch-seconds works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryXmlTimestampsWithEpochSecondsFormatResponse()
        {
            // Arrange
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <XmlTimestampsResult>\n        <epochSeconds>1398796238</epochSeconds>\n    </XmlTimestampsResult>\n</XmlTimestampsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlTimestampsAsync(new XmlTimestampsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlTimestampsResponse
            {
                EpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of epoch-seconds on the target
        /// shape works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryXmlTimestampsWithEpochSecondsOnTargetFormatResponse()
        {
            // Arrange
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <XmlTimestampsResult>\n        <epochSecondsOnTarget>1398796238</epochSecondsOnTarget>\n    </XmlTimestampsResult>\n</XmlTimestampsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlTimestampsAsync(new XmlTimestampsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlTimestampsResponse
            {
                EpochSecondsOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of http-date works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryXmlTimestampsWithHttpDateFormatResponse()
        {
            // Arrange
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <XmlTimestampsResult>\n        <httpDate>Tue, 29 Apr 2014 18:30:38 GMT</httpDate>\n    </XmlTimestampsResult>\n</XmlTimestampsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlTimestampsAsync(new XmlTimestampsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlTimestampsResponse
            {
                HttpDate = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of http-date on the target shape
        /// works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryXmlTimestampsWithHttpDateOnTargetFormatResponse()
        {
            // Arrange
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <XmlTimestampsResult>\n        <httpDateOnTarget>Tue, 29 Apr 2014 18:30:38 GMT</httpDateOnTarget>\n    </XmlTimestampsResult>\n</XmlTimestampsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlTimestampsAsync(new XmlTimestampsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlTimestampsResponse
            {
                HttpDateOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
