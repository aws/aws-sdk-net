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
    /// <para> The configuration settings of a workflow type. </para>
    /// </summary>
    public class WorkflowTypeConfiguration
    {
        
        private string defaultTaskStartToCloseTimeout;
        private string defaultExecutionStartToCloseTimeout;
        private TaskList defaultTaskList;
        private string defaultChildPolicy;

        /// <summary>
        /// The optional default maximum duration, specified when registering the workflow type, that a decision task for executions of this workflow
        /// type might take before returning completion or failure. If the task does not close in the specified time then the task is automatically
        /// timed out and rescheduled. If the decider eventually reports a completion or failure, it is ignored. This default can be overridden when
        /// starting a workflow execution using the <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c> <a>Decision</a>. The
        /// valid values are integers greater than or equal to <c>0</c>. An integer value can be used to specify the duration in seconds while
        /// <c>NONE</c> can be used to specify unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultTaskStartToCloseTimeout
        {
            get { return this.defaultTaskStartToCloseTimeout; }
            set { this.defaultTaskStartToCloseTimeout = value; }
        }

        /// <summary>
        /// Sets the DefaultTaskStartToCloseTimeout property
        /// </summary>
        /// <param name="defaultTaskStartToCloseTimeout">The value to set for the DefaultTaskStartToCloseTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowTypeConfiguration WithDefaultTaskStartToCloseTimeout(string defaultTaskStartToCloseTimeout)
        {
            this.defaultTaskStartToCloseTimeout = defaultTaskStartToCloseTimeout;
            return this;
        }
            

        // Check to see if DefaultTaskStartToCloseTimeout property is set
        internal bool IsSetDefaultTaskStartToCloseTimeout()
        {
            return this.defaultTaskStartToCloseTimeout != null;
        }

        /// <summary>
        /// The optional default maximum duration, specified when registering the workflow type, for executions of this workflow type. This default can
        /// be overridden when starting a workflow execution using the <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c>
        /// <a>Decision</a>. The valid values are integers greater than or equal to <c>0</c>. An integer value can be used to specify the duration in
        /// seconds while <c>NONE</c> can be used to specify unlimited duration.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultExecutionStartToCloseTimeout
        {
            get { return this.defaultExecutionStartToCloseTimeout; }
            set { this.defaultExecutionStartToCloseTimeout = value; }
        }

        /// <summary>
        /// Sets the DefaultExecutionStartToCloseTimeout property
        /// </summary>
        /// <param name="defaultExecutionStartToCloseTimeout">The value to set for the DefaultExecutionStartToCloseTimeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowTypeConfiguration WithDefaultExecutionStartToCloseTimeout(string defaultExecutionStartToCloseTimeout)
        {
            this.defaultExecutionStartToCloseTimeout = defaultExecutionStartToCloseTimeout;
            return this;
        }
            

        // Check to see if DefaultExecutionStartToCloseTimeout property is set
        internal bool IsSetDefaultExecutionStartToCloseTimeout()
        {
            return this.defaultExecutionStartToCloseTimeout != null;
        }

        /// <summary>
        /// The optional default task list, specified when registering the workflow type, for decisions tasks scheduled for workflow executions of this
        /// type. This default can be overridden when starting a workflow execution using the <a>StartWorkflowExecution</a> action or the
        /// <c>StartChildWorkflowExecution</c> <a>Decision</a>.
        ///  
        /// </summary>
        public TaskList DefaultTaskList
        {
            get { return this.defaultTaskList; }
            set { this.defaultTaskList = value; }
        }

        /// <summary>
        /// Sets the DefaultTaskList property
        /// </summary>
        /// <param name="defaultTaskList">The value to set for the DefaultTaskList property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowTypeConfiguration WithDefaultTaskList(TaskList defaultTaskList)
        {
            this.defaultTaskList = defaultTaskList;
            return this;
        }
            

        // Check to see if DefaultTaskList property is set
        internal bool IsSetDefaultTaskList()
        {
            return this.defaultTaskList != null;
        }

        /// <summary>
        /// The optional default policy to use for the child workflow executions when a workflow execution of this type is terminated, by calling the
        /// <a>TerminateWorkflowExecution</a> action explicitly or due to an expired timeout. This default can be overridden when starting a workflow
        /// execution using the <a>StartWorkflowExecution</a> action or the <c>StartChildWorkflowExecution</c> <a>Decision</a>. The supported child
        /// policies are: <ul> <li><b>TERMINATE:</b> the child executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b> a request to cancel will
        /// be attempted for each child execution by recording a <c>WorkflowExecutionCancelRequested</c> event in its history. It is up to the decider
        /// to take appropriate actions when it receives an execution history with this event. </li> <li><b>ABANDON:</b> no action will be taken. The
        /// child executions will continue to run.</li> </ul>
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
        public string DefaultChildPolicy
        {
            get { return this.defaultChildPolicy; }
            set { this.defaultChildPolicy = value; }
        }

        /// <summary>
        /// Sets the DefaultChildPolicy property
        /// </summary>
        /// <param name="defaultChildPolicy">The value to set for the DefaultChildPolicy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowTypeConfiguration WithDefaultChildPolicy(string defaultChildPolicy)
        {
            this.defaultChildPolicy = defaultChildPolicy;
            return this;
        }
            

        // Check to see if DefaultChildPolicy property is set
        internal bool IsSetDefaultChildPolicy()
        {
            return this.defaultChildPolicy != null;
        }
    }
}
