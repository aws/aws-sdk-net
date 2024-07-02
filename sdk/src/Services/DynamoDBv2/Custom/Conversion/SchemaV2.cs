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
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2
{
    #region Converter factories

    internal class DefaultConverterFactoryV2 : ConverterFactory
    {
        public DefaultConverterFactoryV2(DynamoDBEntryConversion conversion) : base(conversion)
        {
        }

        protected override Converter CreateConverter(Type type)
        {
            if (Nullable.GetUnderlyingType(type) is var underlyingType && underlyingType != null)
                type = underlyingType;

            if (type == typeof(byte)) return new ByteConverterV2();
            if (type == typeof(sbyte)) return new SByteConverterV2();
            if (type == typeof(ushort)) return new UInt16ConverterV2();
            if (type == typeof(short)) return new Int16ConverterV2();
            if (type == typeof(uint)) return new UInt32ConverterV2();
            if (type == typeof(int)) return new Int32ConverterV2();
            if (type == typeof(ulong)) return new UInt64ConverterV2();
            if (type == typeof(long)) return new Int64ConverterV2();
            if (type == typeof(float)) return new SingleConverterV2();
            if (type == typeof(double)) return new DoubleConverterV2();
            if (type == typeof(decimal)) return new DecimalConverterV2();
            if (type == typeof(char)) return new CharConverterV2();
            if (type == typeof(string)) return new StringConverterV2();
            if (type == typeof(DateTime)) return new DateTimeConverterV2();
            if (type == typeof(Guid)) return new GuidConverterV2();
            if (type == typeof(byte[])) return new BytesConverterV2();
            if (type == typeof(MemoryStream)) return new MemoryStreamConverterV2();
            if (type == typeof(Enum) || type.IsEnum) return new EnumConverterV2();
            if (type == typeof(Dictionary<string, object>)) return new DictionaryConverterV2();

            return null;
        }
    }

    internal class CollectionConverterFactoryV2 : CollectionConverterFactory
    {
        public CollectionConverterFactoryV2(DynamoDBEntryConversion conversion) : base(conversion, Utils.PrimitiveTypes) { }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL3050:RequiresDynamicCode",
            Justification = "MakeGenericType is safe here since we support reference types only, so fully shareable code is generated.")]
        protected override Converter CreateConverter(Type elementType, Type collectionType)
        {
            var genericType = typeof(CollectionConverterV2<,>).MakeGenericType(elementType, collectionType);
            return Activator.CreateInstance(genericType) as Converter;
        }
    }

    internal class DynamoDBListConverterFactory : CollectionConverterFactory
    {
        public DynamoDBListConverterFactory(DynamoDBEntryConversion conversion)
            : base(conversion, new[] { typeof(String), typeof(MemoryStream), typeof(byte[]) }) { }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL3050:RequiresDynamicCode",
            Justification = "MakeGenericType is safe here since we support reference types only, so fully shareable code is generated.")]
        protected override Converter CreateConverter(Type elementType, Type collectionType)
        {
            var genericType = typeof(DynamoDBListConverter<,>).MakeGenericType(elementType, collectionType);
            return Activator.CreateInstance(genericType) as Converter;
        }
    }

    #endregion


    #region Same converter behavior as V1

    internal class ByteConverterV2 : ByteConverterV1
    { }

    internal class SByteConverterV2 : SByteConverterV1
    { }

    internal class UInt16ConverterV2 : UInt16ConverterV1
    { }

    internal class Int16ConverterV2 : Int16ConverterV1
    { }

    internal class UInt32ConverterV2 : UInt32ConverterV1
    { }

    internal class Int32ConverterV2 : Int32ConverterV1
    { }

    internal class UInt64ConverterV2 : UInt64ConverterV1
    { }

    internal class Int64ConverterV2 : Int64ConverterV1
    { }

    internal class SingleConverterV2 : SingleConverterV1
    { }

    internal class DoubleConverterV2 : DoubleConverterV1
    { }

    internal class DecimalConverterV2 : DecimalConverterV1
    { }

    internal class CharConverterV2 : CharConverterV1
    { }

    internal class StringConverterV2 : StringConverterV1
    { }

    internal class DateTimeConverterV2 : DateTimeConverterV1
    { }

    internal class GuidConverterV2 : GuidConverterV1
    { }

    internal class BytesConverterV2 : BytesConverterV1
    { }

    internal class MemoryStreamConverterV2 : MemoryStreamConverterV1
    { }

    internal class DictionaryConverterV2 : DictionaryConverterV1
    { }

    internal class EnumConverterV2 : EnumConverterV1
    { }

    #endregion

    /// <summary>
    /// A boolean converter which reads booleans as N or BOOL types,
    /// but writes out BOOL type.
    /// </summary>

    internal class BoolConverterV2 : BoolConverterV1
    {
        protected override bool TryTo(bool value, out DynamoDBBool b)
        {
            b = new DynamoDBBool(value);
            return true;
        }
        protected override bool TryTo(bool value, out Primitive p)
        {
            p = null;
            return false;
        }
    }

    /// <summary>
    /// A collection converter which reads both sets of collections (sets and lists)
    /// but writes out different types depending on input:
    /// HashSet input - converts to a DynamoDB set (NS, SS, BS)
    /// Array or List input - converts to a DynamoDB list (L)
    /// </summary>
    internal class CollectionConverterV2<T, TCollection> : PrimitiveCollectionConverterV1<T, TCollection> where TCollection : ICollection<T>
    {
        /// <summary>
        /// If value is HashSet{T}, converts the items to PrimitiveList
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pl"></param>
        /// <returns></returns>
        protected override bool TryTo(TCollection value, out PrimitiveList pl)
        {
            if (typeof(TCollection) == typeof(HashSet<T>))
            {
                pl = Conversion.ItemsToPrimitiveList(value);
                return true;
            }

            pl = null;
            return false;
        }
        /// <summary>
        /// If value implements IEnumerable{T}, converts the items to DynamoDBList
        /// This method is called after the PrimitiveList version of TryTo, so this will
        /// never work on a HashSet{T}.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        protected override bool TryTo(TCollection value, out DynamoDBList l)
        {
            if (typeof(TCollection) != typeof(HashSet<T>))
            {
                var entries = Conversion.ConvertToEntries(value);
                l = new DynamoDBList(entries);
                return true;
            }

            l = null;
            return false;
        }
    }

    internal class DynamoDBListConverter<T, TCollection> : Converter<TCollection> where TCollection : ICollection<T>
    {
        protected override bool TryTo(TCollection value, out DynamoDBList l)
        {
            l = new DynamoDBList();
            foreach (var item in value)
            {
                var entry = Conversion.ConvertToEntry<T>(item);
                l.Add(entry);
            }
            return true;
        }

        protected override bool TryFrom(DynamoDBList l, out TCollection result)
        {
            var items = Conversion.ConvertFromEntries<T>(l.Entries);
            return Utils.ItemsToCollection(items, out result);
        }
    }
}
