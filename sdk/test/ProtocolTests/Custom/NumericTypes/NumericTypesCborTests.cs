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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.Globalization;
using System.Net;
using System.Numerics;
using System.Threading.Tasks;
using static AWSSDK.ProtocolTests.NumericTypes.NumericTypesTestData;
using CborSvc = Amazon.NumericTypesCbor;

namespace AWSSDK.ProtocolTests.NumericTypes
{
    /// <summary>
    /// Full Numeric Type Support specification tests for Smithy RPC v2 CBOR: byte and short are CBOR integers, bigInteger is a
    /// bignum (tags 2/3) and bigDecimal a decimal fraction (tag 4), so no digits or scale are lost.
    /// </summary>
    [TestClass]
    public class NumericTypesCborTests
    {
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        public void RequestBody_UsesCborNumericEncodings()
        {
            var request = new CborSvc.Model.BodyNumbersRequest
            {
                ByteValue = sbyte.MinValue,
                ShortValue = short.MaxValue,
                BigIntegerValue = BigInteger(BigIntegerText),
                BigDecimalValue = BigDecimal(BigDecimalText),
                ShortList = new List<short> { -1, 2 },
                BigDecimalMap = new Dictionary<string, BigDecimal> { ["k"] = BigDecimal("1E+3") },
            };
            var config = new CborSvc.AmazonNumericTypesCborConfig { ServiceURL = "https://test.com/" };

            var marshalled = ProtocolTestUtils.RunMockRequest(request, new CborSvc.Model.Internal.MarshallTransformations.BodyNumbersRequestMarshaller(), config);

            var reader = new CborReader(marshalled.Content);
            var seen = new HashSet<string>();
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var key = reader.ReadTextString();
                seen.Add(key);
                switch (key)
                {
                    case "ByteValue":
                        Assert.AreEqual(CborReaderState.NegativeInteger, reader.PeekState());
                        Assert.AreEqual(-128, reader.ReadInt32());
                        break;
                    case "ShortValue":
                        Assert.AreEqual(CborReaderState.UnsignedInteger, reader.PeekState());
                        Assert.AreEqual(32767, reader.ReadInt32());
                        break;
                    case "BigIntegerValue":
                        Assert.AreEqual(CborTag.NegativeBigNum, reader.PeekTag());
                        Assert.AreEqual(BigInteger(BigIntegerText), reader.ReadBigInteger());
                        break;
                    case "BigDecimalValue":
                        AssertDecimalFraction(reader, -2, 150);
                        break;
                    case "ShortList":
                        Assert.AreEqual(2, reader.ReadStartArray());
                        Assert.AreEqual(-1, reader.ReadInt32());
                        Assert.AreEqual(2, reader.ReadInt32());
                        reader.ReadEndArray();
                        break;
                    case "BigDecimalMap":
                        reader.ReadStartMap();
                        Assert.AreEqual("k", reader.ReadTextString());
                        AssertDecimalFraction(reader, 3, 1);
                        reader.ReadEndMap();
                        break;
                    default:
                        Assert.Fail($"Unexpected key {key}");
                        break;
                }
            }
            reader.ReadEndMap();
            Assert.AreEqual(6, seen.Count);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        public async Task ResponseBody_ReadsEveryDigit()
        {
            var writer = new CborWriter();
            writer.WriteStartMap(null);
            writer.WriteTextString("ByteValue");
            writer.WriteInt32(-128);
            writer.WriteTextString("ShortValue");
            writer.WriteInt32(-32768);
            writer.WriteTextString("BigIntegerValue");
            writer.WriteBigInteger(BigInteger(BigIntegerText));
            writer.WriteTextString("BigDecimalValue");
            writer.WriteBigDecimal(BigDecimal(DoubleLossyDecimalText));
            writer.WriteTextString("BigIntegerList");
            writer.WriteStartArray(2);
            // A plain integer is accepted for bigInteger as well as a bignum.
            writer.WriteUInt64(ulong.MaxValue);
            writer.WriteBigInteger(BigInteger(BigIntegerInMapText));
            writer.WriteEndArray();
            writer.WriteTextString("Nested");
            writer.WriteStartMap(null);
            writer.WriteTextString("BigDecimalValue");
            writer.WriteBigDecimal(BigDecimal("123.4500"));
            writer.WriteEndMap();
            writer.WriteEndMap();

            var config = new CborSvc.AmazonNumericTypesCborConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new CborSvc.AmazonNumericTypesCborClient(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, CborResponse(writer.Encode()));

            var actual = await client.BodyNumbersAsync(new CborSvc.Model.BodyNumbersRequest()).ConfigureAwait(false);

            Assert.AreEqual(sbyte.MinValue, actual.ByteValue);
            Assert.AreEqual(short.MinValue, actual.ShortValue);
            Assert.AreEqual(BigInteger(BigIntegerText), actual.BigIntegerValue);
            Assert.AreEqual(DoubleLossyDecimalText, actual.BigDecimalValue.Value.ToPlainString(CultureInfo.InvariantCulture));
            CollectionAssert.AreEqual(new List<BigInteger> { new BigInteger(ulong.MaxValue), BigInteger(BigIntegerInMapText) }, actual.BigIntegerList);
            Assert.AreEqual("123.4500", actual.Nested.BigDecimalValue.Value.ToPlainString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [DataRow("ByteValue", 128)]
        [DataRow("ByteValue", -129)]
        [DataRow("ShortValue", 32768)]
        public async Task OutOfRangeByteOrShort_ThrowsSameExceptionAsIntOverflow(string member, int value)
        {
            var writer = new CborWriter();
            writer.WriteStartMap(1);
            writer.WriteTextString(member);
            writer.WriteInt32(value);
            writer.WriteEndMap();
            var config = new CborSvc.AmazonNumericTypesCborConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var client = new CborSvc.AmazonNumericTypesCborClient(MockHttpClientUtils.TestCredentials, config);
            MockHttpClientUtils.InjectMockHttp(client, CborResponse(writer.Encode()));
            var actual = await CaptureExceptionAsync(() => client.BodyNumbersAsync(new CborSvc.Model.BodyNumbersRequest())).ConfigureAwait(false);

            var intWriter = new CborWriter();
            intWriter.WriteStartMap(1);
            intWriter.WriteTextString("integerValue");
            intWriter.WriteInt64((long)int.MaxValue + 1);
            intWriter.WriteEndMap();
            var intConfig = new Amazon.RpcV2Protocol.AmazonRpcV2ProtocolConfig { ServiceURL = MockHttpClientUtils.TestServiceUrl, MaxErrorRetry = 0 };
            using var intClient = new Amazon.RpcV2Protocol.AmazonRpcV2ProtocolClient(MockHttpClientUtils.TestCredentials, intConfig);
            MockHttpClientUtils.InjectMockHttp(intClient, CborResponse(intWriter.Encode()));
            var intOverflow = await CaptureExceptionAsync(() => intClient.SimpleScalarPropertiesAsync(new Amazon.RpcV2Protocol.Model.SimpleScalarPropertiesRequest())).ConfigureAwait(false);

            AssertSameAsIntOverflow(intOverflow, actual);
        }

        private static void AssertDecimalFraction(CborReader reader, long exponent, long mantissa)
        {
            Assert.AreEqual(CborTag.DecimalFraction, reader.ReadTag());
            Assert.AreEqual(2, reader.ReadStartArray());
            Assert.AreEqual(exponent, reader.ReadInt64());
            Assert.AreEqual(mantissa, reader.ReadInt64());
            reader.ReadEndArray();
        }

        private static MockHttpResponse CborResponse(byte[] body)
        {
            var response = new MockHttpResponse { StatusCode = HttpStatusCode.OK, Body = body };
            response.Headers["Content-Type"] = "application/cbor";
            response.Headers["smithy-protocol"] = "rpc-v2-cbor";
            return response;
        }
    }
}
