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
    /// This is the response object from the SearchVectors operation.
    /// </summary>
    public partial class SearchVectorsResponse : AmazonWebServiceResponse
    {
        private VectorCapacity _consumedCapacity;
        private List<SearchResultItem> _searchResults = AWSConfigs.InitializeCollections ? new List<SearchResultItem>() : null;

        /// <summary>
        /// Gets and sets the property ConsumedCapacity. 
        /// <para>
        /// The capacity units consumed by the <c>SearchVectors</c> operation. Contains <c>VectorSearchRequestBytes</c>,
        /// which represents the vector search capacity consumed.
        /// </para>
        /// </summary>
        public VectorCapacity ConsumedCapacity
        {
            get { return this._consumedCapacity; }
            set { this._consumedCapacity = value; }
        }

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this._consumedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property SearchResults. 
        /// <para>
        /// A list of items returned by the vector similarity search, sorted by similarity with
        /// the most similar item first. Each item contains the projected attributes and a similarity
        /// score.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SearchResultItem> SearchResults
        {
            get { return this._searchResults; }
            set { this._searchResults = value; }
        }

        // Check to see if SearchResults property is set
        internal bool IsSetSearchResults()
        {
            return this._searchResults != null && (this._searchResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}