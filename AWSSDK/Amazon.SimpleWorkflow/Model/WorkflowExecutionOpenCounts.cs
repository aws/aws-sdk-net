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
    /// <para> Contains the counts of open tasks, child workflow executions and timers for a workflow execution. </para>
    /// </summary>
    public class WorkflowExecutionOpenCounts
    {
        
        private int? openActivityTasks;
        private int? openDecisionTasks;
        private int? openTimers;
        private int? openChildWorkflowExecutions;

        /// <summary>
        /// The count of activity tasks whose status is OPEN.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int OpenActivityTasks
        {
            get { return this.openActivityTasks ?? default(int); }
            set { this.openActivityTasks = value; }
        }

        /// <summary>
        /// Sets the OpenActivityTasks property
        /// </summary>
        /// <param name="openActivityTasks">The value to set for the OpenActivityTasks property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionOpenCounts WithOpenActivityTasks(int openActivityTasks)
        {
            this.openActivityTasks = openActivityTasks;
            return this;
        }
            

        // Check to see if OpenActivityTasks property is set
        internal bool IsSetOpenActivityTasks()
        {
            return this.openActivityTasks.HasValue;
        }

        /// <summary>
        /// The count of decision tasks whose status is OPEN. A workflow execution can have at most one open decision task.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 1</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int OpenDecisionTasks
        {
            get { return this.openDecisionTasks ?? default(int); }
            set { this.openDecisionTasks = value; }
        }

        /// <summary>
        /// Sets the OpenDecisionTasks property
        /// </summary>
        /// <param name="openDecisionTasks">The value to set for the OpenDecisionTasks property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionOpenCounts WithOpenDecisionTasks(int openDecisionTasks)
        {
            this.openDecisionTasks = openDecisionTasks;
            return this;
        }
            

        // Check to see if OpenDecisionTasks property is set
        internal bool IsSetOpenDecisionTasks()
        {
            return this.openDecisionTasks.HasValue;
        }

        /// <summary>
        /// The count of timers started by this workflow execution that have not fired yet.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int OpenTimers
        {
            get { return this.openTimers ?? default(int); }
            set { this.openTimers = value; }
        }

        /// <summary>
        /// Sets the OpenTimers property
        /// </summary>
        /// <param name="openTimers">The value to set for the OpenTimers property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionOpenCounts WithOpenTimers(int openTimers)
        {
            this.openTimers = openTimers;
            return this;
        }
            

        // Check to see if OpenTimers property is set
        internal bool IsSetOpenTimers()
        {
            return this.openTimers.HasValue;
        }

        /// <summary>
        /// The count of child workflow executions whose status is OPEN.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int OpenChildWorkflowExecutions
        {
            get { return this.openChildWorkflowExecutions ?? default(int); }
            set { this.openChildWorkflowExecutions = value; }
        }

        /// <summary>
        /// Sets the OpenChildWorkflowExecutions property
        /// </summary>
        /// <param name="openChildWorkflowExecutions">The value to set for the OpenChildWorkflowExecutions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowExecutionOpenCounts WithOpenChildWorkflowExecutions(int openChildWorkflowExecutions)
        {
            this.openChildWorkflowExecutions = openChildWorkflowExecutions;
            return this;
        }
            

        // Check to see if OpenChildWorkflowExecutions property is set
        internal bool IsSetOpenChildWorkflowExecutions()
        {
            return this.openChildWorkflowExecutions.HasValue;
        }
    }
}
