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
    /// Defines the training jobs launched by a hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTrainingJobDefinition
    {
        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterAlgorithmSpecification.html">HyperParameterAlgorithmSpecification</a>
        /// object that specifies the resource algorithm to use for the training jobs that the
        /// tuning job launches.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HyperParameterAlgorithmSpecification AlgorithmSpecification { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmSpecification property is set.
        /// </summary>
        internal bool IsSetAlgorithmSpecification() => this.AlgorithmSpecification != null;

        /// <summary>
        /// Gets and sets the property CheckpointConfig.
        /// </summary>
        public CheckpointConfig CheckpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointConfig property is set.
        /// </summary>
        internal bool IsSetCheckpointConfig() => this.CheckpointConfig != null;

        /// <summary>
        /// Gets and sets the property DefinitionName. 
        /// <para>
        /// The job definition name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the DefinitionName property is set.
        /// </summary>
        internal bool IsSetDefinitionName() => this.DefinitionName != null;

        /// <summary>
        /// Gets and sets the property EnableInterContainerTrafficEncryption. 
        /// <para>
        /// To encrypt all communications between ML compute instances in distributed training,
        /// choose <c>True</c>. Encryption provides greater security for distributed training,
        /// but training might take longer. How long it takes depends on the amount of communication
        /// between compute instances, especially if you use a deep learning algorithm in distributed
        /// training.
        /// </para>
        /// </summary>
        public bool? EnableInterContainerTrafficEncryption { get; set; }

        /// <summary>
        /// Checks to see if the EnableInterContainerTrafficEncryption property is set.
        /// </summary>
        internal bool IsSetEnableInterContainerTrafficEncryption() => this.EnableInterContainerTrafficEncryption.HasValue;

        /// <summary>
        /// Gets and sets the property EnableManagedSpotTraining. 
        /// <para>
        /// A Boolean indicating whether managed spot training is enabled (<c>True</c>) or not
        /// (<c>False</c>).
        /// </para>
        /// </summary>
        public bool? EnableManagedSpotTraining { get; set; }

        /// <summary>
        /// Checks to see if the EnableManagedSpotTraining property is set.
        /// </summary>
        internal bool IsSetEnableManagedSpotTraining() => this.EnableManagedSpotTraining.HasValue;

        /// <summary>
        /// Gets and sets the property EnableNetworkIsolation. 
        /// <para>
        /// Isolates the training container. No inbound or outbound network calls can be made,
        /// except for calls between peers within a training cluster for distributed training.
        /// If network isolation is used for training jobs that are configured to use a VPC, SageMaker
        /// downloads and uploads customer data and model artifacts through the specified VPC,
        /// but the training container does not have network access.
        /// </para>
        /// </summary>
        public bool? EnableNetworkIsolation { get; set; }

        /// <summary>
        /// Checks to see if the EnableNetworkIsolation property is set.
        /// </summary>
        internal bool IsSetEnableNetworkIsolation() => this.EnableNetworkIsolation.HasValue;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// An environment variable that you can pass into the SageMaker <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html">CreateTrainingJob</a>
        /// API. You can use an existing <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html#sagemaker-CreateTrainingJob-request-Environment">environment
        /// variable from the training container</a> or use your own. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics-variables.html">Define
        /// metrics and variables</a> for more information.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of items specified for <c>Map Entries</c> refers to the maximum
        /// number of environment variables for each <c>TrainingJobDefinition</c> and also the
        /// maximum for the hyperparameter tuning job itself. That is, the sum of the number of
        /// environment variables for all the training job definitions can't exceed the maximum
        /// number specified.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 48)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HyperParameterRanges.
        /// </summary>
        public ParameterRanges HyperParameterRanges { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterRanges property is set.
        /// </summary>
        internal bool IsSetHyperParameterRanges() => this.HyperParameterRanges != null;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningResourceConfig. 
        /// <para>
        /// The configuration for the hyperparameter tuning resources, including the compute instances
        /// and storage volumes, used for training jobs launched by the tuning job. By default,
        /// storage volumes hold model artifacts and incremental states. Choose <c>File</c> for
        /// <c>TrainingInputMode</c> in the <c>AlgorithmSpecification</c> parameter to additionally
        /// store training data in the storage volume (optional).
        /// </para>
        /// </summary>
        public HyperParameterTuningResourceConfig HyperParameterTuningResourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningResourceConfig property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningResourceConfig() => this.HyperParameterTuningResourceConfig != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// An array of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Channel.html">Channel</a>
        /// objects that specify the input for the training jobs that the tuning job launches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<Channel> InputDataConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<Channel>() : null;

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null && (this.InputDataConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Specifies the path to the Amazon S3 bucket where you store model artifacts from the
        /// training jobs that the tuning job launches.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The resources, including the compute instances and storage volumes, to use for the
        /// training jobs that the tuning job launches.
        /// </para>
        ///  
        /// <para>
        /// Storage volumes store model artifacts and incremental states. Training algorithms
        /// might also use storage volumes for scratch space. If you want SageMaker to use the
        /// storage volume to store the training data, choose <c>File</c> as the <c>TrainingInputMode</c>
        /// in the algorithm specification. For distributed training algorithms, specify an instance
        /// count greater than 1.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to use hyperparameter optimization with instance type flexibility, use
        /// <c>HyperParameterTuningResourceConfig</c> instead.
        /// </para>
        ///  </note>
        /// </summary>
        public ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfig property is set.
        /// </summary>
        internal bool IsSetResourceConfig() => this.ResourceConfig != null;

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The number of times to retry the job when the job fails due to an <c>InternalServerError</c>.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RetryStrategy property is set.
        /// </summary>
        internal bool IsSetRetryStrategy() => this.RetryStrategy != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the training jobs that
        /// the tuning job launches.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StaticHyperParameters. 
        /// <para>
        /// Specifies the values of hyperparameters that do not change for the tuning job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> StaticHyperParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StaticHyperParameters property is set.
        /// </summary>
        internal bool IsSetStaticHyperParameters() => this.StaticHyperParameters != null && (this.StaticHyperParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// Specifies a limit to how long a model hyperparameter training job can run. It also
        /// specifies how long a managed spot training job has to complete. When the job reaches
        /// the time limit, SageMaker ends the training job. Use this API to cap model training
        /// costs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property TuningObjective.
        /// </summary>
        public HyperParameterTuningJobObjective TuningObjective { get; set; }

        /// <summary>
        /// Checks to see if the TuningObjective property is set.
        /// </summary>
        internal bool IsSetTuningObjective() => this.TuningObjective != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html">VpcConfig</a>
        /// object that specifies the VPC that you want the training jobs that this hyperparameter
        /// tuning job launches to connect to. Control access to and from your training container
        /// by configuring the VPC. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html">Protect
        /// Training Jobs by Using an Amazon Virtual Private Cloud</a>.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
