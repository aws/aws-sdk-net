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

using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Amazon.DynamoDBv2
{
    #region Basic converters

    internal class ByteConverterV1 : Converter<byte>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(byte), typeof(Nullable<byte>) }; 
        }

        protected override bool TryTo(byte value, out Primitive p)
        {
            p = new Primitive(value.ToString("d", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out byte result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out byte result)
#endif
        {
            return byte.TryParse(p.StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class SByteConverterV1 : Converter<SByte>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(SByte), typeof(Nullable<SByte>) };
        }

        protected override bool TryTo(sbyte value, out Primitive p)
        {
            p = new Primitive(value.ToString("d", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out sbyte result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out sbyte result)
#endif
        {
            return SByte.TryParse(p.StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class UInt16ConverterV1 : Converter<UInt16>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(UInt16), typeof(Nullable<UInt16>) };
        }

        protected override bool TryTo(ushort value, out Primitive p)
        {
            p = new Primitive(value.ToString("d", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out ushort result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out ushort result)
#endif
        {
            return UInt16.TryParse(p.StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class Int16ConverterV1 : Converter<Int16>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(Int16), typeof(Nullable<Int16>) };
        }

        protected override bool TryTo(short value, out Primitive p)
        {
            p = new Primitive(value.ToString("d", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out short result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out short result)
#endif
        {
            return Int16.TryParse(p.StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class UInt32ConverterV1 : Converter<UInt32>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(UInt32), typeof(Nullable<UInt32>) };
        }

        protected override bool TryTo(uint value, out Primitive p)
        {
            p = new Primitive(value.ToString("d", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out uint result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out uint result)
#endif
        {
            return UInt32.TryParse(p.StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class Int32ConverterV1 : Converter<Int32>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(Int32), typeof(Nullable<Int32>) };
        }

        protected override bool TryTo(int value, out Primitive p)
        {
            p = new Primitive(value.ToString("d", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out int result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out int result)
#endif
        {
            return Int32.TryParse(p.StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class UInt64ConverterV1 : Converter<UInt64>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(UInt64), typeof(Nullable<UInt64>) };
        }

        protected override bool TryTo(ulong value, out Primitive p)
        {
            p = new Primitive(value.ToString("d", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out ulong result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out ulong result)
#endif
        {
            return UInt64.TryParse(p.StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class Int64ConverterV1 : Converter<Int64>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(Int64), typeof(Nullable<Int64>) };
        }

        protected override bool TryTo(long value, out Primitive p)
        {
            p = new Primitive(value.ToString("d", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out long result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out long result)
#endif
        {
            return Int64.TryParse(p.StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class SingleConverterV1 : Converter<Single>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(Single), typeof(Nullable<Single>) };
        }

        protected override bool TryTo(float value, out Primitive p)
        {
            p = new Primitive(value.ToString("r", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }
#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out float result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out float result)
#endif
        {
            return Single.TryParse(p.StringValue, NumberStyles.Float, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class DoubleConverterV1 : Converter<Double>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(Double), typeof(Nullable<Double>) };
        }

        protected override bool TryTo(double value, out Primitive p)
        {
            p = new Primitive(value.ToString("r", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out double result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out double result)
#endif
        {
            return Double.TryParse(p.StringValue, NumberStyles.Float, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class DecimalConverterV1 : Converter<Decimal>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(Decimal), typeof(Nullable<Decimal>) };
        }

        protected override bool TryTo(decimal value, out Primitive p)
        {
            p = new Primitive(value.ToString("g", CultureInfo.InvariantCulture), DynamoDBEntryType.Numeric);
            return true;
        }
#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out decimal result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out decimal result)
#endif
        {
            return Decimal.TryParse(p.StringValue, NumberStyles.Float, CultureInfo.InvariantCulture, out result);
        }
    }

    internal class CharConverterV1 : Converter<Char>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(Char), typeof(Nullable<Char>) };
        }

        protected override bool TryTo(char value, out Primitive p)
        {
            p = new Primitive(value.ToString(), DynamoDBEntryType.String);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out char result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out char result)
#endif
        {
            return Char.TryParse(p.StringValue, out result);
        }
    }

    internal class StringConverterV1 : Converter<String>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(String) };
        }

        protected override bool TryTo(string value, out Primitive p)
        {
            p = new Primitive(value, DynamoDBEntryType.String);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out string result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out string result)
#endif
        {
            result = p.StringValue;
            return (result != null);
        }
    }

    internal class DateTimeConverterV1 : Converter<DateTime>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(DateTime), typeof(Nullable<DateTime>) };
        }

        protected override bool TryTo(DateTime value, out Primitive p)
        {
            DateTime utc = value.ToUniversalTime();
            p = new Primitive(utc.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture), DynamoDBEntryType.String);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out DateTime result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out DateTime result)
#endif
        {
            if (DateTime.TryParseExact(p.StringValue, AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out result))
            {
                return true;
            }
            return DateTime.TryParse(p.StringValue, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out result);
        }
    }

    internal class GuidConverterV1 : Converter<Guid>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(Guid), typeof(Nullable<Guid>) };
        }

        protected override bool TryTo(Guid value, out Primitive p)
        {
            p = new Primitive(value.ToString("D"), DynamoDBEntryType.String);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out Guid result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out Guid result)
#endif
        {
            result = new Guid(p.StringValue);
            return true;
        }
    }

    internal class BytesConverterV1 : Converter<byte[]>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(byte[]) };
        }

        protected override bool TryTo(byte[] value, out Primitive p)
        {
            p = new Primitive(value);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out byte[] result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out byte[] result)
#endif
        {
            result = p.Value as byte[];
            return (result != null);
        }
    }

    internal class MemoryStreamConverterV1 : Converter<MemoryStream>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(MemoryStream) };
        }

        protected override bool TryTo(MemoryStream value, out Primitive p)
        {
            p = new Primitive(value);
            return true;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out MemoryStream result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out MemoryStream result)
#endif
        {
            var bytes = p.Value as byte[];
            if (bytes == null)
            {
                result = null;
                return false;
            }

            result = new MemoryStream(bytes);
            return true;
        }
    }

    internal class EnumConverterV1 : Converter<Enum>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(Enum) };
        }

        protected override bool TryTo(Enum value, out Primitive p)
        {
            p = null;

            // get enum type
            var valueType = value.GetType();
            // get numeric type underlying enum (int, byte, etc.)
            var underlyingType = Enum.GetUnderlyingType(valueType);
            // convert enum value to numeric type
            var numerical = Convert.ChangeType(value, underlyingType, CultureInfo.InvariantCulture);

            // convert numeric type to primitive
            DynamoDBEntry entry;
            if (Conversion.TryConvertToEntry(underlyingType, numerical, out entry))
            {
                p = entry as Primitive;
            }

            var succeeded = (p != null);
            return succeeded;
        }

