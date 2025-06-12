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
    /// This is the response object from the DescribeProcessingJob operation.
    /// </summary>
    public partial class DescribeProcessingJobResponse : AmazonWebServiceResponse
    {
        private AppSpecification _appSpecification;
        private string _autoMLJobArn;
        private DateTime? _creationTime;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _exitMessage;
        private ExperimentConfig _experimentConfig;
        private string _failureReason;
        private DateTime? _lastModifiedTime;
        private string _monitoringScheduleArn;
        private NetworkConfig _networkConfig;
        private DateTime? _processingEndTime;
        private List<ProcessingInput> _processingInputs = AWSConfigs.InitializeCollections ? new List<ProcessingInput>() : null;
        private string _processingJobArn;
        private string _processingJobName;
        private ProcessingJobStatus _processingJobStatus;
        private ProcessingOutputConfig _processingOutputConfig;
        private ProcessingResources _processingResources;
        private DateTime? _processingStartTime;
        private string _roleArn;
        private ProcessingStoppingCondition _stoppingCondition;
        private string _trainingJobArn;

        /// <summary>
        /// Gets and sets the property AppSpecification. 
        /// <para>
        /// Configures the processing job to run a specified container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppSpecification AppSpecification
        {
            get { return this._appSpecification; }
            set { this._appSpecification = value; }
        }

        // Check to see if AppSpecification property is set
        internal bool IsSetAppSpecification()
        {
            return this._appSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// The ARN of an AutoML job associated with this processing job.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the processing job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables set in the Docker container.
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
        /// Gets and sets the property ExitMessage. 
        /// <para>
        /// An optional string, up to one KB in size, that contains metadata from the processing
        /// container when the processing job exits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ExitMessage
        {
            get { return this._exitMessage; }
            set { this._exitMessage = value; }
        }

        // Check to see if ExitMessage property is set
        internal bool IsSetExitMessage()
        {
            return this._exitMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentConfig. 
        /// <para>
        /// The configuration information used to create an experiment.
        /// </para>
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
        /// A string, up to one KB in size, that contains the reason a processing job failed,
        /// if it failed.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time at which the processing job was last modified.
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
        /// Gets and sets the property MonitoringScheduleArn. 
        /// <para>
        /// The ARN of a monitoring schedule for an endpoint associated with this processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string MonitoringScheduleArn
        {
            get { return this._monitoringScheduleArn; }
            set { this._monitoringScheduleArn = value; }
        }

        // Check to see if MonitoringScheduleArn property is set
        internal bool IsSetMonitoringScheduleArn()
        {
            return this._monitoringScheduleArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Networking options for a processing job.
        /// </para>
        /// </summary>
        public NetworkConfig NetworkConfig
        {
            get { return this._networkConfig; }
            set { this._networkConfig = value; }
        }

        // Check to see if NetworkConfig property is set
        internal bool IsSetNetworkConfig()
        {
            return this._networkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingEndTime. 
        /// <para>
        /// The time at which the processing job completed.
        /// </para>
        /// </summary>
        public DateTime? ProcessingEndTime
        {
            get { return this._processingEndTime; }
            set { this._processingEndTime = value; }
        }

        // Check to see if ProcessingEndTime property is set
        internal bool IsSetProcessingEndTime()
        {
            return this._processingEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProcessingInputs. 
        /// <para>
        /// The inputs for a processing job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ProcessingInput> ProcessingInputs
        {
            get { return this._processingInputs; }
            set { this._processingInputs = value; }
        }

        // Check to see if ProcessingInputs property is set
        internal bool IsSetProcessingInputs()
        {
            return this._processingInputs != null && (this._processingInputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProcessingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ProcessingJobArn
        {
            get { return this._processingJobArn; }
            set { this._processingJobArn = value; }
        }

        // Check to see if ProcessingJobArn property is set
        internal bool IsSetProcessingJobArn()
        {
            return this._processingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingJobName. 
        /// <para>
        /// The name of the processing job. The name must be unique within an Amazon Web Services
        /// Region in the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ProcessingJobName
        {
            get { return this._processingJobName; }
            set { this._processingJobName = value; }
        }

        // Check to see if ProcessingJobName property is set
        internal bool IsSetProcessingJobName()
        {
            return this._processingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingJobStatus. 
        /// <para>
        /// Provides the status of a processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingJobStatus ProcessingJobStatus
        {
            get { return this._processingJobStatus; }
            set { this._processingJobStatus = value; }
        }

        // Check to see if ProcessingJobStatus property is set
        internal bool IsSetProcessingJobStatus()
        {
            return this._processingJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingOutputConfig. 
        /// <para>
        /// Output configuration for the processing job.
        /// </para>
        /// </summary>
        public ProcessingOutputConfig ProcessingOutputConfig
        {
            get { return this._processingOutputConfig; }
            set { this._processingOutputConfig = value; }
        }

        // Check to see if ProcessingOutputConfig property is set
        internal bool IsSetProcessingOutputConfig()
        {
            return this._processingOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingResources. 
        /// <para>
        /// Identifies the resources, ML compute instances, and ML storage volumes to deploy for
        /// a processing job. In distributed training, you specify more than one instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingResources ProcessingResources
        {
            get { return this._processingResources; }
            set { this._processingResources = value; }
        }

        // Check to see if ProcessingResources property is set
        internal bool IsSetProcessingResources()
        {
            return this._processingResources != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingStartTime. 
        /// <para>
        /// The time at which the processing job started.
        /// </para>
        /// </summary>
        public DateTime? ProcessingStartTime
        {
            get { return this._processingStartTime; }
            set { this._processingStartTime = value; }
        }

        // Check to see if ProcessingStartTime property is set
        internal bool IsSetProcessingStartTime()
        {
            return this._processingStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to
        /// perform tasks on your behalf.
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
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// The time limit for how long the processing job is allowed to run.
        /// </para>
        /// </summary>
        public ProcessingStoppingCondition StoppingCondition
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
        /// Gets and sets the property TrainingJobArn. 
        /// <para>
        /// The ARN of a training job associated with this processing job.
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

    }
}