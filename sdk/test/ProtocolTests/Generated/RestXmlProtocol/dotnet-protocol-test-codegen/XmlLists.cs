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
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace AWSSDK.ProtocolTests.RestXml
{
    [TestClass]
    public class XmlLists
    {
        /// <summary>
        /// Tests for XML list serialization
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestXml")]
        public void XmlListsRequest()
        {
            // Arrange
            var request = new XmlListsRequest
            {
                StringList =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                StringSet =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                IntegerList =  new List<int>()
                {
                    1,
                    2,
                },
                BooleanList =  new List<bool>()
                {
                    true,
                    false,
                },
                TimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                },
                EnumList =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                NestedStringList =  new List<List<string>>()
                {
                     new List<string>()
                    {
                        "foo",
                        "bar",
                    },
                     new List<string>()
                    {
                        "baz",
                        "qux",
                    },
                },
                RenamedListMembers =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                FlattenedList =  new List<string>()
                {
                    "hi",
                    "bye",
                },
                FlattenedList2 =  new List<string>()
                {
                    "yep",
                    "nope",
                },
                StructureList =  new List<StructureListMember>()
                {
                    new StructureListMember
                    {
                        A = "1",
                        B = "2",
                    },
                    new StructureListMember
                    {
                        A = "3",
                        B = "4",
                    },
                },
                FlattenedStructureList =  new List<StructureListMember>()
                {
                    new StructureListMember
                    {
                        A = "5",
                        B = "6",
                    },
                    new StructureListMember
                    {
                        A = "7",
                        B = "8",
                    },
                },
            };
            var config = new AmazonRestXmlProtocolConfig
            {
              ServiceURL = "https://test.com/"
            };

            var marshaller = new XmlListsRequestMarshaller();
            // Act
            var marshalledRequest = ProtocolTestUtils.RunMockRequest(request,marshaller,config);

            // Assert
            var expectedBody = "<XmlListsRequest>\n    <stringList>\n        <member>foo</member>\n        <member>bar</member>\n    </stringList>\n    <stringSet>\n        <member>foo</member>\n        <member>bar</member>\n    </stringSet>\n    <integerList>\n        <member>1</member>\n        <member>2</member>\n    </integerList>\n    <booleanList>\n        <member>true</member>\n        <member>false</member>\n    </booleanList>\n    <timestampList>\n        <member>2014-04-29T18:30:38Z</member>\n        <member>2014-04-29T18:30:38Z</member>\n    </timestampList>\n    <enumList>\n        <member>Foo</member>\n        <member>0</member>\n    </enumList>\n    <intEnumList>\n        <member>1</member>\n        <member>2</member>\n    </intEnumList>\n    <nestedStringList>\n        <member>\n            <member>foo</member>\n            <member>bar</member>\n        </member>\n        <member>\n            <member>baz</member>\n            <member>qux</member>\n        </member>\n    </nestedStringList>\n    <renamed>\n        <item>foo</item>\n        <item>bar</item>\n    </renamed>\n    <flattenedList>hi</flattenedList>\n    <flattenedList>bye</flattenedList>\n    <customName>yep</customName>\n    <customName>nope</customName>\n    <myStructureList>\n        <item>\n            <value>1</value>\n            <other>2</other>\n        </item>\n        <item>\n            <value>3</value>\n            <other>4</other>\n        </item>\n    </myStructureList>\n    <flattenedStructureList>\n        <value>5</value>\n        <other>6</other>\n    </flattenedStructureList>\n    <flattenedStructureList>\n        <value>7</value>\n        <other>8</other>\n    </flattenedStructureList>\n</XmlListsRequest>\n";
            XmlTestUtils.AssertBody(marshalledRequest,expectedBody);
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Uri actualUri = AmazonServiceClient.ComposeUrl(marshalledRequest);
            Assert.AreEqual("/XmlLists", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualUri));
            Assert.AreEqual("application/xml".Replace(" ",""), marshalledRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Tests for XML list serialization
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestXml")]
        public void XmlListsResponse()
        {
            // Arrange
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200);
            webResponseData.Headers["Content-Type"] = "application/xml";
            byte[] bytes = Encoding.ASCII.GetBytes("<XmlListsResponse>\n    <stringList>\n        <member>foo</member>\n        <member>bar</member>\n    </stringList>\n    <stringSet>\n        <member>foo</member>\n        <member>bar</member>\n    </stringSet>\n    <integerList>\n        <member>1</member>\n        <member>2</member>\n    </integerList>\n    <booleanList>\n        <member>true</member>\n        <member>false</member>\n    </booleanList>\n    <timestampList>\n        <member>2014-04-29T18:30:38Z</member>\n        <member>2014-04-29T18:30:38Z</member>\n    </timestampList>\n    <enumList>\n        <member>Foo</member>\n        <member>0</member>\n    </enumList>\n    <intEnumList>\n        <member>1</member>\n        <member>2</member>\n    </intEnumList>\n    <nestedStringList>\n        <member>\n            <member>foo</member>\n            <member>bar</member>\n        </member>\n        <member>\n            <member>baz</member>\n            <member>qux</member>\n        </member>\n    </nestedStringList>\n    <renamed>\n        <item>foo</item>\n        <item>bar</item>\n    </renamed>\n    <flattenedList>hi</flattenedList>\n    <flattenedList>bye</flattenedList>\n    <customName>yep</customName>\n    <customName>nope</customName>\n    <flattenedListWithMemberNamespace xmlns=\"https://xml-member.example.com\">a</flattenedListWithMemberNamespace>\n    <flattenedListWithMemberNamespace xmlns=\"https://xml-member.example.com\">b</flattenedListWithMemberNamespace>\n    <flattenedListWithNamespace>a</flattenedListWithNamespace>\n    <flattenedListWithNamespace>b</flattenedListWithNamespace>\n    <myStructureList>\n        <item>\n            <value>1</value>\n            <other>2</other>\n        </item>\n        <item>\n            <value>3</value>\n            <other>4</other>\n        </item>\n    </myStructureList>\n    <flattenedStructureList>\n        <value>5</value>\n        <other>6</other>\n    </flattenedStructureList>\n    <flattenedStructureList>\n        <value>7</value>\n        <other>8</other>\n    </flattenedStructureList>\n</XmlListsResponse>\n");
            var stream = new MemoryStream(bytes);
            var context = new XmlUnmarshallerContext(stream,true,webResponseData);

            // Act
            var unmarshalledResponse = new XmlListsResponseUnmarshaller().Unmarshall(context);
            var expectedResponse = new XmlListsResponse
            {
                StringList =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                StringSet =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                IntegerList =  new List<int>()
                {
                    1,
                    2,
                },
                BooleanList =  new List<bool>()
                {
                    true,
                    false,
                },
                TimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                },
                EnumList =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                NestedStringList =  new List<List<string>>()
                {
                     new List<string>()
                    {
                        "foo",
                        "bar",
                    },
                     new List<string>()
                    {
                        "baz",
                        "qux",
                    },
                },
                RenamedListMembers =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                FlattenedList =  new List<string>()
                {
                    "hi",
                    "bye",
                },
                FlattenedList2 =  new List<string>()
                {
                    "yep",
                    "nope",
                },
                FlattenedListWithMemberNamespace =  new List<string>()
                {
                    "a",
                    "b",
                },
                FlattenedListWithNamespace =  new List<string>()
                {
                    "a",
                    "b",
                },
                StructureList =  new List<StructureListMember>()
                {
                    new StructureListMember
                    {
                        A = "1",
                        B = "2",
                    },
                    new StructureListMember
                    {
                        A = "3",
                        B = "4",
                    },
                },
                FlattenedStructureList =  new List<StructureListMember>()
                {
                    new StructureListMember
                    {
                        A = "5",
                        B = "6",
                    },
                    new StructureListMember
                    {
                        A = "7",
                        B = "8",
                    },
                },
            };

            // Assert
            var actualResponse = (XmlListsResponse)unmarshalledResponse;
            Comparer.CompareObjects<XmlListsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), context.ResponseData.StatusCode);
        }

    }
}
