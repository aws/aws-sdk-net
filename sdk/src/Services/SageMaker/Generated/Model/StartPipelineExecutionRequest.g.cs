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
    /// Container for the parameters to the StartPipelineExecution operation. Starts a pipeline
    /// execution.
    /// </summary>
    public partial class StartPipelineExecutionRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the operation. An idempotent operation completes no more than once.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 128)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property MlflowExperimentName. 
        /// <para>
        ///  The MLflow experiment name of the pipeline execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MlflowExperimentName { get; set; }

        /// <summary>
        /// Checks to see if the MlflowExperimentName property is set.
        /// </summary>
        internal bool IsSetMlflowExperimentName() => this.MlflowExperimentName != null;

        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// This configuration, if specified, overrides the parallelism configuration of the parent
        /// pipeline for this specific run.
        /// </para>
        /// </summary>
        public ParallelismConfiguration ParallelismConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ParallelismConfiguration property is set.
        /// </summary>
        internal bool IsSetParallelismConfiguration() => this.ParallelismConfiguration != null;

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
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property PipelineParameters. 
        /// <para>
        /// Contains a list of pipeline parameters. This list can be empty. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Parameter> PipelineParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;

        /// <summary>
        /// Checks to see if the PipelineParameters property is set.
        /// </summary>
        internal bool IsSetPipelineParameters() => this.PipelineParameters != null && (this.PipelineParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PipelineVersionId. 
        /// <para>
        /// The ID of the pipeline version to start execution from.
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
