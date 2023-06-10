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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Metadata that includes details and status from this runtime instance of the workflow.
    /// </summary>
    public partial class WorkflowExecutionMetadata
    {
        private string _endTime;
        private string _message;
        private string _startTime;
        private WorkflowExecutionStatus _status;
        private int? _totalStepCount;
        private int? _totalStepsFailed;
        private int? _totalStepsSkipped;
        private int? _totalStepsSucceeded;
        private WorkflowType _type;
        private string _workflowBuildVersionArn;
        private string _workflowExecutionId;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when this runtime instance of the workflow finished.
        /// </para>
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The runtime output message from the workflow, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the runtime instance of this workflow started.
        /// </para>
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current runtime status for this workflow.
        /// </para>
        /// </summary>
        public WorkflowExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TotalStepCount. 
        /// <para>
        /// The total number of steps in the workflow. This should equal the sum of the step counts
        /// for steps that succeeded, were skipped, and failed.
        /// </para>
        /// </summary>
        public int TotalStepCount
        {
            get { return this._totalStepCount.GetValueOrDefault(); }
            set { this._totalStepCount = value; }
        }

        // Check to see if TotalStepCount property is set
        internal bool IsSetTotalStepCount()
        {
            return this._totalStepCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalStepsFailed. 
        /// <para>
        /// A runtime count for the number of steps in the workflow that failed.
        /// </para>
        /// </summary>
        public int TotalStepsFailed
        {
            get { return this._totalStepsFailed.GetValueOrDefault(); }
            set { this._totalStepsFailed = value; }
        }

        // Check to see if TotalStepsFailed property is set
        internal bool IsSetTotalStepsFailed()
        {
            return this._totalStepsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalStepsSkipped. 
        /// <para>
        /// A runtime count for the number of steps in the workflow that were skipped.
        /// </para>
        /// </summary>
        public int TotalStepsSkipped
        {
            get { return this._totalStepsSkipped.GetValueOrDefault(); }
            set { this._totalStepsSkipped = value; }
        }

        // Check to see if TotalStepsSkipped property is set
        internal bool IsSetTotalStepsSkipped()
        {
            return this._totalStepsSkipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalStepsSucceeded. 
        /// <para>
        /// A runtime count for the number of steps in the workflow that ran successfully.
        /// </para>
        /// </summary>
        public int TotalStepsSucceeded
        {
            get { return this._totalStepsSucceeded.GetValueOrDefault(); }
            set { this._totalStepsSucceeded = value; }
        }

        // Check to see if TotalStepsSucceeded property is set
        internal bool IsSetTotalStepsSucceeded()
        {
            return this._totalStepsSucceeded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates what type of workflow that Image Builder ran for this runtime instance of
        /// the workflow.
        /// </para>
        /// </summary>
        public WorkflowType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow resource build version that ran.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string WorkflowBuildVersionArn
        {
            get { return this._workflowBuildVersionArn; }
            set { this._workflowBuildVersionArn = value; }
        }

        // Check to see if WorkflowBuildVersionArn property is set
        internal bool IsSetWorkflowBuildVersionArn()
        {
            return this._workflowBuildVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionId. 
        /// <para>
        /// Unique identifier that Image Builder assigns to keep track of runtime resources each
        /// time it runs a workflow.
        /// </para>
        /// </summary>
        public string WorkflowExecutionId
        {
            get { return this._workflowExecutionId; }
            set { this._workflowExecutionId = value; }
        }

        // Check to see if WorkflowExecutionId property is set
        internal bool IsSetWorkflowExecutionId()
        {
            return this._workflowExecutionId != null;
        }

    }
}