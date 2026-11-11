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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeSpotFleetRequestHistory operation.
    /// </summary>
    public partial class DescribeSpotFleetRequestHistoryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HistoryRecords. 
        /// <para>
        /// Information about the events in the history of the Spot Fleet request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HistoryRecord> HistoryRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<HistoryRecord>() : null;

        /// <summary>
        /// Checks to see if the HistoryRecords property is set.
        /// </summary>
        internal bool IsSetHistoryRecords() => this.HistoryRecords != null && (this.HistoryRecords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastEvaluatedTime. 
        /// <para>
        /// The last date and time for the events, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// All records up to this time were retrieved.
        /// </para>
        ///  
        /// <para>
        /// If <c>nextToken</c> indicates that there are more items, this value is not present.
        /// </para>
        /// </summary>
        public DateTime? LastEvaluatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedTime property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedTime() => this.LastEvaluatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to include in another request to get the next page of items. This value
        /// is <c>null</c> when there are no more items to return.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SpotFleetRequestId. 
        /// <para>
        /// The ID of the Spot Fleet request.
        /// </para>
        /// </summary>
        public string SpotFleetRequestId { get; set; }

        /// <summary>
        /// Checks to see if the SpotFleetRequestId property is set.
        /// </summary>
        internal bool IsSetSpotFleetRequestId() => this.SpotFleetRequestId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The starting date and time for the events, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
