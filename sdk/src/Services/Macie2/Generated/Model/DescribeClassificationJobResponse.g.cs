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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the DescribeClassificationJob operation.
    /// </summary>
    public partial class DescribeClassificationJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowListIds. 
        /// <para>
        /// An array of unique identifiers, one for each allow list that the job is configured
        /// to use when it analyzes data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowListIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowListIds property is set.
        /// </summary>
        internal bool IsSetAllowListIds() => this.AllowListIds != null && (this.AllowListIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The token that was provided to ensure the idempotency of the request to create the
        /// job.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomDataIdentifierIds. 
        /// <para>
        /// An array of unique identifiers, one for each custom data identifier that the job is
        /// configured to use when it analyzes data. This value is null if the job is configured
        /// to use only managed data identifiers to analyze data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomDataIdentifierIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomDataIdentifierIds property is set.
        /// </summary>
        internal bool IsSetCustomDataIdentifierIds() => this.CustomDataIdentifierIds != null && (this.CustomDataIdentifierIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the job.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InitialRun. 
        /// <para>
        /// For a recurring job, specifies whether you configured the job to analyze all existing,
        /// eligible objects immediately after the job was created (true). If you configured the
        /// job to analyze only those objects that were created or changed after the job was created
        /// and before the job's first scheduled run, this value is false. This value is also
        /// false for a one-time job.
        /// </para>
        /// </summary>
        public bool? InitialRun { get; set; }

        /// <summary>
        /// Checks to see if the InitialRun property is set.
        /// </summary>
        internal bool IsSetInitialRun() => this.InitialRun.HasValue;

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
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier for the job.
        /// </para>
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the job. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// CANCELLED - You cancelled the job or, if it's a one-time job, you paused the job and
        /// didn't resume it within 30 days.
        /// </para>
        /// </li> <li>
        /// <para>
        /// COMPLETE - For a one-time job, Amazon Macie finished processing the data specified
        /// for the job. This value doesn't apply to recurring jobs.
        /// </para>
        /// </li> <li>
        /// <para>
        /// IDLE - For a recurring job, the previous scheduled run is complete and the next scheduled
        /// run is pending. This value doesn't apply to one-time jobs.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PAUSED - Macie started running the job but additional processing would exceed the
        /// monthly sensitive data discovery quota for your account or one or more member accounts
        /// that the job analyzes data for.
        /// </para>
        /// </li> <li>
        /// <para>
        /// RUNNING - For a one-time job, the job is in progress. For a recurring job, a scheduled
        /// run is in progress.
        /// </para>
        /// </li> <li>
        /// <para>
        /// USER_PAUSED - You paused the job. If you paused the job while it had a status of RUNNING
        /// and you don't resume it within 30 days of pausing it, the job or job run will expire
        /// and be cancelled, depending on the job's type. To check the expiration date, refer
        /// to the UserPausedDetails.jobExpiresAt property.
        /// </para>
        /// </li></ul>
        /// </summary>
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The schedule for running the job. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ONE_TIME - The job runs only once.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SCHEDULED - The job runs on a daily, weekly, or monthly basis. The scheduleFrequency
        /// property indicates the recurrence pattern for the job.
        /// </para>
        /// </li></ul>
        /// </summary>
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property LastRunErrorStatus. 
        /// <para>
        /// Specifies whether any account- or bucket-level access errors occurred when the job
        /// ran. For a recurring job, this value indicates the error status of the job's most
        /// recent run.
        /// </para>
        /// </summary>
        public LastRunErrorStatus LastRunErrorStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastRunErrorStatus property is set.
        /// </summary>
        internal bool IsSetLastRunErrorStatus() => this.LastRunErrorStatus != null;

        /// <summary>
        /// Gets and sets the property LastRunTime. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the job started. If the
        /// job is a recurring job, this value indicates when the most recent run started or,
        /// if the job hasn't run yet, when the job was created.
        /// </para>
        /// </summary>
        public DateTime? LastRunTime { get; set; }

        /// <summary>
        /// Checks to see if the LastRunTime property is set.
        /// </summary>
        internal bool IsSetLastRunTime() => this.LastRunTime.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedDataIdentifierIds. 
        /// <para>
        /// An array of unique identifiers, one for each managed data identifier that the job
        /// is explicitly configured to include (use) or exclude (not use) when it analyzes data.
        /// Inclusion or exclusion depends on the managed data identifier selection type specified
        /// for the job (managedDataIdentifierSelector).
        /// </para>
        /// 
        /// <para>
        /// This value is null if the job's managed data identifier selection type is ALL, NONE,
        /// or RECOMMENDED.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ManagedDataIdentifierIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ManagedDataIdentifierIds property is set.
        /// </summary>
        internal bool IsSetManagedDataIdentifierIds() => this.ManagedDataIdentifierIds != null && (this.ManagedDataIdentifierIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagedDataIdentifierSelector. 
        /// <para>
        /// The selection type that determines which managed data identifiers the job uses when
        /// it analyzes data. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ALL - Use all managed data identifiers.
        /// </para>
        /// </li> <li>
        /// <para>
        /// EXCLUDE - Use all managed data identifiers except the ones specified by the managedDataIdentifierIds
        /// property.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INCLUDE - Use only the managed data identifiers specified by the managedDataIdentifierIds
        /// property.
        /// </para>
        /// </li> <li>
        /// <para>
        /// NONE - Don't use any managed data identifiers. Use only custom data identifiers (customDataIdentifierIds).
        /// </para>
        /// </li> <li>
        /// <para>
        /// RECOMMENDED (default) - Use the recommended set of managed data identifiers.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// If this value is null, the job uses the recommended set of managed data identifiers.
        /// </para>
        ///  
        /// <para>
        /// If the job is a recurring job and this value is ALL or EXCLUDE, each job run automatically
        /// uses new managed data identifiers that are released. If this value is null or RECOMMENDED
        /// for a recurring job, each job run uses all the managed data identifiers that are in
        /// the recommended set when the run starts.
        /// </para>
        ///  
        /// <para>
        /// To learn about individual managed data identifiers or determine which ones are in
        /// the recommended set, see <a href="https://docs.aws.amazon.com/macie/latest/user/managed-data-identifiers.html">Using
        /// managed data identifiers</a> or <a href="https://docs.aws.amazon.com/macie/latest/user/discovery-jobs-mdis-recommended.html">Recommended
        /// managed data identifiers</a> in the <i>Amazon Macie User Guide</i>.
        /// </para>
        /// </summary>
        public ManagedDataIdentifierSelector ManagedDataIdentifierSelector { get; set; }

        /// <summary>
        /// Checks to see if the ManagedDataIdentifierSelector property is set.
        /// </summary>
        internal bool IsSetManagedDataIdentifierSelector() => this.ManagedDataIdentifierSelector != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom name of the job.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property S3JobDefinition. 
        /// <para>
        /// The S3 buckets that contain the objects to analyze, and the scope of that analysis.
        /// </para>
        /// </summary>
        public S3JobDefinition S3JobDefinition { get; set; }

        /// <summary>
        /// Checks to see if the S3JobDefinition property is set.
        /// </summary>
        internal bool IsSetS3JobDefinition() => this.S3JobDefinition != null;

        /// <summary>
        /// Gets and sets the property SamplingPercentage. 
        /// <para>
        /// The sampling depth, as a percentage, that determines the percentage of eligible objects
        /// that the job analyzes.
        /// </para>
        /// </summary>
        public int? SamplingPercentage { get; set; }

        /// <summary>
        /// Checks to see if the SamplingPercentage property is set.
        /// </summary>
        internal bool IsSetSamplingPercentage() => this.SamplingPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleFrequency. 
        /// <para>
        /// The recurrence pattern for running the job. This value is null if the job is configured
        /// to run only once.
        /// </para>
        /// </summary>
        public JobScheduleFrequency ScheduleFrequency { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleFrequency property is set.
        /// </summary>
        internal bool IsSetScheduleFrequency() => this.ScheduleFrequency != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The number of times that the job has run and processing statistics for the job's current
        /// run.
        /// </para>
        /// </summary>
        public Statistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that specifies which tags (keys and values) are associated
        /// with the job.
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

        /// <summary>
        /// Gets and sets the property UserPausedDetails. 
        /// <para>
        /// If the current status of the job is USER_PAUSED, specifies when the job was paused
        /// and when the job or job run will expire and be cancelled if it isn't resumed. This
        /// value is present only if the value for jobStatus is USER_PAUSED.
        /// </para>
        /// </summary>
        public UserPausedDetails UserPausedDetails { get; set; }

        /// <summary>
        /// Checks to see if the UserPausedDetails property is set.
        /// </summary>
        internal bool IsSetUserPausedDetails() => this.UserPausedDetails != null;
    }
}
