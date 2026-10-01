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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Information about a job run. A job run is a unit of work, such as a Spark JAR, Hive
    /// query, or SparkSQL query, that you submit to an Amazon EMR Serverless application.
    /// </summary>
    public partial class JobRun
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application the job is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The execution role ARN of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The attempt of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Attempt { get; set; }

        /// <summary>
        /// Checks to see if the Attempt property is set.
        /// </summary>
        internal bool IsSetAttempt() => this.Attempt.HasValue;

        /// <summary>
        /// Gets and sets the property AttemptCreatedAt. 
        /// <para>
        /// The date and time of when the job run attempt was created.
        /// </para>
        /// </summary>
        public DateTime? AttemptCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the AttemptCreatedAt property is set.
        /// </summary>
        internal bool IsSetAttemptCreatedAt() => this.AttemptCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property AttemptUpdatedAt. 
        /// <para>
        /// The date and time of when the job run attempt was last updated.
        /// </para>
        /// </summary>
        public DateTime? AttemptUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the AttemptUpdatedAt property is set.
        /// </summary>
        internal bool IsSetAttemptUpdatedAt() => this.AttemptUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property BilledResourceUtilization. 
        /// <para>
        /// The aggregate vCPU, memory, and storage that Amazon Web Services has billed for the
        /// job run. The billed resources include a 1-minute minimum usage for workers, plus additional
        /// storage over 20 GB per worker. Note that billed resources do not include usage for
        /// idle pre-initialized workers.
        /// </para>
        /// </summary>
        public ResourceUtilization BilledResourceUtilization { get; set; }

        /// <summary>
        /// Checks to see if the BilledResourceUtilization property is set.
        /// </summary>
        internal bool IsSetBilledResourceUtilization() => this.BilledResourceUtilization != null;

        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        /// The configuration settings that are used to override default configuration.
        /// </para>
        /// </summary>
        public ConfigurationOverrides ConfigurationOverrides { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationOverrides property is set.
        /// </summary>
        internal bool IsSetConfigurationOverrides() => this.ConfigurationOverrides != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the job run was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user who created the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time when the job was terminated.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionIamPolicy.
        /// </summary>
        public JobRunExecutionIamPolicy ExecutionIamPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionIamPolicy property is set.
        /// </summary>
        internal bool IsSetExecutionIamPolicy() => this.ExecutionIamPolicy != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role ARN of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property ExecutionTimeoutMinutes. 
        /// <para>
        /// Returns the job run timeout value from the <c>StartJobRun</c> call. If no timeout
        /// was specified, then it returns the default timeout of 720 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public long? ExecutionTimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetExecutionTimeoutMinutes() => this.ExecutionTimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property ImageConfiguration.
        /// </summary>
        public ImageConfiguration ImageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageConfiguration property is set.
        /// </summary>
        internal bool IsSetImageConfiguration() => this.ImageConfiguration != null;

        /// <summary>
        /// Gets and sets the property JobDriver. 
        /// <para>
        /// The job driver for the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobDriver JobDriver { get; set; }

        /// <summary>
        /// Checks to see if the JobDriver property is set.
        /// </summary>
        internal bool IsSetJobDriver() => this.JobDriver != null;

        /// <summary>
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The ID of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobRunId { get; set; }

        /// <summary>
        /// Checks to see if the JobRunId property is set.
        /// </summary>
        internal bool IsSetJobRunId() => this.JobRunId != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the job run.
        /// </para>
        /// </summary>
        public JobRunMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional job run name. This doesn't have to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration.
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property QueuedDurationMilliseconds. 
        /// <para>
        /// The total time for a job in the QUEUED state in milliseconds.
        /// </para>
        /// </summary>
        public long? QueuedDurationMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the QueuedDurationMilliseconds property is set.
        /// </summary>
        internal bool IsSetQueuedDurationMilliseconds() => this.QueuedDurationMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release associated with the application your job is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ReleaseLabel { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLabel property is set.
        /// </summary>
        internal bool IsSetReleaseLabel() => this.ReleaseLabel != null;

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// The retry policy of the job run.
        /// </para>
        /// </summary>
        public RetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RetryPolicy property is set.
        /// </summary>
        internal bool IsSetRetryPolicy() => this.RetryPolicy != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time when the job moved to the RUNNING state.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobRunState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// The state details of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string StateDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateDetails property is set.
        /// </summary>
        internal bool IsSetStateDetails() => this.StateDetails != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalExecutionDurationSeconds. 
        /// <para>
        /// The job run total execution duration in seconds. This field is only available for
        /// job runs in a <c>COMPLETED</c>, <c>FAILED</c>, or <c>CANCELLED</c> state.
        /// </para>
        /// </summary>
        public int? TotalExecutionDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TotalExecutionDurationSeconds property is set.
        /// </summary>
        internal bool IsSetTotalExecutionDurationSeconds() => this.TotalExecutionDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResourceUtilization. 
        /// <para>
        /// The aggregate vCPU, memory, and storage resources used from the time the job starts
        /// to execute, until the time the job terminates, rounded up to the nearest second.
        /// </para>
        /// </summary>
        public TotalResourceUtilization TotalResourceUtilization { get; set; }

        /// <summary>
        /// Checks to see if the TotalResourceUtilization property is set.
        /// </summary>
        internal bool IsSetTotalResourceUtilization() => this.TotalResourceUtilization != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the job run was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WorkerTypeSpecifications. 
        /// <para>
        /// The specification applied to each worker type. Includes the JobRun-level ImageConfiguration
        /// when the applicationLevelDigestResolution is false for the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, WorkerTypeSpecification> WorkerTypeSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, WorkerTypeSpecification>() : null;

        /// <summary>
        /// Checks to see if the WorkerTypeSpecifications property is set.
        /// </summary>
        internal bool IsSetWorkerTypeSpecifications() => this.WorkerTypeSpecifications != null && (this.WorkerTypeSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
