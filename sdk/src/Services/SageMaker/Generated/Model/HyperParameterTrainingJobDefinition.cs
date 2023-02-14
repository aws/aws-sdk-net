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
    /// Defines the training jobs launched by a hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTrainingJobDefinition
    {
        private HyperParameterAlgorithmSpecification _algorithmSpecification;
        private CheckpointConfig _checkpointConfig;
        private string _definitionName;
        private bool? _enableInterContainerTrafficEncryption;
        private bool? _enableManagedSpotTraining;
        private bool? _enableNetworkIsolation;
        private Dictionary<string, string> _environment = new Dictionary<string, string>();
        private ParameterRanges _hyperParameterRanges;
        private HyperParameterTuningResourceConfig _hyperParameterTuningResourceConfig;
        private List<Channel> _inputDataConfig = new List<Channel>();
        private OutputDataConfig _outputDataConfig;
        private ResourceConfig _resourceConfig;
        private RetryStrategy _retryStrategy;
        private string _roleArn;
        private Dictionary<string, string> _staticHyperParameters = new Dictionary<string, string>();
        private StoppingCondition _stoppingCondition;
        private HyperParameterTuningJobObjective _tuningObjective;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// The <a>HyperParameterAlgorithmSpecification</a> object that specifies the resource
        /// algorithm to use for the training jobs that the tuning job launches.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HyperParameterAlgorithmSpecification AlgorithmSpecification
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
        /// Gets and sets the property DefinitionName. 
        /// <para>
        /// The job definition name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DefinitionName
        {
            get { return this._definitionName; }
            set { this._definitionName = value; }
        }

        // Check to see if DefinitionName property is set
        internal bool IsSetDefinitionName()
        {
            return this._definitionName != null;
        }

        /// <summary>
        /// Gets and sets the property EnableInterContainerTrafficEncryption. 
        /// <para>
        /// To encrypt all communications between ML compute instances in distributed training,
        /// choose <code>True</code>. Encryption provides greater security for distributed training,
        /// but training might take longer. How long it takes depends on the amount of communication
        /// between compute instances, especially if you use a deep learning algorithm in distributed
        /// training.
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
        /// A Boolean indicating whether managed spot training is enabled (<code>True</code>)
        /// or not (<code>False</code>).
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
        /// If network isolation is used for training jobs that are configured to use a VPC, SageMaker
        /// downloads and uploads customer data and model artifacts through the specified VPC,
        /// but the training container does not have network access.
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
        /// An environment variable that you can pass into the SageMaker <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html">CreateTrainingJob</a>
        /// API. You can use an existing <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html#sagemaker-CreateTrainingJob-request-Environment">environment
        /// variable from the training container</a> or use your own. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics.html">Define
        /// metrics and variables</a> for more information.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of items specified for <code>Map Entries</code> refers to the maximum
        /// number of environment variables for each <code>TrainingJobDefinition</code> and also
        /// the maximum for the hyperparameter tuning job itself. That is, the sum of the number
        /// of environment variables for all the training job definitions can't exceed the maximum
        /// number specified.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property HyperParameterRanges.
        /// </summary>
        public ParameterRanges HyperParameterRanges
        {
            get { return this._hyperParameterRanges; }
            set { this._hyperParameterRanges = value; }
        }

        // Check to see if HyperParameterRanges property is set
        internal bool IsSetHyperParameterRanges()
        {
            return this._hyperParameterRanges != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameterTuningResourceConfig. 
        /// <para>
        /// The configuration for the hyperparameter tuning resources, including the compute instances
        /// and storage volumes, used for training jobs launched by the tuning job. By default,
        /// storage volumes hold model artifacts and incremental states. Choose <code>File</code>
        /// for <code>TrainingInputMode</code> in the <code>AlgorithmSpecification</code> parameter
        /// to additionally store training data in the storage volume (optional).
        /// </para>
        /// </summary>
        public HyperParameterTuningResourceConfig HyperParameterTuningResourceConfig
        {
            get { return this._hyperParameterTuningResourceConfig; }
            set { this._hyperParameterTuningResourceConfig = value; }
        }

        // Check to see if HyperParameterTuningResourceConfig property is set
        internal bool IsSetHyperParameterTuningResourceConfig()
        {
            return this._hyperParameterTuningResourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// An array of <a>Channel</a> objects that specify the input for the training jobs that
        /// the tuning job launches.
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
        /// Specifies the path to the Amazon S3 bucket where you store model artifacts from the
        /// training jobs that the tuning job launches.
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
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The resources, including the compute instances and storage volumes, to use for the
        /// training jobs that the tuning job launches.
        /// </para>
        ///  
        /// <para>
        /// Storage volumes store model artifacts and incremental states. Training algorithms
        /// might also use storage volumes for scratch space. If you want SageMaker to use the
        /// storage volume to store the training data, choose <code>File</code> as the <code>TrainingInputMode</code>
        /// in the algorithm specification. For distributed training algorithms, specify an instance
        /// count greater than 1.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to use hyperparameter optimization with instance type flexibility, use
        /// <code>HyperParameterTuningResourceConfig</code> instead.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// The Amazon Resource Name (ARN) of the IAM role associated with the training jobs that
        /// the tuning job launches.
        /// </para>
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
        /// Gets and sets the property StaticHyperParameters. 
        /// <para>
        /// Specifies the values of hyperparameters that do not change for the tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> StaticHyperParameters
        {
            get { return this._staticHyperParameters; }
            set { this._staticHyperParameters = value; }
        }

        // Check to see if StaticHyperParameters property is set
        internal bool IsSetStaticHyperParameters()
        {
            return this._staticHyperParameters != null && this._staticHyperParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// Specifies a limit to how long a model hyperparameter training job can run. It also
        /// specifies how long a managed spot training job has to complete. When the job reaches
        /// the time limit, SageMaker ends the training job. Use this API to cap model training
        /// costs.
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
        /// Gets and sets the property TuningObjective.
        /// </summary>
        public HyperParameterTuningJobObjective TuningObjective
        {
            get { return this._tuningObjective; }
            set { this._tuningObjective = value; }
        }

        // Check to see if TuningObjective property is set
        internal bool IsSetTuningObjective()
        {
            return this._tuningObjective != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The <a>VpcConfig</a> object that specifies the VPC that you want the training jobs
        /// that this hyperparameter tuning job launches to connect to. Control access to and
        /// from your training container by configuring the VPC. For more information, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html">Protect Training
        /// Jobs by Using an Amazon Virtual Private Cloud</a>.
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