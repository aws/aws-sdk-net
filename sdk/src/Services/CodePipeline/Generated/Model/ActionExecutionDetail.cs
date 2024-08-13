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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Returns information about an execution of an action, including the action execution
    /// ID, and the name, version, and timing of the action.
    /// </summary>
    public partial class ActionExecutionDetail
    {
        private string _actionExecutionId;
        private string _actionName;
        private ActionExecutionInput _input;
        private DateTime? _lastUpdateTime;
        private ActionExecutionOutput _output;
        private string _pipelineExecutionId;
        private int? _pipelineVersion;
        private string _stageName;
        private DateTime? _startTime;
        private ActionExecutionStatus _status;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property ActionExecutionId. 
        /// <para>
        /// The action execution ID.
        /// </para>
        /// </summary>
        public string ActionExecutionId
        {
            get { return this._actionExecutionId; }
            set { this._actionExecutionId = value; }
        }

        // Check to see if ActionExecutionId property is set
        internal bool IsSetActionExecutionId()
        {
            return this._actionExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Input details for the action execution, such as role ARN, Region, and input artifacts.
        /// </para>
        /// </summary>
        public ActionExecutionInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last update time of the action execution.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// Output details for the action execution, such as the action execution result.
        /// </para>
        /// </summary>
        public ActionExecutionOutput Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The pipeline execution ID for the action execution.
        /// </para>
        /// </summary>
        public string PipelineExecutionId
        {
            get { return this._pipelineExecutionId; }
            set { this._pipelineExecutionId = value; }
        }

        // Check to see if PipelineExecutionId property is set
        internal bool IsSetPipelineExecutionId()
        {
            return this._pipelineExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineVersion. 
        /// <para>
        /// The version of the pipeline where the action was run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? PipelineVersion
        {
            get { return this._pipelineVersion; }
            set { this._pipelineVersion = value; }
        }

        // Check to see if PipelineVersion property is set
        internal bool IsSetPipelineVersion()
        {
            return this._pipelineVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage that contains the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the action execution.
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
        ///  The status of the action execution. Status categories are <c>InProgress</c>, <c>Succeeded</c>,
        /// and <c>Failed</c>.
        /// </para>
        /// </summary>
        public ActionExecutionStatus Status
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
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The ARN of the user who changed the pipeline execution details.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}