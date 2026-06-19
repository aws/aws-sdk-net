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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the SearchAssets operation.
    /// Searches for assets in Glue Data Catalog using full-text search, filters, sorting,
    /// and aggregations. Returns matching assets with relevance-ranked results.
    /// </summary>
    public partial class SearchAssetsRequest : AmazonGlueRequest
    {
        private SearchFilterClause _filterClause;
        private int? _maxResults;
        private string _nextToken;
        private string _searchText;
        private SearchSort _sort;

        /// <summary>
        /// Gets and sets the property FilterClause. 
        /// <para>
        /// The filter clause to apply to the search. Supports nested AND/OR logic with attribute-level
        /// and map-level filters.
        /// </para>
        /// </summary>
        public SearchFilterClause FilterClause
        {
            get { return this._filterClause; }
            set { this._filterClause = value; }
        }

        // Check to see if FilterClause property is set
        internal bool IsSetFilterClause()
        {
            return this._filterClause != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if this is a continuation call.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SearchText. 
        /// <para>
        /// The text to search for. At least one of <c>searchText</c> or <c>filterClause</c> must
        /// be provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string SearchText
        {
            get { return this._searchText; }
            set { this._searchText = value; }
        }

        // Check to see if SearchText property is set
        internal bool IsSetSearchText()
        {
            return this._searchText != null;
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sort criteria for the search results.
        /// </para>
        /// </summary>
        public SearchSort Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

    }
}