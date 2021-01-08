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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the SearchFlowExecutions operation.
    /// Searches for AWS IoT Things Graph workflow execution instances.
    /// </summary>
    public partial class SearchFlowExecutionsRequest : AmazonIoTThingsGraphRequest
    {
        private DateTime? _endTime;
        private string _flowExecutionId;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;
        private string _systemInstanceId;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time of the latest flow execution to return.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FlowExecutionId. 
        /// <para>
        /// The ID of a flow execution.
        /// </para>
        /// </summary>
        public string FlowExecutionId
        {
            get { return this._flowExecutionId; }
            set { this._flowExecutionId = value; }
        }

        // Check to see if FlowExecutionId property is set
        internal bool IsSetFlowExecutionId()
        {
            return this._flowExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// The string that specifies the next page of results. Use this when you're paginating
        /// results.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time of the earliest flow execution to return.
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

        /// <summary>
        /// Gets and sets the property SystemInstanceId. 
        /// <para>
        /// The ID of the system instance that contains the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=160)]
        public string SystemInstanceId
        {
            get { return this._systemInstanceId; }
            set { this._systemInstanceId = value; }
        }

        // Check to see if SystemInstanceId property is set
        internal bool IsSetSystemInstanceId()
        {
            return this._systemInstanceId != null;
        }

    }
}