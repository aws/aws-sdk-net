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
    /// A single result from a <c>SearchVectors</c> operation.
    /// </summary>
    public partial class SearchResultItem
    {
        private Dictionary<string, AttributeValue> _item = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private double? _score;

        /// <summary>
        /// Gets and sets the property Item. 
        /// <para>
        /// A map of attribute names to <c>AttributeValue</c> objects, representing the projected
        /// attributes of the item returned by the vector search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> Item
        {
            get { return this._item; }
            set { this._item = value; }
        }

        // Check to see if Item property is set
        internal bool IsSetItem()
        {
            return this._item != null && (this._item.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The similarity score for this item relative to the search vector. The interpretation
        /// depends on the distance function configured for the vector index.
        /// </para>
        /// </summary>
        public double? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

    }
}