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
    /// Contains the counts of open tasks, child workflow executions and timers for a workflow
    /// execution.
    /// </summary>
    public partial class WorkflowExecutionOpenCounts
    {
        private int? _openActivityTasks;
        private int? _openChildWorkflowExecutions;
        private int? _openDecisionTasks;
        private int? _openLambdaFunctions;
        private int? _openTimers;

        /// <summary>
        /// Gets and sets the property OpenActivityTasks. 
        /// <para>
        /// The count of activity tasks whose status is <c>OPEN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? OpenActivityTasks
        {
            get { return this._openActivityTasks; }
            set { this._openActivityTasks = value; }
        }

        // Check to see if OpenActivityTasks property is set
        internal bool IsSetOpenActivityTasks()
        {
            return this._openActivityTasks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenChildWorkflowExecutions. 
        /// <para>
        /// The count of child workflow executions whose status is <c>OPEN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? OpenChildWorkflowExecutions
        {
            get { return this._openChildWorkflowExecutions; }
            set { this._openChildWorkflowExecutions = value; }
        }

        // Check to see if OpenChildWorkflowExecutions property is set
        internal bool IsSetOpenChildWorkflowExecutions()
        {
            return this._openChildWorkflowExecutions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenDecisionTasks. 
        /// <para>
        /// The count of decision tasks whose status is OPEN. A workflow execution can have at
        /// most one open decision task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public int? OpenDecisionTasks
        {
            get { return this._openDecisionTasks; }
            set { this._openDecisionTasks = value; }
        }

        // Check to see if OpenDecisionTasks property is set
        internal bool IsSetOpenDecisionTasks()
        {
            return this._openDecisionTasks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenLambdaFunctions. 
        /// <para>
        /// The count of Lambda tasks whose status is <c>OPEN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? OpenLambdaFunctions
        {
            get { return this._openLambdaFunctions; }
            set { this._openLambdaFunctions = value; }
        }

        // Check to see if OpenLambdaFunctions property is set
        internal bool IsSetOpenLambdaFunctions()
        {
            return this._openLambdaFunctions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenTimers. 
        /// <para>
        /// The count of timers started by this workflow execution that have not fired yet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? OpenTimers
        {
            get { return this._openTimers; }
            set { this._openTimers = value; }
        }

        // Check to see if OpenTimers property is set
        internal bool IsSetOpenTimers()
        {
            return this._openTimers.HasValue; 
        }

    }
}