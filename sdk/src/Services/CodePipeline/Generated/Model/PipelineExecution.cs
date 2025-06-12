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
    /// Represents information about an execution of a pipeline.
    /// </summary>
    public partial class PipelineExecution
    {
        private List<ArtifactRevision> _artifactRevisions = AWSConfigs.InitializeCollections ? new List<ArtifactRevision>() : null;
        private ExecutionMode _executionMode;
        private ExecutionType _executionType;
        private string _pipelineExecutionId;
        private string _pipelineName;
        private int? _pipelineVersion;
        private PipelineRollbackMetadata _rollbackMetadata;
        private PipelineExecutionStatus _status;
        private string _statusSummary;
        private ExecutionTrigger _trigger;
        private List<ResolvedPipelineVariable> _variables = AWSConfigs.InitializeCollections ? new List<ResolvedPipelineVariable>() : null;

        /// <summary>
        /// Gets and sets the property ArtifactRevisions. 
        /// <para>
        /// A list of <c>ArtifactRevision</c> objects included in a pipeline execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ArtifactRevision> ArtifactRevisions
        {
            get { return this._artifactRevisions; }
            set { this._artifactRevisions = value; }
        }

        // Check to see if ArtifactRevisions property is set
        internal bool IsSetArtifactRevisions()
        {
            return this._artifactRevisions != null && (this._artifactRevisions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// The type of the pipeline execution.
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
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline with the specified pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineVersion. 
        /// <para>
        /// The version number of the pipeline with the specified pipeline execution.
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
        /// Gets and sets the property RollbackMetadata. 
        /// <para>
        /// The metadata about the execution pertaining to stage rollback.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the pipeline execution.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Cancelled: The pipeline’s definition was updated before the pipeline execution could
        /// be completed.
        /// </para>
        ///  </li> <li> 
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
        /// A summary that contains a description of the pipeline execution status.
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
        /// Gets and sets the property Trigger.
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

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// A list of pipeline variables used for the pipeline execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolvedPipelineVariable> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && (this._variables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}