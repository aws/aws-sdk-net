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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the StartTraceRetrieval operation.
    /// Initiates a trace retrieval process using the specified time range and for the given
    /// trace IDs in the Transaction Search generated CloudWatch log group. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
    /// Search</a>. 
    /// 
    ///  
    /// <para>
    /// API returns a <c>RetrievalToken</c>, which can be used with <c>ListRetrievedTraces</c>
    /// or <c>GetRetrievedTracesGraph</c> to fetch results. Retrievals will time out after
    /// 60 minutes. To execute long time ranges, consider segmenting into multiple retrievals.
    /// </para>
    ///  
    /// <para>
    /// If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>, you can use this operation in a monitoring account
    /// to retrieve data from a linked source account, as long as both accounts have transaction
    /// search enabled.
    /// </para>
    ///  
    /// <para>
    /// For retrieving data from X-Ray directly as opposed to the Transaction-Search Log group,
    /// see <a href="https://docs.aws.amazon.com/xray/latest/api/API_BatchGetTraces.html">BatchGetTraces</a>.
    /// </para>
    /// </summary>
    public partial class StartTraceRetrievalRequest : AmazonXRayRequest
    {
        private DateTime? _endTime;
        private DateTime? _startTime;
        private List<string> _traceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end of the time range to retrieve traces. The range is inclusive, so the specified
        /// end time is included in the query. Specified as epoch time, the number of seconds
        /// since January 1, 1970, 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start of the time range to retrieve traces. The range is inclusive, so the specified
        /// start time is included in the query. Specified as epoch time, the number of seconds
        /// since January 1, 1970, 00:00:00 UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TraceIds. 
        /// <para>
        ///  Specify the trace IDs of the traces to be retrieved. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> TraceIds
        {
            get { return this._traceIds; }
            set { this._traceIds = value; }
        }

        // Check to see if TraceIds property is set
        internal bool IsSetTraceIds()
        {
            return this._traceIds != null && (this._traceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}