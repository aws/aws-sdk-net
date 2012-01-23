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
using System.Collections.Generic;

using Amazon.DynamoDB.Model;

namespace Amazon.DynamoDB.DocumentModel
{
    /// <summary>
    /// A DynamoDBEntry that represents a primitive list DynamoDB type
    /// </summary>
    public class PrimitiveList : DynamoDBEntry
    {
        #region Constructors

        /// <summary>
        /// Constructs an empty PrimitiveList.
        /// Values are configured to be saved as strings.
        /// </summary>
        public PrimitiveList()
            : this(false)
        {
        }

        /// <summary>
        /// Constructs an empty PrimitiveList and specifies
        /// whether it should be stored as a number or not.
        /// </summary>
        /// <param name="saveAsNumeric"></param>
        public PrimitiveList(bool saveAsNumeric)
        {
            Entries = new List<Primitive>();
            SaveAsNumeric = saveAsNumeric;
        }

        #endregion


        #region Properties/Accessors

        /// <summary>
        /// Collection of Primitive entries
        /// </summary>
        public List<Primitive> Entries
        {
            get;
            set;
        }
        
        /// <summary>
        /// Flag, set to true if value should be treated as a number, not a string
        /// </summary>
        public Boolean SaveAsNumeric
        {
            get;
            set;
        }

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
            AttributeValue attribute = new AttributeValue();
            List<string> values = new List<string>();
            foreach (var entry in Entries)
            {
                values.Add(entry.Value);
            }
            if (SaveAsNumeric)
            {
                attribute.NS = values;
            }
            else
            {
                attribute.SS = values;
            }

            return attribute;
        }

        internal override ExpectedAttributeValue ConvertToExpectedAttributeValue()
        {
            ExpectedAttributeValue expectedAttribute = new ExpectedAttributeValue();
            if ((Entries != null) && (Entries.Count != 0))
            {
                expectedAttribute.Exists = true;
                expectedAttribute.Value = new AttributeValue();
                List<string> values = new List<string>();
                foreach (var entry in Entries)
                {
                    values.Add(entry.Value);
                }
                if (SaveAsNumeric)
                {
                    expectedAttribute.Value.NS = values;
                }
                else
                {
                    expectedAttribute.Value.SS = values;
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
            if ((Entries != null) && (Entries.Count != 0))
            {
                attributeUpdate.Action = "PUT";
                attributeUpdate.Value = new AttributeValue();
                List<string> values = new List<string>();
                foreach (var entry in Entries)
                {
                    values.Add(entry.Value);
                }
                if (SaveAsNumeric)
                {
                    attributeUpdate.Value.NS = values;
                }
                else
                {
                    attributeUpdate.Value.SS = values;
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
            PrimitiveList pl = new PrimitiveList();
            pl.Entries = data;
            return pl;
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

        #endregion

        #region Public overrides
        public override object Clone()
        {
            List<Primitive> values = new List<Primitive>();
            foreach (Primitive entry in this.Entries)
            {
                values.Add(entry.Clone() as Primitive);
            }

            PrimitiveList list = new PrimitiveList(this.SaveAsNumeric);
            list.Entries = values;
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
            if (entryOther == null || this.SaveAsNumeric != entryOther.SaveAsNumeric)
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
    }
}
