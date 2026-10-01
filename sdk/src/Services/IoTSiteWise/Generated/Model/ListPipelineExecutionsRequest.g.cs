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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListPipelineExecutions operation. Lists pipeline
    /// executions for a specific pipeline in a workspace. Supports filtering by state and
    /// time range. State can be combined with either startTime or endTime filters. Time range
    /// filters are grouped: use startTime filters (startTimeAfter, startTimeBefore) or endTime
    /// filters (endTimeAfter, endTimeBefore), but not both. Combining startTime and endTime
    /// filters returns an InvalidRequestException. Note: endTime filters only return executions
    /// in terminal states, as in-progress executions have no endTime.
    /// </summary>
    public partial class ListPipelineExecutionsRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property EndTimeAfter. 
        /// <para>
        /// Inclusive lower bound on execution end time (ISO-8601). Only executions with endTime
        /// &gt;= endTimeAfter are returned. Cannot be combined with startTimeAfter or startTimeBefore.
        /// Only matches executions in terminal states.
        /// </para>
        /// </summary>
        public DateTime? EndTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeAfter property is set.
        /// </summary>
        internal bool IsSetEndTimeAfter() => this.EndTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property EndTimeBefore. 
        /// <para>
        /// Exclusive upper bound on execution end time (ISO-8601). Only executions with endTime
        /// &lt; endTimeBefore are returned. Cannot be combined with startTimeAfter or startTimeBefore.
        /// Only matches executions in terminal states.
        /// </para>
        /// </summary>
        public DateTime? EndTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeBefore property is set.
        /// </summary>
        internal bool IsSetEndTimeBefore() => this.EndTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per request. This is an upper bound; the actual
        /// number of results may be less. Default: 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property StartTimeAfter. 
        /// <para>
        /// Inclusive lower bound on execution start time (ISO-8601). Only executions with startTime
        /// &gt;= startTimeAfter are returned. Cannot be combined with endTimeAfter or endTimeBefore.
        /// </para>
        /// </summary>
        public DateTime? StartTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeAfter property is set.
        /// </summary>
        internal bool IsSetStartTimeAfter() => this.StartTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property StartTimeBefore. 
        /// <para>
        /// Exclusive upper bound on execution start time (ISO-8601). Only executions with startTime
        /// &lt; startTimeBefore are returned. Cannot be combined with endTimeAfter or endTimeBefore.
        /// </para>
        /// </summary>
        public DateTime? StartTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeBefore property is set.
        /// </summary>
        internal bool IsSetStartTimeBefore() => this.StartTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Filter by execution state. If not specified, executions in all states are returned.
        /// </para>
        /// </summary>
        public PipelineExecutionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
