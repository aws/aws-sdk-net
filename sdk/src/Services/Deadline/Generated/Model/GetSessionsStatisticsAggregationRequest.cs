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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the GetSessionsStatisticsAggregation operation.
    /// Gets a set of statistics for queues or farms. Before you can call the <c>GetSessionStatisticsAggregation</c>
    /// operation, you must first call the <c>StartSessionsStatisticsAggregation</c> operation.
    /// Statistics are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
    /// operation.
    /// </summary>
    public partial class GetSessionsStatisticsAggregationRequest : AmazonDeadlineRequest
    {
        private string _aggregationId;
        private string _farmId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AggregationId. 
        /// <para>
        /// The identifier returned by the <c>StartSessionsStatisticsAggregation</c> operation
        /// that identifies the aggregated statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AggregationId
        {
            get { return this._aggregationId; }
            set { this._aggregationId = value; }
        }

        // Check to see if AggregationId property is set
        internal bool IsSetAggregationId()
        {
            return this._aggregationId != null;
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The identifier of the farm to include in the statistics. This should be the same as
        /// the farm ID used in the call to the <c>StartSessionsStatisticsAggregation</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
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
        /// The token for the next set of results, or <c>null</c> to start from the beginning.
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

    }
}