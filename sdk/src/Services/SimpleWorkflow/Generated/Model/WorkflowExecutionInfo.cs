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
    /// Contains information about a workflow execution.
    /// </summary>
    public partial class WorkflowExecutionInfo
    {
        private bool? _cancelRequested;
        private CloseStatus _closeStatus;
        private DateTime? _closeTimestamp;
        private WorkflowExecution _execution;
        private ExecutionStatus _executionStatus;
        private WorkflowExecution _parent;
        private DateTime? _startTimestamp;
        private List<string> _tagList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private WorkflowType _workflowType;

        /// <summary>
        /// Gets and sets the property CancelRequested. 
        /// <para>
        /// Set to true if a cancellation is requested for this workflow execution.
        /// </para>
        /// </summary>
        public bool? CancelRequested
        {
            get { return this._cancelRequested; }
            set { this._cancelRequested = value; }
        }

        // Check to see if CancelRequested property is set
        internal bool IsSetCancelRequested()
        {
            return this._cancelRequested.HasValue; 
        }

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
        public CloseStatus CloseStatus
        {
            get { return this._closeStatus; }
            set { this._closeStatus = value; }
        }

        // Check to see if CloseStatus property is set
        internal bool IsSetCloseStatus()
        {
            return this._closeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CloseTimestamp. 
        /// <para>
        /// The time when the workflow execution was closed. Set only if the execution status
        /// is CLOSED.
        /// </para>
        /// </summary>
        public DateTime? CloseTimestamp
        {
            get { return this._closeTimestamp; }
            set { this._closeTimestamp = value; }
        }

        // Check to see if CloseTimestamp property is set
        internal bool IsSetCloseTimestamp()
        {
            return this._closeTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Execution. 
        /// <para>
        /// The workflow execution this information is about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowExecution Execution
        {
            get { return this._execution; }
            set { this._execution = value; }
        }

        // Check to see if Execution property is set
        internal bool IsSetExecution()
        {
            return this._execution != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The current status of the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Parent. 
        /// <para>
        /// If this workflow execution is a child of another execution then contains the workflow
        /// execution that started this execution.
        /// </para>
        /// </summary>
        public WorkflowExecution Parent
        {
            get { return this._parent; }
            set { this._parent = value; }
        }

        // Check to see if Parent property is set
        internal bool IsSetParent()
        {
            return this._parent != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The time when the execution was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags associated with the workflow execution. Tags can be used to identify
        /// and list workflow executions of interest through the visibility APIs. A workflow execution
        /// can have a maximum of 5 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The type of the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowType WorkflowType
        {
            get { return this._workflowType; }
            set { this._workflowType = value; }
        }

        // Check to see if WorkflowType property is set
        internal bool IsSetWorkflowType()
        {
            return this._workflowType != null;
        }

    }
}