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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListPipelineExecutions operation.
    /// Lists pipeline executions for a specific pipeline in a workspace. Supports filtering
    /// by state and time range. State can be combined with either startTime or endTime filters.
    /// Time range filters are grouped: use startTime filters (startTimeAfter, startTimeBefore)
    /// or endTime filters (endTimeAfter, endTimeBefore), but not both. Combining startTime
    /// and endTime filters returns an InvalidRequestException. Note: endTime filters only
    /// return executions in terminal states, as in-progress executions have no endTime.
    /// </summary>
    public partial class ListPipelineExecutionsRequest : AmazonIoTSiteWiseRequest
    {
        private DateTime? _endTimeAfter;
        private DateTime? _endTimeBefore;
        private int? _maxResults;
        private string _nextToken;
        private string _pipelineName;
        private DateTime? _startTimeAfter;
        private DateTime? _startTimeBefore;
        private PipelineExecutionState _state;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property EndTimeAfter. 
        /// <para>
        /// Inclusive lower bound on execution end time (ISO-8601). Only executions with endTime
        /// &gt;= endTimeAfter are returned. Cannot be combined with startTimeAfter or startTimeBefore.
        /// Only matches executions in terminal states.
        /// </para>
        /// </summary>
        public DateTime? EndTimeAfter
        {
            get { return this._endTimeAfter; }
            set { this._endTimeAfter = value; }
        }

        // Check to see if EndTimeAfter property is set
        internal bool IsSetEndTimeAfter()
        {
            return this._endTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimeBefore. 
        /// <para>
        /// Exclusive upper bound on execution end time (ISO-8601). Only executions with endTime
        /// &lt; endTimeBefore are returned. Cannot be combined with startTimeAfter or startTimeBefore.
        /// Only matches executions in terminal states.
        /// </para>
        /// </summary>
        public DateTime? EndTimeBefore
        {
            get { return this._endTimeBefore; }
            set { this._endTimeBefore = value; }
        }

        // Check to see if EndTimeBefore property is set
        internal bool IsSetEndTimeBefore()
        {
            return this._endTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per request. This is an upper bound; the actual
        /// number of results may be less. Default: 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeAfter. 
        /// <para>
        /// Inclusive lower bound on execution start time (ISO-8601). Only executions with startTime
        /// &gt;= startTimeAfter are returned. Cannot be combined with endTimeAfter or endTimeBefore.
        /// </para>
        /// </summary>
        public DateTime? StartTimeAfter
        {
            get { return this._startTimeAfter; }
            set { this._startTimeAfter = value; }
        }

        // Check to see if StartTimeAfter property is set
        internal bool IsSetStartTimeAfter()
        {
            return this._startTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeBefore. 
        /// <para>
        /// Exclusive upper bound on execution start time (ISO-8601). Only executions with startTime
        /// &lt; startTimeBefore are returned. Cannot be combined with endTimeAfter or endTimeBefore.
        /// </para>
        /// </summary>
        public DateTime? StartTimeBefore
        {
            get { return this._startTimeBefore; }
            set { this._startTimeBefore = value; }
        }

        // Check to see if StartTimeBefore property is set
        internal bool IsSetStartTimeBefore()
        {
            return this._startTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Filter by execution state. If not specified, executions in all states are returned.
        /// </para>
        /// </summary>
        public PipelineExecutionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}