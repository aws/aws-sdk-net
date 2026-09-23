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
    /// Provides information about a classification job, including the current status of the
    /// job.
    /// </summary>
    public partial class JobSummary
    {
        /// <summary>
        /// Gets and sets the property BucketCriteria. 
        /// <para>
        /// The property- and tag-based conditions that determine which S3 buckets are included
        /// or excluded from the job's analysis. Each time the job runs, the job uses these criteria
        /// to determine which buckets to analyze. A job's definition can contain a bucketCriteria
        /// object or a bucketDefinitions array, not both.
        /// </para>
        /// </summary>
        public S3BucketCriteriaForJob BucketCriteria { get; set; }

        /// <summary>
        /// Checks to see if the BucketCriteria property is set.
        /// </summary>
        internal bool IsSetBucketCriteria() => this.BucketCriteria != null;

        /// <summary>
        /// Gets and sets the property BucketDefinitions. 
        /// <para>
        /// An array of objects, one for each Amazon Web Services account that owns specific S3
        /// buckets for the job to analyze. Each object specifies the account ID for an account
        /// and one or more buckets to analyze for that account. A job's definition can contain
        /// a bucketDefinitions array or a bucketCriteria object, not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3BucketDefinitionForJob> BucketDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<S3BucketDefinitionForJob>() : null;

        /// <summary>
        /// Checks to see if the BucketDefinitions property is set.
        /// </summary>
        internal bool IsSetBucketDefinitions() => this.BucketDefinitions != null && (this.BucketDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// SCHEDULED - The job runs on a daily, weekly, or monthly basis.
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
