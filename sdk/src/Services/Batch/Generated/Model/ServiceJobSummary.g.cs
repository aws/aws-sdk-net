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
    /// Summary information about a service job.
    /// </summary>
    public partial class ServiceJobSummary
    {
        /// <summary>
        /// Gets and sets the property CapacityUsage. 
        /// <para>
        /// The capacity usage information for this service job, including the unit of measure
        /// and quantity of resources being used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceJobCapacityUsageSummary> CapacityUsage { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceJobCapacityUsageSummary>() : null;

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
        /// Gets and sets the property LatestAttempt. 
        /// <para>
        /// Information about the latest attempt for the service job.
        /// </para>
        /// </summary>
        public LatestServiceJobAttempt LatestAttempt { get; set; }

        /// <summary>
        /// Checks to see if the LatestAttempt property is set.
        /// </summary>
        internal bool IsSetLatestAttempt() => this.LatestAttempt != null;

        /// <summary>
        /// Gets and sets the property QuotaShareName. 
        /// <para>
        /// The quota share for the service job.
        /// </para>
        /// </summary>
        public string QuotaShareName { get; set; }

        /// <summary>
        /// Checks to see if the QuotaShareName property is set.
        /// </summary>
        internal bool IsSetQuotaShareName() => this.QuotaShareName != null;

        /// <summary>
        /// Gets and sets the property ScheduledAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the service job was scheduled for execution.
        /// </para>
        /// </summary>
        public long? ScheduledAt { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledAt property is set.
        /// </summary>
        internal bool IsSetScheduledAt() => this.ScheduledAt.HasValue;

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
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the job.
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
        public ServiceJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short string to provide more details on the current status of the service job.
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
    }
}
