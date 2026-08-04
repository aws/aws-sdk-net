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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// An element in the search schema of a vector index.
    /// </summary>
    public partial class SearchSchemaElement
    {
        private string _attributeName;
        private SearchSchemaElementType _searchSchemaElementType;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=65535)]
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
        /// Gets and sets the property SearchSchemaElementType. 
        /// <para>
        /// The role of the attribute in the search schema. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HASH</c> - A partition key that partitions the vector index for independent scaling.
        /// When specified, you must provide this attribute's value in the <c>SearchConditionExpression</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INLINE_FILTER</c> - An attribute projected into the vector index for filtering
        /// at the storage layer during search. Inline filters are optional in the <c>SearchConditionExpression</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchSchemaElementType SearchSchemaElementType
        {
            get { return this._searchSchemaElementType; }
            set { this._searchSchemaElementType = value; }
        }

        // Check to see if SearchSchemaElementType property is set
        internal bool IsSetSearchSchemaElementType()
        {
            return this._searchSchemaElementType != null;
        }

    }
}