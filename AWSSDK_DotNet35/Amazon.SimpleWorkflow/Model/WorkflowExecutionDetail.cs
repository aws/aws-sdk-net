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
using Amazon.Runtime;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Contains details about a workflow execution. </para>
    /// </summary>
    public partial class WorkflowExecutionDetail : AmazonWebServiceResponse
    {
        
        private WorkflowExecutionInfo executionInfo;
        private WorkflowExecutionConfiguration executionConfiguration;
        private WorkflowExecutionOpenCounts openCounts;
        private DateTime? latestActivityTaskTimestamp;
        private string latestExecutionContext;

        /// <summary>
        /// Information about the workflow execution.
        ///  
        /// </summary>
        public WorkflowExecutionInfo ExecutionInfo
        {
            get { return this.executionInfo; }
            set { this.executionInfo = value; }
        }

        // Check to see if ExecutionInfo property is set
        internal bool IsSetExecutionInfo()
        {
            return this.executionInfo != null;
        }

        /// <summary>
        /// The configuration settings for this workflow execution including timeout values, tasklist etc.
        ///  
        /// </summary>
        public WorkflowExecutionConfiguration ExecutionConfiguration
        {
            get { return this.executionConfiguration; }
            set { this.executionConfiguration = value; }
        }

        // Check to see if ExecutionConfiguration property is set
        internal bool IsSetExecutionConfiguration()
        {
            return this.executionConfiguration != null;
        }

        /// <summary>
        /// The number of tasks for this workflow execution. This includes open and closed tasks of all types.
        ///  
        /// </summary>
        public WorkflowExecutionOpenCounts OpenCounts
        {
            get { return this.openCounts; }
            set { this.openCounts = value; }
        }

        // Check to see if OpenCounts property is set
        internal bool IsSetOpenCounts()
        {
            return this.openCounts != null;
        }

        /// <summary>
        /// The time when the last activity task was scheduled for this workflow execution. You can use this information to determine if the workflow
        /// has not made progress for an unusually long period of time and might require a corrective action.
        ///  
        /// </summary>
        public DateTime LatestActivityTaskTimestamp
        {
            get { return this.latestActivityTaskTimestamp ?? default(DateTime); }
            set { this.latestActivityTaskTimestamp = value; }
        }

        // Check to see if LatestActivityTaskTimestamp property is set
        internal bool IsSetLatestActivityTaskTimestamp()
        {
            return this.latestActivityTaskTimestamp.HasValue;
        }

        /// <summary>
        /// The latest executionContext provided by the decider for this workflow execution. A decider can provide an executionContext, which is a free
        /// form string, when closing a decision task using <a>RespondDecisionTaskCompleted</a>.
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
        public string LatestExecutionContext
        {
            get { return this.latestExecutionContext; }
            set { this.latestExecutionContext = value; }
        }

        // Check to see if LatestExecutionContext property is set
        internal bool IsSetLatestExecutionContext()
        {
            return this.latestExecutionContext != null;
        }
    }
}
