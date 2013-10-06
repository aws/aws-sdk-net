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
using System.Collections.Generic;

using Amazon.DynamoDBv2.Model;
using System.IO;

namespace Amazon.DynamoDBv2.DocumentModel
{

    /// <summary>
    /// Enumerator describing type of DynamoDB data
    /// </summary>
    public enum DynamoDBEntryType { String, Numeric, Binary }

    /// <summary>
    /// Abstract class representing an arbitrary DynamoDB attribute value
    /// </summary>
    public abstract class DynamoDBEntry : ICloneable
    {
        #region Internal conversion methods

        internal abstract AttributeValue ConvertToAttributeValue();
        internal ExpectedAttributeValue ConvertToExpectedAttributeValue()
        {
            AttributeValue attributeValue = ConvertToAttributeValue();

            ExpectedAttributeValue expectedAttribute = new ExpectedAttributeValue();
            if (attributeValue == null)
            {
                expectedAttribute.Exists = false;
            }
            else
            {
                expectedAttribute.Exists = true;
                expectedAttribute.Value = attributeValue;
            }

            return expectedAttribute;
        }
        internal AttributeValueUpdate ConvertToAttributeUpdateValue()
        {
            AttributeValue attributeValue = ConvertToAttributeValue();

            AttributeValueUpdate attributeUpdate = new AttributeValueUpdate();
            if (attributeValue == null)
            {
                attributeUpdate.Action = "DELETE";
            }
            else
            {
                attributeUpdate.Action = "PUT";
                attributeUpdate.Value = attributeValue;
            }

            return attributeUpdate;
        }
        
        #endregion

        #region Subclass conversions

        /// <summary>
        /// Convert DynamoDBEntry to Primitive
        /// </summary>
        /// <returns>
        /// Primitive if DynamoDBEntry is of Primitive type; otherwise null
        /// </returns>
        public Primitive AsPrimitive()
        {
            return (this as Primitive);
        }

        /// <summary>
        /// Convert DynamoDBEntry to PrimitiveList
        /// </summary>
        /// <returns>
        /// AsPrimitiveList if DynamoDBEntry is of AsPrimitiveList type; otherwise null
        /// </returns>
        public PrimitiveList AsPrimitiveList()
        {
            return (this as PrimitiveList);
        }

        #endregion

        #region Explicit and Implicit conversions

