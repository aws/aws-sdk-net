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
    /// <para> Contains information about a workflow execution. </para>
    /// </summary>
    public class WorkflowExecutionInfo
    {
        
        private WorkflowExecution execution;
        private WorkflowType workflowType;
        private DateTime? startTimestamp;
        private DateTime? closeTimestamp;
        private string executionStatus;
        private string closeStatus;
        private WorkflowExecution parent;
        private List<string> tagList = new List<string>();
        private bool? cancelRequested;

        /// <summary>
        /// The workflow execution this information is about.
        ///  
        /// </summary>
        public WorkflowExecution Execution
        {
            get { return this.execution; }
            set { this.execution = value; }
        }

        /// <summary>
        /// Sets the Execution property
        /// </summary>
        /// <param name="execution">The value to set for the Execution property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithExecution(WorkflowExecution execution)
        {
            this.execution = execution;
            return this;
        }
            

        // Check to see if Execution property is set
        internal bool IsSetExecution()
        {
            return this.execution != null;
        }

        /// <summary>
        /// The type of the workflow execution.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithWorkflowType(WorkflowType workflowType)
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
        /// The time when the execution was started.
        ///  
        /// </summary>
        public DateTime StartTimestamp
        {
            get { return this.startTimestamp ?? default(DateTime); }
            set { this.startTimestamp = value; }
        }

        /// <summary>
        /// Sets the StartTimestamp property
        /// </summary>
        /// <param name="startTimestamp">The value to set for the StartTimestamp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithStartTimestamp(DateTime startTimestamp)
        {
            this.startTimestamp = startTimestamp;
            return this;
        }
            

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this.startTimestamp.HasValue;
        }

        /// <summary>
        /// The time when the workflow execution was closed. Set only if the execution status is CLOSED.
        ///  
        /// </summary>
        public DateTime CloseTimestamp
        {
            get { return this.closeTimestamp ?? default(DateTime); }
            set { this.closeTimestamp = value; }
        }

        /// <summary>
        /// Sets the CloseTimestamp property
        /// </summary>
        /// <param name="closeTimestamp">The value to set for the CloseTimestamp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithCloseTimestamp(DateTime closeTimestamp)
        {
            this.closeTimestamp = closeTimestamp;
            return this;
        }
            

        // Check to see if CloseTimestamp property is set
        internal bool IsSetCloseTimestamp()
        {
            return this.closeTimestamp.HasValue;
        }

        /// <summary>
        /// The current status of the execution.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>OPEN, CLOSED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ExecutionStatus
        {
            get { return this.executionStatus; }
            set { this.executionStatus = value; }
        }

        /// <summary>
        /// Sets the ExecutionStatus property
        /// </summary>
        /// <param name="executionStatus">The value to set for the ExecutionStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithExecutionStatus(string executionStatus)
        {
            this.executionStatus = executionStatus;
            return this;
        }
            

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this.executionStatus != null;
        }

        /// <summary>
        /// If the execution status is closed then this specifies how the execution was closed: <ul> <li>COMPLETED: the execution was successfully
        /// completed.</li> <li>CANCELED: the execution was canceled.Cancellation allows the implementation to gracefully clean up before the execution
        /// is closed.</li> <li>TERMINATED: the execution was force terminated.</li> <li>FAILED: the execution failed to complete.</li> <li>TIMED_OUT:
        /// the execution did not complete in the alloted time and was automatically timed out.</li> <li>CONTINUED_AS_NEW: the execution is logically
        /// continued. This means the current execution was completed and a new execution was started to carry on the workflow.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>COMPLETED, FAILED, CANCELED, TERMINATED, CONTINUED_AS_NEW, TIMED_OUT</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CloseStatus
        {
            get { return this.closeStatus; }
            set { this.closeStatus = value; }
        }

        /// <summary>
        /// Sets the CloseStatus property
        /// </summary>
        /// <param name="closeStatus">The value to set for the CloseStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithCloseStatus(string closeStatus)
        {
            this.closeStatus = closeStatus;
            return this;
        }
            

        // Check to see if CloseStatus property is set
        internal bool IsSetCloseStatus()
        {
            return this.closeStatus != null;
        }

        /// <summary>
        /// If this workflow execution is a child of another execution then contains the workflow execution that started this execution.
        ///  
        /// </summary>
        public WorkflowExecution Parent
        {
            get { return this.parent; }
            set { this.parent = value; }
        }

        /// <summary>
        /// Sets the Parent property
        /// </summary>
        /// <param name="parent">The value to set for the Parent property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithParent(WorkflowExecution parent)
        {
            this.parent = parent;
            return this;
        }
            

        // Check to see if Parent property is set
        internal bool IsSetParent()
        {
            return this.parent != null;
        }

        /// <summary>
        /// The list of tags associated with the workflow execution. Tags can be used to identify and list workflow executions of interest through the
        /// visibility APIs. A workflow execution can have a maximum of 5 tags.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 5</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> TagList
        {
            get { return this.tagList; }
            set { this.tagList = value; }
        }
        /// <summary>
        /// Adds elements to the TagList collection
        /// </summary>
        /// <param name="tagList">The values to add to the TagList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithTagList(params string[] tagList)
        {
            foreach (string element in tagList)
            {
                this.tagList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TagList collection
        /// </summary>
        /// <param name="tagList">The values to add to the TagList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithTagList(IEnumerable<string> tagList)
        {
            foreach (string element in tagList)
            {
                this.tagList.Add(element);
            }

            return this;
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this.tagList.Count > 0;
        }

        /// <summary>
        /// Set to true if a cancellation is requested for this workflow execution.
        ///  
        /// </summary>
        public bool CancelRequested
        {
            get { return this.cancelRequested ?? default(bool); }
            set { this.cancelRequested = value; }
        }

        /// <summary>
        /// Sets the CancelRequested property
        /// </summary>
        /// <param name="cancelRequested">The value to set for the CancelRequested property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionInfo WithCancelRequested(bool cancelRequested)
        {
            this.cancelRequested = cancelRequested;
            return this;
        }
            

        // Check to see if CancelRequested property is set
        internal bool IsSetCancelRequested()
        {
            return this.cancelRequested.HasValue;
        }
    }
}
