/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Provides details of the <c>ChildWorkflowExecutionTerminated</c> event. </para>
    /// </summary>
    public class ChildWorkflowExecutionTerminatedEventAttributes  
    {
        
        private WorkflowExecution workflowExecution;
        private WorkflowType workflowType;
        private long? initiatedEventId;
        private long? startedEventId;

        /// <summary>
        /// The child workflow execution that was terminated.
        ///  
        /// </summary>
        public WorkflowExecution WorkflowExecution
        {
            get { return this.workflowExecution; }
            set { this.workflowExecution = value; }
        }

        /// <summary>
        /// Sets the WorkflowExecution property
        /// </summary>
        /// <param name="workflowExecution">The value to set for the WorkflowExecution property </param>
        /// <returns>this instance</returns>
        public ChildWorkflowExecutionTerminatedEventAttributes WithWorkflowExecution(WorkflowExecution workflowExecution)
        {
            this.workflowExecution = workflowExecution;
            return this;
        }
            

        // Check to see if WorkflowExecution property is set
        internal bool IsSetWorkflowExecution()
        {
            return this.workflowExecution != null;       
        }

        /// <summary>
        /// The type of the child workflow execution.
        ///  
        /// </summary>
        public WorkflowType WorkflowType
        {
            get { return this.workflowType; }
            set { this.workflowType = value; }
        }

        /// <summary>
        /// Sets the WorkflowType property
        /// </summary>
        /// <param name="workflowType">The value to set for the WorkflowType property </param>
        /// <returns>this instance</returns>
        public ChildWorkflowExecutionTerminatedEventAttributes WithWorkflowType(WorkflowType workflowType)
        {
            this.workflowType = workflowType;
            return this;
        }
            

        // Check to see if WorkflowType property is set
        internal bool IsSetWorkflowType()
        {
            return this.workflowType != null;       
        }

        /// <summary>
        /// The id of the <c>StartChildWorkflowExecutionInitiated</c> event corresponding to the <c>StartChildWorkflowExecution</c> <a>Decision</a> to
        /// start this child workflow execution. This information can be useful for diagnosing problems by tracing back the chain of events leading up
        /// to this event.
        ///  
        /// </summary>
        public long InitiatedEventId
        {
            get { return this.initiatedEventId ?? default(long); }
            set { this.initiatedEventId = value; }
        }

        /// <summary>
        /// Sets the InitiatedEventId property
        /// </summary>
        /// <param name="initiatedEventId">The value to set for the InitiatedEventId property </param>
        /// <returns>this instance</returns>
        public ChildWorkflowExecutionTerminatedEventAttributes WithInitiatedEventId(long initiatedEventId)
        {
            this.initiatedEventId = initiatedEventId;
            return this;
        }
            

        // Check to see if InitiatedEventId property is set
        internal bool IsSetInitiatedEventId()
        {
            return this.initiatedEventId.HasValue;       
        }

        /// <summary>
        /// The Id of the <c>ChildWorkflowExecutionStarted</c> event recorded when this child workflow execution was started. This information can be
        /// useful for diagnosing problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long StartedEventId
        {
            get { return this.startedEventId ?? default(long); }
            set { this.startedEventId = value; }
        }

        /// <summary>
        /// Sets the StartedEventId property
        /// </summary>
        /// <param name="startedEventId">The value to set for the StartedEventId property </param>
        /// <returns>this instance</returns>
        public ChildWorkflowExecutionTerminatedEventAttributes WithStartedEventId(long startedEventId)
        {
            this.startedEventId = startedEventId;
            return this;
        }
            

        // Check to see if StartedEventId property is set
        internal bool IsSetStartedEventId()
        {
            return this.startedEventId.HasValue;       
        }
    }
}
