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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetTags operation.
    /// Queries for available tag keys and tag values for a specified period. You can search
    /// the tag values for an arbitrary string.
    /// </summary>
    public partial class GetTagsRequest : AmazonCostExplorerRequest
    {
        private Expression _filter;
        private int? _maxResults;
        private string _nextPageToken;
        private string _searchString;
        private List<SortDefinition> _sortBy = new List<SortDefinition>();
        private string _tagKey;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Expression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// This field is only used when SortBy is provided in the request. The maximum number
        /// of objects that to be returned for this request. If MaxResults is not specified with
        /// SortBy, the request will return 1000 results as the default value for this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. AWS provides the token when the response
        /// from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property SearchString. 
        /// <para>
        /// The value that you want to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SearchString
        {
            get { return this._searchString; }
            set { this._searchString = value; }
        }

        // Check to see if SearchString property is set
        internal bool IsSetSearchString()
        {
            return this._searchString != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value by which you want to sort the data.
        /// </para>
        ///  
        /// <para>
        /// The key represents cost and usage metrics. The following values are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BlendedCost</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UnblendedCost</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AmortizedCost</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NetAmortizedCost</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NetUnblendedCost</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UsageQuantity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NormalizedUsageAmount</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Supported values for <code>SortOrder</code> are <code>ASCENDING</code> or <code>DESCENDING</code>.
        /// </para>
        ///  
        /// <para>
        /// When using <code>SortBy</code>, <code>NextPageToken</code> and <code>SearchString</code>
        /// are not supported.
        /// </para>
        /// </summary>
        public List<SortDefinition> SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null && this._sortBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The key of the tag that you want to return values for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TagKey
        {
            get { return this._tagKey; }
            set { this._tagKey = value; }
        }

        // Check to see if TagKey property is set
        internal bool IsSetTagKey()
        {
            return this._tagKey != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The start and end dates for retrieving the dimension values. The start date is inclusive,
        /// but the end date is exclusive. For example, if <code>start</code> is <code>2017-01-01</code>
        /// and <code>end</code> is <code>2017-05-01</code>, then the cost and usage data is retrieved
        /// from <code>2017-01-01</code> up to and including <code>2017-04-30</code> but not including
        /// <code>2017-05-01</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}