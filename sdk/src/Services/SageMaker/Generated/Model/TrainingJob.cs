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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains information about a training job.
    /// </summary>
    public partial class TrainingJob
    {
        private AlgorithmSpecification _algorithmSpecification;
        private string _autoMLJobArn;
        private int? _billableTimeInSeconds;
        private CheckpointConfig _checkpointConfig;
        private DateTime? _creationTime;
        private DebugHookConfig _debugHookConfig;
        private List<DebugRuleConfiguration> _debugRuleConfigurations = AWSConfigs.InitializeCollections ? new List<DebugRuleConfiguration>() : null;
        private List<DebugRuleEvaluationStatus> _debugRuleEvaluationStatuses = AWSConfigs.InitializeCollections ? new List<DebugRuleEvaluationStatus>() : null;
        private bool? _enableInterContainerTrafficEncryption;
        private bool? _enableManagedSpotTraining;
        private bool? _enableNetworkIsolation;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ExperimentConfig _experimentConfig;
        private string _failureReason;
        private List<MetricData> _finalMetricDataList = AWSConfigs.InitializeCollections ? new List<MetricData>() : null;
        private Dictionary<string, string> _hyperParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Channel> _inputDataConfig = AWSConfigs.InitializeCollections ? new List<Channel>() : null;
        private string _labelingJobArn;
        private DateTime? _lastModifiedTime;
        private ModelArtifacts _modelArtifacts;
        private OutputDataConfig _outputDataConfig;
        private ProfilerConfig _profilerConfig;
        private ResourceConfig _resourceConfig;
        private RetryStrategy _retryStrategy;
        private string _roleArn;
        private SecondaryStatus _secondaryStatus;
        private List<SecondaryStatusTransition> _secondaryStatusTransitions = AWSConfigs.InitializeCollections ? new List<SecondaryStatusTransition>() : null;
        private StoppingCondition _stoppingCondition;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TensorBoardOutputConfig _tensorBoardOutputConfig;
        private DateTime? _trainingEndTime;
        private string _trainingJobArn;
        private string _trainingJobName;
        private TrainingJobStatus _trainingJobStatus;
        private DateTime? _trainingStartTime;
        private int? _trainingTimeInSeconds;
        private string _tuningJobArn;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// Information about the algorithm used for training, and algorithm metadata.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AutoMLJobArn
        {
            get { return this._autoMLJobArn; }
            set { this._autoMLJobArn = value; }
        }

        // Check to see if AutoMLJobArn property is set
        internal bool IsSetAutoMLJobArn()
        {
            return this._autoMLJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property BillableTimeInSeconds. 
        /// <para>
        /// The billable time in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? BillableTimeInSeconds
        {
            get { return this._billableTimeInSeconds; }
            set { this._billableTimeInSeconds = value; }
        }

        // Check to see if BillableTimeInSeconds property is set
        internal bool IsSetBillableTimeInSeconds()
        {
            return this._billableTimeInSeconds.HasValue; 
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the training job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
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
        /// Information about the debug rule configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._debugRuleConfigurations != null && (this._debugRuleConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DebugRuleEvaluationStatuses. 
        /// <para>
        /// Information about the evaluation status of the rules for the training job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<DebugRuleEvaluationStatus> DebugRuleEvaluationStatuses
        {
            get { return this._debugRuleEvaluationStatuses; }
            set { this._debugRuleEvaluationStatuses = value; }
        }

        // Check to see if DebugRuleEvaluationStatuses property is set
        internal bool IsSetDebugRuleEvaluationStatuses()
        {
            return this._debugRuleEvaluationStatuses != null && (this._debugRuleEvaluationStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public bool? EnableInterContainerTrafficEncryption
        {
            get { return this._enableInterContainerTrafficEncryption; }
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
        /// When true, enables managed spot training using Amazon EC2 Spot instances to run training
        /// jobs instead of on-demand instances. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-managed-spot-training.html">Managed
        /// Spot Training</a>.
        /// </para>
        /// </summary>
        public bool? EnableManagedSpotTraining
        {
            get { return this._enableManagedSpotTraining; }
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
        /// If the <c>TrainingJob</c> was created with network isolation, the value is set to
        /// <c>true</c>. If network isolation is enabled, nodes can't communicate beyond the VPC
        /// they run in.
        /// </para>
        /// </summary>
        public bool? EnableNetworkIsolation
        {
            get { return this._enableNetworkIsolation; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the training job failed, the reason it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property FinalMetricDataList. 
        /// <para>
        /// A list of final metric values that are set when the training job completes. Used only
        /// if the training job was configured to use metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public List<MetricData> FinalMetricDataList
        {
            get { return this._finalMetricDataList; }
            set { this._finalMetricDataList = value; }
        }

        // Check to see if FinalMetricDataList property is set
        internal bool IsSetFinalMetricDataList()
        {
            return this._finalMetricDataList != null && (this._finalMetricDataList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Algorithm-specific parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._hyperParameters != null && (this._hyperParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// An array of <c>Channel</c> objects that describes each data input channel.
        /// </para>
        ///  
        /// <para>
        /// Your input must be in the same Amazon Web Services region as your training job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._inputDataConfig != null && (this._inputDataConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string LabelingJobArn
        {
            get { return this._labelingJobArn; }
            set { this._labelingJobArn = value; }
        }

        // Check to see if LabelingJobArn property is set
        internal bool IsSetLabelingJobArn()
        {
            return this._labelingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that indicates when the status of the training job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelArtifacts. 
        /// <para>
        /// Information about the Amazon S3 location that is configured for storing model artifacts.
        /// </para>
        /// </summary>
        public ModelArtifacts ModelArtifacts
        {
            get { return this._modelArtifacts; }
            set { this._modelArtifacts = value; }
        }

        // Check to see if ModelArtifacts property is set
        internal bool IsSetModelArtifacts()
        {
            return this._modelArtifacts != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The S3 path where model artifacts that you configured when creating the job are stored.
        /// SageMaker creates subfolders for model artifacts.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// Resources, including ML compute instances and ML storage volumes, that are configured
        /// for model training.
        /// </para>
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
        /// The number of times to retry the job when the job fails due to an <c>InternalServerError</c>.
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
        /// The Amazon Web Services Identity and Access Management (IAM) role configured for the
        /// training job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property SecondaryStatus. 
        /// <para>
        ///  Provides detailed information about the state of the training job. For detailed information
        /// about the secondary status of the training job, see <c>StatusMessage</c> under <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_SecondaryStatusTransition.html">SecondaryStatusTransition</a>.
        /// </para>
        ///  
        /// <para>
        /// SageMaker provides primary statuses and secondary statuses that apply to each of them:
        /// </para>
        ///  <dl> <dt>InProgress</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>Starting</c> - Starting the training job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Downloading</c> - An optional stage for algorithms that support <c>File</c> training
        /// input mode. It indicates that data is being downloaded to the ML storage volumes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Training</c> - Training is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Uploading</c> - Training is complete and the model artifacts are being uploaded
        /// to the S3 location.
        /// </para>
        ///  </li> </ul> </dd> <dt>Completed</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>Completed</c> - The training job has completed.
        /// </para>
        ///  </li> </ul> </dd> <dt>Failed</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>Failed</c> - The training job has failed. The reason for the failure is returned
        /// in the <c>FailureReason</c> field of <c>DescribeTrainingJobResponse</c>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Stopped</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>MaxRuntimeExceeded</c> - The job stopped because it exceeded the maximum allowed
        /// runtime.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopped</c> - The training job has stopped.
        /// </para>
        ///  </li> </ul> </dd> <dt>Stopping</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>Stopping</c> - Stopping the training job.
        /// </para>
        ///  </li> </ul> </dd> </dl> <important> 
        /// <para>
        /// Valid values for <c>SecondaryStatus</c> are subject to change. 
        /// </para>
        ///  </important> 
        /// <para>
        /// We no longer support the following secondary statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LaunchingMLInstances</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PreparingTrainingStack</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DownloadingTrainingImage</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SecondaryStatus SecondaryStatus
        {
            get { return this._secondaryStatus; }
            set { this._secondaryStatus = value; }
        }

        // Check to see if SecondaryStatus property is set
        internal bool IsSetSecondaryStatus()
        {
            return this._secondaryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryStatusTransitions. 
        /// <para>
        /// A history of all of the secondary statuses that the training job has transitioned
        /// through.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecondaryStatusTransition> SecondaryStatusTransitions
        {
            get { return this._secondaryStatusTransitions; }
            set { this._secondaryStatusTransitions = value; }
        }

        // Check to see if SecondaryStatusTransitions property is set
        internal bool IsSetSecondaryStatusTransitions()
        {
            return this._secondaryStatusTransitions != null && (this._secondaryStatusTransitions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// To stop a job, SageMaker sends the algorithm the <c>SIGTERM</c> signal, which delays
        /// job termination for 120 seconds. Algorithms can use this 120-second window to save
        /// the model artifacts, so the results of training are not lost. 
        /// </para>
        /// </summary>
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property TrainingEndTime. 
        /// <para>
        /// Indicates the time when the training job ends on training instances. You are billed
        /// for the time interval between the value of <c>TrainingStartTime</c> and this time.
        /// For successful jobs and stopped jobs, this is the time after model artifacts are uploaded.
        /// For failed jobs, this is the time when SageMaker detects a job failure.
        /// </para>
        /// </summary>
        public DateTime? TrainingEndTime
        {
            get { return this._trainingEndTime; }
            set { this._trainingEndTime = value; }
        }

        // Check to see if TrainingEndTime property is set
        internal bool IsSetTrainingEndTime()
        {
            return this._trainingEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string TrainingJobArn
        {
            get { return this._trainingJobArn; }
            set { this._trainingJobArn = value; }
        }

        // Check to see if TrainingJobArn property is set
        internal bool IsSetTrainingJobArn()
        {
            return this._trainingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property TrainingJobStatus. 
        /// <para>
        /// The status of the training job.
        /// </para>
        ///  
        /// <para>
        /// Training job statuses are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InProgress</c> - The training is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Completed</c> - The training job has completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - The training job has failed. To see the reason for the failure, see
        /// the <c>FailureReason</c> field in the response to a <c>DescribeTrainingJobResponse</c>
        /// call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopping</c> - The training job is stopping.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopped</c> - The training job has stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more detailed information, see <c>SecondaryStatus</c>. 
        /// </para>
        /// </summary>
        public TrainingJobStatus TrainingJobStatus
        {
            get { return this._trainingJobStatus; }
            set { this._trainingJobStatus = value; }
        }

        // Check to see if TrainingJobStatus property is set
        internal bool IsSetTrainingJobStatus()
        {
            return this._trainingJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingStartTime. 
        /// <para>
        /// Indicates the time when the training job starts on training instances. You are billed
        /// for the time interval between this time and the value of <c>TrainingEndTime</c>. The
        /// start time in CloudWatch Logs might be later than this time. The difference is due
        /// to the time it takes to download the training data and to the size of the training
        /// container.
        /// </para>
        /// </summary>
        public DateTime? TrainingStartTime
        {
            get { return this._trainingStartTime; }
            set { this._trainingStartTime = value; }
        }

        // Check to see if TrainingStartTime property is set
        internal bool IsSetTrainingStartTime()
        {
            return this._trainingStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingTimeInSeconds. 
        /// <para>
        /// The training time in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TrainingTimeInSeconds
        {
            get { return this._trainingTimeInSeconds; }
            set { this._trainingTimeInSeconds = value; }
        }

        // Check to see if TrainingTimeInSeconds property is set
        internal bool IsSetTrainingTimeInSeconds()
        {
            return this._trainingTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TuningJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated hyperparameter tuning job if the
        /// training job was launched by a hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string TuningJobArn
        {
            get { return this._tuningJobArn; }
            set { this._tuningJobArn = value; }
        }

        // Check to see if TuningJobArn property is set
        internal bool IsSetTuningJobArn()
        {
            return this._tuningJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html">VpcConfig</a>
        /// object that specifies the VPC that this training job has access to. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html">Protect
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