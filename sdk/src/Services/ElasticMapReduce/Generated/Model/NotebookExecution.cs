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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A notebook execution. An execution is a specific instance that an EMR Notebook is
    /// run using the <code>StartNotebookExecution</code> action.
    /// </summary>
    public partial class NotebookExecution
    {
        private string _arn;
        private string _editorId;
        private DateTime? _endTime;
        private ExecutionEngineConfig _executionEngine;
        private string _lastStateChangeReason;
        private string _notebookExecutionId;
        private string _notebookExecutionName;
        private string _notebookInstanceSecurityGroupId;
        private string _notebookParams;
        private string _outputNotebookURI;
        private DateTime? _startTime;
        private NotebookExecutionStatus _status;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property EditorId. 
        /// <para>
        /// The unique identifier of the EMR Notebook that is used for the notebook execution.
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
        /// The timestamp when notebook execution ended.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionEngine. 
        /// <para>
        /// The execution engine, such as an EMR cluster, used to run the EMR notebook and perform
        /// the notebook execution.
        /// </para>
        /// </summary>
        public ExecutionEngineConfig ExecutionEngine
        {
            get { return this._executionEngine; }
            set { this._executionEngine = value; }
        }

        // Check to see if ExecutionEngine property is set
        internal bool IsSetExecutionEngine()
        {
            return this._executionEngine != null;
        }

        /// <summary>
        /// Gets and sets the property LastStateChangeReason. 
        /// <para>
        /// The reason for the latest status change of the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string LastStateChangeReason
        {
            get { return this._lastStateChangeReason; }
            set { this._lastStateChangeReason = value; }
        }

        // Check to see if LastStateChangeReason property is set
        internal bool IsSetLastStateChangeReason()
        {
            return this._lastStateChangeReason != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookExecutionId. 
        /// <para>
        /// The unique identifier of a notebook execution.
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
        /// A name for the notebook execution.
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
        /// Gets and sets the property NotebookInstanceSecurityGroupId. 
        /// <para>
        /// The unique identifier of the EC2 security group associated with the EMR Notebook instance.
        /// For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-managed-notebooks-security-groups.html">Specifying
        /// EC2 Security Groups for EMR Notebooks</a> in the <i>EMR Management Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NotebookInstanceSecurityGroupId
        {
            get { return this._notebookInstanceSecurityGroupId; }
            set { this._notebookInstanceSecurityGroupId = value; }
        }

        // Check to see if NotebookInstanceSecurityGroupId property is set
        internal bool IsSetNotebookInstanceSecurityGroupId()
        {
            return this._notebookInstanceSecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookParams. 
        /// <para>
        /// Input parameters in JSON format passed to the EMR Notebook at runtime for execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string NotebookParams
        {
            get { return this._notebookParams; }
            set { this._notebookParams = value; }
        }

        // Check to see if NotebookParams property is set
        internal bool IsSetNotebookParams()
        {
            return this._notebookParams != null;
        }

        /// <summary>
        /// Gets and sets the property OutputNotebookURI. 
        /// <para>
        /// The location of the notebook execution's output file in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string OutputNotebookURI
        {
            get { return this._outputNotebookURI; }
            set { this._outputNotebookURI = value; }
        }

        // Check to see if OutputNotebookURI property is set
        internal bool IsSetOutputNotebookURI()
        {
            return this._outputNotebookURI != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when notebook execution started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        ///  <code>START_PENDING</code> indicates that the cluster has received the execution
        /// request but execution has not begun.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STARTING</code> indicates that the execution is starting on the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RUNNING</code> indicates that the execution is being processed by the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FINISHING</code> indicates that execution processing is in the final stages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FINISHED</code> indicates that the execution has completed without error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILING</code> indicates that the execution is failing and will not finish
        /// successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> indicates that the execution failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOP_PENDING</code> indicates that the cluster has received a <code>StopNotebookExecution</code>
        /// request and the stop is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPING</code> indicates that the cluster is in the process of stopping the
        /// execution as a result of a <code>StopNotebookExecution</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPED</code> indicates that the execution stopped because of a <code>StopNotebookExecution</code>
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with a notebook execution. Tags are user-defined key-value
        /// pairs that consist of a required key string with a maximum of 128 characters and an
        /// optional value string with a maximum of 256 characters.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}