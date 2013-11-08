/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Provides details of the <c>ExternalWorkflowExecutionSignaled</c> event. </para>
    /// </summary>
    public class ExternalWorkflowExecutionSignaledEventAttributes
    {
        
        private WorkflowExecution workflowExecution;
        private long? initiatedEventId;

        /// <summary>
        /// The external workflow execution that the signal was delivered to.
        ///  
        /// </summary>
        public WorkflowExecution WorkflowExecution
        {
            get { return this.workflowExecution; }
            set { this.workflowExecution = value; }
        }

        // Check to see if WorkflowExecution property is set
        internal bool IsSetWorkflowExecution()
        {
            return this.workflowExecution != null;
        }

        /// <summary>
        /// The id of the <c>SignalExternalWorkflowExecutionInitiated</c> event corresponding to the <c>SignalExternalWorkflowExecution</c> decision to
        /// request this signal. This information can be useful for diagnosing problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long InitiatedEventId
        {
            get { return this.initiatedEventId ?? default(long); }
            set { this.initiatedEventId = value; }
        }

        // Check to see if InitiatedEventId property is set
        internal bool IsSetInitiatedEventId()
        {
            return this.initiatedEventId.HasValue;
        }
    }
}
