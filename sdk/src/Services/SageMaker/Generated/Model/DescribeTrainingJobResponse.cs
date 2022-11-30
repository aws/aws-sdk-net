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
    /// This is the response object from the DescribeTrainingJob operation.
    /// </summary>
    public partial class DescribeTrainingJobResponse : AmazonWebServiceResponse
    {
        private AlgorithmSpecification _algorithmSpecification;
        private string _autoMLJobArn;
        private int? _billableTimeInSeconds;
        private CheckpointConfig _checkpointConfig;
        private DateTime? _creationTime;
        private DebugHookConfig _debugHookConfig;
        private List<DebugRuleConfiguration> _debugRuleConfigurations = new List<DebugRuleConfiguration>();
        private List<DebugRuleEvaluationStatus> _debugRuleEvaluationStatuses = new List<DebugRuleEvaluationStatus>();
        private bool? _enableInterContainerTrafficEncryption;
        private bool? _enableManagedSpotTraining;
        private bool? _enableNetworkIsolation;
        private Dictionary<string, string> _environment = new Dictionary<string, string>();
        private ExperimentConfig _experimentConfig;
        private string _failureReason;
        private List<MetricData> _finalMetricDataList = new List<MetricData>();
        private Dictionary<string, string> _hyperParameters = new Dictionary<string, string>();
        private List<Channel> _inputDataConfig = new List<Channel>();
        private string _labelingJobArn;
        private DateTime? _lastModifiedTime;
        private ModelArtifacts _modelArtifacts;
        private OutputDataConfig _outputDataConfig;
        private ProfilerConfig _profilerConfig;
        private List<ProfilerRuleConfiguration> _profilerRuleConfigurations = new List<ProfilerRuleConfiguration>();
        private List<ProfilerRuleEvaluationStatus> _profilerRuleEvaluationStatuses = new List<ProfilerRuleEvaluationStatus>();
        private ProfilingStatus _profilingStatus;
        private ResourceConfig _resourceConfig;
        private RetryStrategy _retryStrategy;
        private string _roleArn;
        private SecondaryStatus _secondaryStatus;
        private List<SecondaryStatusTransition> _secondaryStatusTransitions = new List<SecondaryStatusTransition>();
        private StoppingCondition _stoppingCondition;
        private TensorBoardOutputConfig _tensorBoardOutputConfig;
        private DateTime? _trainingEndTime;
        private string _trainingJobArn;
        private string _trainingJobName;
        private TrainingJobStatus _trainingJobStatus;
        private DateTime? _trainingStartTime;
        private int? _trainingTimeInSeconds;
        private string _tuningJobArn;
        private VpcConfig _vpcConfig;
        private WarmPoolStatus _warmPoolStatus;

        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// Information about the algorithm used for training, and algorithm metadata. 
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
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AutoML job.
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
        /// The billable time in seconds. Billable time refers to the absolute wall-clock time.
        /// </para>
        ///  
        /// <para>
        /// Multiply <code>BillableTimeInSeconds</code> by the number of instances (<code>InstanceCount</code>)
        /// in your training cluster to get the total compute time SageMaker bills you if you
        /// run distributed training. The formula is as follows: <code>BillableTimeInSeconds *
        /// InstanceCount</code> .
        /// </para>
        ///  
        /// <para>
        /// You can calculate the savings from using managed spot training using the formula <code>(1
        /// - BillableTimeInSeconds / TrainingTimeInSeconds) * 100</code>. For example, if <code>BillableTimeInSeconds</code>
        /// is 100 and <code>TrainingTimeInSeconds</code> is 500, the savings is 80%.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int BillableTimeInSeconds
        {
            get { return this._billableTimeInSeconds.GetValueOrDefault(); }
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
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        /// Gets and sets the property DebugRuleEvaluationStatuses. 
        /// <para>
        /// Evaluation status of Amazon SageMaker Debugger rules for debugging on a training job.
        /// </para>
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
            return this._debugRuleEvaluationStatuses != null && this._debugRuleEvaluationStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableInterContainerTrafficEncryption. 
        /// <para>
        /// To encrypt all communications between ML compute instances in distributed training,
        /// choose <code>True</code>. Encryption provides greater security for distributed training,
        /// but training might take longer. How long it takes depends on the amount of communication
        /// between compute instances, especially if you use a deep learning algorithms in distributed
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
        /// If you want to allow inbound or outbound network calls, except for calls between peers
        /// within a training cluster for distributed training, choose <code>True</code>. If you
        /// enable network isolation for training jobs that are configured to use a VPC, SageMaker
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the training job failed, the reason it failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// A collection of <code>MetricData</code> objects that specify the names, values, and
        /// dates and times that the training algorithm emitted to Amazon CloudWatch.
        /// </para>
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
            return this._finalMetricDataList != null && this._finalMetricDataList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Algorithm-specific parameters. 
        /// </para>
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
        /// An array of <code>Channel</code> objects that describes each data input channel. 
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
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker Ground Truth labeling job that created
        /// the transform or training job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
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
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ProfilerRuleEvaluationStatuses. 
        /// <para>
        /// Evaluation status of Amazon SageMaker Debugger rules for profiling on a training job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<ProfilerRuleEvaluationStatus> ProfilerRuleEvaluationStatuses
        {
            get { return this._profilerRuleEvaluationStatuses; }
            set { this._profilerRuleEvaluationStatuses = value; }
        }

        // Check to see if ProfilerRuleEvaluationStatuses property is set
        internal bool IsSetProfilerRuleEvaluationStatuses()
        {
            return this._profilerRuleEvaluationStatuses != null && this._profilerRuleEvaluationStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProfilingStatus. 
        /// <para>
        /// Profiling status of a training job.
        /// </para>
        /// </summary>
        public ProfilingStatus ProfilingStatus
        {
            get { return this._profilingStatus; }
            set { this._profilingStatus = value; }
        }

        // Check to see if ProfilingStatus property is set
        internal bool IsSetProfilingStatus()
        {
            return this._profilingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// Resources, including ML compute instances and ML storage volumes, that are configured
        /// for model training. 
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
        /// on the secondary status of the training job, see <code>StatusMessage</code> under
        /// <a>SecondaryStatusTransition</a>.
        /// </para>
        ///  
        /// <para>
        /// SageMaker provides primary statuses and secondary statuses that apply to each of them:
        /// </para>
        ///  <dl> <dt>InProgress</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>Starting</code> - Starting the training job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Downloading</code> - An optional stage for algorithms that support <code>File</code>
        /// training input mode. It indicates that data is being downloaded to the ML storage
        /// volumes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Training</code> - Training is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Interrupted</code> - The job stopped because the managed spot training instances
        /// were interrupted. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Uploading</code> - Training is complete and the model artifacts are being uploaded
        /// to the S3 location.
        /// </para>
        ///  </li> </ul> </dd> <dt>Completed</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>Completed</code> - The training job has completed.
        /// </para>
        ///  </li> </ul> </dd> <dt>Failed</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>Failed</code> - The training job has failed. The reason for the failure is
        /// returned in the <code>FailureReason</code> field of <code>DescribeTrainingJobResponse</code>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Stopped</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>MaxRuntimeExceeded</code> - The job stopped because it exceeded the maximum
        /// allowed runtime.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaxWaitTimeExceeded</code> - The job stopped because it exceeded the maximum
        /// allowed wait time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Stopped</code> - The training job has stopped.
        /// </para>
        ///  </li> </ul> </dd> <dt>Stopping</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>Stopping</code> - Stopping the training job.
        /// </para>
        ///  </li> </ul> </dd> </dl> <important> 
        /// <para>
        /// Valid values for <code>SecondaryStatus</code> are subject to change. 
        /// </para>
        ///  </important> 
        /// <para>
        /// We no longer support the following secondary statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LaunchingMLInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PreparingTraining</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DownloadingTrainingImage</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// </summary>
        public List<SecondaryStatusTransition> SecondaryStatusTransitions
        {
            get { return this._secondaryStatusTransitions; }
            set { this._secondaryStatusTransitions = value; }
        }

        // Check to see if SecondaryStatusTransitions property is set
        internal bool IsSetSecondaryStatusTransitions()
        {
            return this._secondaryStatusTransitions != null && this._secondaryStatusTransitions.Count > 0; 
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
        /// for the time interval between the value of <code>TrainingStartTime</code> and this
        /// time. For successful jobs and stopped jobs, this is the time after model artifacts
        /// are uploaded. For failed jobs, this is the time when SageMaker detects a job failure.
        /// </para>
        /// </summary>
        public DateTime TrainingEndTime
        {
            get { return this._trainingEndTime.GetValueOrDefault(); }
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
        [AWSProperty(Required=true, Max=256)]
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
        ///  Name of the model training job. 
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
        /// Gets and sets the property TrainingJobStatus. 
        /// <para>
        /// The status of the training job.
        /// </para>
        ///  
        /// <para>
        /// SageMaker provides the following training job statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>InProgress</code> - The training is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Completed</code> - The training job has completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code> - The training job has failed. To see the reason for the failure,
        /// see the <code>FailureReason</code> field in the response to a <code>DescribeTrainingJobResponse</code>
        /// call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Stopping</code> - The training job is stopping.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Stopped</code> - The training job has stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more detailed information, see <code>SecondaryStatus</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// for the time interval between this time and the value of <code>TrainingEndTime</code>.
        /// The start time in CloudWatch Logs might be later than this time. The difference is
        /// due to the time it takes to download the training data and to the size of the training
        /// container.
        /// </para>
        /// </summary>
        public DateTime TrainingStartTime
        {
            get { return this._trainingStartTime.GetValueOrDefault(); }
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
        public int TrainingTimeInSeconds
        {
            get { return this._trainingTimeInSeconds.GetValueOrDefault(); }
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
        [AWSProperty(Max=256)]
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
        /// A <a>VpcConfig</a> object that specifies the VPC that this training job has access
        /// to. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html">Protect
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

        /// <summary>
        /// Gets and sets the property WarmPoolStatus. 
        /// <para>
        /// The status of the warm pool associated with the training job.
        /// </para>
        /// </summary>
        public WarmPoolStatus WarmPoolStatus
        {
            get { return this._warmPoolStatus; }
            set { this._warmPoolStatus = value; }
        }

        // Check to see if WarmPoolStatus property is set
        internal bool IsSetWarmPoolStatus()
        {
            return this._warmPoolStatus != null;
        }

    }
}