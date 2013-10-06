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
    /// <para> Provides details of the <c>ExternalWorkflowExecutionCancelRequested</c> event. </para>
    /// </summary>
    public class ExternalWorkflowExecutionCancelRequestedEventAttributes
    {
        
        private WorkflowExecution workflowExecution;
        private long? initiatedEventId;

        /// <summary>
        /// The external workflow execution to which the cancellation request was delivered.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ExternalWorkflowExecutionCancelRequestedEventAttributes WithWorkflowExecution(WorkflowExecution workflowExecution)
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
        /// The id of the <c>RequestCancelExternalWorkflowExecutionInitiated</c> event corresponding to the
        /// <c>RequestCancelExternalWorkflowExecution</c> decision to cancel this external workflow execution. This information can be useful for
        /// diagnosing problems by tracing back the chain of events leading up to this event.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ExternalWorkflowExecutionCancelRequestedEventAttributes WithInitiatedEventId(long initiatedEventId)
        {
            this.initiatedEventId = initiatedEventId;
            return this;
        }
            

        // Check to see if InitiatedEventId property is set
        internal bool IsSetInitiatedEventId()
        {
            return this.initiatedEventId.HasValue;
        }
    }
}
