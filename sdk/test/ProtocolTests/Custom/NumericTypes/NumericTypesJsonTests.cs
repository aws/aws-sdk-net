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
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon.Extensions.Numerics;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static AWSSDK.ProtocolTests.NumericTypes.NumericTypesTestData;
using JsonSvc = Amazon.NumericTypesJson;
using RestJsonSvc = Amazon.NumericTypesRestJson;

namespace AWSSDK.ProtocolTests.NumericTypes
{
    /// <summary>
    /// Full Numeric Type Support specification tests for awsJson1.1 and restJson1: byte, short, bigInteger and bigDecimal
    /// are JSON numbers, written and read without losing digits or scale.
    /// </summary>
    [TestClass]
    public class NumericTypesJsonTests
    {
        private const string ResponseBody = "{"
            + "\"ByteValue\":-128,"
            + "\"ShortValue\":-32768,"
            + "\"BigIntegerValue\":" + DoubleLossyIntegerText + ","
            + "\"BigDecimalValue\":" + DoubleLossyDecimalText + ","
            + "\"ByteList\":[-128,127],"
            + "\"ShortMap\":{\"k\":32767},"
            + "\"BigIntegerList\":[" + BigIntegerText + ",0],"
            + "\"BigIntegerMap\":{\"k\":" + BigIntegerInMapText + "},"
            + "\"BigDecimalList\":[1.50,1E+3,-0.0],"
            + "\"BigDecimalMap\":{\"k\":\"123.4500\"},"
            + "\"Nested\":{\"BigDecimalValue\":" + NestedBigDecimalText + ",\"ByteValue\":\"7\"}"
            + "}";

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        public void AwsJson_RequestBody_WritesEveryDigit()
        {
            var request = new JsonSvc.Model.BodyNumbersRequest
            {
                ByteValue = sbyte.MinValue,
                ShortValue = short.MaxValue,
                BigIntegerValue = BigInteger(BigIntegerText),
                BigDecimalValue = BigDecimal(BigDecimalText),
                ByteList = new List<sbyte> { -128, 127 },
                ShortMap = new Dictionary<string, short> { ["k"] = short.MinValue },
                BigIntegerMap = new Dictionary<string, BigInteger> { ["k"] = BigInteger(BigIntegerInMapText) },
                BigDecimalList = new List<BigDecimal> { BigDecimal("1E-39"), BigDecimal("1E+3") },
                Nested = new JsonSvc.Model.NestedNumbers { BigDecimalValue = BigDecimal(NestedBigDecimalText) },
            };
            var config = new JsonSvc.AmazonNumericTypesJsonConfig { ServiceURL = "https://test.com/" };

            var marshalled = ProtocolTestUtils.RunMockRequest(request, new JsonSvc.Model.Internal.MarshallTransformations.BodyNumbersRequestMarshaller(), config);

            AssertRequestBody(marshalled);
            Assert.AreEqual("NumericTypesJson.BodyNumbers", marshalled.Headers["X-Amz-Target"]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        public void RestJson_RequestBody_WritesEveryDigit()
        {
            var request = new RestJsonSvc.Model.BodyNumbersRequest
            {
                ByteValue = sbyte.MinValue,
                ShortValue = short.MaxValue,
                BigIntegerValue = BigInteger(BigIntegerText),
                BigDecimalValue = BigDecimal(BigDecimalText),
                ByteList = new List<sbyte> { -128, 127 },
                ShortMap = new Dictionary<string, short> { ["k"] = short.MinValue },
                BigIntegerMap = new Dictionary<string, BigInteger> { ["k"] = BigInteger(BigIntegerInMapText) },
                BigDecimalList = new List<BigDecimal> { BigDecimal("1E-39"), BigDecimal("1E+3") },
                Nested = new RestJsonSvc.Model.NestedNumbers { BigDecimalValue = BigDecimal(NestedBigDecimalText) },
            };
            var config = new RestJsonSvc.AmazonNumericTypesRestJsonConfig { ServiceURL = "https://test.com/" };

            var marshalled = ProtocolTestUtils.RunMockRequest(request, new RestJsonSvc.Model.Internal.MarshallTransformations.BodyNumbersRequestMarshaller(), config);

            AssertRequestBody(marshalled);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        public void RestJson_RequestBody_IgnoresCurrentCulture()
        {
            InNonInvariantCulture(RestJson_RequestBody_WritesEveryDigit);
        }

        private static void AssertRequestBody(IRequest marshalled)
        {
            using (var document = JsonDocument.Parse(Encoding.UTF8.GetString(marshalled.Content)))
            {
                var root = document.RootElement;
                // GetRawText is the exact token on the wire, so a lost digit, a lost trailing zero, a culture-specific
                // minus sign or a string token would all fail here.
                Assert.AreEqual("-128", root.GetProperty("ByteValue").GetRawText());
                Assert.AreEqual("32767", root.GetProperty("ShortValue").GetRawText());
                Assert.AreEqual(BigIntegerText, root.GetProperty("BigIntegerValue").GetRawText());
                Assert.AreEqual(BigDecimalText, root.GetProperty("BigDecimalValue").GetRawText());
                Assert.AreEqual("[-128,127]", root.GetProperty("ByteList").GetRawText());
                Assert.AreEqual("{\"k\":-32768}", root.GetProperty("ShortMap").GetRawText());
                Assert.AreEqual("{\"k\":" + BigIntegerInMapText + "}", root.GetProperty("BigIntegerMap").GetRawText());
                Assert.AreEqual("[0.000000000000000000000000000000000000001,1000]", root.GetProperty("BigDecimalList").GetRawText());
                Assert.AreEqual(NestedBigDecimalText, root.GetProperty("Nested").GetProperty("BigDecimalValue").GetRawText());
                Assert.IsFalse(root.TryGetProperty("BigDecimalMap", out _), "Unset members are not sent.");
            }
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        public async Task AwsJson_ResponseBody_ReadsEveryDigit()
        {
            var config = new JsonSvc.AmazonNumericTypesJsonConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new JsonSvc.AmazonNumericTypesJsonClient(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, JsonResponse(ResponseBody, "application/x-amz-json-1.1"));

            var actual = await client.BodyNumbersAsync(new JsonSvc.Model.BodyNumbersRequest()).ConfigureAwait(false);

            var expected = new JsonSvc.Model.BodyNumbersResponse
            {
                ByteValue = sbyte.MinValue,
                ShortValue = short.MinValue,
                BigIntegerValue = BigInteger(DoubleLossyIntegerText),
                BigDecimalValue = BigDecimal(DoubleLossyDecimalText),
                ByteList = new List<sbyte> { -128, 127 },
                ShortMap = new Dictionary<string, short> { ["k"] = short.MaxValue },
                BigIntegerList = new List<BigInteger> { BigInteger(BigIntegerText), System.Numerics.BigInteger.Zero },
                BigIntegerMap = new Dictionary<string, BigInteger> { ["k"] = BigInteger(BigIntegerInMapText) },
                BigDecimalList = new List<BigDecimal> { BigDecimal("1.50"), BigDecimal("1E+3"), BigDecimal("-0.0") },
                BigDecimalMap = new Dictionary<string, BigDecimal> { ["k"] = BigDecimal("123.4500") },
                Nested = new JsonSvc.Model.NestedNumbers { BigDecimalValue = BigDecimal(NestedBigDecimalText), ByteValue = 7 },
            };
            Comparer.CompareObjects<JsonSvc.Model.BodyNumbersResponse>(expected, actual);
            Assert.AreEqual(DoubleLossyDecimalText, actual.BigDecimalValue.Value.ToPlainString(System.Globalization.CultureInfo.InvariantCulture));
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        public async Task RestJson_ResponseBody_ReadsEveryDigit()
        {
            var config = new RestJsonSvc.AmazonNumericTypesRestJsonConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new RestJsonSvc.AmazonNumericTypesRestJsonClient(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, JsonResponse(ResponseBody, "application/json"));

            var actual = await client.BodyNumbersAsync(new RestJsonSvc.Model.BodyNumbersRequest()).ConfigureAwait(false);

            Assert.AreEqual(sbyte.MinValue, actual.ByteValue);
            Assert.AreEqual(short.MinValue, actual.ShortValue);
            Assert.AreEqual(BigInteger(DoubleLossyIntegerText), actual.BigIntegerValue);
            Assert.AreEqual(DoubleLossyDecimalText, actual.BigDecimalValue.Value.ToPlainString(System.Globalization.CultureInfo.InvariantCulture));
            Assert.AreEqual(BigInteger(BigIntegerText), actual.BigIntegerList[0]);
            Assert.AreEqual("123.4500", actual.BigDecimalMap["k"].ToPlainString(System.Globalization.CultureInfo.InvariantCulture));
            Assert.AreEqual((sbyte)7, actual.Nested.ByteValue);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [DataRow("{\"ByteValue\":128}")]
        [DataRow("{\"ByteValue\":-129}")]
        [DataRow("{\"ShortValue\":32768}")]
        [DataRow("{\"ShortList\":[-32769]}")]
        [DataRow("{\"Nested\":{\"ByteValue\":200}}")]
        public async Task OutOfRangeByteOrShort_ThrowsSameExceptionAsIntOverflow(string body)
        {
            var config = new RestJsonSvc.AmazonNumericTypesRestJsonConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new RestJsonSvc.AmazonNumericTypesRestJsonClient(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, JsonResponse(body, "application/json"));

            var actual = await CaptureExceptionAsync(() => client.BodyNumbersAsync(new RestJsonSvc.Model.BodyNumbersRequest())).ConfigureAwait(false);

            var intConfig = new Amazon.RestJsonProtocol.AmazonRestJsonProtocolConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var intClient = new Amazon.RestJsonProtocol.AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, intConfig);
            MockHttpClientUtils.InjectMockHttp(intClient, JsonResponse("{\"integerValue\":2147483648}", "application/json"));
            var intOverflow = await CaptureExceptionAsync(() => intClient.SimpleScalarPropertiesAsync(new Amazon.RestJsonProtocol.Model.SimpleScalarPropertiesRequest())).ConfigureAwait(false);

            AssertSameAsIntOverflow(intOverflow, actual);
            Assert.IsInstanceOfType(actual, typeof(AmazonUnmarshallingException));
        }

        private static MockHttpResponse JsonResponse(string body, string contentType)
        {
            var response = new MockHttpResponse
            {
                StatusCode = HttpStatusCode.OK,
                Body = Encoding.UTF8.GetBytes(body),
            };
            response.Headers["Content-Type"] = contentType;
            return response;
        }
    }
}
