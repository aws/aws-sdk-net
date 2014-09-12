/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the GetItem operation.
    /// The <i>GetItem</i> operation returns a set of attributes for the item with the given
    /// primary      key. If there is no matching item, <i>GetItem</i> does not return any
    /// data.
    /// 
    ///     
    /// <para>
    /// <i>GetItem</i> provides an eventually consistent read by default. If your application
    ///      requires a strongly consistent read, set <i>ConsistentRead</i> to <code>true</code>.
    /// Although      a strongly consistent read might take more time than an eventually consistent
    /// read, it always      returns the last updated value.
    /// </para>
    /// </summary>
    public partial class GetItemRequest : AmazonDynamoDBRequest
    {
        private List<string> _attributesToGet = new List<string>();
        private bool? _consistentRead;
        private Dictionary<string, AttributeValue> _key = new Dictionary<string, AttributeValue>();
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private string _tableName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetItemRequest() { }

        /// <summary>
        /// Instantiates GetItemRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested item.</param>
        /// <param name="key">A map of attribute names to <i>AttributeValue</i> objects, representing the primary key of   the item to retrieve. For the primary key, you must provide <i>all</i> of the attributes. For example, with a hash   type primary key, you only need to specify the hash attribute. For a hash-and-range type   primary key, you must specify <i>both</i> the hash attribute and the range attribute.</param>
        public GetItemRequest(string tableName, Dictionary<string, AttributeValue> key)
        {
            _tableName = tableName;
            _key = key;
        }

        /// <summary>
        /// Instantiates GetItemRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested item.</param>
        /// <param name="key">A map of attribute names to <i>AttributeValue</i> objects, representing the primary key of   the item to retrieve. For the primary key, you must provide <i>all</i> of the attributes. For example, with a hash   type primary key, you only need to specify the hash attribute. For a hash-and-range type   primary key, you must specify <i>both</i> the hash attribute and the range attribute.</param>
        /// <param name="consistentRead">If set to <code>true</code>, then the operation uses strongly consistent reads; otherwise, eventually   consistent reads are used.</param>
        public GetItemRequest(string tableName, Dictionary<string, AttributeValue> key, bool consistentRead)
        {
            _tableName = tableName;
            _key = key;
            _consistentRead = consistentRead;
        }

        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        /// The names of one or more attributes to retrieve.  If no attribute      names are specified,
        /// then all attributes will be returned. If      any of the requested attributes are
        /// not found, they will not      appear in the result.
        /// </para>
        ///       
        /// <para>
        /// Note that <i>AttributesToGet</i> has no effect on provisioned throughput consumption.
        ///       DynamoDB determines capacity units consumed based on item size, not on the amount
        /// of data that is returned to an application.
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this._attributesToGet; }
            set { this._attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this._attributesToGet != null && this._attributesToGet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConsistentRead. 
        /// <para>
        /// If set to <code>true</code>, then the operation uses strongly consistent reads; otherwise,
        /// eventually      consistent reads are used.
        /// </para>
        /// </summary>
        public bool ConsistentRead
        {
            get { return this._consistentRead.GetValueOrDefault(); }
            set { this._consistentRead = value; }
        }

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this._consistentRead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// A map of attribute names to <i>AttributeValue</i> objects, representing the primary
        /// key of      the item to retrieve.
        /// </para>
        ///     
        /// <para>
        /// For the primary key, you must provide <i>all</i> of the attributes. For example, with
        /// a hash      type primary key, you only need to specify the hash attribute. For a hash-and-range
        /// type      primary key, you must specify <i>both</i> the hash attribute and the range
        /// attribute.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null && this._key.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReturnConsumedCapacity.
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this._returnConsumedCapacity; }
            set { this._returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this._returnConsumedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table containing the requested item.
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}