#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out Enum result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out Enum result)
#endif
        {
            result = null;

            switch (p.Type)
            {
                case DynamoDBEntryType.Numeric:
                    result = ConvertEnum(p, targetType);
                    break;
                case DynamoDBEntryType.String:
                    result = ConvertEnum(p.StringValue, targetType);
                    break;
                default:
                    break;
            }

            var succeeded = (result != null);
            return succeeded;
        }

#if NET8_0_OR_GREATER
        private Enum ConvertEnum(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType)
#else
        private Enum ConvertEnum(Primitive p, Type targetType)
#endif
        {
            object numerical;
            // convert Primitive to numeric type, using current conversion
            if (Conversion.TryConvertFromEntry(typeof(int), p, out numerical))
            {
                // convert numeric to target enum
                return Enum.ToObject(targetType, numerical) as Enum;
            }

            return null;
        }
        private static Enum ConvertEnum(string s, Type targetType)
        {
            // try to parse enum from string
            try
            {
                return Enum.Parse(targetType, s) as Enum;
            }
            catch
            {
                return null;
            }
        }
    }

#endregion

    #region Converters supporting reading V2 DDB items, but writing V1 items

    /// <summary>
    /// A boolean converter which reads booleans as N or BOOL types,
    /// but writes out N type (1 if true, 0 if false).
    /// </summary>
    internal class BoolConverterV1 : Converter<bool>
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            return new[] { typeof(bool), typeof(Nullable<bool>) };
        }

        protected override bool TryTo(bool value, out Primitive p)
        {
            p = new Primitive(value ? "1" : "0", DynamoDBEntryType.Numeric);
            return true;
        }
        protected override bool TryFrom(DynamoDBBool b, Type targetType, out bool result)
        {
            result = b.Value;
            return true;
        }
