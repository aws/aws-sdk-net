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
    /// This is the response object from the DescribeTrainingJob operation.
    /// </summary>
    public partial class DescribeTrainingJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// Information about the algorithm used for training, and algorithm metadata. 
        /// </para>
        /// </summary>
        public AlgorithmSpecification AlgorithmSpecification { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmSpecification property is set.
        /// </summary>
        internal bool IsSetAlgorithmSpecification() => this.AlgorithmSpecification != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AutoMLJobArn { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobArn property is set.
        /// </summary>
        internal bool IsSetAutoMLJobArn() => this.AutoMLJobArn != null;

        /// <summary>
        /// Gets and sets the property BillableTimeInSeconds. 
        /// <para>
        /// The billable time in seconds. Billable time refers to the absolute wall-clock time.
        /// </para>
        ///  
        /// <para>
        /// Multiply <c>BillableTimeInSeconds</c> by the number of instances (<c>InstanceCount</c>)
        /// in your training cluster to get the total compute time SageMaker bills you if you
        /// run distributed training. The formula is as follows: <c>BillableTimeInSeconds * InstanceCount</c>
        /// .
        /// </para>
        ///  
        /// <para>
        /// You can calculate the savings from using managed spot training using the formula <c>(1
        /// - BillableTimeInSeconds / TrainingTimeInSeconds) * 100</c>. For example, if <c>BillableTimeInSeconds</c>
        /// is 100 and <c>TrainingTimeInSeconds</c> is 500, the savings is 80%.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? BillableTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the BillableTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetBillableTimeInSeconds() => this.BillableTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property BillableTokenCount. 
        /// <para>
        ///  The billable token count for eligible serverless training jobs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? BillableTokenCount { get; set; }

        /// <summary>
        /// Checks to see if the BillableTokenCount property is set.
        /// </summary>
        internal bool IsSetBillableTokenCount() => this.BillableTokenCount.HasValue;

        /// <summary>
        /// Gets and sets the property CheckpointConfig.
        /// </summary>
        public CheckpointConfig CheckpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointConfig property is set.
        /// </summary>
        internal bool IsSetCheckpointConfig() => this.CheckpointConfig != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the training job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        /// Gets and sets the property DebugRuleEvaluationStatuses. 
        /// <para>
        /// Evaluation status of Amazon SageMaker Debugger rules for debugging on a training job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<DebugRuleEvaluationStatus> DebugRuleEvaluationStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<DebugRuleEvaluationStatus>() : null;

        /// <summary>
        /// Checks to see if the DebugRuleEvaluationStatuses property is set.
        /// </summary>
        internal bool IsSetDebugRuleEvaluationStatuses() => this.DebugRuleEvaluationStatuses != null && (this.DebugRuleEvaluationStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableInterContainerTrafficEncryption. 
        /// <para>
        /// To encrypt all communications between ML compute instances in distributed training,
        /// choose <c>True</c>. Encryption provides greater security for distributed training,
        /// but training might take longer. How long it takes depends on the amount of communication
        /// between compute instances, especially if you use a deep learning algorithms in distributed
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
        /// If you want to allow inbound or outbound network calls, except for calls between peers
        /// within a training cluster for distributed training, choose <c>True</c>. If you enable
        /// network isolation for training jobs that are configured to use a VPC, SageMaker downloads
        /// and uploads customer data and model artifacts through the specified VPC, but the training
        /// container does not have network access.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the training job failed, the reason it failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property FinalMetricDataList. 
        /// <para>
        /// A collection of <c>MetricData</c> objects that specify the names, values, and dates
        /// and times that the training algorithm emitted to Amazon CloudWatch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public List<MetricData> FinalMetricDataList { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricData>() : null;

        /// <summary>
        /// Checks to see if the FinalMetricDataList property is set.
        /// </summary>
        internal bool IsSetFinalMetricDataList() => this.FinalMetricDataList != null && (this.FinalMetricDataList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Algorithm-specific parameters. 
        /// </para>
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
        /// An array of <c>Channel</c> objects that describes each data input channel. 
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
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker Ground Truth labeling job that created
        /// the transform or training job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string LabelingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobArn property is set.
        /// </summary>
        internal bool IsSetLabelingJobArn() => this.LabelingJobArn != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that indicates when the status of the training job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

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
        /// Gets and sets the property MlflowDetails. 
        /// <para>
        ///  The MLflow details of this job. 
        /// </para>
        /// </summary>
        public MlflowDetails MlflowDetails { get; set; }

        /// <summary>
        /// Checks to see if the MlflowDetails property is set.
        /// </summary>
        internal bool IsSetMlflowDetails() => this.MlflowDetails != null;

        /// <summary>
        /// Gets and sets the property ModelArtifacts. 
        /// <para>
        /// Information about the Amazon S3 location that is configured for storing model artifacts.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelArtifacts ModelArtifacts { get; set; }

        /// <summary>
        /// Checks to see if the ModelArtifacts property is set.
        /// </summary>
        internal bool IsSetModelArtifacts() => this.ModelArtifacts != null;

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
        /// The S3 path where model artifacts that you configured when creating the job are stored.
        /// SageMaker creates subfolders for model artifacts. 
        /// </para>
        /// </summary>
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property OutputModelPackageArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the output model package containing model weights
        /// or checkpoints. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string OutputModelPackageArn { get; set; }

        /// <summary>
        /// Checks to see if the OutputModelPackageArn property is set.
        /// </summary>
        internal bool IsSetOutputModelPackageArn() => this.OutputModelPackageArn != null;

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
        /// Gets and sets the property ProfilerRuleEvaluationStatuses. 
        /// <para>
        /// Evaluation status of Amazon SageMaker Debugger rules for profiling on a training job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ProfilerRuleEvaluationStatus> ProfilerRuleEvaluationStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<ProfilerRuleEvaluationStatus>() : null;

        /// <summary>
        /// Checks to see if the ProfilerRuleEvaluationStatuses property is set.
        /// </summary>
        internal bool IsSetProfilerRuleEvaluationStatuses() => this.ProfilerRuleEvaluationStatuses != null && (this.ProfilerRuleEvaluationStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProfilingStatus. 
        /// <para>
        /// Profiling status of a training job.
        /// </para>
        /// </summary>
        public ProfilingStatus ProfilingStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingStatus property is set.
        /// </summary>
        internal bool IsSetProfilingStatus() => this.ProfilingStatus != null;

        /// <summary>
        /// Gets and sets the property ProgressInfo. 
        /// <para>
        ///  The Serverless training job progress information. 
        /// </para>
        /// </summary>
        public TrainingProgressInfo ProgressInfo { get; set; }

        /// <summary>
        /// Checks to see if the ProgressInfo property is set.
        /// </summary>
        internal bool IsSetProgressInfo() => this.ProgressInfo != null;

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
        /// Resources, including ML compute instances and ML storage volumes, that are configured
        /// for model training. 
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
        /// The Amazon Web Services Identity and Access Management (IAM) role configured for the
        /// training job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SecondaryStatus. 
        /// <para>
        ///  Provides detailed information about the state of the training job. For detailed information
        /// on the secondary status of the training job, see <c>StatusMessage</c> under <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_SecondaryStatusTransition.html">SecondaryStatusTransition</a>.
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
        ///  <c>Pending</c> - The training job is waiting for compute capacity or compute resource
        /// provision.
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
        ///  <c>Interrupted</c> - The job stopped because the managed spot training instances
        /// were interrupted. 
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
        ///  <c>MaxWaitTimeExceeded</c> - The job stopped because it exceeded the maximum allowed
        /// wait time.
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
        ///  <c>PreparingTraining</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DownloadingTrainingImage</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SecondaryStatus SecondaryStatus { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryStatus property is set.
        /// </summary>
        internal bool IsSetSecondaryStatus() => this.SecondaryStatus != null;

        /// <summary>
        /// Gets and sets the property SecondaryStatusTransitions. 
        /// <para>
        /// A history of all of the secondary statuses that the training job has transitioned
        /// through.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecondaryStatusTransition> SecondaryStatusTransitions { get; set; } = AWSConfigs.InitializeCollections ? new List<SecondaryStatusTransition>() : null;

        /// <summary>
        /// Checks to see if the SecondaryStatusTransitions property is set.
        /// </summary>
        internal bool IsSetSecondaryStatusTransitions() => this.SecondaryStatusTransitions != null && (this.SecondaryStatusTransitions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true)]
        public StoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property TensorBoardOutputConfig.
        /// </summary>
        public TensorBoardOutputConfig TensorBoardOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the TensorBoardOutputConfig property is set.
        /// </summary>
        internal bool IsSetTensorBoardOutputConfig() => this.TensorBoardOutputConfig != null;

        /// <summary>
        /// Gets and sets the property TrainingEndTime. 
        /// <para>
        /// Indicates the time when the training job ends on training instances. You are billed
        /// for the time interval between the value of <c>TrainingStartTime</c> and this time.
        /// For successful jobs and stopped jobs, this is the time after model artifacts are uploaded.
        /// For failed jobs, this is the time when SageMaker detects a job failure.
        /// </para>
        /// </summary>
        public DateTime? TrainingEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingEndTime property is set.
        /// </summary>
        internal bool IsSetTrainingEndTime() => this.TrainingEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TrainingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobArn property is set.
        /// </summary>
        internal bool IsSetTrainingJobArn() => this.TrainingJobArn != null;

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        ///  Name of the model training job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string TrainingJobName { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobName property is set.
        /// </summary>
        internal bool IsSetTrainingJobName() => this.TrainingJobName != null;

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
        [AWSProperty(Required = true)]
        public TrainingJobStatus TrainingJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobStatus property is set.
        /// </summary>
        internal bool IsSetTrainingJobStatus() => this.TrainingJobStatus != null;

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
        public DateTime? TrainingStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingStartTime property is set.
        /// </summary>
        internal bool IsSetTrainingStartTime() => this.TrainingStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingTimeInSeconds. 
        /// <para>
        /// The training time in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TrainingTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TrainingTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetTrainingTimeInSeconds() => this.TrainingTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TuningJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated hyperparameter tuning job if the
        /// training job was launched by a hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TuningJobArn { get; set; }

        /// <summary>
        /// Checks to see if the TuningJobArn property is set.
        /// </summary>
        internal bool IsSetTuningJobArn() => this.TuningJobArn != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html">VpcConfig</a>
        /// object that specifies the VPC that this training job has access to. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html">Protect
        /// Training Jobs by Using an Amazon Virtual Private Cloud</a>.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;

        /// <summary>
        /// Gets and sets the property WarmPoolStatus. 
        /// <para>
        /// The status of the warm pool associated with the training job.
        /// </para>
        /// </summary>
        public WarmPoolStatus WarmPoolStatus { get; set; }

        /// <summary>
        /// Checks to see if the WarmPoolStatus property is set.
        /// </summary>
        internal bool IsSetWarmPoolStatus() => this.WarmPoolStatus != null;
    }
}
