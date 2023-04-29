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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the output of DescribeSpotFleetRequestHistory.
    /// </summary>
    public partial class DescribeSpotFleetRequestHistoryResponse : AmazonWebServiceResponse
    {
        private List<HistoryRecord> _historyRecords = new List<HistoryRecord>();
        private DateTime? _lastEvaluatedTime;
        private string _nextToken;
        private string _spotFleetRequestId;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property HistoryRecords. 
        /// <para>
        /// Information about the events in the history of the Spot Fleet request.
        /// </para>
        /// </summary>
        public List<HistoryRecord> HistoryRecords
        {
            get { return this._historyRecords; }
            set { this._historyRecords = value; }
        }

        // Check to see if HistoryRecords property is set
        internal bool IsSetHistoryRecords()
        {
            return this._historyRecords != null && this._historyRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastEvaluatedTime. 
        /// <para>
        /// The last date and time for the events, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// All records up to this time were retrieved.
        /// </para>
        ///  
        /// <para>
        /// If <code>nextToken</code> indicates that there are more items, this value is not present.
        /// </para>
        /// </summary>
        public DateTime LastEvaluatedTime
        {
            get { return this._lastEvaluatedTime.GetValueOrDefault(); }
            set { this._lastEvaluatedTime = value; }
        }

        // Check to see if LastEvaluatedTime property is set
        internal bool IsSetLastEvaluatedTime()
        {
            return this._lastEvaluatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to include in another request to get the next page of items. This value
        /// is <code>null</code> when there are no more items to return.
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
        /// Gets and sets the property SpotFleetRequestId. 
        /// <para>
        /// The ID of the Spot Fleet request.
        /// </para>
        /// </summary>
        public string SpotFleetRequestId
        {
            get { return this._spotFleetRequestId; }
            set { this._spotFleetRequestId = value; }
        }

        // Check to see if SpotFleetRequestId property is set
        internal bool IsSetSpotFleetRequestId()
        {
            return this._spotFleetRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The starting date and time for the events, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}