#if NET8_0_OR_GREATER
        protected override bool TryFrom(Primitive p, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out bool result)
#else
        protected override bool TryFrom(Primitive p, Type targetType, out bool result)
#endif
        {
            result = !p.StringValue.Equals("0", StringComparison.OrdinalIgnoreCase);
            return true;
        }
    }

    internal abstract class CollectionConverter : Converter
    {

#if NET8_0_OR_GREATER
        protected bool EntriesToCollection([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type elementType, IEnumerable<DynamoDBEntry> entries, out object result)
#else
        protected bool EntriesToCollection(Type targetType, Type elementType, IEnumerable<DynamoDBEntry> entries, out object result)
#endif
        {
            var items = Conversion.ConvertFromEntries(elementType, entries);
            return Utils.ItemsToCollection(targetType, items, out result);
        }
    }

    /// <summary>
    /// A collection converter which reads both sets of collections (sets and lists)
    /// and writes out sets (NS, SS, BS)
    /// </summary>
    internal class PrimitiveCollectionConverterV1 : CollectionConverter
    {
        public PrimitiveCollectionConverterV1()
            : base()
        { }

        public override IEnumerable<Type> GetTargetTypes()
        {
            return Utils.PrimitiveTypesCollectionsAndArray;
        }

        public override bool TryTo(object value, out PrimitiveList pl)
        {
            var items = value as IEnumerable;
            if (items != null)
            {
                pl = Conversion.ItemsToPrimitiveList(items);
                return true;
            }

            pl = null;
            return false;
        }

#if NET8_0_OR_GREATER
        public override bool TryFrom(PrimitiveList pl, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out object result)
#else
        public override bool TryFrom(PrimitiveList pl, Type targetType, out object result)
#endif
        {
            var elementType = Utils.GetPrimitiveElementType(targetType);
            var primitives = pl.Entries;
            return EntriesToCollection(targetType, elementType, pl.Entries.Cast<DynamoDBEntry>(), out result);
        }

#if NET8_0_OR_GREATER
        public override bool TryFrom(DynamoDBList l, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, out object result)
#else
        public override bool TryFrom(DynamoDBList l, Type targetType, out object result)
#endif
        {
            var elementType = Utils.GetPrimitiveElementType(targetType);
            var entries = l.Entries;
            return EntriesToCollection(targetType, elementType, entries, out result);
        }
    }

    /// <summary>
    /// Dictionary converter.
    /// Converts from Dictionary{string,object} to DynamoDBEntry.
    /// Does NOT convert from DynamoDBEntry to Dictionary{string,object}.
    /// </summary>
    internal class DictionaryConverterV1 : Converter
    {
        public override IEnumerable<Type> GetTargetTypes()
        {
            yield return typeof(Dictionary<string, object>);
        }

        public override bool TryTo(object value, out Document d)
        {
            var items = value as IDictionary<string, object>;
            if (items != null)
            {
                d = new Document();
                foreach(var kvp in items)
                {
                    string name = kvp.Key;
                    object item = kvp.Value;
                    DynamoDBEntry entry = null;

                    if (item != null)
                    {
                        Type itemType = item.GetType();
                        entry = Conversion.ConvertToEntry(itemType, item);
                    }
                    d[name] = entry;
                }

                return true;
            }

            d = null;
            return false;
        }
    }

#endregion
}
