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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// This is the response object from the GetJob operation.
    /// </summary>
    public partial class GetJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// Definition of the Amazon Braket hybrid job created. Provides information about the
        /// container image used, and the Python scripts used for training.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AlgorithmSpecification AlgorithmSpecification { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmSpecification property is set.
        /// </summary>
        internal bool IsSetAlgorithmSpecification() => this.AlgorithmSpecification != null;

        /// <summary>
        /// Gets and sets the property Associations. 
        /// <para>
        /// The list of Amazon Braket resources associated with the hybrid job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Association> Associations { get; set; } = AWSConfigs.InitializeCollections ? new List<Association>() : null;

        /// <summary>
        /// Checks to see if the Associations property is set.
        /// </summary>
        internal bool IsSetAssociations() => this.Associations != null && (this.Associations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillableDuration. 
        /// <para>
        /// The billable time for which the Amazon Braket hybrid job used to complete.
        /// </para>
        /// </summary>
        public int? BillableDuration { get; set; }

        /// <summary>
        /// Checks to see if the BillableDuration property is set.
        /// </summary>
        internal bool IsSetBillableDuration() => this.BillableDuration.HasValue;

        /// <summary>
        /// Gets and sets the property CheckpointConfig. 
        /// <para>
        /// Information about the output locations for hybrid job checkpoint data.
        /// </para>
        /// </summary>
        public JobCheckpointConfig CheckpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointConfig property is set.
        /// </summary>
        internal bool IsSetCheckpointConfig() => this.CheckpointConfig != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the Amazon Braket hybrid job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceConfig. 
        /// <para>
        /// The primary device used by the Amazon Braket hybrid job.
        /// </para>
        /// </summary>
        public DeviceConfig DeviceConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeviceConfig property is set.
        /// </summary>
        internal bool IsSetDeviceConfig() => this.DeviceConfig != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time at which the Amazon Braket hybrid job ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// Details about the time and type of events occurred related to the Amazon Braket hybrid
        /// job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<JobEventDetails> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<JobEventDetails>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A description of the reason why an Amazon Braket hybrid job failed, if it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Algorithm-specific parameters used by an Amazon Braket hybrid job that influence the
        /// quality of the traiing job. The values are set with a map of JSON key:value pairs,
        /// where the key is the name of the hyperparameter and the value is the value of th hyperparameter.
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
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// A list of parameters that specify the name and type of input data and where it is
        /// located.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputFileConfig> InputDataConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<InputFileConfig>() : null;

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null && (this.InputDataConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceConfig. 
        /// <para>
        /// The resource instances to use while running the hybrid job on Amazon Braket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceConfig InstanceConfig { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConfig property is set.
        /// </summary>
        internal bool IsSetInstanceConfig() => this.InstanceConfig != null;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN of the Amazon Braket hybrid job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the Amazon Braket hybrid job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The path to the S3 location where hybrid job artifacts are stored and the encryption
        /// key used to store them there.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobOutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property QueueInfo. 
        /// <para>
        /// Queue information for the requested hybrid job. Only returned if <c>QueueInfo</c>
        /// is specified in the <c>additionalAttributeNames"</c> field in the <c>GetJob</c> API
        /// request.
        /// </para>
        /// </summary>
        public HybridJobQueueInfo QueueInfo { get; set; }

        /// <summary>
        /// Checks to see if the QueueInfo property is set.
        /// </summary>
        internal bool IsSetQueueInfo() => this.QueueInfo != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon Braket can assume to perform
        /// tasks on behalf of a user. It can access user resources, run an Amazon Braket job
        /// container on behalf of user, and output results and other hybrid job details to the
        /// s3 buckets of a user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time at which the Amazon Braket hybrid job was started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon Braket hybrid job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobPrimaryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// The user-defined criteria that specifies when to stop a running hybrid job.
        /// </para>
        /// </summary>
        public JobStoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with this hybrid job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
