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
using Amazon.RestXmlProtocol;
using Amazon.RestXmlProtocol.Model;
using Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.RestXml
{
    [TestClass]
    public class AllQueryStringTypes
    {
        /// <summary>
        /// Serializes query string parameters with all supported types
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void AllQueryStringTypesRequest()
        {
            // Arrange
            var request = new AllQueryStringTypesRequest
            {
                QueryString = "Hello there",
                QueryStringList =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
                },
                QueryStringSet =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
                },
                QueryByte = 1,
                QueryShort = 2,
                QueryInteger = 3,
                QueryIntegerList =  new List<int>()
                {
                    1,
                    2,
                    3,
                },
                QueryIntegerSet =  new List<int>()
                {
                    1,
                    2,
                    3,
                },
                QueryLong = 4,
                QueryFloat = 1.1F,
                QueryDouble = 1.1,
                QueryDoubleList =  new List<double>()
                {
                    1.1,
                    2.1,
                    3.1,
                },
                QueryBoolean = true,
                QueryBooleanList =  new List<bool>()
                {
                    true,
                    false,
                    true,
                },
                QueryTimestamp = ProtocolTestConstants.epoch.AddSeconds(1),
                QueryTimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1),
                    ProtocolTestConstants.epoch.AddSeconds(2),
                    ProtocolTestConstants.epoch.AddSeconds(3),
                },
                QueryEnum = "Foo",
                QueryEnumList =  new List<string>()
                {
                    "Foo",
                    "Baz",
                    "Bar",
                },
                QueryIntegerEnum = 1,
                QueryIntegerEnumList =  new List<int>()
                {
                    1,
                    2,
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new AllQueryStringTypesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/AllQueryStringTypesInput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualUri);
            Assert.IsTrue(actualQuerySegments.Contains("String=Hello%20there"));
            Assert.IsTrue(actualQuerySegments.Contains("StringList=a"));
            Assert.IsTrue(actualQuerySegments.Contains("StringList=b"));
            Assert.IsTrue(actualQuerySegments.Contains("StringList=c"));
            Assert.IsTrue(actualQuerySegments.Contains("StringSet=a"));
            Assert.IsTrue(actualQuerySegments.Contains("StringSet=b"));
            Assert.IsTrue(actualQuerySegments.Contains("StringSet=c"));
            Assert.IsTrue(actualQuerySegments.Contains("Byte=1"));
            Assert.IsTrue(actualQuerySegments.Contains("Short=2"));
            Assert.IsTrue(actualQuerySegments.Contains("Integer=3"));
            Assert.IsTrue(actualQuerySegments.Contains("IntegerList=1"));
            Assert.IsTrue(actualQuerySegments.Contains("IntegerList=2"));
            Assert.IsTrue(actualQuerySegments.Contains("IntegerList=3"));
            Assert.IsTrue(actualQuerySegments.Contains("IntegerSet=1"));
            Assert.IsTrue(actualQuerySegments.Contains("IntegerSet=2"));
            Assert.IsTrue(actualQuerySegments.Contains("IntegerSet=3"));
            Assert.IsTrue(actualQuerySegments.Contains("Long=4"));
            Assert.IsTrue(actualQuerySegments.Contains("Float=1.1"));
            Assert.IsTrue(actualQuerySegments.Contains("Double=1.1"));
            Assert.IsTrue(actualQuerySegments.Contains("DoubleList=1.1"));
            Assert.IsTrue(actualQuerySegments.Contains("DoubleList=2.1"));
            Assert.IsTrue(actualQuerySegments.Contains("DoubleList=3.1"));
            Assert.IsTrue(actualQuerySegments.Contains("Boolean=true"));
            Assert.IsTrue(actualQuerySegments.Contains("BooleanList=true"));
            Assert.IsTrue(actualQuerySegments.Contains("BooleanList=false"));
            Assert.IsTrue(actualQuerySegments.Contains("BooleanList=true"));
            Assert.IsTrue(actualQuerySegments.Contains("Timestamp=1970-01-01T00%3A00%3A01Z"));
            Assert.IsTrue(actualQuerySegments.Contains("TimestampList=1970-01-01T00%3A00%3A01Z"));
            Assert.IsTrue(actualQuerySegments.Contains("TimestampList=1970-01-01T00%3A00%3A02Z"));
            Assert.IsTrue(actualQuerySegments.Contains("TimestampList=1970-01-01T00%3A00%3A03Z"));
            Assert.IsTrue(actualQuerySegments.Contains("Enum=Foo"));
            Assert.IsTrue(actualQuerySegments.Contains("EnumList=Foo"));
            Assert.IsTrue(actualQuerySegments.Contains("EnumList=Baz"));
            Assert.IsTrue(actualQuerySegments.Contains("EnumList=Bar"));
            Assert.IsTrue(actualQuerySegments.Contains("IntegerEnum=1"));
            Assert.IsTrue(actualQuerySegments.Contains("IntegerEnumList=1"));
            Assert.IsTrue(actualQuerySegments.Contains("IntegerEnumList=2"));
        }

        /// <summary>
        /// Handles query string maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlQueryStringMapRequest()
        {
            // Arrange
            var request = new AllQueryStringTypesRequest
            {
                QueryParamsMapOfStrings = new Dictionary<string, string>()
                {

                    { "QueryParamsStringKeyA", "Foo" },
                    { "QueryParamsStringKeyB", "Bar" },
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new AllQueryStringTypesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/AllQueryStringTypesInput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualUri);
            Assert.IsTrue(actualQuerySegments.Contains("QueryParamsStringKeyA=Foo"));
            Assert.IsTrue(actualQuerySegments.Contains("QueryParamsStringKeyB=Bar"));
        }

        /// <summary>
        /// Handles escaping all required characters in the query string.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlQueryStringEscapingRequest()
        {
            // Arrange
            var request = new AllQueryStringTypesRequest
            {
                QueryString = " %:/?#[]@!$&'()*+,;=😹",
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new AllQueryStringTypesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/AllQueryStringTypesInput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualUri);
            Assert.IsTrue(actualQuerySegments.Contains("String=%20%25%3A%2F%3F%23%5B%5D%40%21%24%26%27%28%29%2A%2B%2C%3B%3D%F0%9F%98%B9"));
        }

        /// <summary>
        /// Supports handling NaN float query values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlSupportsNaNFloatQueryValuesRequest()
        {
            // Arrange
            var request = new AllQueryStringTypesRequest
            {
                QueryFloat = float.NaN,
                QueryDouble = double.NaN,
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new AllQueryStringTypesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/AllQueryStringTypesInput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualUri);
            Assert.IsTrue(actualQuerySegments.Contains("Float=NaN"));
            Assert.IsTrue(actualQuerySegments.Contains("Double=NaN"));
        }

        /// <summary>
        /// Supports handling Infinity float query values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlSupportsInfinityFloatQueryValuesRequest()
        {
            // Arrange
            var request = new AllQueryStringTypesRequest
            {
                QueryFloat = float.PositiveInfinity,
                QueryDouble = double.PositiveInfinity,
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new AllQueryStringTypesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/AllQueryStringTypesInput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualUri);
            Assert.IsTrue(actualQuerySegments.Contains("Float=Infinity"));
            Assert.IsTrue(actualQuerySegments.Contains("Double=Infinity"));
        }

        /// <summary>
        /// Supports handling -Infinity float query values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlSupportsNegativeInfinityFloatQueryValuesRequest()
        {
            // Arrange
            var request = new AllQueryStringTypesRequest
            {
                QueryFloat = float.NegativeInfinity,
                QueryDouble = double.NegativeInfinity,
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new AllQueryStringTypesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/AllQueryStringTypesInput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualUri);
            Assert.IsTrue(actualQuerySegments.Contains("Float=-Infinity"));
            Assert.IsTrue(actualQuerySegments.Contains("Double=-Infinity"));
        }

        /// <summary>
        /// Query values of 0 and false are serialized
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void RestXmlZeroAndFalseQueryValuesRequest()
        {
            // Arrange
            var request = new AllQueryStringTypesRequest
            {
                QueryInteger = 0,
                QueryBoolean = false,
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new AllQueryStringTypesRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            Assert.AreEqual("GET", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/AllQueryStringTypesInput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualUri);
            Assert.IsTrue(actualQuerySegments.Contains("Integer=0"));
            Assert.IsTrue(actualQuerySegments.Contains("Boolean=false"));
        }

    }
}
