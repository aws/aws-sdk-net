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
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.AwsQuery
{
    [TestClass]
    public class QueryLists
    {
        /// <summary>
        /// Serializes query lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryListsRequest()
        {
            // Arrange
            var request = new QueryListsRequest
            {
                ListArg =  new List<string>()
                {
                    "foo",
                    "bar",
                    "baz",
                },
                ComplexListArg =  new List<GreetingStruct>()
                {
                    new GreetingStruct
                    {
                        Hi = "hello",
                    },
                    new GreetingStruct
                    {
                        Hi = "hola",
                    },
                },
            };
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            await client.QueryListsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "Action=QueryLists&Version=2020-01-08&ListArg.member.1=foo&ListArg.member.2=bar&ListArg.member.3=baz&ComplexListArg.member.1.hi=hello&ComplexListArg.member.2.hi=hola";
            QueryTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8", actualRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Serializes empty query lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsQuery")]
        public async Task EmptyQueryListsRequest()
        {
            // Arrange
            var request = new QueryListsRequest
            {
                ListArg =  new List<string>()
                {
                },
            };
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            await client.QueryListsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "Action=QueryLists&Version=2020-01-08&ListArg=";
            QueryTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8", actualRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Flattens query lists by repeating the member name and removing
        /// the member element
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsQuery")]
        public async Task FlattenedQueryListsRequest()
        {
            // Arrange
            var request = new QueryListsRequest
            {
                FlattenedListArg =  new List<string>()
                {
                    "A",
                    "B",
                },
            };
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            await client.QueryListsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "Action=QueryLists&Version=2020-01-08&FlattenedListArg.1=A&FlattenedListArg.2=B";
            QueryTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8", actualRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Changes the member of lists using xmlName trait
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryListArgWithXmlNameMemberRequest()
        {
            // Arrange
            var request = new QueryListsRequest
            {
                ListArgWithXmlNameMember =  new List<string>()
                {
                    "A",
                    "B",
                },
            };
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            await client.QueryListsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "Action=QueryLists&Version=2020-01-08&ListArgWithXmlNameMember.item.1=A&ListArgWithXmlNameMember.item.2=B";
            QueryTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8", actualRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Changes the name of flattened lists using xmlName trait on the
        /// structure member
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryFlattenedListArgWithXmlNameRequest()
        {
            // Arrange
            var request = new QueryListsRequest
            {
                FlattenedListArgWithXmlName =  new List<string>()
                {
                    "A",
                    "B",
                },
            };
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            await client.QueryListsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "Action=QueryLists&Version=2020-01-08&Hi.1=A&Hi.2=B";
            QueryTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8", actualRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Nested structure with a list member
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsQuery")]
        public async Task QueryNestedStructWithListRequest()
        {
            // Arrange
            var request = new QueryListsRequest
            {
                NestedWithList = new NestedStructWithList
                {
                    ListArg =  new List<string>()
                    {
                        "A",
                        "B",
                    },
                },
            };
            var config = new AmazonQueryProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonQueryProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            await client.QueryListsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "Action=QueryLists&Version=2020-01-08&NestedWithList.ListArg.member.1=A&NestedWithList.ListArg.member.2=B";
            QueryTestUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8", actualRequest.Headers["Content-Type"]);
        }

    }
}
