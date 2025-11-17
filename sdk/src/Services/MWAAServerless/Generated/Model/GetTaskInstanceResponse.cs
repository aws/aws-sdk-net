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
    /// This is the response object from the GetTaskInstance operation.
    /// </summary>
    public partial class GetTaskInstanceResponse : AmazonWebServiceResponse
    {
        private int? _attemptNumber;
        private int? _durationInSeconds;
        private DateTime? _endedAt;
        private string _errorMessage;
        private string _logStream;
        private DateTime? _modifiedAt;
        private string _operatorName;
        private string _runId;
        private DateTime? _startedAt;
        private TaskInstanceStatus _status;
        private string _taskId;
        private string _taskInstanceId;
        private string _workflowArn;
        private string _workflowVersion;
        private Dictionary<string, string> _xcom = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AttemptNumber. 
        /// <para>
        /// The attempt number for this task instance.
        /// </para>
        /// </summary>
        public int AttemptNumber
        {
            get { return this._attemptNumber.GetValueOrDefault(); }
            set { this._attemptNumber = value; }
        }

        // Check to see if AttemptNumber property is set
        internal bool IsSetAttemptNumber()
        {
            return this._attemptNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration of the task instance execution in seconds. This value is null if the
        /// task is not complete.
        /// </para>
        /// </summary>
        public int DurationInSeconds
        {
            get { return this._durationInSeconds.GetValueOrDefault(); }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the task instance completed execution, in ISO 8601 date-time format.
        /// This value is null if the task is not complete.
        /// </para>
        /// </summary>
        public DateTime EndedAt
        {
            get { return this._endedAt.GetValueOrDefault(); }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message if the task instance failed. This value is null if the task completed
        /// successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LogStream. 
        /// <para>
        /// The CloudWatch log stream name for this task instance execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LogStream
        {
            get { return this._logStream; }
            set { this._logStream = value; }
        }

        // Check to see if LogStream property is set
        internal bool IsSetLogStream()
        {
            return this._logStream != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp when the task instance was last modified, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the task instance started execution, in ISO 8601 date-time format.
        /// This value is null if the task has not started.
        /// </para>
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
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
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the task definition within the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskInstanceId. 
        /// <para>
        /// The unique identifier of this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Xcom. 
        /// <para>
        /// Cross-communication data exchanged between tasks in the workflow execution.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Xcom
        {
            get { return this._xcom; }
            set { this._xcom = value; }
        }

        // Check to see if Xcom property is set
        internal bool IsSetXcom()
        {
            return this._xcom != null && (this._xcom.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}