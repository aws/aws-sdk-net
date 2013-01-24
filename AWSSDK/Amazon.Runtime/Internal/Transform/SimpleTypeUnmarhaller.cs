/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Text;
using System.Xml;
using System.Globalization;

namespace Amazon.Runtime.Internal.Transform
{
    static class SimpleTypeUnmarshaller<T>
    {
        public static T Unmarshall(XmlUnmarshallerContext context)
        {
            string text = context.ReadText();
            return (T)Convert.ChangeType(text, typeof(T), System.Globalization.CultureInfo.InvariantCulture);
        }

        public static T Unmarshall(JsonUnmarshallerContext context)
        {
            string text = context.ReadText();
            if (text == null)
                return default(T);

            return (T)Convert.ChangeType(text, typeof(T), System.Globalization.CultureInfo.InvariantCulture);
        }
    }

    /// <summary>
    /// Unmarshaller for int fields
    /// </summary>
    public class IntUnmarshaller : IUnmarshaller<int, XmlUnmarshallerContext>, IUnmarshaller<int, JsonUnmarshallerContext>
    {
        private static IntUnmarshaller instance;
        private IntUnmarshaller() { }

        public static IntUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new IntUnmarshaller();
            return instance;
        }

        public int Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<int>.Unmarshall(context);
        }
        public int Unmarshall(JsonUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<int>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for long fields
    /// </summary>
    public class LongUnmarshaller : IUnmarshaller<long, XmlUnmarshallerContext>, IUnmarshaller<long, JsonUnmarshallerContext>
    {
        private static LongUnmarshaller instance;
        private LongUnmarshaller() { }

        public static LongUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new LongUnmarshaller();
            return instance;
        }

        public long Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<long>.Unmarshall(context);
        }
        public long Unmarshall(JsonUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<long>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for float fields
    /// </summary>
    public class FloatUnmarshaller : IUnmarshaller<float, XmlUnmarshallerContext>, IUnmarshaller<float, JsonUnmarshallerContext>
    {
        private static FloatUnmarshaller instance;
        private FloatUnmarshaller() { }

        public static FloatUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new FloatUnmarshaller();
            return instance;
        }

        public float Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<float>.Unmarshall(context);
        }
        public float Unmarshall(JsonUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<float>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for double fields
    /// </summary>
    public class DoubleUnmarshaller : IUnmarshaller<double, XmlUnmarshallerContext>, IUnmarshaller<double, JsonUnmarshallerContext>
    {
        private static DoubleUnmarshaller instance;
        private DoubleUnmarshaller() { }

        public static DoubleUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new DoubleUnmarshaller();
            return instance;
        }

        public double Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<double>.Unmarshall(context);
        }
        public double Unmarshall(JsonUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<double>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for bool fields
    /// </summary>
    public class BoolUnmarshaller : IUnmarshaller<bool, XmlUnmarshallerContext>, IUnmarshaller<bool, JsonUnmarshallerContext>
    {
        private static BoolUnmarshaller instance;
        private BoolUnmarshaller() { }

        public static BoolUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new BoolUnmarshaller();
            return instance;
        }

        public bool Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<bool>.Unmarshall(context);
        }
        public bool Unmarshall(JsonUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<bool>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for string fields
    /// </summary>
    public class StringUnmarshaller : IUnmarshaller<string, XmlUnmarshallerContext>, IUnmarshaller<string, JsonUnmarshallerContext>
    {
        private static StringUnmarshaller instance;
        private StringUnmarshaller() { }

        public static StringUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new StringUnmarshaller();
            return instance;
        }

        public string Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<string>.Unmarshall(context);
        }
        public string Unmarshall(JsonUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<string>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for byte fields
    /// </summary>
    public class ByteUnmarshaller : IUnmarshaller<byte, XmlUnmarshallerContext>, IUnmarshaller<byte, JsonUnmarshallerContext>
    {
        private static ByteUnmarshaller instance;
        private ByteUnmarshaller() { }

        public static ByteUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new ByteUnmarshaller();
            return instance;
        }

        public byte Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<byte>.Unmarshall(context);
        }
        public byte Unmarshall(JsonUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<byte>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for DateTime fields
    /// </summary>
    public class DateTimeUnmarshaller : IUnmarshaller<DateTime, XmlUnmarshallerContext>, IUnmarshaller<DateTime, JsonUnmarshallerContext>
    {
        private static DateTimeUnmarshaller instance;
        private DateTimeUnmarshaller() { }

        public static DateTimeUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new DateTimeUnmarshaller();
            return instance;
        }

        public DateTime Unmarshall(XmlUnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<DateTime>.Unmarshall(context);
        }
        public DateTime Unmarshall(JsonUnmarshallerContext context)
        {
            DateTime ret;
            Double seconds;
            if (Double.TryParse(context.ReadText(), NumberStyles.Any, CultureInfo.InvariantCulture, out seconds))
            {
                ret = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                ret = ret.AddSeconds(seconds);
            }
            else
            {
                ret = SimpleTypeUnmarshaller<DateTime>.Unmarshall(context);
            }
            return ret;
        }
    }

    /// <summary>
    /// Unmarshaller for MemoryStream fields
    /// </summary>
    public class MemoryStreamUnmarshaller : IUnmarshaller<MemoryStream, XmlUnmarshallerContext>, IUnmarshaller<MemoryStream, JsonUnmarshallerContext>
    {
        private static MemoryStreamUnmarshaller instance;
        private MemoryStreamUnmarshaller() { }

        public static MemoryStreamUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new MemoryStreamUnmarshaller();
            return instance;
        }

        public MemoryStream Unmarshall(XmlUnmarshallerContext context)
        {
            byte[] bytes = Convert.FromBase64String(context.ReadText());
            MemoryStream stream = new MemoryStream(bytes);
            return stream;
        }
        public MemoryStream Unmarshall(JsonUnmarshallerContext context)
        {
            byte[] bytes = Convert.FromBase64String(context.ReadText());
            MemoryStream stream = new MemoryStream(bytes);
            return stream;
        }
    }

    /// <summary>
    /// Unmarshaller for ResponseMetadata
    /// </summary>
    public class ResponseMetadataUnmarshaller : IUnmarshaller<ResponseMetadata, XmlUnmarshallerContext>, IUnmarshaller<ResponseMetadata, JsonUnmarshallerContext>
    {
        private static ResponseMetadataUnmarshaller instance;
        private ResponseMetadataUnmarshaller() { }

        public static ResponseMetadataUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new ResponseMetadataUnmarshaller();
            return instance;
        }

        public ResponseMetadata Unmarshall(XmlUnmarshallerContext context)
        {
            ResponseMetadata metadata = new ResponseMetadata();
            
            context.Read();
            if (context.TestExpression("ResponseMetadata/RequestId"))
                metadata.RequestId = StringUnmarshaller.GetInstance().Unmarshall(context);

            return metadata;
        }
        public ResponseMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            ResponseMetadata metadata = new ResponseMetadata();
            int depth = context.CurrentDepth;

            while (depth == context.CurrentDepth)
            {
                context.Read();
                if (context.IsLeafValue && context.TestExpression("ResponseMetadata/RequestId"))
                {
                    metadata.RequestId = StringUnmarshaller.GetInstance().Unmarshall(context);
                }
            }

            return metadata;
        }
    }

    public class KeyValueUnmarshaller<K, V, KUnmarshaller, VUnmarshaller> :
    IUnmarshaller<KeyValuePair<K, V>, XmlUnmarshallerContext>, 
    IUnmarshaller<KeyValuePair<K, V>, JsonUnmarshallerContext>
        where KUnmarshaller : IUnmarshaller<K, XmlUnmarshallerContext>, IUnmarshaller<K, JsonUnmarshallerContext>
        where VUnmarshaller : IUnmarshaller<V, XmlUnmarshallerContext>, IUnmarshaller<V, JsonUnmarshallerContext>
    {
        private KUnmarshaller keyUnmarshaller;
        private VUnmarshaller valueUnmarshaller;

        public KeyValueUnmarshaller(KUnmarshaller keyUnmarshaller, VUnmarshaller valueUnmarshaller)
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
        public KeyValuePair<K, V> Unmarshall(JsonUnmarshallerContext context)
        {
            K key = this.keyUnmarshaller.Unmarshall(context);
            context.Read(); 
            context.Read(); 
            V value = this.valueUnmarshaller.Unmarshall(context);

            return new KeyValuePair<K, V>(key, value);
        }
    }

    public class ListUnmarshaller<I, IUnmarshaller> : IUnmarshaller<List<I>, XmlUnmarshallerContext>, IUnmarshaller<List<I>, JsonUnmarshallerContext>
        where IUnmarshaller : IUnmarshaller<I, XmlUnmarshallerContext>, IUnmarshaller<I, JsonUnmarshallerContext>
    {
        private IUnmarshaller iUnmarshaller;

        public ListUnmarshaller(IUnmarshaller iUnmarshaller)
        {
            this.iUnmarshaller = iUnmarshaller;
        }

        List<I> IUnmarshaller<List<I>,XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }
        public List<I> Unmarshall(JsonUnmarshallerContext context)
        {
            List<I> list = new List<I>();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth;

            while (context.Read())
            {
                if ((context.IsStartArray || context.IsStartElement || context.IsLeafArrayElement) && (context.CurrentDepth == targetDepth))
                {
                    list.Add(iUnmarshaller.Unmarshall(context));
                }
                else if (context.IsEndArray || (context.CurrentDepth < originalDepth))
                {
                    break;
                }
            }

            return list;
        }
    }

    public class DictionaryUnmarshaller<K, V, KUnmarshaller, VUnmarshaller> : IUnmarshaller<Dictionary<K,V>, XmlUnmarshallerContext>, IUnmarshaller<Dictionary<K, V>, JsonUnmarshallerContext>
        where KUnmarshaller : IUnmarshaller<K, XmlUnmarshallerContext>, IUnmarshaller<K, JsonUnmarshallerContext>
        where VUnmarshaller : IUnmarshaller<V, XmlUnmarshallerContext>, IUnmarshaller<V, JsonUnmarshallerContext>
    {
        private KeyValueUnmarshaller<K,V,KUnmarshaller,VUnmarshaller> KVUnmarshaller;

        public DictionaryUnmarshaller(KUnmarshaller kUnmarshaller, VUnmarshaller vUnmarshaller)
        {
            KVUnmarshaller = new KeyValueUnmarshaller<K,V,KUnmarshaller,VUnmarshaller>(kUnmarshaller,vUnmarshaller);
        }

        Dictionary<K, V> IUnmarshaller<Dictionary<K, V>, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }
        public Dictionary<K, V> Unmarshall(JsonUnmarshallerContext context)
        {
            Dictionary<K, V> dictionary = new Dictionary<K, V>();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth+1))
                {
                    KeyValuePair<K,V> item = KVUnmarshaller.Unmarshall(context);
                    dictionary.Add(item.Key, item.Value);
                }
                else if (context.IsEndElement || (context.CurrentDepth < originalDepth))
                {
                    break;
                }
            }

            return dictionary;
        }
    }
}
