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
    /// Summary information about a pipeline execution.
    /// </summary>
    public partial class PipelineExecutionSummary
    {
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
        /// Type of the pipeline execution.
        /// </para>
        /// </summary>
        public ExecutionType ExecutionType { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionType property is set.
        /// </summary>
        internal bool IsSetExecutionType() => this.ExecutionType != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time of the last change to the pipeline execution, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

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
        /// Gets and sets the property RollbackMetadata. 
        /// <para>
        /// The metadata for the stage execution to be rolled back.
        /// </para>
        /// </summary>
        public PipelineRollbackMetadata RollbackMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RollbackMetadata property is set.
        /// </summary>
        internal bool IsSetRollbackMetadata() => this.RollbackMetadata != null;

        /// <summary>
        /// Gets and sets the property SourceRevisions. 
        /// <para>
        /// A list of the source artifact revisions that initiated a pipeline execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceRevision> SourceRevisions { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceRevision>() : null;

        /// <summary>
        /// Checks to see if the SourceRevisions property is set.
        /// </summary>
        internal bool IsSetSourceRevisions() => this.SourceRevisions != null && (this.SourceRevisions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the pipeline execution began, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

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
        public PipelineExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusSummary. 
        /// <para>
        /// Status summary for the pipeline.
        /// </para>
        /// </summary>
        public string StatusSummary { get; set; }

        /// <summary>
        /// Checks to see if the StatusSummary property is set.
        /// </summary>
        internal bool IsSetStatusSummary() => this.StatusSummary != null;

        /// <summary>
        /// Gets and sets the property StopTrigger. 
        /// <para>
        /// The interaction that stopped a pipeline execution.
        /// </para>
        /// </summary>
        public StopExecutionTrigger StopTrigger { get; set; }

        /// <summary>
        /// Checks to see if the StopTrigger property is set.
        /// </summary>
        internal bool IsSetStopTrigger() => this.StopTrigger != null;

        /// <summary>
        /// Gets and sets the property Trigger. 
        /// <para>
        /// The interaction or event that started a pipeline execution, such as automated change
        /// detection or a <c>StartPipelineExecution</c> API call.
        /// </para>
        /// </summary>
        public ExecutionTrigger Trigger { get; set; }

        /// <summary>
        /// Checks to see if the Trigger property is set.
        /// </summary>
        internal bool IsSetTrigger() => this.Trigger != null;
    }
}
