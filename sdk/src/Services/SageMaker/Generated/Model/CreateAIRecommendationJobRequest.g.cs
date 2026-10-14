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
    /// Container for the parameters to the CreateAIRecommendationJob operation. Creates a
    /// recommendation job that generates intelligent optimization recommendations for generative
    /// AI inference deployments. The job analyzes your model, workload configuration, and
    /// performance targets to recommend optimal instance types, model optimization techniques
    /// (such as quantization and speculative decoding), and deployment configurations.
    /// </summary>
    public partial class CreateAIRecommendationJobRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AIRecommendationJobName. 
        /// <para>
        /// The name of the AI recommendation job. The name must be unique within your Amazon
        /// Web Services account in the current Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string AIRecommendationJobName { get; set; }

        /// <summary>
        /// Checks to see if the AIRecommendationJobName property is set.
        /// </summary>
        internal bool IsSetAIRecommendationJobName() => this.AIRecommendationJobName != null;

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigIdentifier. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the AI workload configuration to use for
        /// this recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AIWorkloadConfigIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AIWorkloadConfigIdentifier property is set.
        /// </summary>
        internal bool IsSetAIWorkloadConfigIdentifier() => this.AIWorkloadConfigIdentifier != null;

        /// <summary>
        /// Gets and sets the property AdapterSource. 
        /// <para>
        /// The LoRA adapter source for the recommendation job. Specify either a list of model
        /// package ARNs or Amazon S3 URIs for your LoRA adapters. When this parameter is absent,
        /// the recommendation job runs without LoRA adapter support.
        /// </para>
        /// </summary>
        public AIAdapterSource AdapterSource { get; set; }

        /// <summary>
        /// Checks to see if the AdapterSource property is set.
        /// </summary>
        internal bool IsSetAdapterSource() => this.AdapterSource != null;

        /// <summary>
        /// Gets and sets the property ComputeSpec. 
        /// <para>
        /// The compute resource specification for the recommendation job. You can specify up
        /// to 3 instance types to consider, and optionally provide capacity reservation configuration.
        /// </para>
        /// </summary>
        public AIRecommendationComputeSpec ComputeSpec { get; set; }

        /// <summary>
        /// Checks to see if the ComputeSpec property is set.
        /// </summary>
        internal bool IsSetComputeSpec() => this.ComputeSpec != null;

        /// <summary>
        /// Gets and sets the property InferenceSpecification. 
        /// <para>
        /// The inference framework configuration. Specify the framework (such as LMI or vLLM)
        /// for the recommendation job.
        /// </para>
        /// </summary>
        public AIRecommendationInferenceSpecification InferenceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSpecification property is set.
        /// </summary>
        internal bool IsSetInferenceSpecification() => this.InferenceSpecification != null;

        /// <summary>
        /// Gets and sets the property ModelSource. 
        /// <para>
        /// The source of the model to optimize. Specify the Amazon S3 location of the model artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIModelSource ModelSource { get; set; }

        /// <summary>
        /// Checks to see if the ModelSource property is set.
        /// </summary>
        internal bool IsSetModelSource() => this.ModelSource != null;

        /// <summary>
        /// Gets and sets the property OptimizeModel. 
        /// <para>
        /// Whether to allow model optimization techniques such as quantization, speculative decoding,
        /// and kernel tuning. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? OptimizeModel { get; set; }

        /// <summary>
        /// Checks to see if the OptimizeModel property is set.
        /// </summary>
        internal bool IsSetOptimizeModel() => this.OptimizeModel.HasValue;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for the recommendation job, including the Amazon S3 location
        /// for results and an optional model package group where the optimized model is registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIRecommendationOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property PerformanceTarget. 
        /// <para>
        /// The performance targets for the recommendation job. Specify constraints on metrics
        /// such as time to first token (<c>ttft-ms</c>), <c>throughput</c>, or <c>cost</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIRecommendationPerformanceTarget PerformanceTarget { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceTarget property is set.
        /// </summary>
        internal bool IsSetPerformanceTarget() => this.PerformanceTarget != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that enables Amazon SageMaker AI to
        /// perform tasks on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to Amazon Web Services resources to help you categorize
        /// and organize them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
