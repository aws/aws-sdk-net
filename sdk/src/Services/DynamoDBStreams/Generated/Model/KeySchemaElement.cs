/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the streams.dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// Represents <i>a single element</i> of a key schema. A key schema specifies the attributes
    /// that make up the primary key of a table, or the key attributes of an index.
    /// 
    ///  
    /// <para>
    /// A <c>KeySchemaElement</c> represents exactly one attribute of the primary key. For
    /// example, a simple primary key would be represented by one <c>KeySchemaElement</c>
    /// (for the partition key). A composite primary key would require one <c>KeySchemaElement</c>
    /// for the partition key, and another <c>KeySchemaElement</c> for the sort key.
    /// </para>
    ///  
    /// <para>
    /// A <c>KeySchemaElement</c> must be a scalar, top-level attribute (not a nested attribute).
    /// The data type must be one of String, Number, or Binary. The attribute cannot be nested
    /// within a List or a Map.
    /// </para>
    /// </summary>
    public partial class KeySchemaElement
    {
        private string _attributeName;
        private KeyType _keyType;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of a key attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The role that this key attribute will assume:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HASH</c> - partition key
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RANGE</c> - sort key
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The partition key of an item is also known as its <i>hash attribute</i>. The term
        /// "hash attribute" derives from DynamoDB's usage of an internal hash function to evenly
        /// distribute data items across partitions, based on their partition key values.
        /// </para>
        ///  
        /// <para>
        /// The sort key of an item is also known as its <i>range attribute</i>. The term "range
        /// attribute" derives from the way DynamoDB stores items with the same partition key
        /// physically close together, in sorted order by the sort key value.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyType KeyType
        {
            get { return this._keyType; }
            set { this._keyType = value; }
        }

        // Check to see if KeyType property is set
        internal bool IsSetKeyType()
        {
            return this._keyType != null;
        }

    }
}