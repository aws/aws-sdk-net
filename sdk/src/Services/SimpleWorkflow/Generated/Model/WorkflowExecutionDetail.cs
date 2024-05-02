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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Contains details about a workflow execution.
    /// </summary>
    public partial class WorkflowExecutionDetail
    {
        private WorkflowExecutionConfiguration _executionConfiguration;
        private WorkflowExecutionInfo _executionInfo;
        private DateTime? _latestActivityTaskTimestamp;
        private string _latestExecutionContext;
        private WorkflowExecutionOpenCounts _openCounts;

        /// <summary>
        /// Gets and sets the property ExecutionConfiguration. 
        /// <para>
        /// The configuration settings for this workflow execution including timeout values, tasklist
        /// etc.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowExecutionConfiguration ExecutionConfiguration
        {
            get { return this._executionConfiguration; }
            set { this._executionConfiguration = value; }
        }

        // Check to see if ExecutionConfiguration property is set
        internal bool IsSetExecutionConfiguration()
        {
            return this._executionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionInfo. 
        /// <para>
        /// Information about the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowExecutionInfo ExecutionInfo
        {
            get { return this._executionInfo; }
            set { this._executionInfo = value; }
        }

        // Check to see if ExecutionInfo property is set
        internal bool IsSetExecutionInfo()
        {
            return this._executionInfo != null;
        }

        /// <summary>
        /// Gets and sets the property LatestActivityTaskTimestamp. 
        /// <para>
        /// The time when the last activity task was scheduled for this workflow execution. You
        /// can use this information to determine if the workflow has not made progress for an
        /// unusually long period of time and might require a corrective action.
        /// </para>
        /// </summary>
        public DateTime? LatestActivityTaskTimestamp
        {
            get { return this._latestActivityTaskTimestamp; }
            set { this._latestActivityTaskTimestamp = value; }
        }

        // Check to see if LatestActivityTaskTimestamp property is set
        internal bool IsSetLatestActivityTaskTimestamp()
        {
            return this._latestActivityTaskTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestExecutionContext. 
        /// <para>
        /// The latest executionContext provided by the decider for this workflow execution. A
        /// decider can provide an executionContext (a free-form string) when closing a decision
        /// task using <a>RespondDecisionTaskCompleted</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string LatestExecutionContext
        {
            get { return this._latestExecutionContext; }
            set { this._latestExecutionContext = value; }
        }

        // Check to see if LatestExecutionContext property is set
        internal bool IsSetLatestExecutionContext()
        {
            return this._latestExecutionContext != null;
        }

        /// <summary>
        /// Gets and sets the property OpenCounts. 
        /// <para>
        /// The number of tasks for this workflow execution. This includes open and closed tasks
        /// of all types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowExecutionOpenCounts OpenCounts
        {
            get { return this._openCounts; }
            set { this._openCounts = value; }
        }

        // Check to see if OpenCounts property is set
        internal bool IsSetOpenCounts()
        {
            return this._openCounts != null;
        }

    }
}