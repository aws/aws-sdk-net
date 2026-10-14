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
    /// Container for the parameters to the CreateTrainingJob operation. Starts a model training
    /// job. After training completes, SageMaker saves the resulting model artifacts to an
    /// Amazon S3 location that you specify. <para> If you choose to host your model using
    /// SageMaker hosting services, you can use the resulting model artifacts as part of the
    /// model. You can also use the artifacts in a machine learning service other than SageMaker,
    /// provided that you know how to use them for inference. </para> <para> In the request
    /// body, you provide the following: </para> <ul> <li> <para> <c>AlgorithmSpecification</c>
    /// - Identifies the training algorithm to use. </para> </li> <li> <para> <c>HyperParameters</c>
    /// - Specify these algorithm-specific parameters to enable the estimation of model parameters
    /// during training. Hyperparameters can be tuned to optimize this learning process. For
    /// a list of hyperparameters for each training algorithm provided by SageMaker, see <a
    /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
    /// </para> <important> <para> Do not include any security-sensitive information including
    /// account access IDs, secrets, or tokens in any hyperparameter fields. As part of the
    /// shared responsibility model, you are responsible for any potential exposure, unauthorized
    /// access, or compromise of your sensitive data if caused by security-sensitive information
    /// included in the request hyperparameter variable or plain text fields. </para> </important>
    /// </li> <li> <para> <c>InputDataConfig</c> - Describes the input required by the training
    /// job and the Amazon S3, EFS, or FSx location where it is stored. </para> </li> <li>
    /// <para> <c>OutputDataConfig</c> - Identifies the Amazon S3 bucket where you want SageMaker
    /// to save the results of model training. </para> </li> <li> <para> <c>ResourceConfig</c>
    /// - Identifies the resources, ML compute instances, and ML storage volumes to deploy
    /// for model training. In distributed training, you specify more than one instance. </para>
    /// </li> <li> <para> <c>EnableManagedSpotTraining</c> - Optimize the cost of training
    /// machine learning models by up to 80% by using Amazon EC2 Spot instances. For more
    /// information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-managed-spot-training.html">Managed
    /// Spot Training</a>. </para> </li> <li> <para> <c>RoleArn</c> - The Amazon Resource
    /// Name (ARN) that SageMaker assumes to perform tasks on your behalf during model training.
    /// You must grant this role the necessary permissions so that SageMaker can successfully
    /// complete model training. </para> </li> <li> <para> <c>StoppingCondition</c> - To help
    /// cap training costs, use <c>MaxRuntimeInSeconds</c> to set a time limit for training.
    /// Use <c>MaxWaitTimeInSeconds</c> to specify how long a managed spot training job has
    /// to complete. </para> </li> <li> <para> <c>Environment</c> - The environment variables
    /// to set in the Docker container. </para> <important> <para> Do not include any security-sensitive
    /// information including account access IDs, secrets, or tokens in any environment fields.
    /// As part of the shared responsibility model, you are responsible for any potential
    /// exposure, unauthorized access, or compromise of your sensitive data if caused by security-sensitive
    /// information included in the request environment variable or plain text fields. </para>
    /// </important> </li> <li> <para> <c>RetryStrategy</c> - The number of times to retry
    /// the job when the job fails due to an <c>InternalServerError</c>. </para> </li> </ul>
    /// <para> For more information about SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
    /// It Works</a>. </para>
    /// </summary>
    public partial class CreateTrainingJobRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// The registry path of the Docker image that contains the training algorithm and algorithm-specific
        /// metadata, including the input mode. For more information about algorithms provided
        /// by SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// For information about providing your own algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
        /// Your Own Algorithms with Amazon SageMaker</a>. 
        /// </para>
        /// </summary>
        public AlgorithmSpecification AlgorithmSpecification { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmSpecification property is set.
        /// </summary>
        internal bool IsSetAlgorithmSpecification() => this.AlgorithmSpecification != null;

        /// <summary>
        /// Gets and sets the property CheckpointConfig. 
        /// <para>
        /// Contains information about the output location for managed spot training checkpoint
        /// data.
        /// </para>
        /// </summary>
        public CheckpointConfig CheckpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointConfig property is set.
        /// </summary>
        internal bool IsSetCheckpointConfig() => this.CheckpointConfig != null;

        /// <summary>
        /// Gets and sets the property DebugHookConfig.
        /// </summary>
        public DebugHookConfig DebugHookConfig { get; set; }

        /// <summary>
        /// Checks to see if the DebugHookConfig property is set.
        /// </summary>
        internal bool IsSetDebugHookConfig() => this.DebugHookConfig != null;

        /// <summary>
        /// Gets and sets the property DebugRuleConfigurations. 
        /// <para>
        /// Configuration information for Amazon SageMaker Debugger rules for debugging output
        /// tensors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<DebugRuleConfiguration> DebugRuleConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<DebugRuleConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DebugRuleConfigurations property is set.
        /// </summary>
        internal bool IsSetDebugRuleConfigurations() => this.DebugRuleConfigurations != null && (this.DebugRuleConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableInterContainerTrafficEncryption. 
        /// <para>
        /// To encrypt all communications between ML compute instances in distributed training,
        /// choose <c>True</c>. Encryption provides greater security for distributed training,
        /// but training might take longer. How long it takes depends on the amount of communication
        /// between compute instances, especially if you use a deep learning algorithm in distributed
        /// training. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-encrypt.html">Protect
        /// Communications Between ML Compute Instances in a Distributed Training Job</a>.
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
        /// To train models using managed spot training, choose <c>True</c>. Managed spot training
        /// provides a fully managed and scalable infrastructure for training machine learning
        /// models. this option is useful when training jobs can be interrupted and when there
        /// is flexibility when the training job is run. 
        /// </para>
        ///  
        /// <para>
        /// The complete and intermediate results of jobs are stored in an Amazon S3 bucket, and
        /// can be used as a starting point to train models incrementally. Amazon SageMaker provides
        /// metrics and logs in CloudWatch. They can be used to see when managed spot training
        /// jobs are running, interrupted, resumed, or completed. 
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
        /// If you enable network isolation for training jobs that are configured to use a VPC,
        /// SageMaker downloads and uploads customer data and model artifacts through the specified
        /// VPC, but the training container does not have network access.
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
        /// The environment variables to set in the Docker container.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets,
        /// or tokens in any environment fields. As part of the shared responsibility model, you
        /// are responsible for any potential exposure, unauthorized access, or compromise of
        /// your sensitive data if caused by security-sensitive information included in the request
        /// environment variable or plain text fields.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExperimentConfig.
        /// </summary>
        public ExperimentConfig ExperimentConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentConfig property is set.
        /// </summary>
        internal bool IsSetExperimentConfig() => this.ExperimentConfig != null;

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Algorithm-specific parameters that influence the quality of the model. You set hyperparameters
        /// before you start the learning process. For a list of hyperparameters for each training
        /// algorithm provided by SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can specify a maximum of 100 hyperparameters. Each hyperparameter is a key-value
        /// pair. Each key and value is limited to 256 characters, as specified by the <c>Length
        /// Constraint</c>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets,
        /// or tokens in any hyperparameter fields. As part of the shared responsibility model,
        /// you are responsible for any potential exposure, unauthorized access, or compromise
        /// of your sensitive data if caused by any security-sensitive information included in
        /// the request hyperparameter variable or plain text fields.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> HyperParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the HyperParameters property is set.
        /// </summary>
        internal bool IsSetHyperParameters() => this.HyperParameters != null && (this.HyperParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InfraCheckConfig. 
        /// <para>
        /// Contains information about the infrastructure health check configuration for the training
        /// job.
        /// </para>
        /// </summary>
        public InfraCheckConfig InfraCheckConfig { get; set; }

        /// <summary>
        /// Checks to see if the InfraCheckConfig property is set.
        /// </summary>
        internal bool IsSetInfraCheckConfig() => this.InfraCheckConfig != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// An array of <c>Channel</c> objects. Each channel is a named input source. <c>InputDataConfig</c>
        /// describes the input data and its location. 
        /// </para>
        ///  
        /// <para>
        /// Algorithms can accept input data from one or more channels. For example, an algorithm
        /// might have two channels of input data, <c>training_data</c> and <c>validation_data</c>.
        /// The configuration for each channel provides the S3, EFS, or FSx location where the
        /// input data is stored. It also provides information about the stored data: the MIME
        /// type, compression method, and whether the data is wrapped in RecordIO format. 
        /// </para>
        ///  
        /// <para>
        /// Depending on the input mode that the algorithm supports, SageMaker either copies input
        /// data files from an S3 bucket to a local directory in the Docker container, or makes
        /// it available as input streams. For example, if you specify an EFS location, input
        /// data files are available as input streams. They do not need to be downloaded.
        /// </para>
        ///  
        /// <para>
        /// Your input must be in the same Amazon Web Services region as your training job.
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
        /// Gets and sets the property MlflowConfig. 
        /// <para>
        ///  The MLflow configuration using SageMaker managed MLflow. 
        /// </para>
        /// </summary>
        public MlflowConfig MlflowConfig { get; set; }

        /// <summary>
        /// Checks to see if the MlflowConfig property is set.
        /// </summary>
        internal bool IsSetMlflowConfig() => this.MlflowConfig != null;

        /// <summary>
        /// Gets and sets the property ModelPackageConfig. 
        /// <para>
        ///  The configuration for the model package. 
        /// </para>
        /// </summary>
        public ModelPackageConfig ModelPackageConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageConfig property is set.
        /// </summary>
        internal bool IsSetModelPackageConfig() => this.ModelPackageConfig != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Specifies the path to the S3 location where you want to store model artifacts. SageMaker
        /// creates subfolders for the artifacts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property ProfilerConfig.
        /// </summary>
        public ProfilerConfig ProfilerConfig { get; set; }

        /// <summary>
        /// Checks to see if the ProfilerConfig property is set.
        /// </summary>
        internal bool IsSetProfilerConfig() => this.ProfilerConfig != null;

        /// <summary>
        /// Gets and sets the property ProfilerRuleConfigurations. 
        /// <para>
        /// Configuration information for Amazon SageMaker Debugger rules for profiling system
        /// and framework metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ProfilerRuleConfiguration> ProfilerRuleConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ProfilerRuleConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ProfilerRuleConfigurations property is set.
        /// </summary>
        internal bool IsSetProfilerRuleConfigurations() => this.ProfilerRuleConfigurations != null && (this.ProfilerRuleConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoteDebugConfig. 
        /// <para>
        /// Configuration for remote debugging. To learn more about the remote debugging functionality
        /// of SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-remote-debugging.html">Access
        /// a training container through Amazon Web Services Systems Manager (SSM) for remote
        /// debugging</a>.
        /// </para>
        /// </summary>
        public RemoteDebugConfig RemoteDebugConfig { get; set; }

        /// <summary>
        /// Checks to see if the RemoteDebugConfig property is set.
        /// </summary>
        internal bool IsSetRemoteDebugConfig() => this.RemoteDebugConfig != null;

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The resources, including the ML compute instances and ML storage volumes, to use for
        /// model training. 
        /// </para>
        ///  
        /// <para>
        /// ML storage volumes store model artifacts and incremental states. Training algorithms
        /// might also use ML storage volumes for scratch space. If you want SageMaker to use
        /// the ML storage volume to store the training data, choose <c>File</c> as the <c>TrainingInputMode</c>
        /// in the algorithm specification. For distributed training algorithms, specify an instance
        /// count greater than 1.
        /// </para>
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
        /// The Amazon Resource Name (ARN) of an IAM role that SageMaker can assume to perform
        /// tasks on your behalf. 
        /// </para>
        ///  
        /// <para>
        /// During model training, SageMaker needs your permission to read input data from an
        /// S3 bucket, download a Docker image that contains training code, write model artifacts
        /// to an S3 bucket, write logs to Amazon CloudWatch Logs, and publish metrics to Amazon
        /// CloudWatch. You grant permissions for all of these tasks to an IAM role. For more
        /// information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">SageMaker
        /// Roles</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to pass this role to SageMaker, the caller of this API must have the <c>iam:PassRole</c>
        /// permission.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property ServerlessJobConfig. 
        /// <para>
        ///  The configuration for serverless training jobs. 
        /// </para>
        /// </summary>
        public ServerlessJobConfig ServerlessJobConfig { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessJobConfig property is set.
        /// </summary>
        internal bool IsSetServerlessJobConfig() => this.ServerlessJobConfig != null;

        /// <summary>
        /// Gets and sets the property SessionChainingConfig. 
        /// <para>
        /// Contains information about attribute-based access control (ABAC) for the training
        /// job.
        /// </para>
        /// </summary>
        public SessionChainingConfig SessionChainingConfig { get; set; }

        /// <summary>
        /// Checks to see if the SessionChainingConfig property is set.
        /// </summary>
        internal bool IsSetSessionChainingConfig() => this.SessionChainingConfig != null;

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// Specifies a limit to how long a model training job can run. It also specifies how
        /// long a managed Spot training job has to complete. When the job reaches the time limit,
        /// SageMaker ends the training job. Use this API to cap model training costs.
        /// </para>
        ///  
        /// <para>
        /// To stop a job, SageMaker sends the algorithm the <c>SIGTERM</c> signal, which delays
        /// job termination for 120 seconds. Algorithms can use this 120-second window to save
        /// the model artifacts, so the results of training are not lost. 
        /// </para>
        /// </summary>
        public StoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets,
        /// or tokens in any tags. As part of the shared responsibility model, you are responsible
        /// for any potential exposure, unauthorized access, or compromise of your sensitive data
        /// if caused by any security-sensitive information included in the request tag variable
        /// or plain text fields.
        /// </para>
        ///  </important>
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

        /// <summary>
        /// Gets and sets the property TensorBoardOutputConfig.
        /// </summary>
        public TensorBoardOutputConfig TensorBoardOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the TensorBoardOutputConfig property is set.
        /// </summary>
        internal bool IsSetTensorBoardOutputConfig() => this.TensorBoardOutputConfig != null;

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job. The name must be unique within an Amazon Web Services
        /// Region in an Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string TrainingJobName { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobName property is set.
        /// </summary>
        internal bool IsSetTrainingJobName() => this.TrainingJobName != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html">VpcConfig</a>
        /// object that specifies the VPC that you want your training job to connect to. Control
        /// access to and from your training container by configuring the VPC. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html">Protect
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
