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
using System.Globalization;
using System.IO;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Extensions.CborProtocol.Internal.Transform
{
    static class CborSimpleTypeUnmarshaller<T>
    {
        public static T Unmarshall(CborUnmarshallerContext context)
        {
            var reader = context.Reader;
            object value;

            if (
                (
                    typeof(T) == typeof(int?) ||
                    typeof(T) == typeof(long?) ||
                    typeof(T) == typeof(decimal?) ||
                    typeof(T) == typeof(double?) ||
                    typeof(T) == typeof(bool?) ||
                    typeof(T) == typeof(float?) ||
                    typeof(T) == typeof(string)
                )
                && reader.PeekState() == CborReaderState.Null
            )
            {
                reader.ReadNull();
                value = default(T);
            }
            else if (typeof(T) == typeof(string))
                value = reader.ReadTextString();
            else if (typeof(T) == typeof(int) || typeof(T) == typeof(int?))
                value = reader.ReadInt32();
            else if (typeof(T) == typeof(long) || typeof(T) == typeof(long?))
                value = reader.ReadInt64();
            else if (typeof(T) == typeof(decimal) || typeof(T) == typeof(decimal?))
                value = reader.ReadDecimal();
            else if (typeof(T) == typeof(bool) || typeof(T) == typeof(bool?))
                value = reader.ReadBoolean();
            else if (typeof(T) == typeof(double) || typeof(T) == typeof(double?))
            {
                var state = reader.PeekState();
                // CBOR values for doubles may sometimes be encoded as integers to save space
                // (e.g., when the original value was a whole number).
                if (state == CborReaderState.UnsignedInteger)
                {
                    value = (double)reader.ReadUInt64();
                }
                else if (state == CborReaderState.NegativeInteger)
                {
                    value = (double)reader.ReadInt64();
                }
                else
                {
                    value = reader.ReadDouble();
                }
            }
            else if (typeof(T) == typeof(float) || typeof(T) == typeof(float?))
            {
                var state = reader.PeekState();
                // CBOR values for floats may sometimes be encoded as integers to save space
                // (e.g., when the original value was a whole number).
                if (state == CborReaderState.UnsignedInteger)
                {
                    value = (float)reader.ReadUInt64();
                }
                else if (state == CborReaderState.NegativeInteger)
                {
                    value = (float)reader.ReadInt64();
                }
                else
                {
                    value = reader.ReadSingle();
                }
            }
            else if (typeof(T) == typeof(byte))
            {
                int result = reader.ReadInt32();
                if (result > byte.MaxValue)
                {
                    throw new OverflowException($"{result} value exceeds byte range.");
                }
                value = (byte)result;
            }
            else
                throw new NotSupportedException(
                    $"CBOR deserialization for type {typeof(T)} is not supported."
                );

            return (T)value;
        }
    }

    public class CborIntUnmarshaller : ICborUnmarshaller<int, CborUnmarshallerContext>
    {
        private CborIntUnmarshaller() { }

        private static CborIntUnmarshaller _instance = new CborIntUnmarshaller();

        public static CborIntUnmarshaller Instance
        {
            get { return _instance; }
        }

        public int Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<int>.Unmarshall(context);
        }
    }

    public class CborNullableIntUnmarshaller : ICborUnmarshaller<int?, CborUnmarshallerContext>
    {
        private CborNullableIntUnmarshaller() { }

        private static CborNullableIntUnmarshaller _instance = new CborNullableIntUnmarshaller();

        public static CborNullableIntUnmarshaller Instance
        {
            get { return _instance; }
        }

        public int? Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<int?>.Unmarshall(context);
        }
    }

    public class CborLongUnmarshaller : ICborUnmarshaller<long, CborUnmarshallerContext>
    {
        private CborLongUnmarshaller() { }

        private static CborLongUnmarshaller _instance = new CborLongUnmarshaller();

        public static CborLongUnmarshaller Instance
        {
            get { return _instance; }
        }

        public long Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<long>.Unmarshall(context);
        }
    }

    public class CborNullableLongUnmarshaller : ICborUnmarshaller<long?, CborUnmarshallerContext>
    {
        private CborNullableLongUnmarshaller() { }

        private static CborNullableLongUnmarshaller _instance = new CborNullableLongUnmarshaller();

        public static CborNullableLongUnmarshaller Instance
        {
            get { return _instance; }
        }

        public long? Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<long?>.Unmarshall(context);
        }
    }

    public class CborFloatUnmarshaller : ICborUnmarshaller<float, CborUnmarshallerContext>
    {
        private CborFloatUnmarshaller() { }

        private static CborFloatUnmarshaller _instance = new CborFloatUnmarshaller();

        public static CborFloatUnmarshaller Instance
        {
            get { return _instance; }
        }

        public float Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<float>.Unmarshall(context);
        }
    }

    public class CborNullableFloatUnmarshaller : ICborUnmarshaller<float?, CborUnmarshallerContext>
    {
        private CborNullableFloatUnmarshaller() { }

        private static CborNullableFloatUnmarshaller _instance =
            new CborNullableFloatUnmarshaller();

        public static CborNullableFloatUnmarshaller Instance
        {
            get { return _instance; }
        }

        public float? Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<float?>.Unmarshall(context);
        }
    }

    public class CborDoubleUnmarshaller : ICborUnmarshaller<double, CborUnmarshallerContext>
    {
        private CborDoubleUnmarshaller() { }

        private static CborDoubleUnmarshaller _instance = new CborDoubleUnmarshaller();

        public static CborDoubleUnmarshaller Instance
        {
            get { return _instance; }
        }

        public double Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<double>.Unmarshall(context);
        }
    }

    public class CborNullableDoubleUnmarshaller
        : ICborUnmarshaller<double?, CborUnmarshallerContext>
    {
        private CborNullableDoubleUnmarshaller() { }

        private static CborNullableDoubleUnmarshaller _instance =
            new CborNullableDoubleUnmarshaller();

        public static CborNullableDoubleUnmarshaller Instance
        {
            get { return _instance; }
        }

        public double? Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<double?>.Unmarshall(context);
        }
    }

    public class CborDecimalUnmarshaller : ICborUnmarshaller<decimal, CborUnmarshallerContext>
    {
        private CborDecimalUnmarshaller() { }

        private static CborDecimalUnmarshaller _instance = new CborDecimalUnmarshaller();

        public static CborDecimalUnmarshaller Instance
        {
            get { return _instance; }
        }

        public decimal Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<decimal>.Unmarshall(context);
        }
    }

    public class CborNullableDecimalUnmarshaller
        : ICborUnmarshaller<decimal?, CborUnmarshallerContext>
    {
        private CborNullableDecimalUnmarshaller() { }

        private static CborNullableDecimalUnmarshaller _instance =
            new CborNullableDecimalUnmarshaller();

        public static CborNullableDecimalUnmarshaller Instance
        {
            get { return _instance; }
        }

        public decimal? Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<decimal?>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for bool fields
    /// </summary>
    public class CborBoolUnmarshaller : ICborUnmarshaller<bool, CborUnmarshallerContext>
    {
        private CborBoolUnmarshaller() { }

        private static CborBoolUnmarshaller _instance = new CborBoolUnmarshaller();

        public static CborBoolUnmarshaller Instance
        {
            get { return _instance; }
        }

        public bool Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<bool>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for bool fields
    /// </summary>
    public class CborNullableBoolUnmarshaller : ICborUnmarshaller<bool?, CborUnmarshallerContext>
    {
        private CborNullableBoolUnmarshaller() { }

        private static CborNullableBoolUnmarshaller _instance = new CborNullableBoolUnmarshaller();

        public static CborNullableBoolUnmarshaller Instance
        {
            get { return _instance; }
        }

        public bool? Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<bool?>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for string fields
    /// </summary>
    public class CborStringUnmarshaller : ICborUnmarshaller<string, CborUnmarshallerContext>
    {
        private CborStringUnmarshaller() { }

        private static CborStringUnmarshaller _instance = new CborStringUnmarshaller();

        public static CborStringUnmarshaller Instance
        {
            get { return _instance; }
        }

        public string Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<string>.Unmarshall(context);
        }
    }

    public class CborByteUnmarshaller : ICborUnmarshaller<byte, CborUnmarshallerContext>
    {
        private CborByteUnmarshaller() { }

        private static CborByteUnmarshaller _instance = new CborByteUnmarshaller();

        public static CborByteUnmarshaller Instance
        {
            get { return _instance; }
        }

        public byte Unmarshall(CborUnmarshallerContext context)
        {
            return CborSimpleTypeUnmarshaller<byte>.Unmarshall(context);
        }
    }

    public class CborDateTimeUnmarshaller : ICborUnmarshaller<DateTime, CborUnmarshallerContext>
    {
        private CborDateTimeUnmarshaller() { }

        private static CborDateTimeUnmarshaller _instance = new CborDateTimeUnmarshaller();

        public static CborDateTimeUnmarshaller Instance
        {
            get { return _instance; }
        }

        public DateTime Unmarshall(CborUnmarshallerContext context)
        {
            var tag = context.Reader.ReadTag();
            if (tag == CborTag.UnixTimeSeconds)
            {
                var epochSeconds = CborSimpleTypeUnmarshaller<double>.Unmarshall(context);
                return AWSSDKUtils.ConvertFromUnixDoubleEpochSeconds(epochSeconds);
            }
            throw new NotSupportedException($"Unsupported CBOR tag: {tag}");
        }
    }

    public class CborNullableDateTimeUnmarshaller
        : ICborUnmarshaller<DateTime?, CborUnmarshallerContext>
    {
        private CborNullableDateTimeUnmarshaller() { }

        private static CborNullableDateTimeUnmarshaller _instance =
            new CborNullableDateTimeUnmarshaller();

        public static CborNullableDateTimeUnmarshaller Instance
        {
            get { return _instance; }
        }

        public DateTime? Unmarshall(CborUnmarshallerContext context)
        {
            if (context.Reader.PeekState() == CborReaderState.Null)
            {
                context.Reader.ReadNull();
                return null;
            }
            return CborDateTimeUnmarshaller.Instance.Unmarshall(context);
        }
    }

    public class CborNullableDateTimeEpochLongMillisecondsUnmarshaller
        : ICborUnmarshaller<DateTime?, CborUnmarshallerContext>
    {

        private CborNullableDateTimeEpochLongMillisecondsUnmarshaller() { }

        private static CborNullableDateTimeEpochLongMillisecondsUnmarshaller _instance =
            new CborNullableDateTimeEpochLongMillisecondsUnmarshaller();

        public static CborNullableDateTimeEpochLongMillisecondsUnmarshaller Instance
        {
            get { return _instance; }
        }

        public DateTime? Unmarshall(CborUnmarshallerContext context)
        {
            if (context.Reader.PeekState() == CborReaderState.Null)
            {
                context.Reader.ReadNull();
                return null;
            }
            var millseconds =  CborLongUnmarshaller.Instance.Unmarshall(context);
            var ret = Amazon.Util.AWSSDKUtils.EPOCH_START.AddMilliseconds(millseconds);
            return ret;
        }
    }

    public class CborMemoryStreamUnmarshaller
        : ICborUnmarshaller<MemoryStream, CborUnmarshallerContext>
    {
        private CborMemoryStreamUnmarshaller() { }

        private static CborMemoryStreamUnmarshaller _instance = new CborMemoryStreamUnmarshaller();

        public static CborMemoryStreamUnmarshaller Instance
        {
            get { return _instance; }
        }

        public MemoryStream Unmarshall(CborUnmarshallerContext context)
        {
            if (context.Reader.PeekState() == CborReaderState.Null)
            {
                context.Reader.ReadNull();
                return null;
            }

            var bytes = context.Reader.ReadByteString();
            MemoryStream stream = new MemoryStream(bytes, 0, bytes.Length, true, true);
            return stream;
        }
    }

    /// <summary>
    /// Unmarshaller for ResponseMetadata
    /// </summary>
    public class CborResponseMetadataUnmarshaller
        : ICborUnmarshaller<ResponseMetadata, CborUnmarshallerContext>
    {
        private CborResponseMetadataUnmarshaller() { }

        private static CborResponseMetadataUnmarshaller _instance =
            new CborResponseMetadataUnmarshaller();

        public static CborResponseMetadataUnmarshaller Instance
        {
            get { return _instance; }
        }

        public ResponseMetadata Unmarshall(CborUnmarshallerContext context)
        {
            var metadata = new ResponseMetadata();
            var reader = context.Reader;
            reader.ReadStartMap();

            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();

                switch (propertyName)
                {
                    case "RequestId":
                        metadata.RequestId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }

            reader.ReadEndMap();
            return metadata;
        }
    }

    public class CborKeyValueUnmarshaller<K, V, KUnmarshaller, VUnmarshaller>
        : ICborUnmarshaller<KeyValuePair<K, V>, CborUnmarshallerContext>
        where KUnmarshaller : ICborUnmarshaller<K, CborUnmarshallerContext>
        where VUnmarshaller : ICborUnmarshaller<V, CborUnmarshallerContext>
    {
        private readonly KUnmarshaller keyUnmarshaller;
        private readonly VUnmarshaller valueUnmarshaller;

        public CborKeyValueUnmarshaller(
            KUnmarshaller keyUnmarshaller,
            VUnmarshaller valueUnmarshaller
        )
        {
            this.keyUnmarshaller = keyUnmarshaller;
            this.valueUnmarshaller = valueUnmarshaller;
        }

        public KeyValuePair<K, V> Unmarshall(CborUnmarshallerContext context)
        {
            var key = keyUnmarshaller.Unmarshall(context);
            var value = valueUnmarshaller.Unmarshall(context);
            return new KeyValuePair<K, V>(key, value);
        }
    }

    public class CborListUnmarshaller<T, TUnmarshaller>
        : ICborUnmarshaller<List<T>, CborUnmarshallerContext>
        where TUnmarshaller : ICborUnmarshaller<T, CborUnmarshallerContext>
    {
        private readonly TUnmarshaller itemUnmarshaller;

        public CborListUnmarshaller(TUnmarshaller itemUnmarshaller)
        {
            this.itemUnmarshaller = itemUnmarshaller;
        }

        public List<T> Unmarshall(CborUnmarshallerContext context)
        {
            var reader = context.Reader;

            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return AWSConfigs.InitializeCollections ? new List<T>() : null;
            }

            reader.ReadStartArray();
            var list = new AlwaysSendList<T>();

            while (reader.PeekState() != CborReaderState.EndArray)
            {
                list.Add(itemUnmarshaller.Unmarshall(context));
            }

            reader.ReadEndArray();
            return list;
        }
    }

    public class CborDictionaryUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller>
        : ICborUnmarshaller<Dictionary<TKey, TValue>, CborUnmarshallerContext>
        where TKeyUnmarshaller : ICborUnmarshaller<TKey, CborUnmarshallerContext>
        where TValueUnmarshaller : ICborUnmarshaller<TValue, CborUnmarshallerContext>
    {
        private readonly CborKeyValueUnmarshaller<
            TKey,
            TValue,
            TKeyUnmarshaller,
            TValueUnmarshaller
        > kvUnmarshaller;

        public CborDictionaryUnmarshaller(
            TKeyUnmarshaller keyUnmarshaller,
            TValueUnmarshaller valueUnmarshaller
        )
        {
            kvUnmarshaller = new CborKeyValueUnmarshaller<
                TKey,
                TValue,
                TKeyUnmarshaller,
                TValueUnmarshaller
            >(keyUnmarshaller, valueUnmarshaller);
        }

        public Dictionary<TKey, TValue> Unmarshall(CborUnmarshallerContext context)
        {
            var reader = context.Reader;

            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return AWSConfigs.InitializeCollections ? new Dictionary<TKey, TValue>() : null;
            }

            reader.ReadStartMap();
            var dictionary = new AlwaysSendDictionary<TKey, TValue>();

            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var pair = kvUnmarshaller.Unmarshall(context);

                if (pair.Value != null)
                    dictionary.Add(pair.Key, pair.Value);
            }

            reader.ReadEndMap();
            return dictionary;
        }
    }
}
