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
    /// An object that represents summary details of a job.
    /// </summary>
    public partial class JobSummary
    {
        /// <summary>
        /// Gets and sets the property ArrayProperties. 
        /// <para>
        /// The array properties of the job, if it's an array job.
        /// </para>
        /// </summary>
        public ArrayPropertiesSummary ArrayProperties { get; set; }

        /// <summary>
        /// Checks to see if the ArrayProperties property is set.
        /// </summary>
        internal bool IsSetArrayProperties() => this.ArrayProperties != null;

        /// <summary>
        /// Gets and sets the property CapacityUsage. 
        /// <para>
        /// The configured capacity usage information for this job, including the unit of measure
        /// and quantity of resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JobCapacityUsageSummary> CapacityUsage { get; set; } = AWSConfigs.InitializeCollections ? new List<JobCapacityUsageSummary>() : null;

        /// <summary>
        /// Checks to see if the CapacityUsage property is set.
        /// </summary>
        internal bool IsSetCapacityUsage() => this.CapacityUsage != null && (this.CapacityUsage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// An object that represents the details of the container that's associated with the
        /// job.
        /// </para>
        /// </summary>
        public ContainerSummary Container { get; set; }

        /// <summary>
        /// Checks to see if the Container property is set.
        /// </summary>
        internal bool IsSetContainer() => this.Container != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the job was created. For non-array jobs
        /// and parent array jobs, this is when the job entered the <c>SUBMITTED</c> state (at
        /// the time <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_SubmitJob.html">SubmitJob</a>
        /// was called). For array child jobs, this is when the child job was spawned by its parent
        /// and entered the <c>PENDING</c> state.
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
        /// The Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job definition.
        /// </para>
        /// </summary>
        public string JobDefinition { get; set; }

        /// <summary>
        /// Checks to see if the JobDefinition property is set.
        /// </summary>
        internal bool IsSetJobDefinition() => this.JobDefinition != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID.
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
        /// The job name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property NodeProperties. 
        /// <para>
        /// The node properties for a single node in a job summary list.
        /// </para>
        ///  <note> 
        /// <para>
        /// This isn't applicable to jobs that are running on Fargate resources.
        /// </para>
        ///  </note>
        /// </summary>
        public NodePropertiesSummary NodeProperties { get; set; }

        /// <summary>
        /// Checks to see if the NodeProperties property is set.
        /// </summary>
        internal bool IsSetNodeProperties() => this.NodeProperties != null;

        /// <summary>
        /// Gets and sets the property ScheduledAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the job was scheduled for execution.
        /// For more information on job statues, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/service-job-status.html">Service
        /// job status</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public long? ScheduledAt { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledAt property is set.
        /// </summary>
        internal bool IsSetScheduledAt() => this.ScheduledAt.HasValue;

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the fairshare scheduling queue that this job is associated
        /// with.
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
        /// The Unix timestamp for when the job was started. More specifically, it's when the
        /// job transitioned from the <c>STARTING</c> state to the <c>RUNNING</c> state.
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
        /// The current status for the job.
        /// </para>
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide more details for the current status of the
        /// job.
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
        /// The Unix timestamp for when the job was stopped. More specifically, it's when the
        /// job transitioned from the <c>RUNNING</c> state to a terminal state, such as <c>SUCCEEDED</c>
        /// or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public long? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;
    }
}
