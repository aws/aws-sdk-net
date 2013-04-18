/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.IO;

using Amazon.DynamoDBv2.Model;
using Amazon.Util;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// A DynamoDBEntry that represents a primitive DynamoDB type
    /// </summary>
    public class Primitive : DynamoDBEntry, IEquatable<Primitive>
    {
        #region Constructors

        /// <summary>
        /// Constructs an empty Primitive
        /// </summary>
        public Primitive()
            : this(null, DynamoDBEntryType.String)
        {
        }

        /// <summary>
        /// Constructs a Primitive with the specified value.
        /// Value is stored as a string, not numeric.
        /// </summary>
        /// <param name="value">Value of the Primitive</param>
        public Primitive(string value)
            : this(value, DynamoDBEntryType.String)
        {
        }

        /// <summary>
        /// Constructs a Primitive with the specified value
        /// and specifies whether it should be stored as a number or not.
        /// </summary>
        /// <param name="value">Value of the Primitive</param>
        /// <param name="saveAsNumeric">
        /// Flag, set to true if value should be treated as a number instead of a string
        /// </param>
        public Primitive(string value, bool saveAsNumeric)
            : this(value, saveAsNumeric ? DynamoDBEntryType.Numeric : DynamoDBEntryType.String)
        {
        }

        /// <summary>
        /// Constructs a Binary Primitive with the specified MemoryStream value.
        /// Note: Primitive's Value is set to the stream's ToArray() response.
        /// </summary>
        /// <param name="value">Value of the Primitive</param>
        public Primitive(MemoryStream value)
            : this(value.ToArray()) { }

        /// <summary>
        /// Constructs a Binary Primitive with the specified byte[] value.
        /// </summary>
        /// <param name="value">Value of the Primitive</param>
        public Primitive(byte[] value)
            : this(value, DynamoDBEntryType.Binary) { }

        internal Primitive(object value, DynamoDBEntryType type)
        {
            Value = value;
            Type = type;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Value of the Primitive.
        /// If Type is String or Numeric, this property is a string.
        /// If Type is Binary, this property is a byte array.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Type of this primitive object
        /// </summary>
        public DynamoDBEntryType Type { get; set; }

        #endregion

        #region Internal conversion methods

        internal override AttributeValue ConvertToAttributeValue()
        {
            if (this.Value == null)
                return null;

            if (this.Type != DynamoDBEntryType.Binary && string.IsNullOrEmpty(this.StringValue))
                return null;

            AttributeValue attribute = new AttributeValue();
            switch (this.Type)
            {
                case DynamoDBEntryType.Numeric:
                    attribute.N = StringValue;
                    break;
                case DynamoDBEntryType.String:
                    attribute.S = StringValue;
                    break;
                case DynamoDBEntryType.Binary:
                    byte[] bytes = (byte[])Value;
                    attribute.B = new MemoryStream(bytes);
                    break;
            }
            return attribute;
        }

        internal string StringValue
        {
            get
            {
                if (this.Type == DynamoDBEntryType.Numeric || this.Type == DynamoDBEntryType.String)
                    return this.Value as string;
                return null;
            }
        }

        #endregion

        #region Explicit and Implicit conversions

        /// <summary>
        /// Explicitly convert Primitive to Boolean
        /// </summary>
        /// <returns>Boolean value of this object</returns>
        public override Boolean AsBoolean()
        {
            if (string.IsNullOrEmpty(StringValue))
            {
                throw new InvalidCastException();
            }
            Boolean ret = !string.Equals("0", StringValue, StringComparison.OrdinalIgnoreCase);
            return ret;
        }
        /// <summary>
        /// Implicitly convert Boolean to Primitive
        /// </summary>
        /// <param name="data">Boolean data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Boolean data)
        {
            Primitive ret = new Primitive();
            ret.Value = data ? "1" : "0";
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Boolean
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Boolean value of Primitive</returns>
        public static explicit operator Boolean(Primitive p)
        {
            return p.AsBoolean();
        }



        /// <summary>
        /// Explicitly convert Primitive to Byte
        /// </summary>
        /// <returns>Byte value of this object</returns>
        public override Byte AsByte()
        {
            Byte ret = 0;
            if (!Byte.TryParse(StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert Byte to Primitive
        /// </summary>
        /// <param name="data">Byte data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Byte data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("d", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Byte
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Byte value of Primitive</returns>
        public static explicit operator Byte(Primitive p)
        {
            return p.AsByte();
        }



        /// <summary>
        /// Explicitly convert Primitive to SByte
        /// </summary>
        /// <returns>SByte value of this object</returns>
        [CLSCompliant(false)]
        public override SByte AsSByte()
        {
            SByte ret = 0;
            if (!SByte.TryParse(StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert SByte to Primitive
        /// </summary>
        /// <param name="data">SByte data to convert</param>
        /// <returns>Primitive representing the data</returns>
        [CLSCompliant(false)]
        public static implicit operator Primitive(SByte data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("d", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to SByte
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>SByte value of Primitive</returns>
        [CLSCompliant(false)]
        public static explicit operator SByte(Primitive p)
        {
            return p.AsSByte();
        }



        /// <summary>
        /// Explicitly convert Primitive to UInt16
        /// </summary>
        /// <returns>UInt16 value of this object</returns>
        [CLSCompliant(false)]
        public override UInt16 AsUShort()
        {
            UInt16 ret = 0;
            if (!UInt16.TryParse(StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert UInt16 to Primitive
        /// </summary>
        /// <param name="data">UInt16 data to convert</param>
        /// <returns>Primitive representing the data</returns>
        [CLSCompliant(false)]
        public static implicit operator Primitive(UInt16 data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("d", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to UInt16
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>UInt16 value of Primitive</returns>
        [CLSCompliant(false)]
        public static explicit operator UInt16(Primitive p)
        {
            return p.AsUShort();
        }



        /// <summary>
        /// Explicitly convert Primitive to Int16
        /// </summary>
        /// <returns>Int16 value of this object</returns>
        public override Int16 AsShort()
        {
            Int16 ret = 0;
            if (!Int16.TryParse(StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert Int16 to Primitive
        /// </summary>
        /// <param name="data">Int16 data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Int16 data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("d", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Int16
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Int16 value of Primitive</returns>
        public static explicit operator Int16(Primitive p)
        {
            return p.AsShort();
        }



        /// <summary>
        /// Explicitly convert Primitive to UInt32
        /// </summary>
        /// <returns>UInt32 value of this object</returns>
        [CLSCompliant(false)]
        public override UInt32 AsUInt()
        {
            UInt32 ret = 0;
            if (!UInt32.TryParse(StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert UInt32 to Primitive
        /// </summary>
        /// <param name="data">UInt32 data to convert</param>
        /// <returns>Primitive representing the data</returns>
        [CLSCompliant(false)]
        public static implicit operator Primitive(UInt32 data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("d", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to UInt32
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>UInt32 value of Primitive</returns>
        [CLSCompliant(false)]
        public static explicit operator UInt32(Primitive p)
        {
            return p.AsUInt();
        }



        /// <summary>
        /// Explicitly convert Primitive to Int32
        /// </summary>
        /// <returns>Int32 value of this object</returns>
        public override Int32 AsInt()
        {
            Int32 ret = 0;
            if (!Int32.TryParse(StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert Int32 to Primitive
        /// </summary>
        /// <param name="data">Int32 data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Int32 data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("d", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Int32
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Int32 value of Primitive</returns>
        public static explicit operator Int32(Primitive p)
        {
            return p.AsInt();
        }



        /// <summary>
        /// Explicitly convert Primitive to UInt64
        /// </summary>
        /// <returns>UInt64 value of this object</returns>
        [CLSCompliant(false)]
        public override UInt64 AsULong()
        {
            UInt64 ret = 0;
            if (!UInt64.TryParse(StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert UInt64 to Primitive
        /// </summary>
        /// <param name="data">UInt64 data to convert</param>
        /// <returns>Primitive representing the data</returns>
        [CLSCompliant(false)]
        public static implicit operator Primitive(UInt64 data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("d", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to UInt64
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>UInt64 value of Primitive</returns>
        [CLSCompliant(false)]
        public static explicit operator UInt64(Primitive p)
        {
            return p.AsULong();
        }



        /// <summary>
        /// Explicitly convert Primitive to Int64
        /// </summary>
        /// <returns>Int64 value of this object</returns>
        public override Int64 AsLong()
        {
            Int64 ret = 0;
            if (!Int64.TryParse(StringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert Int64 to Primitive
        /// </summary>
        /// <param name="data">Int64 data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Int64 data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("d", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Int64
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Int64 value of Primitive</returns>
        public static explicit operator Int64(Primitive p)
        {
            return p.AsLong();
        }



        /// <summary>
        /// Explicitly convert Primitive to Single
        /// </summary>
        /// <returns>Single value of this object</returns>
        public override Single AsSingle()
        {
            Single ret = 0;
            if (!Single.TryParse(StringValue, NumberStyles.Float, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert Single to Primitive
        /// </summary>
        /// <param name="data">Single data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Single data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("r", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Single
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Single value of Primitive</returns>
        public static explicit operator Single(Primitive p)
        {
            return p.AsSingle();
        }



        /// <summary>
        /// Explicitly convert Primitive to Double
        /// </summary>
        /// <returns>Double value of this object</returns>
        public override Double AsDouble()
        {
            Double ret = 0;
            if (!Double.TryParse(StringValue, NumberStyles.Float, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert Double to Primitive
        /// </summary>
        /// <param name="data">Double data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Double data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("r", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Double
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Double value of Primitive</returns>
        public static explicit operator Double(Primitive p)
        {
            return p.AsDouble();
        }



        /// <summary>
        /// Explicitly convert Primitive to Decimal
        /// </summary>
        /// <returns>Decimal value of this object</returns>
        public override Decimal AsDecimal()
        {
            Decimal ret = 0;
            if (!Decimal.TryParse(StringValue, NumberStyles.Float, CultureInfo.InvariantCulture, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert Decimal to Primitive
        /// </summary>
        /// <param name="data">Decimal data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Decimal data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString("g", CultureInfo.InvariantCulture);
            ret.Type = DynamoDBEntryType.Numeric;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Decimal
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Decimal value of Primitive</returns>
        public static explicit operator Decimal(Primitive p)
        {
            return p.AsDecimal();
        }



        /// <summary>
        /// Explicitly convert Primitive to Char
        /// </summary>
        /// <returns>Char value of this object</returns>
        public override Char AsChar()
        {
            Char ret = '0';
            if (!Char.TryParse(StringValue, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert Char to Primitive
        /// </summary>
        /// <param name="data">Char data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Char data)
        {
            Primitive ret = new Primitive();
            ret.Value = data.ToString(CultureInfo.InvariantCulture);
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Char
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Char value of Primitive</returns>
        public static explicit operator Char(Primitive p)
        {
            return p.AsChar();
        }



        /// <summary>
        /// Explicitly convert Primitive to String
        /// </summary>
        /// <returns>String value of this object</returns>
        public override String AsString()
        {
            return StringValue;
        }
        /// <summary>
        /// Implicitly convert String to Primitive
        /// </summary>
        /// <param name="data">String data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(String data)
        {
            Primitive ret = new Primitive();
            ret.Value = data;
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to String
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>String value of Primitive</returns>
        public static implicit operator String(Primitive p)
        {
            return p.AsString();
        }



        /// <summary>
        /// Explicitly convert Primitive to DateTime
        /// </summary>
        /// <returns>DateTime value of this object</returns>
        public override DateTime AsDateTime()
        {
            DateTime ret;
            if (!DateTime.TryParseExact(StringValue, AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out ret))
            {
                throw new InvalidCastException();
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert DateTime to Primitive
        /// </summary>
        /// <param name="data">DateTime data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(DateTime data)
        {
            Primitive ret = new Primitive();
            DateTime utc = data.ToUniversalTime();
            ret.Value = utc.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture);
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to DateTime
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>DateTime value of Primitive</returns>
        public static explicit operator DateTime(Primitive p)
        {
            return p.AsDateTime();
        }



        /// <summary>
        /// Explicitly convert Primitive to Guid
        /// </summary>
        /// <returns>Guid value of this object</returns>
        public override Guid AsGuid()
        {
            Guid ret = new Guid(StringValue);
            return ret;
        }
        /// <summary>
        /// Implicitly convert Guid to Primitive
        /// </summary>
        /// <param name="data">Guid data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(Guid data)
        {
            Primitive ret = data.ToString();
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to Guid
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>Guid value of Primitive</returns>
        public static explicit operator Guid(Primitive p)
        {
            return p.AsGuid();
        }



        /// <summary>
        /// Explicitly convert Primitive to byte[]
        /// </summary>
        /// <returns>byte[] value of this object</returns>
        public override byte[] AsByteArray()
        {
            byte[] ret = (byte[])Value;
            return ret;
        }
        /// <summary>
        /// Implicitly convert byte[] to Primitive
        /// </summary>
        /// <param name="data">byte[] data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(byte[] data)
        {
            Primitive ret = new Primitive(data, DynamoDBEntryType.Binary);
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to byte[]
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>byte[] value of Primitive</returns>
        public static explicit operator byte[](Primitive p)
        {
            return p.AsByteArray();
        }



        /// <summary>
        /// Explicitly convert Primitive to MemoryStream
        /// </summary>
        /// <returns>MemoryStream value of this object</returns>
        public override MemoryStream AsMemoryStream()
        {
            MemoryStream ret = new MemoryStream((byte[])Value);
            return ret;
        }
        /// <summary>
        /// Implicitly convert MemoryStream to Primitive
        /// </summary>
        /// <param name="data">MemoryStream data to convert</param>
        /// <returns>Primitive representing the data</returns>
        public static implicit operator Primitive(MemoryStream data)
        {
            Primitive ret = new Primitive(data.ToArray(), DynamoDBEntryType.Binary);
            return ret;
        }
        /// <summary>
        /// Explicitly convert Primitive to MemoryStream
        /// </summary>
        /// <param name="p">Primitive to convert</param>
        /// <returns>MemoryStream value of Primitive</returns>
        public static explicit operator MemoryStream(Primitive p)
        {
            return p.AsMemoryStream();
        }

        #endregion

        #region Public overrides

        public override object Clone()
        {
            return new Primitive(this.Value, this.Type);
        }

        int hashCode = new Random().Next(int.MaxValue);
        public override int GetHashCode()
        {
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            Primitive entryOther = obj as Primitive;
            if (entryOther == null)
                return false;
            if (this.Type != entryOther.Type)
                return false;

            if (this.Type == DynamoDBEntryType.Numeric || this.Type == DynamoDBEntryType.String)
            {
                return (string.Equals(this.StringValue, entryOther.StringValue));
            }
            else if (this.Type == DynamoDBEntryType.Binary)
            {
                byte[] thisByteArray = this.Value as byte[];
                byte[] otherByteArray = entryOther.Value as byte[];

                if (thisByteArray.Length != otherByteArray.Length)
                    return false;

                for (int i = 0; i < thisByteArray.Length; i++)
                {
                    if (thisByteArray[i] != otherByteArray[i])
                        return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region IEquatable<Primitive> Members

        public bool Equals(Primitive other)
        {
            return this.Equals((object)other);
        }

        #endregion
    }
}
