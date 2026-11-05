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
    /// Provides the details of the <c>WorkflowExecutionCancelRequested</c> event.
    /// </summary>
    public partial class WorkflowExecutionCancelRequestedEventAttributes
    {
        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// If set, indicates that the request to cancel the workflow execution was automatically
        /// generated, and specifies the cause. This happens if the parent workflow execution
        /// times out or is terminated, and the child policy is set to cancel child executions.
        /// </para>
        /// </summary>
        public WorkflowExecutionCancelRequestedCause Cause { get; set; }

        /// <summary>
        /// Checks to see if the Cause property is set.
        /// </summary>
        internal bool IsSetCause() => this.Cause != null;

        /// <summary>
        /// Gets and sets the property ExternalInitiatedEventId. 
        /// <para>
        /// The ID of the <c>RequestCancelExternalWorkflowExecutionInitiated</c> event corresponding
        /// to the <c>RequestCancelExternalWorkflowExecution</c> decision to cancel this workflow
        /// execution.The source event with this ID can be found in the history of the source
        /// workflow execution. This information can be useful for diagnosing problems by tracing
        /// back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        public long? ExternalInitiatedEventId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalInitiatedEventId property is set.
        /// </summary>
        internal bool IsSetExternalInitiatedEventId() => this.ExternalInitiatedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property ExternalWorkflowExecution. 
        /// <para>
        /// The external workflow execution for which the cancellation was requested.
        /// </para>
        /// </summary>
        public WorkflowExecution ExternalWorkflowExecution { get; set; }

        /// <summary>
        /// Checks to see if the ExternalWorkflowExecution property is set.
        /// </summary>
        internal bool IsSetExternalWorkflowExecution() => this.ExternalWorkflowExecution != null;
    }
}
