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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribePipelineExecution operation.
    /// </summary>
    public partial class DescribePipelineExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the pipeline execution was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the execution failed, a message describing why.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1300)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the pipeline execution was modified last.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MLflowConfig. 
        /// <para>
        ///  The MLflow configuration of the pipeline execution. 
        /// </para>
        /// </summary>
        public MLflowConfiguration MLflowConfig { get; set; }

        /// <summary>
        /// Checks to see if the MLflowConfig property is set.
        /// </summary>
        internal bool IsSetMLflowConfig() => this.MLflowConfig != null;

        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// The parallelism configuration applied to the pipeline.
        /// </para>
        /// </summary>
        public ParallelismConfiguration ParallelismConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ParallelismConfiguration property is set.
        /// </summary>
        internal bool IsSetParallelismConfiguration() => this.ParallelismConfiguration != null;

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string PipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineArn property is set.
        /// </summary>
        internal bool IsSetPipelineArn() => this.PipelineArn != null;

        /// <summary>
        /// Gets and sets the property PipelineExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string PipelineExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExecutionArn property is set.
        /// </summary>
        internal bool IsSetPipelineExecutionArn() => this.PipelineExecutionArn != null;

        /// <summary>
        /// Gets and sets the property PipelineExecutionDescription. 
        /// <para>
        /// The description of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3072)]
        public string PipelineExecutionDescription { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExecutionDescription property is set.
        /// </summary>
        internal bool IsSetPipelineExecutionDescription() => this.PipelineExecutionDescription != null;

        /// <summary>
        /// Gets and sets the property PipelineExecutionDisplayName. 
        /// <para>
        /// The display name of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 82)]
        public string PipelineExecutionDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExecutionDisplayName property is set.
        /// </summary>
        internal bool IsSetPipelineExecutionDisplayName() => this.PipelineExecutionDisplayName != null;

        /// <summary>
        /// Gets and sets the property PipelineExecutionStatus. 
        /// <para>
        /// The status of the pipeline execution.
        /// </para>
        /// </summary>
        public PipelineExecutionStatus PipelineExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExecutionStatus property is set.
        /// </summary>
        internal bool IsSetPipelineExecutionStatus() => this.PipelineExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property PipelineExperimentConfig.
        /// </summary>
        public PipelineExperimentConfig PipelineExperimentConfig { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExperimentConfig property is set.
        /// </summary>
        internal bool IsSetPipelineExperimentConfig() => this.PipelineExperimentConfig != null;

        /// <summary>
        /// Gets and sets the property PipelineVersionId. 
        /// <para>
        /// The ID of the pipeline version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? PipelineVersionId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersionId property is set.
        /// </summary>
        internal bool IsSetPipelineVersionId() => this.PipelineVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property SelectiveExecutionConfig. 
        /// <para>
        /// The selective execution configuration applied to the pipeline run.
        /// </para>
        /// </summary>
        public SelectiveExecutionConfig SelectiveExecutionConfig { get; set; }

        /// <summary>
        /// Checks to see if the SelectiveExecutionConfig property is set.
        /// </summary>
        internal bool IsSetSelectiveExecutionConfig() => this.SelectiveExecutionConfig != null;
    }
}
