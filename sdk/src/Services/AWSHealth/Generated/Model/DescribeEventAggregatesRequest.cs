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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEventAggregates operation.
    /// Returns the number of events of each event type (issue, scheduled change, and account
    /// notification). If no filter is specified, the counts of all events in each category
    /// are returned.
    /// 
    ///  <note> 
    /// <para>
    /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
    /// the next request to return more results.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeEventAggregatesRequest : AmazonAWSHealthRequest
    {
        private EventAggregateField _aggregateField;
        private EventFilter _filter;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AggregateField. 
        /// <para>
        /// The only currently supported value is <code>eventTypeCategory</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventAggregateField AggregateField
        {
            get { return this._aggregateField; }
            set { this._aggregateField = value; }
        }

        // Check to see if AggregateField property is set
        internal bool IsSetAggregateField()
        {
            return this._aggregateField != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Values to narrow the results returned.
        /// </para>
        /// </summary>
        public EventFilter Filter
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
        /// The maximum number of items to return in one batch, between 10 and 100, inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=100)]
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
        /// If the results of a search are large, only a portion of the results are returned,
        /// and a <code>nextToken</code> pagination token is returned in the response. To retrieve
        /// the next batch of results, reissue the search request and include the returned token.
        /// When all results have been returned, the response does not contain a pagination token
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=10000)]
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

    }
}