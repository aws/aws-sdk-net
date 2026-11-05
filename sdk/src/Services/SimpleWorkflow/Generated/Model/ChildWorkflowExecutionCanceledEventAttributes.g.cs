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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provide details of the <c>ChildWorkflowExecutionCanceled</c> event.
    /// </summary>
    public partial class ChildWorkflowExecutionCanceledEventAttributes
    {
        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Details of the cancellation (if provided).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property InitiatedEventId. 
        /// <para>
        /// The ID of the <c>StartChildWorkflowExecutionInitiated</c> event corresponding to the
        /// <c>StartChildWorkflowExecution</c> <a>Decision</a> to start this child workflow execution.
        /// This information can be useful for diagnosing problems by tracing back the chain of
        /// events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? InitiatedEventId { get; set; }

        /// <summary>
        /// Checks to see if the InitiatedEventId property is set.
        /// </summary>
        internal bool IsSetInitiatedEventId() => this.InitiatedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property StartedEventId. 
        /// <para>
        /// The ID of the <c>ChildWorkflowExecutionStarted</c> event recorded when this child
        /// workflow execution was started. This information can be useful for diagnosing problems
        /// by tracing back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StartedEventId { get; set; }

        /// <summary>
        /// Checks to see if the StartedEventId property is set.
        /// </summary>
        internal bool IsSetStartedEventId() => this.StartedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property WorkflowExecution. 
        /// <para>
        /// The child workflow execution that was canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowExecution WorkflowExecution { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecution property is set.
        /// </summary>
        internal bool IsSetWorkflowExecution() => this.WorkflowExecution != null;

        /// <summary>
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The type of the child workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowType WorkflowType { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowType property is set.
        /// </summary>
        internal bool IsSetWorkflowType() => this.WorkflowType != null;
    }
}