        /// <summary>
        /// Explicitly convert DynamoDBEntry to Boolean
        /// </summary>
        /// <returns>Boolean value of this object</returns>
        public virtual Boolean AsBoolean()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Boolean to DynamoDBEntry
        /// </summary>
        /// <param name="data">Boolean data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Boolean data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Boolean
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Boolean value of DynamoDBEntry</returns>
        public static explicit operator Boolean(DynamoDBEntry p)
        {
            return p.AsBoolean();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to Byte
        /// </summary>
        /// <returns>Byte value of this object</returns>
        public virtual Byte AsByte()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Byte to DynamoDBEntry
        /// </summary>
        /// <param name="data">Byte data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Byte data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Byte
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Byte value of DynamoDBEntry</returns>
        public static explicit operator Byte(DynamoDBEntry p)
        {
            return p.AsByte();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to SByte
        /// </summary>
        /// <returns>SByte value of this object</returns>
        [CLSCompliant(false)]
        public virtual SByte AsSByte()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert SByte to DynamoDBEntry
        /// </summary>
        /// <param name="data">SByte data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        [CLSCompliant(false)]
        public static implicit operator DynamoDBEntry(SByte data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to SByte
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>SByte value of DynamoDBEntry</returns>
        [CLSCompliant(false)]
        public static explicit operator SByte(DynamoDBEntry p)
        {
            return p.AsSByte();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to UInt16
        /// </summary>
        /// <returns>UInt16 value of this object</returns>
        [CLSCompliant(false)]
        public virtual UInt16 AsUShort()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert UInt16 to DynamoDBEntry
        /// </summary>
        /// <param name="data">UInt16 data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        [CLSCompliant(false)]
        public static implicit operator DynamoDBEntry(UInt16 data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to UInt16
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>UInt16 value of DynamoDBEntry</returns>
        [CLSCompliant(false)]
        public static explicit operator UInt16(DynamoDBEntry p)
        {
            return p.AsUShort();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to Int16
        /// </summary>
        /// <returns>Int16 value of this object</returns>
        public virtual Int16 AsShort()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Int16 to DynamoDBEntry
        /// </summary>
        /// <param name="data">Int16 data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Int16 data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Int16
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Int16 value of DynamoDBEntry</returns>
        public static explicit operator Int16(DynamoDBEntry p)
        {
            return p.AsShort();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to UInt32
        /// </summary>
        /// <returns>UInt32 value of this object</returns>
        [CLSCompliant(false)]
        public virtual UInt32 AsUInt()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert UInt32 to DynamoDBEntry
        /// </summary>
        /// <param name="data">UInt32 data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        [CLSCompliant(false)]
        public static implicit operator DynamoDBEntry(UInt32 data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to UInt32
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>UInt32 value of DynamoDBEntry</returns>
        [CLSCompliant(false)]
        public static explicit operator UInt32(DynamoDBEntry p)
        {
            return p.AsUInt();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to Int32
        /// </summary>
        /// <returns>Int32 value of this object</returns>
        public virtual Int32 AsInt()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Int32 to DynamoDBEntry
        /// </summary>
        /// <param name="data">Int32 data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Int32 data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Int32
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Int32 value of DynamoDBEntry</returns>
        public static explicit operator Int32(DynamoDBEntry p)
        {
            return p.AsInt();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to UInt64
        /// </summary>
        /// <returns>UInt64 value of this object</returns>
        [CLSCompliant(false)]
        public virtual UInt64 AsULong()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert UInt64 to DynamoDBEntry
        /// </summary>
        /// <param name="data">UInt64 data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        [CLSCompliant(false)]
        public static implicit operator DynamoDBEntry(UInt64 data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to UInt64
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>UInt64 value of DynamoDBEntry</returns>
        [CLSCompliant(false)]
        public static explicit operator UInt64(DynamoDBEntry p)
        {
            return p.AsULong();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to Int64
        /// </summary>
        /// <returns>Int64 value of this object</returns>
        public virtual Int64 AsLong()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Int64 to DynamoDBEntry
        /// </summary>
        /// <param name="data">Int64 data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Int64 data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Int64
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Int64 value of DynamoDBEntry</returns>
        public static explicit operator Int64(DynamoDBEntry p)
        {
            return p.AsLong();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to Single
        /// </summary>
        /// <returns>Single value of this object</returns>
        public virtual Single AsSingle()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Single to DynamoDBEntry
        /// </summary>
        /// <param name="data">Single data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Single data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Single
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Single value of DynamoDBEntry</returns>
        public static explicit operator Single(DynamoDBEntry p)
        {
            return p.AsSingle();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to Double
        /// </summary>
        /// <returns>Double value of this object</returns>
        public virtual Double AsDouble()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Double to DynamoDBEntry
        /// </summary>
        /// <param name="data">Double data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Double data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Double
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Double value of DynamoDBEntry</returns>
        public static explicit operator Double(DynamoDBEntry p)
        {
            return p.AsDouble();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to Decimal
        /// </summary>
        /// <returns>Decimal value of this object</returns>
        public virtual Decimal AsDecimal()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Decimal to DynamoDBEntry
        /// </summary>
        /// <param name="data">Decimal data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Decimal data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Decimal
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Decimal value of DynamoDBEntry</returns>
        public static explicit operator Decimal(DynamoDBEntry p)
        {
            return p.AsDecimal();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to Char
        /// </summary>
        /// <returns>Char value of this object</returns>
        public virtual Char AsChar()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Char to DynamoDBEntry
        /// </summary>
        /// <param name="data">Char data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Char data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Char
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Char value of DynamoDBEntry</returns>
        public static explicit operator Char(DynamoDBEntry p)
        {
            return p.AsChar();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to String
        /// </summary>
        /// <returns>String value of this object</returns>
        public virtual String AsString()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert String to DynamoDBEntry
        /// </summary>
        /// <param name="data">String data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(String data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to String
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>String value of DynamoDBEntry</returns>
        public static implicit operator String(DynamoDBEntry p)
        {
            return p.AsString();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to DateTime
        /// </summary>
        /// <returns>DateTime value of this object</returns>
        public virtual DateTime AsDateTime()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert DateTime to DynamoDBEntry
        /// </summary>
        /// <param name="data">DateTime data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(DateTime data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to DateTime
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>DateTime value of DynamoDBEntry</returns>
        public static explicit operator DateTime(DynamoDBEntry p)
        {
            return p.AsDateTime();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to Guid
        /// </summary>
        /// <returns>Guid value of this object</returns>
        public virtual Guid AsGuid()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert Guid to DynamoDBEntry
        /// </summary>
        /// <param name="data">Guid data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(Guid data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to Guid
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>Guid value of DynamoDBEntry</returns>
        public static explicit operator Guid(DynamoDBEntry p)
        {
            return p.AsGuid();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to byte[]
        /// </summary>
        /// <returns>byte[] value of this object</returns>
        public virtual byte[] AsByteArray()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert byte[] to DynamoDBEntry
        /// </summary>
        /// <param name="data">byte[] data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(byte[] data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to byte[]
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>byte[] value of DynamoDBEntry</returns>
        public static explicit operator byte[](DynamoDBEntry p)
        {
            return p.AsByteArray();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to MemoryStream
        /// </summary>
        /// <returns>MemoryStream value of this object</returns>
        public virtual MemoryStream AsMemoryStream()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert MemoryStream to DynamoDBEntry
        /// </summary>
        /// <param name="data">MemoryStream data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(MemoryStream data)
        {
            Primitive p = data;
            return p;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to MemoryStream
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>MemoryStream value of DynamoDBEntry</returns>
        public static explicit operator MemoryStream(DynamoDBEntry p)
        {
            return p.AsMemoryStream();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to List&lt;Primitive&gt;
        /// </summary>
        /// <returns>List&lt;Primitive&gt; value of this object</returns>
        public virtual List<Primitive> AsListOfPrimitives()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert List&lt;Primitive&gt; to DynamoDBEntry
        /// </summary>
        /// <param name="data">List&lt;Primitive&gt; data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(List<Primitive> data)
        {
            PrimitiveList pl = data;
            return pl;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to List&lt;Primitive&gt;
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>List&lt;Primitive&gt; value of DynamoDBEntry</returns>
        public static explicit operator List<Primitive>(DynamoDBEntry p)
        {
            return p.AsListOfPrimitives();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to List&lt;String&gt;
        /// </summary>
        /// <returns>List&lt;String&gt; value of this object</returns>
        public virtual List<String> AsListOfString()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert List&lt;String&gt; to DynamoDBEntry
        /// </summary>
        /// <param name="data">List&lt;String&gt; data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(List<String> data)
        {
            PrimitiveList pl = data;
            return pl;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to List&lt;String&gt;
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>List&lt;String&gt; value of DynamoDBEntry</returns>
        public static explicit operator List<String>(DynamoDBEntry p)
        {
            return p.AsListOfString();
        }

        

        /// <summary>
        /// Explicitly convert DynamoDBEntry to List&lt;byte[]&gt;
        /// </summary>
        /// <returns>List&lt;byte[]&gt; value of this object</returns>
        public virtual List<byte[]> AsListOfByteArray()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert List&lt;byte[]&gt; to DynamoDBEntry
        /// </summary>
        /// <param name="data">List&lt;byte[]&gt; data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(List<byte[]> data)
        {
            PrimitiveList pl = data;
            return pl;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to List&lt;byte[]&gt;
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>List&lt;byte[]&gt; value of DynamoDBEntry</returns>
        public static explicit operator List<byte[]>(DynamoDBEntry p)
        {
            return p.AsListOfByteArray();
        }



        /// <summary>
        /// Explicitly convert DynamoDBEntry to List&lt;MemoryStream&gt;
        /// </summary>
        /// <returns>List&lt;MemoryStream&gt; value of this object</returns>
        public virtual List<MemoryStream> AsListOfMemoryStream()
        {
            throw new InvalidCastException();
        }
        /// <summary>
        /// Implicitly convert List&lt;MemoryStream&gt; to DynamoDBEntry
        /// </summary>
        /// <param name="data">List&lt;MemoryStream&gt; data to convert</param>
        /// <returns>DynamoDBEntry representing the data</returns>
        public static implicit operator DynamoDBEntry(List<MemoryStream> data)
        {
            PrimitiveList pl = data;
            return pl;
        }
        /// <summary>
        /// Explicitly convert DynamoDBEntry to List&lt;MemoryStream&gt;
        /// </summary>
        /// <param name="p">DynamoDBEntry to convert</param>
        /// <returns>List&lt;MemoryStream&gt; value of DynamoDBEntry</returns>
        public static explicit operator List<MemoryStream>(DynamoDBEntry p)
        {
            return p.AsListOfMemoryStream();
        }

        #endregion

        public abstract object Clone();
    }

}
