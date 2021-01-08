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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <code>ChildWorkflowExecutionTerminated</code> event.
    /// </summary>
    public partial class ChildWorkflowExecutionTerminatedEventAttributes
    {
        private long? _initiatedEventId;
        private long? _startedEventId;
        private WorkflowExecution _workflowExecution;
        private WorkflowType _workflowType;

        /// <summary>
        /// Gets and sets the property InitiatedEventId. 
        /// <para>
        /// The ID of the <code>StartChildWorkflowExecutionInitiated</code> event corresponding
        /// to the <code>StartChildWorkflowExecution</code> <a>Decision</a> to start this child
        /// workflow execution. This information can be useful for diagnosing problems by tracing
        /// back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long InitiatedEventId
        {
            get { return this._initiatedEventId.GetValueOrDefault(); }
            set { this._initiatedEventId = value; }
        }

        // Check to see if InitiatedEventId property is set
        internal bool IsSetInitiatedEventId()
        {
            return this._initiatedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedEventId. 
        /// <para>
        /// The ID of the <code>ChildWorkflowExecutionStarted</code> event recorded when this
        /// child workflow execution was started. This information can be useful for diagnosing
        /// problems by tracing back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long StartedEventId
        {
            get { return this._startedEventId.GetValueOrDefault(); }
            set { this._startedEventId = value; }
        }

        // Check to see if StartedEventId property is set
        internal bool IsSetStartedEventId()
        {
            return this._startedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecution. 
        /// <para>
        /// The child workflow execution that was terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowExecution WorkflowExecution
        {
            get { return this._workflowExecution; }
            set { this._workflowExecution = value; }
        }

        // Check to see if WorkflowExecution property is set
        internal bool IsSetWorkflowExecution()
        {
            return this._workflowExecution != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The type of the child workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowType WorkflowType
        {
            get { return this._workflowType; }
            set { this._workflowType = value; }
        }

        // Check to see if WorkflowType property is set
        internal bool IsSetWorkflowType()
        {
            return this._workflowType != null;
        }

    }
}