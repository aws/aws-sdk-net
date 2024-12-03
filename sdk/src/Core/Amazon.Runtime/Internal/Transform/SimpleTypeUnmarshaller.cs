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
using System.Globalization;
using System.IO;
using System.Text.Json;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal.Transform
{
    static class SimpleTypeUnmarshaller<T>
    {
        public static T Unmarshall(XmlUnmarshallerContext context)
        {
            string text = context.ReadText();
            return (T)Convert.ChangeType(text, typeof(T), CultureInfo.InvariantCulture);
        }

        public static T Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);
            if (text == null)
                return default(T);

            return (T)Convert.ChangeType(text, typeof(T), CultureInfo.InvariantCulture);
        }
    }

    /// <summary>
    /// Unmarshaller for int fields
    /// </summary>
    public class IntUnmarshaller : IXmlUnmarshaller<int, XmlUnmarshallerContext>, IJsonUnmarshaller<int, JsonUnmarshallerContext>
    {
        private IntUnmarshaller() { }

        private static IntUnmarshaller _instance = new IntUnmarshaller();

        public static IntUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static IntUnmarshaller GetInstance()
        {
            return IntUnmarshaller.Instance;
        }

        public int Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<int>.Unmarshall(context);
        }
        public int Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return SimpleTypeUnmarshaller<int>.Unmarshall(context, ref reader);
        }
    }

    /// <summary>
    /// Unmarshaller for nullable int fields. Implemented only for JSON context
    /// to handle cases where value can be null e.g. {'Priority': null}.
    /// This unmarshaller is not implemented for XML context, as XML responses
    /// will null elements (xsi:nil='true') will be skipped by the XML parser.
    /// </summary>
    public class NullableIntUnmarshaller : IXmlUnmarshaller<int?, XmlUnmarshallerContext>, IJsonUnmarshaller<int?, JsonUnmarshallerContext>
    {   
        private NullableIntUnmarshaller() { }

        private static NullableIntUnmarshaller _instance = new NullableIntUnmarshaller();

        public static NullableIntUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static NullableIntUnmarshaller GetInstance()
        {
            return NullableIntUnmarshaller.Instance;
        }

        public int? Unmarshall(XmlUnmarshallerContext context)
        {
            context.Read();
            string text = context.ReadText();

            if (text == null)
            {
                return null;
            }
            return int.Parse(text, CultureInfo.InvariantCulture);
        }

        public int? Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);

            if (text == null)
            {
                return null;
            }
            return int.Parse(text, CultureInfo.InvariantCulture);
        }
    }

    /// <summary>
    /// Unmarshaller for long fields
    /// </summary>
    public class LongUnmarshaller : IXmlUnmarshaller<long, XmlUnmarshallerContext>, IJsonUnmarshaller<long, JsonUnmarshallerContext>
    {
        private LongUnmarshaller() { }

        private static LongUnmarshaller _instance = new LongUnmarshaller();

        public static LongUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static LongUnmarshaller GetInstance()
        {
            return LongUnmarshaller.Instance;
        }

        public long Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<long>.Unmarshall(context);
        }
        public long Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return SimpleTypeUnmarshaller<long>.Unmarshall(context, ref reader);
        }
    }

    public class NullableLongUnmarshaller : IXmlUnmarshaller<long?, XmlUnmarshallerContext>, IJsonUnmarshaller<long?, JsonUnmarshallerContext>
    {
        private NullableLongUnmarshaller() { }

        private static NullableLongUnmarshaller _instance = new NullableLongUnmarshaller();

        public static NullableLongUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public long? Unmarshall(XmlUnmarshallerContext context)
        {
            context.Read();
            string text = context.ReadText();

            if (text == null)
            {
                return null;
            }
            return long.Parse(text, CultureInfo.InvariantCulture);
        }

        public long? Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);

            if (text == null)
            {
                return null;
            }
            return long.Parse(text, CultureInfo.InvariantCulture);
        }
    }

    /// <summary>
    /// Unmarshaller for float fields
    /// </summary>
    public class FloatUnmarshaller : IXmlUnmarshaller<float, XmlUnmarshallerContext>, IJsonUnmarshaller<float, JsonUnmarshallerContext>
    {
        private FloatUnmarshaller() { }

        private static FloatUnmarshaller _instance = new FloatUnmarshaller();

        public static FloatUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static FloatUnmarshaller GetInstance()
        {
            return FloatUnmarshaller.Instance;
        }

        public float Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<float>.Unmarshall(context);
        }
        public float Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return SimpleTypeUnmarshaller<float>.Unmarshall(context, ref reader);
        }
    }

    /// <summary>
    /// Unmarshaller for float fields
    /// </summary>
    public class NullableFloatUnmarshaller : IXmlUnmarshaller<float?, XmlUnmarshallerContext>, IJsonUnmarshaller<float?, JsonUnmarshallerContext>
    {
        private NullableFloatUnmarshaller() { }

        private static NullableFloatUnmarshaller _instance = new NullableFloatUnmarshaller();

        public static NullableFloatUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public float? Unmarshall(XmlUnmarshallerContext context)
        {
            context.Read();
            string text = context.ReadText();

            if (text == null)
            {
                return null;
            }
            return float.Parse(text, CultureInfo.InvariantCulture);
        }

        public float? Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);

            if (text == null)
            {
                return null;
            }
            return float.Parse(text, CultureInfo.InvariantCulture);
        }

    }

    /// <summary>
    /// Unmarshaller for double fields
    /// </summary>
    public class DoubleUnmarshaller : IXmlUnmarshaller<double, XmlUnmarshallerContext>, IJsonUnmarshaller<double, JsonUnmarshallerContext>
    {
        private DoubleUnmarshaller() { }

        private static DoubleUnmarshaller _instance = new DoubleUnmarshaller();

        public static DoubleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }


        public static DoubleUnmarshaller GetInstance()
        {
            return DoubleUnmarshaller.Instance;
        }

        public double Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<double>.Unmarshall(context);
        }
        public double Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return SimpleTypeUnmarshaller<double>.Unmarshall(context, ref reader);
        }
    }

    /// <summary>
    /// Unmarshaller for double fields
    /// </summary>
    public class NullableDoubleUnmarshaller : IXmlUnmarshaller<double?, XmlUnmarshallerContext>, IJsonUnmarshaller<double?, JsonUnmarshallerContext>
    {
        private NullableDoubleUnmarshaller() { }

        private static NullableDoubleUnmarshaller _instance = new NullableDoubleUnmarshaller();

        public static NullableDoubleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public double? Unmarshall(XmlUnmarshallerContext context)
        {
            context.Read();
            string text = context.ReadText();

            if (text == null)
            {
                return null;
            }
            return double.Parse(text, CultureInfo.InvariantCulture);
        }

        public double? Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);

            if (text == null)
            {
                return null;
            }
            return double.Parse(text, CultureInfo.InvariantCulture);
        }
    }

    /// <summary>
    /// Unmarshaller for decimal fields
    /// </summary>
    public class DecimalUnmarshaller : IXmlUnmarshaller<decimal, XmlUnmarshallerContext>, IJsonUnmarshaller<decimal, JsonUnmarshallerContext>
    {
        private DecimalUnmarshaller() { }

        private static DecimalUnmarshaller _instance = new DecimalUnmarshaller();

        public static DecimalUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static DecimalUnmarshaller GetInstance()
        {
            return DecimalUnmarshaller.Instance;
        }

        public decimal Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<decimal>.Unmarshall(context);
        }
        public decimal Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return SimpleTypeUnmarshaller<decimal>.Unmarshall(context, ref reader);
        }
    }

    /// <summary>
    /// Unmarshaller for decimal fields
    /// </summary>
    public class NullableDecimalUnmarshaller : IXmlUnmarshaller<decimal?, XmlUnmarshallerContext>, IJsonUnmarshaller<decimal?, JsonUnmarshallerContext>
    {
        private NullableDecimalUnmarshaller() { }

        private static NullableDecimalUnmarshaller _instance = new NullableDecimalUnmarshaller();

        public static NullableDecimalUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public decimal? Unmarshall(XmlUnmarshallerContext context)
        {
            context.Read();
            string text = context.ReadText();

            if (text == null)
            {
                return null;
            }
            return decimal.Parse(text, CultureInfo.InvariantCulture);
        }

        public decimal? Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);

            if (text == null)
            {
                return null;
            }
            return decimal.Parse(text, CultureInfo.InvariantCulture);
        }
    }

    /// <summary>
    /// Unmarshaller for bool fields
    /// </summary>
    public class BoolUnmarshaller : IXmlUnmarshaller<bool, XmlUnmarshallerContext>, IJsonUnmarshaller<bool, JsonUnmarshallerContext>
    {
        private BoolUnmarshaller() { }

        private static BoolUnmarshaller _instance = new BoolUnmarshaller();

        public static BoolUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static BoolUnmarshaller GetInstance()
        {
            return BoolUnmarshaller.Instance;
        }

        public bool Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<bool>.Unmarshall(context);
        }
        public bool Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return SimpleTypeUnmarshaller<bool>.Unmarshall(context, ref reader);
        }
    }

    /// <summary>
    /// Unmarshaller for bool fields
    /// </summary>
    public class NullableBoolUnmarshaller : IXmlUnmarshaller<bool?, XmlUnmarshallerContext>, IJsonUnmarshaller<bool?, JsonUnmarshallerContext>
    {
        private NullableBoolUnmarshaller() { }

        private static NullableBoolUnmarshaller _instance = new NullableBoolUnmarshaller();

        public static NullableBoolUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public bool? Unmarshall(XmlUnmarshallerContext context)
        {
            context.Read();
            string text = context.ReadText();
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            return bool.Parse(text);
        }

        public bool? Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);
            if(string.IsNullOrEmpty(text))
            {
                return null;
            }

            return bool.Parse(text);
        }
    }

    /// <summary>
    /// Unmarshaller for string fields
    /// </summary>
    public class StringUnmarshaller : IXmlUnmarshaller<string, XmlUnmarshallerContext>, IJsonUnmarshaller<string, JsonUnmarshallerContext>
    {
        private StringUnmarshaller() { }

        private static StringUnmarshaller _instance = new StringUnmarshaller();

        public static StringUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static StringUnmarshaller GetInstance()
        {
            return StringUnmarshaller.Instance;
        }

        public string Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<string>.Unmarshall(context);
        }
        public string Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return SimpleTypeUnmarshaller<string>.Unmarshall(context, ref reader);
        }
    }

    /// <summary>
    /// Unmarshaller for byte fields
    /// </summary>
    public class ByteUnmarshaller : IXmlUnmarshaller<byte, XmlUnmarshallerContext>, IJsonUnmarshaller<byte, JsonUnmarshallerContext>
    {
        private ByteUnmarshaller() { }

        private static ByteUnmarshaller _instance = new ByteUnmarshaller();

        public static ByteUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static ByteUnmarshaller GetInstance()
        {
            return ByteUnmarshaller.Instance;
        }

        public byte Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<byte>.Unmarshall(context);
        }
        public byte Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return SimpleTypeUnmarshaller<byte>.Unmarshall(context, ref reader);
        }
    }

    /// <summary>
    /// Unmarshaller for DateTime fields
    /// </summary>
    public class DateTimeUnmarshaller : IXmlUnmarshaller<DateTime, XmlUnmarshallerContext>, IJsonUnmarshaller<DateTime, JsonUnmarshallerContext>
    {
        private DateTimeUnmarshaller() { }

        private static DateTimeUnmarshaller _instance = new DateTimeUnmarshaller();

        public static DateTimeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static DateTimeUnmarshaller GetInstance()
        {
            return DateTimeUnmarshaller.Instance;
        }

        public DateTime Unmarshall(XmlUnmarshallerContext context)
        {
            string text = context.ReadText();
            return UnmarshallInternal(text, treatAsNullable: false).Value;
        }

        public DateTime Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);
            return UnmarshallInternal(text, treatAsNullable: false).Value;
        }

        /// <summary>
        ///  Unmarshalls given string as a DateTime. Handles cases where we want to unmarshall 
        ///  as just a DateTime or a nullable Datetime.
        /// </summary>
        /// <param name="text">Value to be parsed</param>
        /// <param name="treatAsNullable">If true, the method will return null if text is null. 
        /// If false, the method will return default(DateTime), if text is null.</param>
        /// <returns></returns>
        internal static DateTime? UnmarshallInternal(string text, bool treatAsNullable)
        {
            Double seconds;
            if (Double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out seconds))
            {
                return AWSSDKUtils.EPOCH_START.AddSeconds(seconds);
            }
            else
            {
                if (text == null)
                {
                    if (treatAsNullable) { return null; }
                    else { return default(DateTime); }
                }

                return DateTime.Parse(text, CultureInfo.InvariantCulture);
            }
        }
    }

    /// <summary>
    /// Unmarshaller for nullable DateTime fields. Implemented only for JSON context
    /// to handle cases where value can be null e.g. {'Priority': null}.
    /// This unmarshaller is not implemented for XML context, as XML responses
    /// will null elements (xsi:nil='true') will be skipped by the XML parser.
    /// </summary>
    public class NullableDateTimeUnmarshaller : IXmlUnmarshaller<DateTime?, XmlUnmarshallerContext>, IJsonUnmarshaller<DateTime?, JsonUnmarshallerContext>
    {
        private NullableDateTimeUnmarshaller() { }

        private static NullableDateTimeUnmarshaller _instance = new NullableDateTimeUnmarshaller();

        public static NullableDateTimeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static NullableDateTimeUnmarshaller GetInstance()
        {
            return NullableDateTimeUnmarshaller.Instance;
        }

        public DateTime? Unmarshall(XmlUnmarshallerContext context)
        {
            string text = context.ReadText();
            return DateTimeUnmarshaller.UnmarshallInternal(text, treatAsNullable: true);
        }

        public DateTime? Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);
            return DateTimeUnmarshaller.UnmarshallInternal(text, treatAsNullable: true);
        }
    }

    public class DateTimeEpochLongMillisecondsUnmarshaller : IXmlUnmarshaller<DateTime, XmlUnmarshallerContext>, IJsonUnmarshaller<DateTime, JsonUnmarshallerContext>
    {
        private DateTimeEpochLongMillisecondsUnmarshaller() { }

        private static DateTimeEpochLongMillisecondsUnmarshaller _instance = new DateTimeEpochLongMillisecondsUnmarshaller();

        public static DateTimeEpochLongMillisecondsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static DateTimeEpochLongMillisecondsUnmarshaller GetInstance()
        {
            return DateTimeEpochLongMillisecondsUnmarshaller.Instance;
        }

        public DateTime Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<DateTime>.Unmarshall(context);
        }
        public DateTime Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            long millseconds = LongUnmarshaller.Instance.Unmarshall(context, ref reader);
            var ret = Amazon.Util.AWSSDKUtils.EPOCH_START.AddMilliseconds(millseconds);
            return ret;
        }
    }

    public class NullableDateTimeEpochLongMillisecondsUnmarshaller : IXmlUnmarshaller<DateTime?, XmlUnmarshallerContext>, IJsonUnmarshaller<DateTime?, JsonUnmarshallerContext>
    {
        private NullableDateTimeEpochLongMillisecondsUnmarshaller() { }

        private static NullableDateTimeEpochLongMillisecondsUnmarshaller _instance = new NullableDateTimeEpochLongMillisecondsUnmarshaller();

        public static NullableDateTimeEpochLongMillisecondsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public DateTime? Unmarshall(XmlUnmarshallerContext context)
        {
            context.Read();
            string text = context.ReadText();

            if (text == null)
            {
                return null;
            }

            long millseconds = long.Parse(text, CultureInfo.InvariantCulture);
            var ret = Amazon.Util.AWSSDKUtils.EPOCH_START.AddMilliseconds(millseconds);
            return ret;
        }

        public DateTime? Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            string text = context.ReadText(ref reader);

            if (text == null)
            {
                return null;
            }

            long millseconds = long.Parse(text, CultureInfo.InvariantCulture);
            var ret = Amazon.Util.AWSSDKUtils.EPOCH_START.AddMilliseconds(millseconds);
            return ret;
        }
    }

    /// <summary>
    /// Unmarshaller for MemoryStream fields
    /// </summary>
    public class MemoryStreamUnmarshaller : IXmlUnmarshaller<MemoryStream, XmlUnmarshallerContext>, IJsonUnmarshaller<MemoryStream, JsonUnmarshallerContext>
    {
        private MemoryStreamUnmarshaller() { }

        private static MemoryStreamUnmarshaller _instance = new MemoryStreamUnmarshaller();

        public static MemoryStreamUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static MemoryStreamUnmarshaller GetInstance()
        {
            return MemoryStreamUnmarshaller.Instance;
        }

        public MemoryStream Unmarshall(XmlUnmarshallerContext context)
        {
            byte[] bytes = Convert.FromBase64String(context.ReadText());
            MemoryStream stream = new MemoryStream(bytes, 0, bytes.Length, true, true);
            return stream;
        }

        public MemoryStream Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null)
                return null;

            byte[] bytes = Convert.FromBase64String(context.ReadText(ref reader));
            MemoryStream stream = new MemoryStream(bytes, 0, bytes.Length, true, true);
            return stream;
        }
    }

    /// <summary>
    /// Unmarshaller for ResponseMetadata
    /// </summary>
    public class ResponseMetadataUnmarshaller : IXmlUnmarshaller<ResponseMetadata, XmlUnmarshallerContext>, IJsonUnmarshaller<ResponseMetadata, JsonUnmarshallerContext>
    {
        private ResponseMetadataUnmarshaller() { }

        private static ResponseMetadataUnmarshaller _instance = new ResponseMetadataUnmarshaller();

        public static ResponseMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        public static ResponseMetadataUnmarshaller GetInstance()
        {
            return ResponseMetadataUnmarshaller.Instance;
        }

        public ResponseMetadata Unmarshall(XmlUnmarshallerContext context)
        {
            ResponseMetadata metadata = new ResponseMetadata();

            int depth = context.CurrentDepth;

            while (depth <= context.CurrentDepth)
            {
                context.Read();
                if (context.IsStartElement)
                {
                    if (context.TestExpression("ResponseMetadata/RequestId"))
                        metadata.RequestId = StringUnmarshaller.GetInstance().Unmarshall(context);
                    else
                        metadata.Metadata.Add(context.CurrentPath.Substring(context.CurrentPath.LastIndexOf('/') + 1), StringUnmarshaller.GetInstance().Unmarshall(context));
                }
            }

            return metadata;
        }
        public ResponseMetadata Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ResponseMetadata metadata = new ResponseMetadata();
            int depth = context.CurrentDepth;

            while (context.CurrentDepth >= depth)
            {
                context.Read(ref reader);
                if (context.TestExpression("ResponseMetadata/RequestId"))
                {
                    metadata.RequestId = StringUnmarshaller.GetInstance().Unmarshall(context, ref reader);
                }
            }

            return metadata;
        }
    }

    public class XmlKeyValueUnmarshaller<K, V, KUnmarshaller, VUnmarshaller> :
    IXmlUnmarshaller<KeyValuePair<K, V>, XmlUnmarshallerContext>
        where KUnmarshaller : IXmlUnmarshaller<K, XmlUnmarshallerContext>
        where VUnmarshaller : IXmlUnmarshaller<V, XmlUnmarshallerContext>
    {
        private KUnmarshaller keyUnmarshaller;
        private VUnmarshaller valueUnmarshaller;

        public XmlKeyValueUnmarshaller(KUnmarshaller keyUnmarshaller, VUnmarshaller valueUnmarshaller)
        {
            this.keyUnmarshaller = keyUnmarshaller;
            this.valueUnmarshaller = valueUnmarshaller;
        }

        public KeyValuePair<K, V> Unmarshall(XmlUnmarshallerContext context)
        {
            K key = default(K);
            V value = default(V);

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if (context.TestExpression("key", targetDepth))
                {
                    key = this.keyUnmarshaller.Unmarshall(context);
                }
                else if (context.TestExpression("name", targetDepth))
                {
                    key = this.keyUnmarshaller.Unmarshall(context);
                }
                else if (context.TestExpression("value", targetDepth))
                {
                    value = this.valueUnmarshaller.Unmarshall(context);
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    break;
                }
            }

            return new KeyValuePair<K, V>(key, value);
        }

    }

    public class JsonKeyValueUnmarshaller<K, V, KUnmarshaller, VUnmarshaller> :
        IJsonUnmarshaller<KeyValuePair<K, V>, JsonUnmarshallerContext>
        where KUnmarshaller : IJsonUnmarshaller<K, JsonUnmarshallerContext>
        where VUnmarshaller : IJsonUnmarshaller<V, JsonUnmarshallerContext>
    {
        private KUnmarshaller keyUnmarshaller;
        private VUnmarshaller valueUnmarshaller;

        public JsonKeyValueUnmarshaller(KUnmarshaller keyUnmarshaller, VUnmarshaller valueUnmarshaller)
        {
            this.keyUnmarshaller = keyUnmarshaller;
            this.valueUnmarshaller = valueUnmarshaller;
        }

        public KeyValuePair<K, V> Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            K key = this.keyUnmarshaller.Unmarshall(context, ref reader);
            V value = this.valueUnmarshaller.Unmarshall(context, ref reader);

            return new KeyValuePair<K, V>(key, value);
        }
    }

    public class XmlListUnmarshaller<T, TUnmarshaller> : IXmlUnmarshaller<List<T>, XmlUnmarshallerContext>
        where TUnmarshaller : IXmlUnmarshaller<T, XmlUnmarshallerContext>
    {
        private TUnmarshaller iUnmarshaller;

        public XmlListUnmarshaller(TUnmarshaller iUnmarshaller)
        {
            this.iUnmarshaller = iUnmarshaller;
        }

        public List<T> Unmarshall(XmlUnmarshallerContext context)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            var list = new List<T>();
            // If the list is nested, we don't want the current depth to be less than the original depth
            // because then, context.Read() will return true if there are more elements and all the
            // list's elements will be unmarshalled as one list instead of multiple nested lists.
            while (context.Read() && context.CurrentDepth >= originalDepth)
            {
                if (context.IsStartElement)
                {
                    if (context.TestExpression("member", targetDepth))
                    {
                        var item = iUnmarshaller.Unmarshall(context);
                        list.Add(item);
                    }
                }
            }
            return list;
        }
    }

    public class JsonListUnmarshaller<T, TUnmarshaller> : IJsonUnmarshaller<List<T>, JsonUnmarshallerContext>
        where TUnmarshaller : IJsonUnmarshaller<T, JsonUnmarshallerContext>
    {
        private TUnmarshaller iUnmarshaller;

        public JsonListUnmarshaller(TUnmarshaller iUnmarshaller)
        {
            this.iUnmarshaller = iUnmarshaller;
        }

        public List<T> Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader); // Read [ or null
            if (context.CurrentTokenType == JsonTokenType.Null)
            {
                if (AWSConfigs.InitializeCollections)
                    return new List<T>();
                else
                    return null;
            }

            // If a list is present in the response, use AlwaysSendList,
            // so if the response was empty, reusing the object in the request we will
            // end up sending the same empty collection back.
            List<T> list = new AlwaysSendList<T>();
            while (!context.Peek(JsonTokenType.EndArray, ref reader)) // Peek for ]
            {
                list.Add(iUnmarshaller.Unmarshall(context, ref reader));
            }
            context.Read(ref reader); // Read ]
            return list;
        }
    }


    public class XmlDictionaryUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller> : IXmlUnmarshaller<Dictionary<TKey, TValue>, XmlUnmarshallerContext>
        where TKeyUnmarshaller : IXmlUnmarshaller<TKey, XmlUnmarshallerContext>
        where TValueUnmarshaller : IXmlUnmarshaller<TValue, XmlUnmarshallerContext>
    {
        private XmlKeyValueUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller> KVUnmarshaller;

        public XmlDictionaryUnmarshaller(TKeyUnmarshaller kUnmarshaller, TValueUnmarshaller vUnmarshaller)
        {
            KVUnmarshaller = new XmlKeyValueUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller>(kUnmarshaller, vUnmarshaller);
        }                

        public Dictionary<TKey, TValue> Unmarshall(XmlUnmarshallerContext context)
        {
            var originalDepth = context.CurrentDepth;
            var targetDepth = originalDepth + 1;

            // If a dictionary is present in the response, use AlwaysSendDictionary,
            // so if the response was empty, reusing the object in the request we will
            // end up sending the same empty collection back.
            var dictionary = new AlwaysSendDictionary<TKey, TValue>();
            
            while (context.Read())
            {
                if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    break;
                }

                var item = KVUnmarshaller.Unmarshall(context);
                dictionary.Add(item.Key, item.Value);
            }                        
            
            return dictionary;
        }
    }

    public class JsonDictionaryUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller> : IJsonUnmarshaller<Dictionary<TKey, TValue>, JsonUnmarshallerContext>
        where TKeyUnmarshaller :IJsonUnmarshaller<TKey, JsonUnmarshallerContext>
        where TValueUnmarshaller : IJsonUnmarshaller<TValue, JsonUnmarshallerContext>
    {
        private JsonKeyValueUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller> KVUnmarshaller;

        public JsonDictionaryUnmarshaller(TKeyUnmarshaller kUnmarshaller, TValueUnmarshaller vUnmarshaller)
        {
            KVUnmarshaller = new JsonKeyValueUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller>(kUnmarshaller, vUnmarshaller);
        }

        public Dictionary<TKey, TValue> Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            context.Read(ref reader); // Read { or null
            if (context.CurrentTokenType == JsonTokenType.Null)
            {
                if (AWSConfigs.InitializeCollections)
                    return new Dictionary<TKey, TValue>();
                else
                    return null;
            }


            // If a dictionary is present in the response, use AlwaysSendDictionary,
            // so if the response was empty, reusing the object in the request we will
            // end up sending the same empty collection back.
            Dictionary<TKey, TValue> dictionary = new AlwaysSendDictionary<TKey, TValue>();
            while (!context.Peek(JsonTokenType.EndObject, ref reader)) // Peek }
            {
                KeyValuePair<TKey, TValue> item = KVUnmarshaller.Unmarshall(context, ref reader);
                dictionary.Add(item.Key, item.Value);
            }
            context.Read(ref reader); // Read }
            return dictionary;

        }
    }

    public static class UnmarshallerExtensions
    {
        public static void Add<TKey, TValue>(this Dictionary<TKey, TValue> dict, KeyValuePair<TKey, TValue> item)
        {
            dict.Add(item.Key, item.Value);
        }
        //public static void Add<T>(this List<T> list, List<T> items)
        //{
        //    list.AddRange(items);
        //}
    }
}
