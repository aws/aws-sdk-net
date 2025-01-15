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
using Amazon.EC2Protocol;
using Amazon.EC2Protocol.Model;
using Amazon.EC2Protocol.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.AwsEc2
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
        [TestCategory("AwsEc2")]
        public void Ec2XmlTimestampsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <normal>2014-04-29T18:30:38Z</normal>\n    <requestId>requestid</requestId>\n</XmlTimestampsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlTimestampsResponse
            {
                Normal = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (XmlTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of date-time works like normal
        /// timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public void Ec2XmlTimestampsWithDateTimeFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <dateTime>2014-04-29T18:30:38Z</dateTime>\n    <requestId>requestid</requestId>\n</XmlTimestampsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlTimestampsResponse
            {
                DateTime = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (XmlTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of date-time on the target shape
        /// works like normal timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public void Ec2XmlTimestampsWithDateTimeOnTargetFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <dateTimeOnTarget>2014-04-29T18:30:38Z</dateTimeOnTarget>\n    <requestId>requestid</requestId>\n</XmlTimestampsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlTimestampsResponse
            {
                DateTimeOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (XmlTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of epoch-seconds works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public void Ec2XmlTimestampsWithEpochSecondsFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <epochSeconds>1398796238</epochSeconds>\n    <requestId>requestid</requestId>\n</XmlTimestampsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlTimestampsResponse
            {
                EpochSeconds = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (XmlTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of epoch-seconds on the target
        /// shape works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public void Ec2XmlTimestampsWithEpochSecondsOnTargetFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <epochSecondsOnTarget>1398796238</epochSecondsOnTarget>\n    <requestId>requestid</requestId>\n</XmlTimestampsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlTimestampsResponse
            {
                EpochSecondsOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (XmlTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of http-date works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public void Ec2XmlTimestampsWithHttpDateFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <httpDate>Tue, 29 Apr 2014 18:30:38 GMT</httpDate>\n    <requestId>requestid</requestId>\n</XmlTimestampsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlTimestampsResponse
            {
                HttpDate = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (XmlTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

        /// <summary>
        /// Ensures that the timestampFormat of http-date on the target shape
        /// works
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public void Ec2XmlTimestampsWithHttpDateOnTargetFormatResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlTimestampsResponse xmlns=\"https://example.com/\">\n    <httpDateOnTarget>Tue, 29 Apr 2014 18:30:38 GMT</httpDateOnTarget>\n    <requestId>requestid</requestId>\n</XmlTimestampsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlTimestampsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlTimestampsResponse
            {
                HttpDateOnTarget = ProtocolTestConstants.epoch.AddSeconds(1398796238),
            };

            // Assert
            var actualResponse = (XmlTimestampsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlTimestampsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
