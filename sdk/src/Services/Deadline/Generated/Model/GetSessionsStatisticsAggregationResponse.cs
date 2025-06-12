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
    /// This is the response object from the GetSessionsStatisticsAggregation operation.
    /// </summary>
    public partial class GetSessionsStatisticsAggregationResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Statistics> _statistics = AWSConfigs.InitializeCollections ? new List<Statistics>() : null;
        private SessionsStatisticsAggregationStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If Deadline Cloud returns <c>nextToken</c>, then there are more results available.
        /// The value of <c>nextToken</c> is a unique pagination token for each page. To retrieve
        /// the next page, call the operation again using the returned token. Keep all other arguments
        /// unchanged. If no results remain, then <c>nextToken</c> is set to <c>null</c>. Each
        /// pagination token expires after 24 hours. If you provide a token that isn't valid,
        /// then you receive an HTTP 400 <c>ValidationException</c> error.
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
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistics for the specified fleets or queues.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Statistics> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && (this._statistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the aggregated results. An aggregation may fail or time out if the results
        /// are too large. If this happens, you can call the <c>StartSessionsStatisticsAggregation</c>
        /// operation after you reduce the aggregation time frame, reduce the number of queues
        /// or fleets in the aggregation, or increase the period length.
        /// </para>
        ///  
        /// <para>
        /// If you call the <c>StartSessionsStatisticsAggregation </c> operation when the status
        /// is <c>IN_PROGRESS</c>, you will receive a <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionsStatisticsAggregationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that describes the status.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}