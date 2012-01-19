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
    /// A collection of attribute key-value pairs that defines
    /// an item in DynamoDB.
    /// </summary>
    public class Document
    {
        #region Private/internal members

        private Dictionary<string, DynamoDBEntry> originalValues;
        private Dictionary<string, DynamoDBEntry> currentValues;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs an empty Document.
        /// </summary>
        public Document()
        {
            originalValues = new Dictionary<string, DynamoDBEntry>();
            currentValues = new Dictionary<string, DynamoDBEntry>();
        }

        #endregion

        #region Properties/accessors

        /// <summary>
        /// Attribute accessor, allows getting or setting of an individual attribute.
        /// </summary>
        /// <param name="key">Name of the attribute.</param>
        /// <returns>Current value of the attribute.</returns>
        public DynamoDBEntry this[string key]
        {
            get
            {
                return currentValues[key];
            }
            set
            {
                if (value == null)
                {
                    currentValues[key] = new Primitive();
                }
                else
                {
                    currentValues[key] = value;
                }
            }
        }

        /// <summary>
        /// Returns true if the attribute has been changed.
        /// </summary>
        /// <param name="attributeName">Name of the attribute.</param>
        /// <returns>True if the attribute has been changed.</returns>
        public bool IsAttributeChanged(string attributeName)
        {
            DynamoDBEntry original;
            this.originalValues.TryGetValue(attributeName, out original);           

            DynamoDBEntry current;
            this.currentValues.TryGetValue(attributeName, out current);

            if ((original != null && current == null) || (original == null && current != null))
                return true;

            if (original == null && current == null)
                return false;

            return !original.Equals(current);
        }

        /// <summary>
        /// Returns true if the document contains attributes that have not been saved.
        /// </summary>
        /// <returns>True if the document contains attributes that have not been saved.</returns>
        public bool IsDirty()
        {
            Dictionary<string, string> keys = new Dictionary<string, string>();
            foreach (string key in currentValues.Keys)
            {
                keys.Add(key, key);
            }

            foreach (string key in originalValues.Keys)
            {
                if (!keys.ContainsKey(key))
                {
                    keys.Add(key, key);
                }
            }

            foreach (string key in keys.Keys)
            {
                if (this.IsAttributeChanged(key))
                {
                    return true;
                }
            }

            return false;
        }

        internal void CommitChanges()
        {
            this.originalValues.Clear();
            foreach (var kvp in currentValues)
            {
                this.originalValues[kvp.Key] = kvp.Value.Clone() as DynamoDBEntry;
            }
        }

        /// <summary>
        /// Gets the value associated with the specified attribute value.
        /// </summary>
        /// <param name="attributeName">Attribute name</param>
        /// <param name="entry">
        /// If the specified attribute value is found, returns the value associated with the 
        /// attribute; otherwise, null.
        /// </param>
        /// <returns>True if attribute is found; false otherwise</returns>
        public bool TryGetValue(string attributeName, out DynamoDBEntry entry)
        {
            return this.currentValues.TryGetValue(attributeName, out entry);
        }

        /// <summary>
        /// Determines if a specific attribute is set on the Document.
        /// </summary>
        /// <param name="attributeName">Attribute name</param>
        /// <returns>Returns true if the specified attribute is found; false otherwise.</returns>
        public bool Contains(string attributeName)
        {
            return this.currentValues.ContainsKey(attributeName);
        }

        #endregion

        #region DynamoDB conversion

        /// <summary>
        /// Creates a map of attribute names mapped to AttributeValue objects.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, AttributeValue> ToAttributeMap()
        {
            Dictionary<string, AttributeValue> ret = new Dictionary<string, AttributeValue>();

            foreach (var attribute in currentValues)
            {
                AttributeValue value = attribute.Value.ConvertToAttributeValue();
                if (value != null)
                {
                    ret.Add(attribute.Key, value);
                }
            }
            
            return ret;
        }

        /// <summary>
        /// Creates a map of attribute names mapped to ExpectedAttributeValue objects.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, ExpectedAttributeValue> ToExpectedAttributeMap()
        {
            Dictionary<string, ExpectedAttributeValue> ret = new Dictionary<string, ExpectedAttributeValue>();

            foreach (var attribute in currentValues)
            {
                ret.Add(attribute.Key, attribute.Value.ConvertToExpectedAttributeValue());
            }

            return ret;
        }

        /// <summary>
        /// Creates a map of attribute names mapped to AttributeValueUpdate objects.
        /// </summary>
        /// <param name="changedAttributesOnly">If true, only attributes that have been changed will be in the map.</param>
        /// <returns></returns>
        public Dictionary<string, AttributeValueUpdate> ToAttributeUpdateMap(bool changedAttributesOnly)
        {
            Dictionary<string, AttributeValueUpdate> ret = new Dictionary<string, AttributeValueUpdate>();

            foreach (var attribute in currentValues)
            {
                if (!changedAttributesOnly || this.IsAttributeChanged(attribute.Key))
                {
                    ret.Add(attribute.Key, attribute.Value.ConvertToAttributeUpdateValue());
                }
            }

            return ret;
        }

        /// <summary>
        /// Returns the names of all the attributes.
        /// </summary>
        /// <returns>List of attribute names.</returns>
        public List<String> GetAttributeNames()
        {
            return new List<string>(this.currentValues.Keys);
        }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Creates a Document from an attribute map.
        /// </summary>
        /// <param name="data">Map of attribute names to attribute values.</param>
        /// <returns>Document representing the data.</returns>
        public static Document FromAttributeMap(Dictionary<string, AttributeValue> data)
        {
            Document doc = new Document();

            // Add Primitives and PrimitiveLists
            foreach (var attribute in data)
            {
                string wholeKey = attribute.Key;
                AttributeValue value = attribute.Value;


                if (value.S != null)
                {
                    doc.currentValues[wholeKey] = value.S;
                }
                else if (value.N != null)
                {
                    Primitive primitive = value.N;
                    primitive.SaveAsNumeric = true;
                    doc.currentValues[wholeKey] = primitive;
                }
                else if (value.SS != null && value.SS.Count != 0)
                {
                    doc.currentValues[wholeKey] = value.SS;
                }
                else if (value.NS != null && value.NS.Count != 0)
                {
                    PrimitiveList primitiveList = value.NS;
                    primitiveList.SaveAsNumeric = true;
                    doc.currentValues[wholeKey] = primitiveList;
                }
            }

            doc.CommitChanges();
            return doc;
        }


        #endregion
    }
}
