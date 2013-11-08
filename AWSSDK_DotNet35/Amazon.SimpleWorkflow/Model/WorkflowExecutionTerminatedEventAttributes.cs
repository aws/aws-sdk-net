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
    /// <para> Provides details of the <c>WorkflowExecutionTerminated</c> event. </para>
    /// </summary>
    public class WorkflowExecutionTerminatedEventAttributes
    {
        
        private string reason;
        private string details;
        private ChildPolicy childPolicy;
        private WorkflowExecutionTerminatedCause cause;

        /// <summary>
        /// The reason provided for the termination (if any).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this.reason; }
            set { this.reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this.reason != null;
        }

        /// <summary>
        /// The details provided for the termination (if any).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32768</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this.details != null;
        }

        /// <summary>
        /// The policy used for the child workflow executions of this workflow execution. The supported child policies are: <ul> <li><b>TERMINATE:</b>
        /// the child executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b> a request to cancel will be attempted for each child execution by
        /// recording a <c>WorkflowExecutionCancelRequested</c> event in its history. It is up to the decider to take appropriate actions when it
        /// receives an execution history with this event. </li> <li><b>ABANDON:</b> no action will be taken. The child executions will continue to
        /// run.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>TERMINATE, REQUEST_CANCEL, ABANDON</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ChildPolicy ChildPolicy
        {
            get { return this.childPolicy; }
            set { this.childPolicy = value; }
        }

        // Check to see if ChildPolicy property is set
        internal bool IsSetChildPolicy()
        {
            return this.childPolicy != null;
        }

        /// <summary>
        /// If set, indicates that the workflow execution was automatically terminated, and specifies the cause. This happens if the parent workflow
        /// execution times out or is terminated and the child policy is set to terminate child executions.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CHILD_POLICY_APPLIED, EVENT_LIMIT_EXCEEDED, OPERATOR_INITIATED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public WorkflowExecutionTerminatedCause Cause
        {
            get { return this.cause; }
            set { this.cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this.cause != null;
        }
    }
}
