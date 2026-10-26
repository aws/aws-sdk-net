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
using AWSSDK.ProtocolTests.Utils;
using Amazon.Extensions.Numerics;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static AWSSDK.ProtocolTests.NumericTypes.NumericTypesTestData;
using Ec2Svc = Amazon.NumericTypesEC2;
using QuerySvc = Amazon.NumericTypesQuery;
using RestJsonSvc = Amazon.NumericTypesRestJson;
using RestXmlSvc = Amazon.NumericTypesRestXml;

namespace AWSSDK.ProtocolTests.NumericTypes
{
    /// <summary>
    /// Full Numeric Type Support SEP tests for restXml, awsQuery and ec2Query (decimal text), plus the REST header,
    /// query string and URI label bindings shared by restJson1 and restXml.
    /// </summary>
    [TestClass]
    public class NumericTypesXmlTests
    {
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        public void RestXml_RequestBody_WritesDecimalText()
        {
            var request = new RestXmlSvc.Model.BodyNumbersRequest
            {
                ByteValue = sbyte.MinValue,
                ShortValue = short.MaxValue,
                BigIntegerValue = BigInteger(BigIntegerText),
                BigDecimalValue = BigDecimal(BigDecimalText),
                ByteList = new List<sbyte> { -128, 127 },
                BigDecimalMap = new Dictionary<string, BigDecimal> { ["k"] = BigDecimal("1E+3") },
                Nested = new RestXmlSvc.Model.NestedNumbers { BigDecimalValue = BigDecimal(NestedBigDecimalText) },
            };
            var config = new RestXmlSvc.AmazonNumericTypesRestXmlConfig { ServiceURL = "https://test.com/" };

            var marshalled = ProtocolTestUtils.RunMockRequest(request, new RestXmlSvc.Model.Internal.MarshallTransformations.BodyNumbersRequestMarshaller(), config);

            var root = XDocument.Parse(Encoding.UTF8.GetString(marshalled.Content)).Root;
            Assert.AreEqual("-128", Child(root, "ByteValue").Value);
            Assert.AreEqual("32767", Child(root, "ShortValue").Value);
            Assert.AreEqual(BigIntegerText, Child(root, "BigIntegerValue").Value);
            Assert.AreEqual(BigDecimalText, Child(root, "BigDecimalValue").Value);
            CollectionAssert.AreEqual(new[] { "-128", "127" }, Child(root, "ByteList").Elements().Select(e => e.Value).ToArray());
            Assert.AreEqual("1000", Child(root, "BigDecimalMap").Descendants().Single(e => e.Name.LocalName == "value").Value);
            Assert.AreEqual(NestedBigDecimalText, Child(Child(root, "Nested"), "BigDecimalValue").Value);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        public void Query_RequestBody_WritesDecimalText()
        {
            var request = new QuerySvc.Model.BodyNumbersRequest
            {
                ByteValue = sbyte.MinValue,
                ShortValue = short.MaxValue,
                BigIntegerValue = BigInteger(BigIntegerText),
                BigDecimalValue = BigDecimal(BigDecimalText),
                ByteList = new List<sbyte> { -128, 127 },
                ShortMap = new Dictionary<string, short> { ["k"] = short.MinValue },
                BigDecimalMap = new Dictionary<string, BigDecimal> { ["k"] = BigDecimal("1E+3") },
                Nested = new QuerySvc.Model.NestedNumbers { BigIntegerValue = BigInteger(BigIntegerInMapText) },
            };
            var config = new QuerySvc.AmazonNumericTypesQueryConfig { ServiceURL = "https://test.com/" };

            var marshalled = ProtocolTestUtils.RunMockRequest(request, new QuerySvc.Model.Internal.MarshallTransformations.BodyNumbersRequestMarshaller(), config);
            var parameters = QueryParameters(marshalled);

            Assert.AreEqual("-128", parameters["ByteValue"]);
            Assert.AreEqual("32767", parameters["ShortValue"]);
            Assert.AreEqual(BigIntegerText, parameters["BigIntegerValue"]);
            Assert.AreEqual(BigDecimalText, parameters["BigDecimalValue"]);
            Assert.AreEqual("-128", parameters["ByteList.member.1"]);
            Assert.AreEqual("127", parameters["ByteList.member.2"]);
            Assert.AreEqual("k", parameters["ShortMap.entry.1.key"]);
            Assert.AreEqual("-32768", parameters["ShortMap.entry.1.value"]);
            Assert.AreEqual("1000", parameters["BigDecimalMap.entry.1.value"]);
            Assert.AreEqual(BigIntegerInMapText, parameters["Nested.BigIntegerValue"]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        public void Ec2_RequestBody_WritesDecimalText()
        {
            var request = new Ec2Svc.Model.BodyNumbersRequest
            {
                ByteValue = sbyte.MinValue,
                ShortValue = short.MaxValue,
                BigIntegerValue = BigInteger(BigIntegerText),
                BigDecimalValue = BigDecimal(BigDecimalText),
                BigDecimalList = new List<BigDecimal> { BigDecimal("1E-39"), BigDecimal(BigDecimalText) },
            };
            var config = new Ec2Svc.AmazonNumericTypesEC2Config { ServiceURL = "https://test.com/" };

            var marshalled = ProtocolTestUtils.RunMockRequest(request, new Ec2Svc.Model.Internal.MarshallTransformations.BodyNumbersRequestMarshaller(), config);
            var parameters = QueryParameters(marshalled);

            Assert.AreEqual("-128", parameters["ByteValue"]);
            Assert.AreEqual("32767", parameters["ShortValue"]);
            Assert.AreEqual(BigIntegerText, parameters["BigIntegerValue"]);
            Assert.AreEqual(BigDecimalText, parameters["BigDecimalValue"]);
            Assert.AreEqual("0.000000000000000000000000000000000000001", parameters["BigDecimalList.1"]);
            Assert.AreEqual(BigDecimalText, parameters["BigDecimalList.2"]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        public void Query_RequestBody_IgnoresCurrentCulture()
        {
            InNonInvariantCulture(Query_RequestBody_WritesDecimalText);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        public async Task RestXml_ResponseBody_ReadsEveryDigit()
        {
            var body = "<BodyNumbersResponse>"
                + "<ByteValue>-128</ByteValue>"
                + "<ShortValue>-32768</ShortValue>"
                + "<BigIntegerValue>" + DoubleLossyIntegerText + "</BigIntegerValue>"
                + "<BigDecimalValue>" + DoubleLossyDecimalText + "</BigDecimalValue>"
                + "<ShortList><member>1</member><member>-2</member></ShortList>"
                + "<BigIntegerMap><entry><key>k</key><value>" + BigIntegerText + "</value></entry></BigIntegerMap>"
                + "<Nested><BigDecimalValue>123.4500</BigDecimalValue></Nested>"
                + "</BodyNumbersResponse>";
            var config = new RestXmlSvc.AmazonNumericTypesRestXmlConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new RestXmlSvc.AmazonNumericTypesRestXmlClient(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, XmlResponse(body));

            var actual = await client.BodyNumbersAsync(new RestXmlSvc.Model.BodyNumbersRequest()).ConfigureAwait(false);

            Assert.AreEqual(sbyte.MinValue, actual.ByteValue);
            Assert.AreEqual(short.MinValue, actual.ShortValue);
            Assert.AreEqual(BigInteger(DoubleLossyIntegerText), actual.BigIntegerValue);
            Assert.AreEqual(DoubleLossyDecimalText, actual.BigDecimalValue.Value.ToPlainString(CultureInfo.InvariantCulture));
            CollectionAssert.AreEqual(new List<short> { 1, -2 }, actual.ShortList);
            Assert.AreEqual(BigInteger(BigIntegerText), actual.BigIntegerMap["k"]);
            Assert.AreEqual("123.4500", actual.Nested.BigDecimalValue.Value.ToPlainString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        public async Task Query_ResponseBody_ReadsEveryDigit()
        {
            var body = "<BodyNumbersResponse xmlns=\"https://example.com/numerictypes/\"><BodyNumbersResult>"
                + "<ByteValue>127</ByteValue>"
                + "<BigIntegerValue>" + BigIntegerText + "</BigIntegerValue>"
                + "<BigDecimalValue>" + BigDecimalText + "</BigDecimalValue>"
                + "<BigDecimalList><member>" + DoubleLossyDecimalText + "</member></BigDecimalList>"
                + "</BodyNumbersResult></BodyNumbersResponse>";
            var config = new QuerySvc.AmazonNumericTypesQueryConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new QuerySvc.AmazonNumericTypesQueryClient(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, XmlResponse(body));

            var actual = await client.BodyNumbersAsync(new QuerySvc.Model.BodyNumbersRequest()).ConfigureAwait(false);

            Assert.AreEqual((sbyte)127, actual.ByteValue);
            Assert.AreEqual(BigInteger(BigIntegerText), actual.BigIntegerValue);
            Assert.AreEqual(BigDecimalText, actual.BigDecimalValue.Value.ToPlainString(CultureInfo.InvariantCulture));
            Assert.AreEqual(DoubleLossyDecimalText, actual.BigDecimalList.Single().ToPlainString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        public async Task Ec2_ResponseBody_ReadsEveryDigit()
        {
            var body = "<BodyNumbersResponse>"
                + "<shortValue>-32768</shortValue>"
                + "<bigIntegerValue>" + BigIntegerInMapText + "</bigIntegerValue>"
                + "<bigDecimalValue>" + DoubleLossyDecimalText + "</bigDecimalValue>"
                + "</BodyNumbersResponse>";
            var config = new Ec2Svc.AmazonNumericTypesEC2Config { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new Ec2Svc.AmazonNumericTypesEC2Client(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, XmlResponse(body));

            var actual = await client.BodyNumbersAsync(new Ec2Svc.Model.BodyNumbersRequest()).ConfigureAwait(false);

            Assert.AreEqual(short.MinValue, actual.ShortValue);
            Assert.AreEqual(BigInteger(BigIntegerInMapText), actual.BigIntegerValue);
            Assert.AreEqual(DoubleLossyDecimalText, actual.BigDecimalValue.Value.ToPlainString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [DataRow("<BodyNumbersResponse><ByteValue>128</ByteValue></BodyNumbersResponse>")]
        [DataRow("<BodyNumbersResponse><ShortValue>-32769</ShortValue></BodyNumbersResponse>")]
        [DataRow("<BodyNumbersResponse><ByteList><member>-129</member></ByteList></BodyNumbersResponse>")]
        public async Task RestXml_OutOfRangeByteOrShort_ThrowsSameExceptionAsIntOverflow(string body)
        {
            var config = new RestXmlSvc.AmazonNumericTypesRestXmlConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new RestXmlSvc.AmazonNumericTypesRestXmlClient(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, XmlResponse(body));

            var actual = await CaptureExceptionAsync(() => client.BodyNumbersAsync(new RestXmlSvc.Model.BodyNumbersRequest())).ConfigureAwait(false);

            var intConfig = new Amazon.RestXmlProtocol.AmazonRestXmlProtocolConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var intClient = new Amazon.RestXmlProtocol.AmazonRestXmlProtocolClient(MockHttpClientUtils.TestCredentials, intConfig);
            MockHttpClientUtils.InjectMockHttp(intClient, XmlResponse("<SimpleScalarPropertiesResponse><integerValue>2147483648</integerValue></SimpleScalarPropertiesResponse>"));
            var intOverflow = await CaptureExceptionAsync(() => intClient.SimpleScalarPropertiesAsync(new Amazon.RestXmlProtocol.Model.SimpleScalarPropertiesRequest())).ConfigureAwait(false);

            AssertSameAsIntOverflow(intOverflow, actual);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        public void RestXml_HttpBindings_WriteDecimalText()
        {
            var request = new RestXmlSvc.Model.HttpNumbersRequest
            {
                LabelByte = sbyte.MinValue,
                LabelShort = short.MaxValue,
                LabelBigInteger = BigInteger(BigIntegerText),
                LabelBigDecimal = BigDecimal(BigDecimalText),
                QueryBigDecimal = BigDecimal(DoubleLossyDecimalText),
                QueryShortList = new List<short> { 1, -2 },
                HeaderBigInteger = BigInteger(BigIntegerInMapText),
                HeaderBigDecimalList = new List<BigDecimal> { BigDecimal(BigDecimalText), BigDecimal("1E+3") },
                HeaderShortList = new List<short> { -1, 2 },
            };
            var config = new RestXmlSvc.AmazonNumericTypesRestXmlConfig { ServiceURL = "https://test.com/" };

            InNonInvariantCulture(() =>
            {
                var marshalled = ProtocolTestUtils.RunMockRequest(request, new RestXmlSvc.Model.Internal.MarshallTransformations.HttpNumbersRequestMarshaller(), config);

                var uri = AmazonServiceClient.ComposeUrl(marshalled);
                Assert.AreEqual($"/HttpNumbers/-128/32767/{BigIntegerText}/{BigDecimalText}", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(uri));
                var query = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(uri);
                CollectionAssert.Contains(query, "BigDecimal=" + DoubleLossyDecimalText);
                CollectionAssert.Contains(query, "ShortList=1");
                CollectionAssert.Contains(query, "ShortList=-2");
                Assert.AreEqual(BigIntegerInMapText, marshalled.Headers["X-BigInteger"]);
                Assert.AreEqual("1.50,1000", marshalled.Headers["X-BigDecimalList"]);
                Assert.AreEqual("-1,2", marshalled.Headers["X-ShortList"]);
            });
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        public async Task RestJson_ResponseHeaders_ReadEveryDigit()
        {
            var response = new MockHttpResponse { StatusCode = HttpStatusCode.OK, Body = Encoding.UTF8.GetBytes("{}") };
            response.Headers["Content-Type"] = "application/json";
            response.Headers["X-Byte"] = "-128";
            response.Headers["X-Short"] = "32767";
            response.Headers["X-BigInteger"] = BigIntegerText;
            response.Headers["X-BigDecimal"] = DoubleLossyDecimalText;
            response.Headers["X-ShortList"] = "1, -2";
            response.Headers["X-BigIntegerList"] = BigIntegerText + "," + BigIntegerInMapText;
            response.Headers["X-BigDecimalList"] = "1.50, 1E+3";
            var config = new RestJsonSvc.AmazonNumericTypesRestJsonConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new RestJsonSvc.AmazonNumericTypesRestJsonClient(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, response);

            var request = new RestJsonSvc.Model.HttpNumbersRequest
            {
                LabelByte = 1,
                LabelShort = 1,
                LabelBigInteger = System.Numerics.BigInteger.One,
                LabelBigDecimal = Amazon.Extensions.Numerics.BigDecimal.One,
            };
            var actual = await client.HttpNumbersAsync(request).ConfigureAwait(false);

            Assert.AreEqual(sbyte.MinValue, actual.HeaderByte);
            Assert.AreEqual(short.MaxValue, actual.HeaderShort);
            Assert.AreEqual(BigInteger(BigIntegerText), actual.HeaderBigInteger);
            Assert.AreEqual(DoubleLossyDecimalText, actual.HeaderBigDecimal.Value.ToPlainString(CultureInfo.InvariantCulture));
            CollectionAssert.AreEqual(new List<short> { 1, -2 }, actual.HeaderShortList);
            CollectionAssert.AreEqual(new List<BigInteger> { BigInteger(BigIntegerText), BigInteger(BigIntegerInMapText) }, actual.HeaderBigIntegerList);
            CollectionAssert.AreEqual(new[] { "1.50", "1E+3" }, actual.HeaderBigDecimalList.Select(d => d.ToString(CultureInfo.InvariantCulture)).ToArray());
        }

        private static XElement Child(XElement parent, string name) =>
            parent.Elements().Single(e => e.Name.LocalName == name);

        private static Dictionary<string, string> QueryParameters(IRequest marshalled) =>
            QueryTestUtils.ConvertBodyToParameters(Encoding.UTF8.GetString(marshalled.Content));

        private static MockHttpResponse XmlResponse(string body)
        {
            var response = new MockHttpResponse { StatusCode = HttpStatusCode.OK, Body = Encoding.UTF8.GetBytes(body) };
            response.Headers["Content-Type"] = "text/xml";
            return response;
        }
    }
}
