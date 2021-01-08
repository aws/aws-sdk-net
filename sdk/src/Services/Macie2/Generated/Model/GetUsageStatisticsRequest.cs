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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the GetUsageStatistics operation.
    /// Retrieves (queries) quotas and aggregated usage data for one or more accounts.
    /// </summary>
    public partial class GetUsageStatisticsRequest : AmazonMacie2Request
    {
        private List<UsageStatisticsFilter> _filterBy = new List<UsageStatisticsFilter>();
        private int? _maxResults;
        private string _nextToken;
        private UsageStatisticsSortBy _sortBy;

        /// <summary>
        /// Gets and sets the property FilterBy. 
        /// <para>
        /// An array of objects, one for each condition to use to filter the query results. If
        /// the array contains more than one object, Amazon Macie uses an AND operator to join
        /// the conditions specified by the objects.
        /// </para>
        /// </summary>
        public List<UsageStatisticsFilter> FilterBy
        {
            get { return this._filterBy; }
            set { this._filterBy = value; }
        }

        // Check to see if FilterBy property is set
        internal bool IsSetFilterBy()
        {
            return this._filterBy != null && this._filterBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to include in each page of the response.
        /// </para>
        /// </summary>
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
        /// The nextToken string that specifies which page of results to return in a paginated
        /// response.
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The criteria to use to sort the query results.
        /// </para>
        /// </summary>
        public UsageStatisticsSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

    }
}