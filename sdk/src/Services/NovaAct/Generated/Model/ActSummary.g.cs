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
    /// Summary information about an act, including its status and execution timing.
    /// </summary>
    public partial class ActSummary
    {
        /// <summary>
        /// Gets and sets the property ActId. 
        /// <para>
        /// The unique identifier of the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ActId { get; set; }

        /// <summary>
        /// Checks to see if the ActId property is set.
        /// </summary>
        internal bool IsSetActId() => this.ActId != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the act completed execution, if applicable.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session containing this act.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the act started execution.
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
        /// The current execution status of the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TraceLocation. 
        /// <para>
        /// The location where trace information for this act is stored.
        /// </para>
        /// </summary>
        public TraceLocation TraceLocation { get; set; }

        /// <summary>
        /// Checks to see if the TraceLocation property is set.
        /// </summary>
        internal bool IsSetTraceLocation() => this.TraceLocation != null;

        /// <summary>
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The unique identifier of the workflow run containing this act.
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
