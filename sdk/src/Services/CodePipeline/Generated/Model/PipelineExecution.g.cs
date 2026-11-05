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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ArtifactRevisions. 
        /// <para>
        /// A list of <c>ArtifactRevision</c> objects included in a pipeline execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ArtifactRevision> ArtifactRevisions { get; set; } = AWSConfigs.InitializeCollections ? new List<ArtifactRevision>() : null;

        /// <summary>
        /// Checks to see if the ArtifactRevisions property is set.
        /// </summary>
        internal bool IsSetArtifactRevisions() => this.ArtifactRevisions != null && (this.ArtifactRevisions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionMode. 
        /// <para>
        /// The method that the pipeline will use to handle multiple executions. The default mode
        /// is SUPERSEDED.
        /// </para>
        /// </summary>
        public ExecutionMode ExecutionMode { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionMode property is set.
        /// </summary>
        internal bool IsSetExecutionMode() => this.ExecutionMode != null;

        /// <summary>
        /// Gets and sets the property ExecutionType. 
        /// <para>
        /// The type of the pipeline execution.
        /// </para>
        /// </summary>
        public ExecutionType ExecutionType { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionType property is set.
        /// </summary>
        internal bool IsSetExecutionType() => this.ExecutionType != null;

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The ID of the pipeline execution.
        /// </para>
        /// </summary>
        public string PipelineExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExecutionId property is set.
        /// </summary>
        internal bool IsSetPipelineExecutionId() => this.PipelineExecutionId != null;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline with the specified pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property PipelineVersion. 
        /// <para>
        /// The version number of the pipeline with the specified pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? PipelineVersion { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersion property is set.
        /// </summary>
        internal bool IsSetPipelineVersion() => this.PipelineVersion.HasValue;

        /// <summary>
        /// Gets and sets the property RollbackMetadata. 
        /// <para>
        /// The metadata about the execution pertaining to stage rollback.
        /// </para>
        /// </summary>
        public PipelineRollbackMetadata RollbackMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RollbackMetadata property is set.
        /// </summary>
        internal bool IsSetRollbackMetadata() => this.RollbackMetadata != null;

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
        public PipelineExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusSummary. 
        /// <para>
        /// A summary that contains a description of the pipeline execution status.
        /// </para>
        /// </summary>
        public string StatusSummary { get; set; }

        /// <summary>
        /// Checks to see if the StatusSummary property is set.
        /// </summary>
        internal bool IsSetStatusSummary() => this.StatusSummary != null;

        /// <summary>
        /// Gets and sets the property Trigger.
        /// </summary>
        public ExecutionTrigger Trigger { get; set; }

        /// <summary>
        /// Checks to see if the Trigger property is set.
        /// </summary>
        internal bool IsSetTrigger() => this.Trigger != null;

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// A list of pipeline variables used for the pipeline execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolvedPipelineVariable> Variables { get; set; } = AWSConfigs.InitializeCollections ? new List<ResolvedPipelineVariable>() : null;

        /// <summary>
        /// Checks to see if the Variables property is set.
        /// </summary>
        internal bool IsSetVariables() => this.Variables != null && (this.Variables.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
