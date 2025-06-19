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

using System;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.Linq;
using Amazon.Runtime.Internal;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.ProtocolTests.Utils
{
    internal static class CborProtocolUtils
    {
        public static void AssertBody(IRequest actualRequest, string expectedBody)
        {
            var expectedCbor = Convert.FromBase64String(expectedBody);
            var expectedObj = CborToNativeObject(expectedCbor);
            var actualObj = CborToNativeObject(actualRequest.Content);

            AssertObjectsEqual(expectedObj, actualObj);
        }

        private static object CborToNativeObject(byte[] cborBytes)
        {
            var reader = new CborReader(cborBytes);
            return ReadCborValue(reader);
        }

        private static object ReadCborValue(CborReader reader)
        {
            switch (reader.PeekState())
            {
                case CborReaderState.StartMap:
                    var map = new Dictionary<string, object>();
                    reader.ReadStartMap();
                    while (reader.PeekState() != CborReaderState.EndMap)
                    {
                        var key = ReadCborValue(reader).ToString();
                        var value = ReadCborValue(reader);
                        map[key] = value;
                    }
                    reader.ReadEndMap();
                    return map;

                case CborReaderState.StartArray:
                    var list = new List<object>();
                    reader.ReadStartArray();
                    while (reader.PeekState() != CborReaderState.EndArray)
                    {
                        list.Add(ReadCborValue(reader));
                    }
                    reader.ReadEndArray();
                    return list;

                case CborReaderState.TextString:
                    return reader.ReadTextString();

                case CborReaderState.ByteString:
                    return reader.ReadByteString();

                case CborReaderState.UnsignedInteger:
                    return reader.ReadUInt64();

                case CborReaderState.NegativeInteger:
                    return reader.ReadInt64();

                case CborReaderState.Boolean:
                    return reader.ReadBoolean();

                case CborReaderState.Null:
                    reader.ReadNull();
                    return null;

                case CborReaderState.DoublePrecisionFloat:
                    return reader.ReadDouble();

                case CborReaderState.SinglePrecisionFloat:
                case CborReaderState.HalfPrecisionFloat:
                    return (double)reader.ReadSingle();

                case CborReaderState.Tag:
                    var tag = reader.ReadTag();
                    if (tag == CborTag.UnixTimeSeconds)
                    {
                        var epochSeconds = Convert.ToDouble(ReadCborValue(reader));
                        return AWSSDKUtils.ConvertFromUnixDoubleEpochSeconds(epochSeconds);
                    }
                    throw new NotSupportedException($"Unsupported CBOR tag: {tag}");

                default:
                    throw new NotSupportedException($"Unsupported CBOR state: {reader.PeekState()}");
            }
        }

        private static void AssertObjectsEqual(object expected, object actual)
        {
            if (expected == null || actual == null)
            {
                Assert.AreEqual(expected, actual);
                return;
            }

            var expectedType = expected.GetType();
            var actualType = actual.GetType();

            Assert.AreEqual(expectedType, actualType);

            if (expectedType == typeof(byte[]))
            {
                var expectedBytes = (byte[])expected;
                var actualBytes = (byte[])actual;
                Assert.IsTrue(expectedBytes.SequenceEqual(actualBytes));
            }
            else if (expectedType == typeof(Dictionary<string, object>))
            {
                var expectedDict = (Dictionary<string, object>)expected;
                var actualDict = (Dictionary<string, object>)actual;

                Assert.AreEqual(expectedDict.Count, actualDict.Count);

                foreach (var key in expectedDict.Keys)
                {
                    Assert.IsTrue(actualDict.ContainsKey(key));
                    AssertObjectsEqual(expectedDict[key], actualDict[key]);
                }
            }
            else if (expectedType == typeof(List<object>))
            {
                var expectedList = (List<object>)expected;
                var actualList = (List<object>)actual;

                Assert.AreEqual(expectedList.Count, actualList.Count);

                for (int i = 0; i < expectedList.Count; i++)
                {
                    AssertObjectsEqual(expectedList[i], actualList[i]);
                }
            }
            else if (IsNumericType(expectedType))
            {
                // Normalize numeric types by converting both to double for comparison
                var expectedDouble = Convert.ToDouble(expected);
                var actualDouble = Convert.ToDouble(actual);
                Assert.AreEqual(expectedDouble, actualDouble);
            }
            else
            {
                Assert.AreEqual(expected, actual);
            }
        }

        private static bool IsNumericType(Type type)
        {
            return type == typeof(byte)
                || type == typeof(sbyte)
                || type == typeof(short)
                || type == typeof(ushort)
                || type == typeof(int)
                || type == typeof(uint)
                || type == typeof(long)
                || type == typeof(ulong)
                || type == typeof(float)
                || type == typeof(double)
                || type == typeof(decimal);
        }
    }
}
