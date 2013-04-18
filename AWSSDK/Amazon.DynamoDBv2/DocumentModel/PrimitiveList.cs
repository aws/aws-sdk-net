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
    /// A DynamoDBEntry that represents a primitive list DynamoDB type
    /// </summary>
    public class PrimitiveList : DynamoDBEntry, IEquatable<PrimitiveList>
    {
        #region Constructors

        /// <summary>
        /// Constructs an empty PrimitiveList.
        /// Values are configured to be saved as strings.
        /// </summary>
        public PrimitiveList()
            : this(DynamoDBEntryType.String)
        {
        }

        /// <summary>
        /// Constructs an empty PrimitiveList and specifies
        /// the type of its elements.
        /// </summary>
        /// <param name="type"></param>
        public PrimitiveList(DynamoDBEntryType type)
        {
            Entries = new List<Primitive>();
            Type = type;
        }

        #endregion


        #region Properties/Accessors

        /// <summary>
        /// Collection of Primitive entries
        /// </summary>
        public List<Primitive> Entries { get; set; }

        /// <summary>
        /// Type of Primitive items in the list
        /// </summary>
        public DynamoDBEntryType Type { get; set; }

        /// <summary>
        /// Gets or sets Primitive at a specific location in the list.
        /// </summary>
        /// <param name="i">Index of the Primitive in question.</param>
        /// <returns>Primitive in question.</returns>
        public Primitive this[int i]
        {
            get
            {
                return Entries[i];
            }
            set
            {
                if (i < Entries.Count && i >= 0)
                {
                    Entries[i] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("i");
                }
            }
        }

        /// <summary>
        /// Adds a Primitive to the end of the list.
        /// </summary>
        /// <param name="value">Primitive to add.</param>
        public void Add(Primitive value)
        {
            this.Entries.Add(value);
        }

        #endregion


        #region Internal conversion methods

        internal override AttributeValue ConvertToAttributeValue()
        {
            if (Entries == null || Entries.Count == 0)
                return null;

            AttributeValue attribute = new AttributeValue();
            if (Type == DynamoDBEntryType.Numeric || Type == DynamoDBEntryType.String)
            {
                List<string> values = new List<string>();
                foreach (var entry in Entries)
                {
                    values.Add(entry.StringValue);
                }

                if (Type == DynamoDBEntryType.Numeric)
                {
                    attribute.NS = values;
                }
                else
                {
                    attribute.SS = values;
                }
            }
            else if (Type == DynamoDBEntryType.Binary)
            {
                List<MemoryStream> values = new List<MemoryStream>();
                foreach (var entry in Entries)
                {
                    MemoryStream stream = new MemoryStream(entry.AsByteArray());
                    values.Add(stream);
                }

                attribute.BS = values;
            }
            else
            {
                throw new InvalidOperationException("Unsupported Type");
            }

            return attribute;
        }

        #endregion


        #region Explicit and Implicit conversions


        /// <summary>
        /// Explicitly convert PrimitiveList to List&lt;Primitive&gt;
        /// </summary>
        /// <returns>List&lt;Primitive&gt; value of this object</returns>
        public override List<Primitive> AsListOfPrimitives()
        {
            return Entries;
        }
        /// <summary>
        /// Implicitly convert List&lt;Primitive&gt; to PrimitiveList
        /// </summary>
        /// <param name="data">List&lt;Primitive&gt; data to convert</param>
        /// <returns>PrimitiveList representing the data</returns>
        public static implicit operator PrimitiveList(List<Primitive> data)
        {
            PrimitiveList primitiveList = new PrimitiveList();
            DynamoDBEntryType? listType = null;
            foreach (var primitive in data)
            {
                listType = primitive.Type;
                primitiveList.Entries.Add(primitive);
            }
            primitiveList.Type = listType.GetValueOrDefault(DynamoDBEntryType.String);

            return primitiveList;
        }
        /// <summary>
        /// Explicitly convert PrimitiveList to List&lt;Primitive&gt;
        /// </summary>
        /// <param name="p">PrimitiveList to convert</param>
        /// <returns>List&lt;Primitive&gt; value of PrimitiveList</returns>
        public static explicit operator List<Primitive>(PrimitiveList p)
        {
            return p.AsListOfPrimitives();
        }



        /// <summary>
        /// Explicitly convert PrimitiveList to List&lt;String&gt;
        /// </summary>
        /// <returns>List&lt;String&gt; value of this object</returns>
        public override List<String> AsListOfString()
        {
            List<String> ret = new List<String>();
            foreach (var entry in Entries)
            {
                ret.Add(entry);
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert List&lt;String&gt; to PrimitiveList
        /// </summary>
        /// <param name="data">List&lt;String&gt; data to convert</param>
        /// <returns>PrimitiveList representing the data</returns>
        public static implicit operator PrimitiveList(List<String> data)
        {
            PrimitiveList pl = new PrimitiveList();
            foreach (string entry in data)
            {
                pl.Entries.Add(entry);
            }
            return pl;
        }
        /// <summary>
        /// Explicitly convert PrimitiveList to List&lt;String&gt;
        /// </summary>
        /// <param name="p">PrimitiveList to convert</param>
        /// <returns>List&lt;String&gt; value of PrimitiveList</returns>
        public static explicit operator List<String>(PrimitiveList p)
        {
            return p.AsListOfString();
        }



        /// <summary>
        /// Explicitly convert PrimitiveList to byte[]
        /// </summary>
        /// <returns>List&lt;byte[]&gt; value of this object</returns>
        public override List<byte[]> AsListOfByteArray()
        {
            List<byte[]> ret = new List<byte[]>();
            foreach (Primitive entry in Entries)
            {
                ret.Add(entry.AsByteArray());
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert List&lt;byte[]&gt; to PrimitiveList
        /// </summary>
        /// <param name="data">List&lt;byte[]&gt; data to convert</param>
        /// <returns>PrimitiveList representing the data</returns>
        public static implicit operator PrimitiveList(List<byte[]> data)
        {
            PrimitiveList pl = new PrimitiveList(DynamoDBEntryType.Binary);
            foreach (byte[] entry in data)
            {
                pl.Entries.Add(entry);
            }
            return pl;
        }
        /// <summary>
        /// Explicitly convert PrimitiveList to List&lt;byte[]&gt;
        /// </summary>
        /// <param name="p">PrimitiveList to convert</param>
        /// <returns>List&lt;byte[]&gt; value of PrimitiveList</returns>
        public static explicit operator List<byte[]>(PrimitiveList p)
        {
            return p.AsListOfByteArray();
        }



        /// <summary>
        /// Explicitly convert PrimitiveList to List&lt;MemoryStream&gt;
        /// </summary>
        /// <returns>List&lt;MemoryStream&gt; value of this object</returns>
        public override List<MemoryStream> AsListOfMemoryStream()
        {
            List<MemoryStream> ret = new List<MemoryStream>();
            foreach (var entry in Entries)
            {
                ret.Add(new MemoryStream(entry.AsByteArray()));
            }
            return ret;
        }
        /// <summary>
        /// Implicitly convert List&lt;MemoryStream&gt; to PrimitiveList
        /// </summary>
        /// <param name="data">List&lt;MemoryStream&gt; data to convert</param>
        /// <returns>PrimitiveList representing the data</returns>
        public static implicit operator PrimitiveList(List<MemoryStream> data)
        {
            PrimitiveList pl = new PrimitiveList(DynamoDBEntryType.Binary);
            foreach (MemoryStream entry in data)
            {
                pl.Entries.Add(entry.ToArray());
            }
            return pl;
        }
        /// <summary>
        /// Explicitly convert PrimitiveList to List&lt;MemoryStream&gt;
        /// </summary>
        /// <param name="p">PrimitiveList to convert</param>
        /// <returns>List&lt;MemoryStream&gt; value of PrimitiveList</returns>
        public static explicit operator List<MemoryStream>(PrimitiveList p)
        {
            return p.AsListOfMemoryStream();
        }


        #endregion


        #region Public overrides

        public override object Clone()
        {
            PrimitiveList list = new PrimitiveList(this.Type);
            foreach (Primitive entry in this.Entries)
            {
                list.Add(entry.Clone() as Primitive);
            }

            return list;
        }

        int hashCode = new Random().Next(int.MaxValue);
        public override int GetHashCode()
        {
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            PrimitiveList entryOther = obj as PrimitiveList;
            if (entryOther == null || this.Type != entryOther.Type)
                return false;

            if (entryOther.Entries.Count != this.Entries.Count)
                return false;

            for (int i = 0; i < this.Entries.Count; i++)
            {
                Primitive thisPrim = this[i];
                Primitive otherPrim = entryOther[i];

                if (thisPrim == null && otherPrim == null)
                    continue;
                else if (thisPrim == null || otherPrim == null)
                    return false;
                else if (!thisPrim.Equals(otherPrim))
                    return false;
            }

            return true;
        }
        
        #endregion

        #region IEquatable<PrimitiveList> Members

        public bool Equals(PrimitiveList other)
        {
            return this.Equals((object)other);
        }

        #endregion
    }
}
