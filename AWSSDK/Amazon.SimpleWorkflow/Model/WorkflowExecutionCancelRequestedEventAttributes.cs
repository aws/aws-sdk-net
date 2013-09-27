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
    /// <para> Provides details of the <c>WorkflowExecutionCancelRequested</c> event. </para>
    /// </summary>
    public class WorkflowExecutionCancelRequestedEventAttributes
    {
        
        private WorkflowExecution externalWorkflowExecution;
        private long? externalInitiatedEventId;
        private string cause;

        /// <summary>
        /// The external workflow execution for which the cancellation was requested.
        ///  
        /// </summary>
        public WorkflowExecution ExternalWorkflowExecution
        {
            get { return this.externalWorkflowExecution; }
            set { this.externalWorkflowExecution = value; }
        }

        /// <summary>
        /// Sets the ExternalWorkflowExecution property
        /// </summary>
        /// <param name="externalWorkflowExecution">The value to set for the ExternalWorkflowExecution property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionCancelRequestedEventAttributes WithExternalWorkflowExecution(WorkflowExecution externalWorkflowExecution)
        {
            this.externalWorkflowExecution = externalWorkflowExecution;
            return this;
        }
            

        // Check to see if ExternalWorkflowExecution property is set
        internal bool IsSetExternalWorkflowExecution()
        {
            return this.externalWorkflowExecution != null;
        }

        /// <summary>
        /// The id of the <c>RequestCancelExternalWorkflowExecutionInitiated</c> event corresponding to the
        /// <c>RequestCancelExternalWorkflowExecution</c> decision to cancel this workflow execution.The source event with this Id can be found in the
        /// history of the source workflow execution. This information can be useful for diagnosing problems by tracing back the chain of events leading
        /// up to this event.
        ///  
        /// </summary>
        public long ExternalInitiatedEventId
        {
            get { return this.externalInitiatedEventId ?? default(long); }
            set { this.externalInitiatedEventId = value; }
        }

        /// <summary>
        /// Sets the ExternalInitiatedEventId property
        /// </summary>
        /// <param name="externalInitiatedEventId">The value to set for the ExternalInitiatedEventId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionCancelRequestedEventAttributes WithExternalInitiatedEventId(long externalInitiatedEventId)
        {
            this.externalInitiatedEventId = externalInitiatedEventId;
            return this;
        }
            

        // Check to see if ExternalInitiatedEventId property is set
        internal bool IsSetExternalInitiatedEventId()
        {
            return this.externalInitiatedEventId.HasValue;
        }

        /// <summary>
        /// If set, indicates that the request to cancel the workflow execution was automatically generated, and specifies the cause. This happens if
        /// the parent workflow execution times out or is terminated, and the child policy is set to cancel child executions.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CHILD_POLICY_APPLIED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Cause
        {
            get { return this.cause; }
            set { this.cause = value; }
        }

        /// <summary>
        /// Sets the Cause property
        /// </summary>
        /// <param name="cause">The value to set for the Cause property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionCancelRequestedEventAttributes WithCause(string cause)
        {
            this.cause = cause;
            return this;
        }
            

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this.cause != null;
        }
    }
}
