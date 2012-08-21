/*
 * Copyright 2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.DynamoDB.Model;
using Amazon.Util;

namespace Amazon.DynamoDB.DocumentModel
{
    /// <summary>
    /// A DynamoDBEntry that represents a primitive DynamoDB type
    /// </summary>
    public class Primitive : DynamoDBEntry
    {
        #region Constructors

        /// <summary>
        /// Constructs an empty Primitive
        /// </summary>
        public Primitive()
            : this(null, false)
        {
        }

        /// <summary>
        /// Constructs a Primitive with the specified value.
        /// Value is stored as a string, not numeric.
        /// </summary>
        /// <param name="value">Value of the Primitive</param>
        public Primitive(string value)
            : this(value, false)
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
        {
            Value = value;
            SaveAsNumeric = saveAsNumeric;
        }

        #endregion

        #region Properties

        /// <summary>
        /// String representation of the Primitive
        /// </summary>
        public String Value
        {
            get;
            set;
        }

        /// <summary>
        /// Flag, set to true if value should be treated as a number instead of a string
        /// </summary>
        public Boolean SaveAsNumeric
        {
            get;
            set;
        }

        #endregion

        #region Internal conversion methods

        internal override AttributeValue ConvertToAttributeValue()
        {
            if (!string.IsNullOrEmpty(this.Value))
            {
                AttributeValue attribute = new AttributeValue();
                if (SaveAsNumeric)
                {
                    attribute.N = Value;
                }
                else
                {
                    attribute.S = Value;
                }
                return attribute;
            }
            else
            {
                return null;
            }
        }

        internal override ExpectedAttributeValue ConvertToExpectedAttributeValue()
        {
            ExpectedAttributeValue expectedAttribute = new ExpectedAttributeValue();
            if (!string.IsNullOrEmpty(this.Value))
            {
                expectedAttribute.Exists = true;
                expectedAttribute.Value = new AttributeValue();
                if (SaveAsNumeric)
                {
                    expectedAttribute.Value.N = Value;
                }
                else
                {
                    expectedAttribute.Value.S = Value;
                }
            }
            else
            {
                expectedAttribute.Exists = false;
            }

            return expectedAttribute;
        }

        internal override AttributeValueUpdate ConvertToAttributeUpdateValue()
        {

            AttributeValueUpdate attributeUpdate = new AttributeValueUpdate();
            if (!string.IsNullOrEmpty(this.Value))
            {
                attributeUpdate.Action = "PUT";
                attributeUpdate.Value = new AttributeValue();
                if (SaveAsNumeric)
                {
                    attributeUpdate.Value.N = Value;
                }
                else
                {
                    attributeUpdate.Value.S = Value;
                }
            }
            else
            {
                attributeUpdate.Action = "DELETE";
            }

            return attributeUpdate;
        }

        #endregion

        #region Explicit and Implicit conversions

        /// <summary>
        /// Explicitly convert Primitive to Boolean
        /// </summary>
        /// <returns>Boolean value of this object</returns>
        public override Boolean AsBoolean()
        {
            if (string.IsNullOrEmpty(Value))
            {
                throw new InvalidCastException();
            }
            Boolean ret = !string.Equals("0", Value, StringComparison.OrdinalIgnoreCase);
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
            ret.SaveAsNumeric = true;
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
            if (!Byte.TryParse(Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("d");
            ret.SaveAsNumeric = true;
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
            if (!SByte.TryParse(Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("d");
            ret.SaveAsNumeric = true;
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
            if (!UInt16.TryParse(Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("d");
            ret.SaveAsNumeric = true;
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
            if (!Int16.TryParse(Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("d");
            ret.SaveAsNumeric = true;
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
            if (!UInt32.TryParse(Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("d");
            ret.SaveAsNumeric = true;
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
            if (!Int32.TryParse(Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("d");
            ret.SaveAsNumeric = true;
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
            if (!UInt64.TryParse(Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("d");
            ret.SaveAsNumeric = true;
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
            if (!Int64.TryParse(Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("d");
            ret.SaveAsNumeric = true;
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
            if (!Single.TryParse(Value, NumberStyles.Float, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("r");
            ret.SaveAsNumeric = true;
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
            if (!Double.TryParse(Value, NumberStyles.Float, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("r");
            ret.SaveAsNumeric = true;
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
            if (!Decimal.TryParse(Value, NumberStyles.Float, CultureInfo.InvariantCulture, out ret))
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
            ret.Value = data.ToString("g");
            ret.SaveAsNumeric = true;
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
            if (!Char.TryParse(Value, out ret))
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
            ret.Value = data.ToString();
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
            return Value;
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
            if (!DateTime.TryParseExact(Value, AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out ret))
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
            Guid ret = new Guid(Value);
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

        #endregion

        #region Public overrides
        public override object Clone()
        {
            return new Primitive(this.Value, this.SaveAsNumeric);
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

            return entryOther.SaveAsNumeric == this.SaveAsNumeric && string.Equals(entryOther.Value, this.Value);
        }
        #endregion
    }
}
