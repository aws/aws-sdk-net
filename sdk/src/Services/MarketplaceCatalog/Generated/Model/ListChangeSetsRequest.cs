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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the ListChangeSets operation.
    /// Returns the list of change sets owned by the account being used to make the call.
    /// You can filter this list by providing any combination of <code>entityId</code>, <code>ChangeSetName</code>,
    /// and status. If you provide more than one filter, the API operation applies a logical
    /// AND between the filters.
    /// 
    ///  
    /// <para>
    /// You can describe a change during the 60-day request history retention period for API
    /// calls.
    /// </para>
    /// </summary>
    public partial class ListChangeSetsRequest : AmazonMarketplaceCatalogRequest
    {
        private string _catalog;
        private List<Filter> _filterList = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private Sort _sort;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog related to the request. Fixed value: <code>AWSMarketplace</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property FilterList. 
        /// <para>
        /// An array of filter objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public List<Filter> FilterList
        {
            get { return this._filterList; }
            set { this._filterList = value; }
        }

        // Check to see if FilterList property is set
        internal bool IsSetFilterList()
        {
            return this._filterList != null && this._filterList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by a single call. This value must be provided
        /// in the next call to retrieve the next set of results. By default, this value is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token value retrieved from a previous call to access the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Sort. 
        /// <para>
        /// An object that contains two attributes, <code>SortBy</code> and <code>SortOrder</code>.
        /// </para>
        /// </summary>
        public Sort Sort
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