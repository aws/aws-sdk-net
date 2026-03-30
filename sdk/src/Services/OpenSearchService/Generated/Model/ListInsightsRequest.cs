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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the ListInsights operation.
    /// Lists insights for an Amazon OpenSearch Service domain or Amazon Web Services account.
    /// Returns a paginated list of insights based on the specified entity, filters, time
    /// range, and sort order.
    /// </summary>
    public partial class ListInsightsRequest : AmazonOpenSearchServiceRequest
    {
        private InsightEntity _entity;
        private int? _maxResults;
        private string _nextToken;
        private InsightSortOrder _sortOrder;
        private InsightTimeRange _timeRange;

        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The entity for which to list insights. Specifies the type and value of the entity,
        /// such as a domain name or Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InsightEntity Entity
        {
            get { return this._entity; }
            set { this._entity = value; }
        }

        // Check to see if Entity property is set
        internal bool IsSetEntity()
        {
            return this._entity != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional parameter that specifies the maximum number of results to return. You
        /// can use <c>NextToken</c> to get the next page of results. Valid values are 1 to 500.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// If your initial <c>ListInsights</c> operation returns a <c>NextToken</c>, include
        /// the returned <c>NextToken</c> in subsequent <c>ListInsights</c> operations to retrieve
        /// the next page of results.
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
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for the results. Possible values are <c>ASC</c> (ascending) and <c>DESC</c>
        /// (descending).
        /// </para>
        /// </summary>
        public InsightSortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        /// The time range for filtering insights, specified as epoch millisecond timestamps.
        /// </para>
        /// </summary>
        public InsightTimeRange TimeRange
        {
            get { return this._timeRange; }
            set { this._timeRange = value; }
        }

        // Check to see if TimeRange property is set
        internal bool IsSetTimeRange()
        {
            return this._timeRange != null;
        }

    }
}