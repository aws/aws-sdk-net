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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property OpenActivityTasks. 
        /// <para>
        /// The count of activity tasks whose status is <c>OPEN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? OpenActivityTasks { get; set; }

        /// <summary>
        /// Checks to see if the OpenActivityTasks property is set.
        /// </summary>
        internal bool IsSetOpenActivityTasks() => this.OpenActivityTasks.HasValue;

        /// <summary>
        /// Gets and sets the property OpenChildWorkflowExecutions. 
        /// <para>
        /// The count of child workflow executions whose status is <c>OPEN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? OpenChildWorkflowExecutions { get; set; }

        /// <summary>
        /// Checks to see if the OpenChildWorkflowExecutions property is set.
        /// </summary>
        internal bool IsSetOpenChildWorkflowExecutions() => this.OpenChildWorkflowExecutions.HasValue;

        /// <summary>
        /// Gets and sets the property OpenDecisionTasks. 
        /// <para>
        /// The count of decision tasks whose status is OPEN. A workflow execution can have at
        /// most one open decision task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public int? OpenDecisionTasks { get; set; }

        /// <summary>
        /// Checks to see if the OpenDecisionTasks property is set.
        /// </summary>
        internal bool IsSetOpenDecisionTasks() => this.OpenDecisionTasks.HasValue;

        /// <summary>
        /// Gets and sets the property OpenLambdaFunctions. 
        /// <para>
        /// The count of Lambda tasks whose status is <c>OPEN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? OpenLambdaFunctions { get; set; }

        /// <summary>
        /// Checks to see if the OpenLambdaFunctions property is set.
        /// </summary>
        internal bool IsSetOpenLambdaFunctions() => this.OpenLambdaFunctions.HasValue;

        /// <summary>
        /// Gets and sets the property OpenTimers. 
        /// <para>
        /// The count of timers started by this workflow execution that have not fired yet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? OpenTimers { get; set; }

        /// <summary>
        /// Checks to see if the OpenTimers property is set.
        /// </summary>
        internal bool IsSetOpenTimers() => this.OpenTimers.HasValue;
    }
}
