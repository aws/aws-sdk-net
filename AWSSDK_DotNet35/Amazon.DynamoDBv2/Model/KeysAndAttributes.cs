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
    /// Represents a set of primary keys and, for each key, the attributes to retrieve from
    /// the      table.
    /// 
    ///     
    /// <para>
    /// For each primary key, you must provide <i>all</i> of the key attributes. For example,
    /// with a      hash type primary key, you only need to specify the hash attribute. For
    /// a hash-and-range type      primary key, you must specify <i>both</i> the hash attribute
    /// and the range attribute.
    /// </para>
    /// </summary>
    public partial class KeysAndAttributes
    {
        private List<string> _attributesToGet = new List<string>();
        private bool? _consistentRead;
        private List<Dictionary<string, AttributeValue>> _keys = new List<Dictionary<string, AttributeValue>>();

        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        /// One or more attributes to retrieve from the table or index. If no attribute names
        /// are      specified then all attributes will be returned. If any of the specified attributes
        /// are not      found, they will not appear in the result.
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
        /// The consistency of a read operation. If set to <code>true</code>, then a strongly
        /// consistent      read is used; otherwise, an eventually consistent read is used.
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
        /// Gets and sets the property Keys. 
        /// <para>
        /// The primary key attribute values that define the items and the attributes associated
        /// with the      items.
        /// </para>
        /// </summary>
        public List<Dictionary<string, AttributeValue>> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && this._keys.Count > 0; 
        }

    }
}