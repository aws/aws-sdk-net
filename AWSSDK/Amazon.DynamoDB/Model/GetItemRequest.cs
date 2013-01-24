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
    /// Container for the parameters to the GetItem operation.
    /// <para>Retrieves a set of Attributes for an item that matches the primary key.</para> <para>The <c>GetItem</c> operation provides an
    /// eventually-consistent read by default. If eventually-consistent reads are not acceptable for your application, use <c>ConsistentRead</c> .
    /// Although this operation might take longer than a standard read, it always returns the last updated value.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.GetItem"/>
    public class GetItemRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private Key key;
        private List<string> attributesToGet = new List<string>();
        private bool? consistentRead;

        /// <summary>
        /// The name of the table in which you want to get an item. Allowed characters are <c>a-z</c>, <c>A-Z</c>, <c>0-9</c>, <c>_</c> (underscore),
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
        public GetItemRequest WithTableName(string tableName)
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
        public GetItemRequest WithKey(Key key)
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
        /// List of <c>Attribute</c> names. If attribute names are not specified then all attributes will be returned. If some attributes are not found,
        /// they will not appear in the result.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this.attributesToGet; }
            set { this.attributesToGet = value; }
        }
        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        public GetItemRequest WithAttributesToGet(params string[] attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        public GetItemRequest WithAttributesToGet(IEnumerable<string> attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this.attributesToGet.Count > 0;       
        }

        /// <summary>
        /// If set to <c>true</c>, then a consistent read is issued. Otherwise eventually-consistent is used.
        ///  
        /// </summary>
        public bool ConsistentRead
        {
            get { return this.consistentRead ?? default(bool); }
            set { this.consistentRead = value; }
        }

        /// <summary>
        /// Sets the ConsistentRead property
        /// </summary>
        /// <param name="consistentRead">The value to set for the ConsistentRead property </param>
        /// <returns>this instance</returns>
        public GetItemRequest WithConsistentRead(bool consistentRead)
        {
            this.consistentRead = consistentRead;
            return this;
        }
            

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this.consistentRead.HasValue;       
        }
    }
}
    
