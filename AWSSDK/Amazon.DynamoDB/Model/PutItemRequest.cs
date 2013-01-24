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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDB.Model
{
    /// <summary>
    /// Container for the parameters to the PutItem operation.
    /// <para>Creates a new item, or replaces an old item with a new item (including all the attributes).</para> <para>If an item already exists in
    /// the specified table with the same primary key, the new item completely replaces the existing item. You can perform a conditional put (insert
    /// a new item if one with the specified primary key doesn't exist), or replace an existing item if it has certain attribute values.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.PutItem"/>
    public class PutItemRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private Dictionary<string,AttributeValue> item = new Dictionary<string,AttributeValue>();
        private Dictionary<string,ExpectedAttributeValue> expected = new Dictionary<string,ExpectedAttributeValue>();
        private string returnValues;

        /// <summary>
        /// The name of the table in which you want to put an item. Allowed characters are <c>a-z</c>, <c>A-Z</c>, <c>0-9</c>, <c>_</c> (underscore),
        /// <c>-</c> (hyphen) and <c>.</c> (period).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this.tableName; }
            set { this.tableName = value; }
        }

        /// <summary>
        /// Sets the TableName property
        /// </summary>
        /// <param name="tableName">The value to set for the TableName property </param>
        /// <returns>this instance</returns>
        public PutItemRequest WithTableName(string tableName)
        {
            this.tableName = tableName;
            return this;
        }
            

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this.tableName != null;       
        }

        /// <summary>
        /// A map of the attributes for the item, and must include the primary key values that define the item. Other attribute name-value pairs can be
        /// provided for the item.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> Item
        {
            get { return this.item; }
            set { this.item = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Item dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Item dictionary.</param>
        /// <returns>this instance</returns>
        public PutItemRequest WithItem(params KeyValuePair<string, AttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, AttributeValue> pair in pairs)
            {
                this.Item[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Item property is set
        internal bool IsSetItem()
        {
            return this.item != null;       
        }

        /// <summary>
        /// Designates an attribute for a conditional modification. The <c>Expected</c> parameter allows you to provide an attribute name, and whether
        /// or not Amazon DynamoDB should check to see if the attribute has a particular value before modifying it.
        ///  
        /// </summary>
        public Dictionary<string,ExpectedAttributeValue> Expected
        {
            get { return this.expected; }
            set { this.expected = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Expected dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Expected dictionary.</param>
        /// <returns>this instance</returns>
        public PutItemRequest WithExpected(params KeyValuePair<string, ExpectedAttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, ExpectedAttributeValue> pair in pairs)
            {
                this.Expected[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this.expected != null;       
        }

        /// <summary>
        /// Use this parameter if you want to get the attribute name-value pairs before or after they are modified. For <c>PUT</c> operations, the
        /// possible parameter values are <c>NONE</c> (default) or <c>ALL_OLD</c>. For update operations, the possible parameter values are <c>NONE</c>
        /// (default) or <c>ALL_OLD</c>, <c>UPDATED_OLD</c>, <c>ALL_NEW</c> or <c>UPDATED_NEW</c>. <ul> <li><c>NONE</c>: Nothing is returned.</li>
        /// <li><c>ALL_OLD</c>: Returns the attributes of the item as they were before the operation.</li> <li><c>UPDATED_OLD</c>: Returns the values of
        /// the updated attributes, only, as they were before the operation.</li> <li><c>ALL_NEW</c>: Returns all the attributes and their new values
        /// after the operation.</li> <li><c>UPDATED_NEW</c>: Returns the values of the updated attributes, only, as they are after the operation.</li>
        /// </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>NONE, ALL_OLD, UPDATED_OLD, ALL_NEW, UPDATED_NEW</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ReturnValues
        {
            get { return this.returnValues; }
            set { this.returnValues = value; }
        }

        /// <summary>
        /// Sets the ReturnValues property
        /// </summary>
        /// <param name="returnValues">The value to set for the ReturnValues property </param>
        /// <returns>this instance</returns>
        public PutItemRequest WithReturnValues(string returnValues)
        {
            this.returnValues = returnValues;
            return this;
        }
            

        // Check to see if ReturnValues property is set
        internal bool IsSetReturnValues()
        {
            return this.returnValues != null;       
        }
    }
}
    
