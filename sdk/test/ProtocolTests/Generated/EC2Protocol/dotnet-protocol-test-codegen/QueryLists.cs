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
    public class QueryLists
    {
        /// <summary>
        /// Serializes query lists. All EC2 lists are flattened.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2ListsRequest()
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
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new QueryListsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=QueryLists&Version=2020-01-08&ListArg.1=foo&ListArg.2=bar&ListArg.3=baz&ComplexListArg.1.Hi=hello&ComplexListArg.2.Hi=hola");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Does not serialize empty query lists.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2EmptyQueryListsRequest()
        {
            // Arrange
            var request = new QueryListsRequest
            {
                ListArg =  new List<string>()
                {
                },
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new QueryListsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=QueryLists&Version=2020-01-08");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// An xmlName trait in the member of a list has no effect on the
        /// list serialization.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2ListArgWithXmlNameMemberRequest()
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
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new QueryListsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=QueryLists&Version=2020-01-08&ListArgWithXmlNameMember.1=A&ListArgWithXmlNameMember.2=B");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Changes the name of the list using the xmlName trait
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2ListMemberWithXmlNameRequest()
        {
            // Arrange
            var request = new QueryListsRequest
            {
                ListArgWithXmlName =  new List<string>()
                {
                    "A",
                    "B",
                },
            };
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new QueryListsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=QueryLists&Version=2020-01-08&Hi.1=A&Hi.2=B");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

        /// <summary>
        /// Nested structure with a list member
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("AwsEc2")]
        public void Ec2ListNestedStructWithListRequest()
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
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new QueryListsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedParams = QueryTestUtils.ConvertBodyToParameters("Action=QueryLists&Version=2020-01-08&NestedWithList.ListArg.1=A&NestedWithList.ListArg.2=B");
            foreach(var queryParam in expectedParams.Keys)
            {
               Assert.IsTrue(marshalledRequest.Parameters.Keys.Contains(queryParam));
               Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam].ToString()),WebUtility.UrlDecode(marshalledRequest.Parameters[queryParam].ToString()));
            }

            Assert.AreEqual("POST", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/x-www-form-urlencoded; charset=utf-8",marshalledRequest.Headers["Content-Type"]);
        }

    }
}
