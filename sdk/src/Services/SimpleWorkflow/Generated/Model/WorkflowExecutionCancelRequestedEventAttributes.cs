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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
        private WorkflowExecutionCancelRequestedCause _cause;
        private long? _externalInitiatedEventId;
        private WorkflowExecution _externalWorkflowExecution;

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// If set, indicates that the request to cancel the workflow execution was automatically
        /// generated, and specifies the cause. This happens if the parent workflow execution
        /// times out or is terminated, and the child policy is set to cancel child executions.
        /// </para>
        /// </summary>
        public WorkflowExecutionCancelRequestedCause Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

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
        public long? ExternalInitiatedEventId
        {
            get { return this._externalInitiatedEventId; }
            set { this._externalInitiatedEventId = value; }
        }

        // Check to see if ExternalInitiatedEventId property is set
        internal bool IsSetExternalInitiatedEventId()
        {
            return this._externalInitiatedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExternalWorkflowExecution. 
        /// <para>
        /// The external workflow execution for which the cancellation was requested.
        /// </para>
        /// </summary>
        public WorkflowExecution ExternalWorkflowExecution
        {
            get { return this._externalWorkflowExecution; }
            set { this._externalWorkflowExecution = value; }
        }

        // Check to see if ExternalWorkflowExecution property is set
        internal bool IsSetExternalWorkflowExecution()
        {
            return this._externalWorkflowExecution != null;
        }

    }
}