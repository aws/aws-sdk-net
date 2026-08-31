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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is the response object from the DescribeServiceJob operation.
    /// </summary>
    public partial class DescribeServiceJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Attempts. 
        /// <para>
        /// A list of job attempts associated with the service job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceJobAttemptDetail> Attempts { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceJobAttemptDetail>() : null;

        /// <summary>
        /// Checks to see if the Attempts property is set.
        /// </summary>
        internal bool IsSetAttempts() => this.Attempts != null && (this.Attempts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityUsage. 
        /// <para>
        /// The configured capacity for the service job, such as the number of instances. The
        /// number of instances should be the same value as the <c>serviceRequestPayload.InstanceCount</c>
        /// field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceJobCapacityUsageDetail> CapacityUsage { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceJobCapacityUsageDetail>() : null;

        /// <summary>
        /// Checks to see if the CapacityUsage property is set.
        /// </summary>
        internal bool IsSetCapacityUsage() => this.CapacityUsage != null && (this.CapacityUsage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the service job was created.
        /// </para>
        /// </summary>
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property IsTerminated. 
        /// <para>
        /// Indicates whether the service job has been terminated.
        /// </para>
        /// </summary>
        public bool? IsTerminated { get; set; }

        /// <summary>
        /// Checks to see if the IsTerminated property is set.
        /// </summary>
        internal bool IsSetIsTerminated() => this.IsTerminated.HasValue;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service job.
        /// </para>
        /// </summary>
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID for the service job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the service job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The ARN of the job queue that the service job is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueue { get; set; }

        /// <summary>
        /// Checks to see if the JobQueue property is set.
        /// </summary>
        internal bool IsSetJobQueue() => this.JobQueue != null;

        /// <summary>
        /// Gets and sets the property LatestAttempt. 
        /// <para>
        /// The latest attempt associated with the service job.
        /// </para>
        /// </summary>
        public LatestServiceJobAttempt LatestAttempt { get; set; }

        /// <summary>
        /// Checks to see if the LatestAttempt property is set.
        /// </summary>
        internal bool IsSetLatestAttempt() => this.LatestAttempt != null;

        /// <summary>
        /// Gets and sets the property PreemptionConfiguration. 
        /// <para>
        /// Specifies the service job behavior when preempted.
        /// </para>
        /// </summary>
        public ServiceJobPreemptionConfiguration PreemptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PreemptionConfiguration property is set.
        /// </summary>
        internal bool IsSetPreemptionConfiguration() => this.PreemptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property PreemptionSummary. 
        /// <para>
        /// Summarizes the preemptions of the service job. This field appears on a service job
        /// when it has been preempted.
        /// </para>
        /// </summary>
        public ServiceJobPreemptionSummary PreemptionSummary { get; set; }

        /// <summary>
        /// Checks to see if the PreemptionSummary property is set.
        /// </summary>
        internal bool IsSetPreemptionSummary() => this.PreemptionSummary != null;

        /// <summary>
        /// Gets and sets the property QuotaShareName. 
        /// <para>
        /// The name of the quota share that the service job is associated with.
        /// </para>
        /// </summary>
        public string QuotaShareName { get; set; }

        /// <summary>
        /// Checks to see if the QuotaShareName property is set.
        /// </summary>
        internal bool IsSetQuotaShareName() => this.QuotaShareName != null;

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed service jobs that are submitted with this service
        /// job.
        /// </para>
        /// </summary>
        public ServiceJobRetryStrategy RetryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RetryStrategy property is set.
        /// </summary>
        internal bool IsSetRetryStrategy() => this.RetryStrategy != null;

        /// <summary>
        /// Gets and sets the property ScheduledAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the service job was scheduled. This
        /// represents when the service job was dispatched to SageMaker and the service job transitioned
        /// to the <c>SCHEDULED</c> state.
        /// </para>
        /// </summary>
        public long? ScheduledAt { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledAt property is set.
        /// </summary>
        internal bool IsSetScheduledAt() => this.ScheduledAt.HasValue;

        /// <summary>
        /// Gets and sets the property SchedulingPriority. 
        /// <para>
        /// The scheduling priority of the service job. 
        /// </para>
        /// </summary>
        public int? SchedulingPriority { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingPriority property is set.
        /// </summary>
        internal bool IsSetSchedulingPriority() => this.SchedulingPriority.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceJobType. 
        /// <para>
        /// The type of service job. For SageMaker Training jobs, this value is <c>SAGEMAKER_TRAINING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceJobType ServiceJobType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceJobType property is set.
        /// </summary>
        internal bool IsSetServiceJobType() => this.ServiceJobType != null;

        /// <summary>
        /// Gets and sets the property ServiceRequestPayload. 
        /// <para>
        /// The request, in JSON, for the service that the <c>SubmitServiceJob</c> operation is
        /// queueing. 
        /// </para>
        /// </summary>
        public string ServiceRequestPayload { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRequestPayload property is set.
        /// </summary>
        internal bool IsSetServiceRequestPayload() => this.ServiceRequestPayload != null;

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the service job. This is used for fair-share scheduling.
        /// </para>
        /// </summary>
        public string ShareIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ShareIdentifier property is set.
        /// </summary>
        internal bool IsSetShareIdentifier() => this.ShareIdentifier != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the service job was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the service job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide more details for the current status of the
        /// service job.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the service job stopped running.
        /// </para>
        /// </summary>
        public long? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are associated with the service job. Each tag consists of a key and
        /// an optional value. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// The timeout configuration for the service job.
        /// </para>
        /// </summary>
        public ServiceJobTimeout TimeoutConfig { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConfig property is set.
        /// </summary>
        internal bool IsSetTimeoutConfig() => this.TimeoutConfig != null;
    }
}
