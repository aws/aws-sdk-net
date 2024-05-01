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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Details for a notebook execution. The details include information such as the unique
    /// ID and status of the notebook execution.
    /// </summary>
    public partial class NotebookExecutionSummary
    {
        private string _editorId;
        private DateTime? _endTime;
        private string _executionEngineId;
        private string _notebookExecutionId;
        private string _notebookExecutionName;
        private NotebookS3LocationForOutput _notebookS3Location;
        private DateTime? _startTime;
        private NotebookExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property EditorId. 
        /// <para>
        /// The unique identifier of the editor associated with the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string EditorId
        {
            get { return this._editorId; }
            set { this._editorId = value; }
        }

        // Check to see if EditorId property is set
        internal bool IsSetEditorId()
        {
            return this._editorId != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when notebook execution started.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionEngineId. 
        /// <para>
        /// The unique ID of the execution engine for the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string ExecutionEngineId
        {
            get { return this._executionEngineId; }
            set { this._executionEngineId = value; }
        }

        // Check to see if ExecutionEngineId property is set
        internal bool IsSetExecutionEngineId()
        {
            return this._executionEngineId != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookExecutionId. 
        /// <para>
        /// The unique identifier of the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NotebookExecutionId
        {
            get { return this._notebookExecutionId; }
            set { this._notebookExecutionId = value; }
        }

        // Check to see if NotebookExecutionId property is set
        internal bool IsSetNotebookExecutionId()
        {
            return this._notebookExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookExecutionName. 
        /// <para>
        /// The name of the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NotebookExecutionName
        {
            get { return this._notebookExecutionName; }
            set { this._notebookExecutionName = value; }
        }

        // Check to see if NotebookExecutionName property is set
        internal bool IsSetNotebookExecutionName()
        {
            return this._notebookExecutionName != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookS3Location. 
        /// <para>
        /// The Amazon S3 location that stores the notebook execution input.
        /// </para>
        /// </summary>
        public NotebookS3LocationForOutput NotebookS3Location
        {
            get { return this._notebookS3Location; }
            set { this._notebookS3Location = value; }
        }

        // Check to see if NotebookS3Location property is set
        internal bool IsSetNotebookS3Location()
        {
            return this._notebookS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when notebook execution started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notebook execution.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>START_PENDING</c> indicates that the cluster has received the execution request
        /// but execution has not begun.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STARTING</c> indicates that the execution is starting on the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> indicates that the execution is being processed by the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINISHING</c> indicates that execution processing is in the final stages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINISHED</c> indicates that the execution has completed without error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILING</c> indicates that the execution is failing and will not finish successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> indicates that the execution failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOP_PENDING</c> indicates that the cluster has received a <c>StopNotebookExecution</c>
        /// request and the stop is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPING</c> indicates that the cluster is in the process of stopping the execution
        /// as a result of a <c>StopNotebookExecution</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c> indicates that the execution stopped because of a <c>StopNotebookExecution</c>
        /// request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NotebookExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}