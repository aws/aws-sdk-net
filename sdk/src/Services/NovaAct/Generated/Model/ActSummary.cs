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
    /// Summary information about an act, including its status and execution timing.
    /// </summary>
    public partial class ActSummary
    {
        private string _actId;
        private DateTime? _endedAt;
        private string _sessionId;
        private DateTime? _startedAt;
        private ActStatus _status;
        private TraceLocation _traceLocation;
        private string _workflowRunId;

        /// <summary>
        /// Gets and sets the property ActId. 
        /// <para>
        /// The unique identifier of the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActId
        {
            get { return this._actId; }
            set { this._actId = value; }
        }

        // Check to see if ActId property is set
        internal bool IsSetActId()
        {
            return this._actId != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the act completed execution, if applicable.
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session containing this act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the act started execution.
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
        /// The current execution status of the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActStatus Status
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
        /// The location where trace information for this act is stored.
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
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The unique identifier of the workflow run containing this act.
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