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
    /// Container for the parameters to the DeleteItem operation.
    /// <para>Deletes a single item in a table by primary key.</para> <para>You can perform a conditional delete operation that deletes the item if
    /// it exists, or if it has an expected attribute value.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.DeleteItem"/>
    public class DeleteItemRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private Key key;
        private Dictionary<string,ExpectedAttributeValue> expected = new Dictionary<string,ExpectedAttributeValue>();
        private string returnValues;

        /// <summary>
        /// The name of the table in which you want to delete an item. Allowed characters are <c>a-z</c>, <c>A-Z</c>, <c>0-9</c>, <c>_</c> (underscore),
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
        public DeleteItemRequest WithTableName(string tableName)
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
        /// The primary key that uniquely identifies each item in a table. A primary key can be a one attribute (hash) primary key or a two attribute
        /// (hash-and-range) primary key.
        ///  
        /// </summary>
        public Key Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the Key property
        /// </summary>
        /// <param name="key">The value to set for the Key property </param>
        /// <returns>this instance</returns>
        public DeleteItemRequest WithKey(Key key)
        {
            this.key = key;
            return this;
        }
            

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;       
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
        public DeleteItemRequest WithExpected(params KeyValuePair<string, ExpectedAttributeValue>[] pairs)
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
        public DeleteItemRequest WithReturnValues(string returnValues)
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
    
