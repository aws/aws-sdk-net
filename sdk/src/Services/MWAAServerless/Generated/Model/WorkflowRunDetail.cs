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
    /// Detailed information about a workflow run execution, including timing, status, error
    /// information, and associated task instances. This structure provides comprehensive
    /// visibility into the workflow execution lifecycle within the Amazon Managed Workflows
    /// for Apache Airflow Serverless serverless environment. The service tracks execution
    /// across distributed ECS worker tasks and provides detailed timing information, error
    /// diagnostics, and task instance relationships to support effective monitoring and troubleshooting
    /// of complex workflow executions.
    /// </summary>
    public partial class WorkflowRunDetail
    {
        private DateTime? _completedOn;
        private DateTime? _createdAt;
        private int? _duration;
        private string _errorMessage;
        private DateTime? _modifiedAt;
        private string _runId;
        private WorkflowRunStatus _runState;
        private RunType _runType;
        private DateTime? _startedOn;
        private List<string> _taskInstances = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workflowArn;
        private string _workflowVersion;

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The timestamp when the workflow run completed execution, in ISO 8601 date-time format.
        /// This value is null if the run is not complete.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn
        {
            get { return this._completedOn; }
            set { this._completedOn = value; }
        }

        // Check to see if CompletedOn property is set
        internal bool IsSetCompletedOn()
        {
            return this._completedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow run was created, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The total duration of the workflow run execution in seconds. This value is null if
        /// the run is not complete.
        /// </para>
        /// </summary>
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message if the workflow run failed. This value is null if the run completed
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp when the workflow run was last modified, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of this workflow run.
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
        /// Gets and sets the property RunState. 
        /// <para>
        /// The current execution state of the workflow run.
        /// </para>
        /// </summary>
        public WorkflowRunStatus RunState
        {
            get { return this._runState; }
            set { this._runState = value; }
        }

        // Check to see if RunState property is set
        internal bool IsSetRunState()
        {
            return this._runState != null;
        }

        /// <summary>
        /// Gets and sets the property RunType. 
        /// <para>
        /// The type of workflow run.
        /// </para>
        /// </summary>
        public RunType RunType
        {
            get { return this._runType; }
            set { this._runType = value; }
        }

        // Check to see if RunType property is set
        internal bool IsSetRunType()
        {
            return this._runType != null;
        }

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The timestamp when the workflow run started execution, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? StartedOn
        {
            get { return this._startedOn; }
            set { this._startedOn = value; }
        }

        // Check to see if StartedOn property is set
        internal bool IsSetStartedOn()
        {
            return this._startedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskInstances. 
        /// <para>
        /// A list of task instance IDs that are part of this workflow run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TaskInstances
        {
            get { return this._taskInstances; }
            set { this._taskInstances = value; }
        }

        // Check to see if TaskInstances property is set
        internal bool IsSetTaskInstances()
        {
            return this._taskInstances != null && (this._taskInstances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow that contains this run.
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
        /// The version of the workflow used for this run.
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