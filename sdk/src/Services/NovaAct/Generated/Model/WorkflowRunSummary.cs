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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
        private DateTime? _endedAt;
        private DateTime? _startedAt;
        private WorkflowRunStatus _status;
        private TraceLocation _traceLocation;
        private string _workflowRunArn;
        private string _workflowRunId;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the workflow run completed execution, if applicable.
        /// </para>
        /// </summary>
        public DateTime EndedAt
        {
            get { return this._endedAt.GetValueOrDefault(); }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the workflow run started execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current execution status of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowRunStatus Status
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
        /// Gets and sets the property TraceLocation. 
        /// <para>
        /// The location where trace information for this workflow run is stored.
        /// </para>
        /// </summary>
        public TraceLocation TraceLocation
        {
            get { return this._traceLocation; }
            set { this._traceLocation = value; }
        }

        // Check to see if TraceLocation property is set
        internal bool IsSetTraceLocation()
        {
            return this._traceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkflowRunArn
        {
            get { return this._workflowRunArn; }
            set { this._workflowRunArn = value; }
        }

        // Check to see if WorkflowRunArn property is set
        internal bool IsSetWorkflowRunArn()
        {
            return this._workflowRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The unique identifier of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkflowRunId
        {
            get { return this._workflowRunId; }
            set { this._workflowRunId = value; }
        }

        // Check to see if WorkflowRunId property is set
        internal bool IsSetWorkflowRunId()
        {
            return this._workflowRunId != null;
        }

    }
}