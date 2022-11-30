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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrainingJob operation.
    /// Starts a model training job. After training completes, SageMaker saves the resulting
    /// model artifacts to an Amazon S3 location that you specify. 
    /// 
    ///  
    /// <para>
    /// If you choose to host your model using SageMaker hosting services, you can use the
    /// resulting model artifacts as part of the model. You can also use the artifacts in
    /// a machine learning service other than SageMaker, provided that you know how to use
    /// them for inference. 
    /// </para>
    ///  
    /// <para>
    /// In the request body, you provide the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AlgorithmSpecification</code> - Identifies the training algorithm to use. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>HyperParameters</code> - Specify these algorithm-specific parameters to enable
    /// the estimation of model parameters during training. Hyperparameters can be tuned to
    /// optimize this learning process. For a list of hyperparameters for each training algorithm
    /// provided by SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
    /// 
    /// </para>
    ///  <important> 
    /// <para>
    /// Do not include any security-sensitive information including account access IDs, secrets
    /// or tokens in any hyperparameter field. If the use of security-sensitive credentials
    /// are detected, SageMaker will reject your training job request and return an exception
    /// error.
    /// </para>
    ///  </important> </li> <li> 
    /// <para>
    ///  <code>InputDataConfig</code> - Describes the input required by the training job and
    /// the Amazon S3, EFS, or FSx location where it is stored.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>OutputDataConfig</code> - Identifies the Amazon S3 bucket where you want SageMaker
    /// to save the results of model training. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ResourceConfig</code> - Identifies the resources, ML compute instances, and
    /// ML storage volumes to deploy for model training. In distributed training, you specify
    /// more than one instance. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>EnableManagedSpotTraining</code> - Optimize the cost of training machine learning
    /// models by up to 80% by using Amazon EC2 Spot instances. For more information, see
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-managed-spot-training.html">Managed
    /// Spot Training</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RoleArn</code> - The Amazon Resource Name (ARN) that SageMaker assumes to perform
    /// tasks on your behalf during model training. You must grant this role the necessary
    /// permissions so that SageMaker can successfully complete model training. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>StoppingCondition</code> - To help cap training costs, use <code>MaxRuntimeInSeconds</code>
    /// to set a time limit for training. Use <code>MaxWaitTimeInSeconds</code> to specify
    /// how long a managed spot training job has to complete. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Environment</code> - The environment variables to set in the Docker container.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RetryStrategy</code> - The number of times to retry the job when the job fails
    /// due to an <code>InternalServerError</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information about SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
    /// It Works</a>. 
    /// </para>
    /// </summary>
    public partial class CreateTrainingJobRequest : AmazonSageMakerRequest
    {
        private AlgorithmSpecification _algorithmSpecification;
        private CheckpointConfig _checkpointConfig;
        private DebugHookConfig _debugHookConfig;
        private List<DebugRuleConfiguration> _debugRuleConfigurations = new List<DebugRuleConfiguration>();
        private bool? _enableInterContainerTrafficEncryption;
        private bool? _enableManagedSpotTraining;
        private bool? _enableNetworkIsolation;
        private Dictionary<string, string> _environment = new Dictionary<string, string>();
        private ExperimentConfig _experimentConfig;
        private Dictionary<string, string> _hyperParameters = new Dictionary<string, string>();
        private List<Channel> _inputDataConfig = new List<Channel>();
        private OutputDataConfig _outputDataConfig;
        private ProfilerConfig _profilerConfig;
        private List<ProfilerRuleConfiguration> _profilerRuleConfigurations = new List<ProfilerRuleConfiguration>();
        private ResourceConfig _resourceConfig;
        private RetryStrategy _retryStrategy;
        private string _roleArn;
        private StoppingCondition _stoppingCondition;
        private List<Tag> _tags = new List<Tag>();
        private TensorBoardOutputConfig _tensorBoardOutputConfig;
        private string _trainingJobName;
        private VpcConfig _vpcConfig;

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
        [AWSProperty(Required=true)]
        public AlgorithmSpecification AlgorithmSpecification
        {
            get { return this._algorithmSpecification; }
            set { this._algorithmSpecification = value; }
        }

        // Check to see if AlgorithmSpecification property is set
        internal bool IsSetAlgorithmSpecification()
        {
            return this._algorithmSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CheckpointConfig. 
        /// <para>
        /// Contains information about the output location for managed spot training checkpoint
        /// data.
        /// </para>
        /// </summary>
        public CheckpointConfig CheckpointConfig
        {
            get { return this._checkpointConfig; }
            set { this._checkpointConfig = value; }
        }

        // Check to see if CheckpointConfig property is set
        internal bool IsSetCheckpointConfig()
        {
            return this._checkpointConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DebugHookConfig.
        /// </summary>
        public DebugHookConfig DebugHookConfig
        {
            get { return this._debugHookConfig; }
            set { this._debugHookConfig = value; }
        }

        // Check to see if DebugHookConfig property is set
        internal bool IsSetDebugHookConfig()
        {
            return this._debugHookConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DebugRuleConfigurations. 
        /// <para>
        /// Configuration information for Amazon SageMaker Debugger rules for debugging output
        /// tensors.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<DebugRuleConfiguration> DebugRuleConfigurations
        {
            get { return this._debugRuleConfigurations; }
            set { this._debugRuleConfigurations = value; }
        }

        // Check to see if DebugRuleConfigurations property is set
        internal bool IsSetDebugRuleConfigurations()
        {
            return this._debugRuleConfigurations != null && this._debugRuleConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableInterContainerTrafficEncryption. 
        /// <para>
        /// To encrypt all communications between ML compute instances in distributed training,
        /// choose <code>True</code>. Encryption provides greater security for distributed training,
        /// but training might take longer. How long it takes depends on the amount of communication
        /// between compute instances, especially if you use a deep learning algorithm in distributed
        /// training. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-encrypt.html">Protect
        /// Communications Between ML Compute Instances in a Distributed Training Job</a>.
        /// </para>
        /// </summary>
        public bool EnableInterContainerTrafficEncryption
        {
            get { return this._enableInterContainerTrafficEncryption.GetValueOrDefault(); }
            set { this._enableInterContainerTrafficEncryption = value; }
        }

        // Check to see if EnableInterContainerTrafficEncryption property is set
        internal bool IsSetEnableInterContainerTrafficEncryption()
        {
            return this._enableInterContainerTrafficEncryption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableManagedSpotTraining. 
        /// <para>
        /// To train models using managed spot training, choose <code>True</code>. Managed spot
        /// training provides a fully managed and scalable infrastructure for training machine
        /// learning models. this option is useful when training jobs can be interrupted and when
        /// there is flexibility when the training job is run. 
        /// </para>
        ///  
        /// <para>
        /// The complete and intermediate results of jobs are stored in an Amazon S3 bucket, and
        /// can be used as a starting point to train models incrementally. Amazon SageMaker provides
        /// metrics and logs in CloudWatch. They can be used to see when managed spot training
        /// jobs are running, interrupted, resumed, or completed. 
        /// </para>
        /// </summary>
        public bool EnableManagedSpotTraining
        {
            get { return this._enableManagedSpotTraining.GetValueOrDefault(); }
            set { this._enableManagedSpotTraining = value; }
        }

        // Check to see if EnableManagedSpotTraining property is set
        internal bool IsSetEnableManagedSpotTraining()
        {
            return this._enableManagedSpotTraining.HasValue; 
        }

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
        public bool EnableNetworkIsolation
        {
            get { return this._enableNetworkIsolation.GetValueOrDefault(); }
            set { this._enableNetworkIsolation = value; }
        }

        // Check to see if EnableNetworkIsolation property is set
        internal bool IsSetEnableNetworkIsolation()
        {
            return this._enableNetworkIsolation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container.
        /// </para>
        /// </summary>
        [AWSProperty(Max=48)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && this._environment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExperimentConfig.
        /// </summary>
        public ExperimentConfig ExperimentConfig
        {
            get { return this._experimentConfig; }
            set { this._experimentConfig = value; }
        }

        // Check to see if ExperimentConfig property is set
        internal bool IsSetExperimentConfig()
        {
            return this._experimentConfig != null;
        }

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
        /// pair. Each key and value is limited to 256 characters, as specified by the <code>Length
        /// Constraint</code>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets
        /// or tokens in any hyperparameter field. If the use of security-sensitive credentials
        /// are detected, SageMaker will reject your training job request and return an exception
        /// error.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> HyperParameters
        {
            get { return this._hyperParameters; }
            set { this._hyperParameters = value; }
        }

        // Check to see if HyperParameters property is set
        internal bool IsSetHyperParameters()
        {
            return this._hyperParameters != null && this._hyperParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// An array of <code>Channel</code> objects. Each channel is a named input source. <code>InputDataConfig</code>
        /// describes the input data and its location. 
        /// </para>
        ///  
        /// <para>
        /// Algorithms can accept input data from one or more channels. For example, an algorithm
        /// might have two channels of input data, <code>training_data</code> and <code>validation_data</code>.
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
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<Channel> InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null && this._inputDataConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Specifies the path to the S3 location where you want to store model artifacts. SageMaker
        /// creates subfolders for the artifacts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilerConfig.
        /// </summary>
        public ProfilerConfig ProfilerConfig
        {
            get { return this._profilerConfig; }
            set { this._profilerConfig = value; }
        }

        // Check to see if ProfilerConfig property is set
        internal bool IsSetProfilerConfig()
        {
            return this._profilerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilerRuleConfigurations. 
        /// <para>
        /// Configuration information for Amazon SageMaker Debugger rules for profiling system
        /// and framework metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<ProfilerRuleConfiguration> ProfilerRuleConfigurations
        {
            get { return this._profilerRuleConfigurations; }
            set { this._profilerRuleConfigurations = value; }
        }

        // Check to see if ProfilerRuleConfigurations property is set
        internal bool IsSetProfilerRuleConfigurations()
        {
            return this._profilerRuleConfigurations != null && this._profilerRuleConfigurations.Count > 0; 
        }

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
        /// the ML storage volume to store the training data, choose <code>File</code> as the
        /// <code>TrainingInputMode</code> in the algorithm specification. For distributed training
        /// algorithms, specify an instance count greater than 1.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceConfig ResourceConfig
        {
            get { return this._resourceConfig; }
            set { this._resourceConfig = value; }
        }

        // Check to see if ResourceConfig property is set
        internal bool IsSetResourceConfig()
        {
            return this._resourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The number of times to retry the job when the job fails due to an <code>InternalServerError</code>.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy
        {
            get { return this._retryStrategy; }
            set { this._retryStrategy = value; }
        }

        // Check to see if RetryStrategy property is set
        internal bool IsSetRetryStrategy()
        {
            return this._retryStrategy != null;
        }

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
        /// To be able to pass this role to SageMaker, the caller of this API must have the <code>iam:PassRole</code>
        /// permission.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// Specifies a limit to how long a model training job can run. It also specifies how
        /// long a managed Spot training job has to complete. When the job reaches the time limit,
        /// SageMaker ends the training job. Use this API to cap model training costs.
        /// </para>
        ///  
        /// <para>
        /// To stop a job, SageMaker sends the algorithm the <code>SIGTERM</code> signal, which
        /// delays job termination for 120 seconds. Algorithms can use this 120-second window
        /// to save the model artifacts, so the results of training are not lost. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StoppingCondition StoppingCondition
        {
            get { return this._stoppingCondition; }
            set { this._stoppingCondition = value; }
        }

        // Check to see if StoppingCondition property is set
        internal bool IsSetStoppingCondition()
        {
            return this._stoppingCondition != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TensorBoardOutputConfig.
        /// </summary>
        public TensorBoardOutputConfig TensorBoardOutputConfig
        {
            get { return this._tensorBoardOutputConfig; }
            set { this._tensorBoardOutputConfig = value; }
        }

        // Check to see if TensorBoardOutputConfig property is set
        internal bool IsSetTensorBoardOutputConfig()
        {
            return this._tensorBoardOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job. The name must be unique within an Amazon Web Services
        /// Region in an Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TrainingJobName
        {
            get { return this._trainingJobName; }
            set { this._trainingJobName = value; }
        }

        // Check to see if TrainingJobName property is set
        internal bool IsSetTrainingJobName()
        {
            return this._trainingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a>VpcConfig</a> object that specifies the VPC that you want your training job to
        /// connect to. Control access to and from your training container by configuring the
        /// VPC. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html">Protect
        /// Training Jobs by Using an Amazon Virtual Private Cloud</a>.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}