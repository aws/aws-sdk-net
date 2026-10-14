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
    /// This is the response object from the DescribeProcessingJob operation.
    /// </summary>
    public partial class DescribeProcessingJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AppSpecification. 
        /// <para>
        /// Configures the processing job to run a specified container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AppSpecification AppSpecification { get; set; }

        /// <summary>
        /// Checks to see if the AppSpecification property is set.
        /// </summary>
        internal bool IsSetAppSpecification() => this.AppSpecification != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// The ARN of an AutoML job associated with this processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AutoMLJobArn { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobArn property is set.
        /// </summary>
        internal bool IsSetAutoMLJobArn() => this.AutoMLJobArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the processing job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables set in the Docker container.
        /// </para>
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
        /// Gets and sets the property ExitMessage. 
        /// <para>
        /// An optional string, up to one KB in size, that contains metadata from the processing
        /// container when the processing job exits.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ExitMessage { get; set; }

        /// <summary>
        /// Checks to see if the ExitMessage property is set.
        /// </summary>
        internal bool IsSetExitMessage() => this.ExitMessage != null;

        /// <summary>
        /// Gets and sets the property ExperimentConfig. 
        /// <para>
        /// The configuration information used to create an experiment.
        /// </para>
        /// </summary>
        public ExperimentConfig ExperimentConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentConfig property is set.
        /// </summary>
        internal bool IsSetExperimentConfig() => this.ExperimentConfig != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A string, up to one KB in size, that contains the reason a processing job failed,
        /// if it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time at which the processing job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringScheduleArn. 
        /// <para>
        /// The ARN of a monitoring schedule for an endpoint associated with this processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MonitoringScheduleArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringScheduleArn property is set.
        /// </summary>
        internal bool IsSetMonitoringScheduleArn() => this.MonitoringScheduleArn != null;

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Networking options for a processing job.
        /// </para>
        /// </summary>
        public NetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfig property is set.
        /// </summary>
        internal bool IsSetNetworkConfig() => this.NetworkConfig != null;

        /// <summary>
        /// Gets and sets the property ProcessingEndTime. 
        /// <para>
        /// The time at which the processing job completed.
        /// </para>
        /// </summary>
        public DateTime? ProcessingEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingEndTime property is set.
        /// </summary>
        internal bool IsSetProcessingEndTime() => this.ProcessingEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProcessingInputs. 
        /// <para>
        /// The inputs for a processing job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ProcessingInput> ProcessingInputs { get; set; } = AWSConfigs.InitializeCollections ? new List<ProcessingInput>() : null;

        /// <summary>
        /// Checks to see if the ProcessingInputs property is set.
        /// </summary>
        internal bool IsSetProcessingInputs() => this.ProcessingInputs != null && (this.ProcessingInputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ProcessingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJobArn property is set.
        /// </summary>
        internal bool IsSetProcessingJobArn() => this.ProcessingJobArn != null;

        /// <summary>
        /// Gets and sets the property ProcessingJobName. 
        /// <para>
        /// The name of the processing job. The name must be unique within an Amazon Web Services
        /// Region in the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ProcessingJobName { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJobName property is set.
        /// </summary>
        internal bool IsSetProcessingJobName() => this.ProcessingJobName != null;

        /// <summary>
        /// Gets and sets the property ProcessingJobStatus. 
        /// <para>
        /// Provides the status of a processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessingJobStatus ProcessingJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJobStatus property is set.
        /// </summary>
        internal bool IsSetProcessingJobStatus() => this.ProcessingJobStatus != null;

        /// <summary>
        /// Gets and sets the property ProcessingOutputConfig. 
        /// <para>
        /// Output configuration for the processing job.
        /// </para>
        /// </summary>
        public ProcessingOutputConfig ProcessingOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingOutputConfig property is set.
        /// </summary>
        internal bool IsSetProcessingOutputConfig() => this.ProcessingOutputConfig != null;

        /// <summary>
        /// Gets and sets the property ProcessingResources. 
        /// <para>
        /// Identifies the resources, ML compute instances, and ML storage volumes to deploy for
        /// a processing job. In distributed training, you specify more than one instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessingResources ProcessingResources { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingResources property is set.
        /// </summary>
        internal bool IsSetProcessingResources() => this.ProcessingResources != null;

        /// <summary>
        /// Gets and sets the property ProcessingStartTime. 
        /// <para>
        /// The time at which the processing job started.
        /// </para>
        /// </summary>
        public DateTime? ProcessingStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingStartTime property is set.
        /// </summary>
        internal bool IsSetProcessingStartTime() => this.ProcessingStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to
        /// perform tasks on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// The time limit for how long the processing job is allowed to run.
        /// </para>
        /// </summary>
        public ProcessingStoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property TrainingJobArn. 
        /// <para>
        /// The ARN of a training job associated with this processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TrainingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobArn property is set.
        /// </summary>
        internal bool IsSetTrainingJobArn() => this.TrainingJobArn != null;
    }
}
