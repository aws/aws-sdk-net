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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
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
namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// Summary information about a task instance within a workflow run, including its status
    /// and execution details.
    /// </summary>
    public partial class TaskInstanceSummary
    {
        private int? _durationInSeconds;
        private string _operatorName;
        private string _runId;
        private TaskInstanceStatus _status;
        private string _taskInstanceId;
        private string _workflowArn;
        private string _workflowVersion;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration of the task instance execution in seconds. This value is null if the
        /// task is not complete.
        /// </para>
        /// </summary>
        public int? DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperatorName. 
        /// <para>
        /// The name of the Apache Airflow operator used for this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OperatorName
        {
            get { return this._operatorName; }
            set { this._operatorName = value; }
        }

        // Check to see if OperatorName property is set
        internal bool IsSetOperatorName()
        {
            return this._operatorName != null;
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of the workflow run that contains this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the task instance.
        /// </para>
        /// </summary>
        public TaskInstanceStatus Status
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
        /// Gets and sets the property TaskInstanceId. 
        /// <para>
        /// The unique identifier of this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TaskInstanceId
        {
            get { return this._taskInstanceId; }
            set { this._taskInstanceId = value; }
        }

        // Check to see if TaskInstanceId property is set
        internal bool IsSetTaskInstanceId()
        {
            return this._taskInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow that contains this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string WorkflowArn
        {
            get { return this._workflowArn; }
            set { this._workflowArn = value; }
        }

        // Check to see if WorkflowArn property is set
        internal bool IsSetWorkflowArn()
        {
            return this._workflowArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version of the workflow that contains this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string WorkflowVersion
        {
            get { return this._workflowVersion; }
            set { this._workflowVersion = value; }
        }

        // Check to see if WorkflowVersion property is set
        internal bool IsSetWorkflowVersion()
        {
            return this._workflowVersion != null;
        }

    }
}