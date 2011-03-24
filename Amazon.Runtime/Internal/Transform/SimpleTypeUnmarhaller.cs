/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Runtime.Internal.Transform
{
    static class SimpleTypeUnmarshaller<T>
    {
        public static T Unmarshall(UnmarshallerContext context)
        {
            string text = context.ReadText();
            return (T)Convert.ChangeType(text, typeof(T), System.Globalization.CultureInfo.InvariantCulture);
        }
    }

    /// <summary>
    /// Unmarshaller for int fields
    /// </summary>
    public class IntUnmarshaller : IUnmarshaller<int, UnmarshallerContext>
    {
        private static IntUnmarshaller instance;
        private IntUnmarshaller() { }

        public static IntUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new IntUnmarshaller();
            return instance;
        }

        public int Unmarshall(UnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<int>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for long fields
    /// </summary>
    public class LongUnmarshaller : IUnmarshaller<long, UnmarshallerContext>
    {
        private static LongUnmarshaller instance;
        private LongUnmarshaller() { }

        public static LongUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new LongUnmarshaller();
            return instance;
        }

        public long Unmarshall(UnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<long>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for float fields
    /// </summary>
    public class FloatUnmarshaller : IUnmarshaller<float, UnmarshallerContext>
    {
        private static FloatUnmarshaller instance;
        private FloatUnmarshaller() { }

        public static FloatUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new FloatUnmarshaller();
            return instance;
        }

        public float Unmarshall(UnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<float>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for double fields
    /// </summary>
    public class DoubleUnmarshaller : IUnmarshaller<double, UnmarshallerContext>
    {
        private static DoubleUnmarshaller instance;
        private DoubleUnmarshaller() { }

        public static DoubleUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new DoubleUnmarshaller();
            return instance;
        }

        public double Unmarshall(UnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<double>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for bool fields
    /// </summary>
    public class BoolUnmarshaller : IUnmarshaller<bool, UnmarshallerContext>
    {
        private static BoolUnmarshaller instance;
        private BoolUnmarshaller() { }

        public static BoolUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new BoolUnmarshaller();
            return instance;
        }

        public bool Unmarshall(UnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<bool>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for string fields
    /// </summary>
    public class StringUnmarshaller : IUnmarshaller<string, UnmarshallerContext>
    {
        private static StringUnmarshaller instance;
        private StringUnmarshaller() { }

        public static StringUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new StringUnmarshaller();
            return instance;
        }

        public string Unmarshall(UnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<string>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for byte fields
    /// </summary>
    public class ByteUnmarshaller : IUnmarshaller<byte, UnmarshallerContext>
    {
        private static ByteUnmarshaller instance;
        private ByteUnmarshaller() { }

        public static ByteUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new ByteUnmarshaller();
            return instance;
        }

        public byte Unmarshall(UnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<byte>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for DateTime fields
    /// </summary>
    public class DateTimeUnmarshaller : IUnmarshaller<DateTime, UnmarshallerContext>
    {
        private static DateTimeUnmarshaller instance;
        private DateTimeUnmarshaller() { }

        public static DateTimeUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new DateTimeUnmarshaller();
            return instance;
        }

        public DateTime Unmarshall(UnmarshallerContext context)
        {
            return SimpleTypeUnmarshaller<DateTime>.Unmarshall(context);
        }
    }

    /// <summary>
    /// Unmarshaller for MemoryStream fields
    /// </summary>
    public class MemoryStreamUnmarshaller : IUnmarshaller<MemoryStream, UnmarshallerContext>
    {
        private static MemoryStreamUnmarshaller instance;
        private MemoryStreamUnmarshaller() { }

        public static MemoryStreamUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new MemoryStreamUnmarshaller();
            return instance;
        }

        public MemoryStream Unmarshall(UnmarshallerContext context)
        {
            byte[] bytes = Convert.FromBase64String(context.ReadText());
            MemoryStream stream = new MemoryStream(bytes);
            return stream;
        }
    }

    /// <summary>
    /// Unmarshaller for ResponseMetadata
    /// </summary>
    public class ResponseMetadataUnmarshaller : IUnmarshaller<ResponseMetadata, UnmarshallerContext>
    {
        private static ResponseMetadataUnmarshaller instance;
        private ResponseMetadataUnmarshaller() { }

        public static ResponseMetadataUnmarshaller GetInstance()
        {
            if (null == instance)
                instance = new ResponseMetadataUnmarshaller();
            return instance;
        }

        public ResponseMetadata Unmarshall(UnmarshallerContext context)
        {
            ResponseMetadata metadata = new ResponseMetadata();
            
            context.Read();
            if (context.TestExpression("ResponseMetadata/RequestId"))
                metadata.RequestId = StringUnmarshaller.GetInstance().Unmarshall(context);

            return metadata;
        }
    }

    public class KeyValueUnmarshaller<K, V, KUnmarshaller, VUnmarshaller> :
    IUnmarshaller<KeyValuePair<K, V>, UnmarshallerContext>
        where KUnmarshaller : IUnmarshaller<K, UnmarshallerContext>
        where VUnmarshaller : IUnmarshaller<V, UnmarshallerContext>
    {
        KUnmarshaller keyUnmarshaller;
        VUnmarshaller valueUnmarshaller;

        public KeyValueUnmarshaller(KUnmarshaller keyUnmarshaller, VUnmarshaller valueUnmarshaller)
        {
            this.keyUnmarshaller = keyUnmarshaller;
            this.valueUnmarshaller = valueUnmarshaller;
        }

        public KeyValuePair<K, V> Unmarshall(UnmarshallerContext context)
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
    }

}
