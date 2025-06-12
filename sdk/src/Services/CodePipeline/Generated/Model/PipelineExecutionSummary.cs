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
    /// Summary information about a pipeline execution.
    /// </summary>
    public partial class PipelineExecutionSummary
    {
        private ExecutionMode _executionMode;
        private ExecutionType _executionType;
        private DateTime? _lastUpdateTime;
        private string _pipelineExecutionId;
        private PipelineRollbackMetadata _rollbackMetadata;
        private List<SourceRevision> _sourceRevisions = AWSConfigs.InitializeCollections ? new List<SourceRevision>() : null;
        private DateTime? _startTime;
        private PipelineExecutionStatus _status;
        private string _statusSummary;
        private StopExecutionTrigger _stopTrigger;
        private ExecutionTrigger _trigger;

        /// <summary>
        /// Gets and sets the property ExecutionMode. 
        /// <para>
        /// The method that the pipeline will use to handle multiple executions. The default mode
        /// is SUPERSEDED.
        /// </para>
        /// </summary>
        public ExecutionMode ExecutionMode
        {
            get { return this._executionMode; }
            set { this._executionMode = value; }
        }

        // Check to see if ExecutionMode property is set
        internal bool IsSetExecutionMode()
        {
            return this._executionMode != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionType. 
        /// <para>
        /// Type of the pipeline execution.
        /// </para>
        /// </summary>
        public ExecutionType ExecutionType
        {
            get { return this._executionType; }
            set { this._executionType = value; }
        }

        // Check to see if ExecutionType property is set
        internal bool IsSetExecutionType()
        {
            return this._executionType != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time of the last change to the pipeline execution, in timestamp format.
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
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the pipeline execution.
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
        /// Gets and sets the property RollbackMetadata. 
        /// <para>
        /// The metadata for the stage execution to be rolled back.
        /// </para>
        /// </summary>
        public PipelineRollbackMetadata RollbackMetadata
        {
            get { return this._rollbackMetadata; }
            set { this._rollbackMetadata = value; }
        }

        // Check to see if RollbackMetadata property is set
        internal bool IsSetRollbackMetadata()
        {
            return this._rollbackMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRevisions. 
        /// <para>
        /// A list of the source artifact revisions that initiated a pipeline execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceRevision> SourceRevisions
        {
            get { return this._sourceRevisions; }
            set { this._sourceRevisions = value; }
        }

        // Check to see if SourceRevisions property is set
        internal bool IsSetSourceRevisions()
        {
            return this._sourceRevisions != null && (this._sourceRevisions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the pipeline execution began, in timestamp format.
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
        /// The status of the pipeline execution.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// InProgress: The pipeline execution is currently running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stopped: The pipeline execution was manually stopped. For more information, see <a
        /// href="https://docs.aws.amazon.com/codepipeline/latest/userguide/concepts.html#concepts-executions-stopped">Stopped
        /// Executions</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stopping: The pipeline execution received a request to be manually stopped. Depending
        /// on the selected stop mode, the execution is either completing or abandoning in-progress
        /// actions. For more information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/concepts.html#concepts-executions-stopped">Stopped
        /// Executions</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Succeeded: The pipeline execution was completed successfully. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Superseded: While this pipeline execution was waiting for the next stage to be completed,
        /// a newer pipeline execution advanced and continued through the pipeline instead. For
        /// more information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/concepts.html#concepts-superseded">Superseded
        /// Executions</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The pipeline execution was not completed successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PipelineExecutionStatus Status
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
        /// Gets and sets the property StatusSummary. 
        /// <para>
        /// Status summary for the pipeline.
        /// </para>
        /// </summary>
        public string StatusSummary
        {
            get { return this._statusSummary; }
            set { this._statusSummary = value; }
        }

        // Check to see if StatusSummary property is set
        internal bool IsSetStatusSummary()
        {
            return this._statusSummary != null;
        }

        /// <summary>
        /// Gets and sets the property StopTrigger. 
        /// <para>
        /// The interaction that stopped a pipeline execution.
        /// </para>
        /// </summary>
        public StopExecutionTrigger StopTrigger
        {
            get { return this._stopTrigger; }
            set { this._stopTrigger = value; }
        }

        // Check to see if StopTrigger property is set
        internal bool IsSetStopTrigger()
        {
            return this._stopTrigger != null;
        }

        /// <summary>
        /// Gets and sets the property Trigger. 
        /// <para>
        /// The interaction or event that started a pipeline execution, such as automated change
        /// detection or a <c>StartPipelineExecution</c> API call.
        /// </para>
        /// </summary>
        public ExecutionTrigger Trigger
        {
            get { return this._trigger; }
            set { this._trigger = value; }
        }

        // Check to see if Trigger property is set
        internal bool IsSetTrigger()
        {
            return this._trigger != null;
        }

    }
}