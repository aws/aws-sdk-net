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

namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Summary information about a workflow run, including execution status and timing.
    /// </summary>
    public partial class WorkflowRunSummary
    {
        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the workflow run completed execution, if applicable.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the workflow run started execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current execution status of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TraceLocation. 
        /// <para>
        /// The location where trace information for this workflow run is stored.
        /// </para>
        /// </summary>
        public TraceLocation TraceLocation { get; set; }

        /// <summary>
        /// Checks to see if the TraceLocation property is set.
        /// </summary>
        internal bool IsSetTraceLocation() => this.TraceLocation != null;

        /// <summary>
        /// Gets and sets the property WorkflowRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkflowRunArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowRunArn property is set.
        /// </summary>
        internal bool IsSetWorkflowRunArn() => this.WorkflowRunArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The unique identifier of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkflowRunId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowRunId property is set.
        /// </summary>
        internal bool IsSetWorkflowRunId() => this.WorkflowRunId != null;
    }
}
