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
    /// Contains information about a workflow execution.
    /// </summary>
    public partial class WorkflowExecutionInfo
    {
        /// <summary>
        /// Gets and sets the property CancelRequested. 
        /// <para>
        /// Set to true if a cancellation is requested for this workflow execution.
        /// </para>
        /// </summary>
        public bool? CancelRequested { get; set; }

        /// <summary>
        /// Checks to see if the CancelRequested property is set.
        /// </summary>
        internal bool IsSetCancelRequested() => this.CancelRequested.HasValue;

        /// <summary>
        /// Gets and sets the property CloseStatus. 
        /// <para>
        /// If the execution status is closed then this specifies how the execution was closed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLETED</c> – the execution was successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c> – the execution was canceled.Cancellation allows the implementation
        /// to gracefully clean up before the execution is closed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATED</c> – the execution was force terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – the execution failed to complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TIMED_OUT</c> – the execution did not complete in the alloted time and was automatically
        /// timed out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONTINUED_AS_NEW</c> – the execution is logically continued. This means the current
        /// execution was completed and a new execution was started to carry on the workflow.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CloseStatus CloseStatus { get; set; }

        /// <summary>
        /// Checks to see if the CloseStatus property is set.
        /// </summary>
        internal bool IsSetCloseStatus() => this.CloseStatus != null;

        /// <summary>
        /// Gets and sets the property CloseTimestamp. 
        /// <para>
        /// The time when the workflow execution was closed. Set only if the execution status
        /// is CLOSED.
        /// </para>
        /// </summary>
        public DateTime? CloseTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CloseTimestamp property is set.
        /// </summary>
        internal bool IsSetCloseTimestamp() => this.CloseTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Execution. 
        /// <para>
        /// The workflow execution this information is about.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowExecution Execution { get; set; }

        /// <summary>
        /// Checks to see if the Execution property is set.
        /// </summary>
        internal bool IsSetExecution() => this.Execution != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The current status of the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property Parent. 
        /// <para>
        /// If this workflow execution is a child of another execution then contains the workflow
        /// execution that started this execution.
        /// </para>
        /// </summary>
        public WorkflowExecution Parent { get; set; }

        /// <summary>
        /// Checks to see if the Parent property is set.
        /// </summary>
        internal bool IsSetParent() => this.Parent != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The time when the execution was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags associated with the workflow execution. Tags can be used to identify
        /// and list workflow executions of interest through the visibility APIs. A workflow execution
        /// can have a maximum of 5 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The type of the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowType WorkflowType { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowType property is set.
        /// </summary>
        internal bool IsSetWorkflowType() => this.WorkflowType != null;
    }
}
