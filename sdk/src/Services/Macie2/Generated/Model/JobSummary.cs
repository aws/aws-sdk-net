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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
        private S3BucketCriteriaForJob _bucketCriteria;
        private List<S3BucketDefinitionForJob> _bucketDefinitions = AWSConfigs.InitializeCollections ? new List<S3BucketDefinitionForJob>() : null;
        private DateTime? _createdAt;
        private string _jobId;
        private JobStatus _jobStatus;
        private JobType _jobType;
        private LastRunErrorStatus _lastRunErrorStatus;
        private string _name;
        private UserPausedDetails _userPausedDetails;

        /// <summary>
        /// Gets and sets the property BucketCriteria. 
        /// <para>
        /// The property- and tag-based conditions that determine which S3 buckets are included
        /// or excluded from the job's analysis. Each time the job runs, the job uses these criteria
        /// to determine which buckets to analyze. A job's definition can contain a bucketCriteria
        /// object or a bucketDefinitions array, not both.
        /// </para>
        /// </summary>
        public S3BucketCriteriaForJob BucketCriteria
        {
            get { return this._bucketCriteria; }
            set { this._bucketCriteria = value; }
        }

        // Check to see if BucketCriteria property is set
        internal bool IsSetBucketCriteria()
        {
            return this._bucketCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property BucketDefinitions. 
        /// <para>
        /// An array of objects, one for each Amazon Web Services account that owns specific S3
        /// buckets for the job to analyze. Each object specifies the account ID for an account
        /// and one or more buckets to analyze for that account. A job's definition can contain
        /// a bucketDefinitions array or a bucketCriteria object, not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3BucketDefinitionForJob> BucketDefinitions
        {
            get { return this._bucketDefinitions; }
            set { this._bucketDefinitions = value; }
        }

        // Check to see if BucketDefinitions property is set
        internal bool IsSetBucketDefinitions()
        {
            return this._bucketDefinitions != null && (this._bucketDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier for the job.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

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
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

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
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunErrorStatus. 
        /// <para>
        /// Specifies whether any account- or bucket-level access errors occurred when the job
        /// ran. For a recurring job, this value indicates the error status of the job's most
        /// recent run.
        /// </para>
        /// </summary>
        public LastRunErrorStatus LastRunErrorStatus
        {
            get { return this._lastRunErrorStatus; }
            set { this._lastRunErrorStatus = value; }
        }

        // Check to see if LastRunErrorStatus property is set
        internal bool IsSetLastRunErrorStatus()
        {
            return this._lastRunErrorStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom name of the job.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property UserPausedDetails. 
        /// <para>
        /// If the current status of the job is USER_PAUSED, specifies when the job was paused
        /// and when the job or job run will expire and be cancelled if it isn't resumed. This
        /// value is present only if the value for jobStatus is USER_PAUSED.
        /// </para>
        /// </summary>
        public UserPausedDetails UserPausedDetails
        {
            get { return this._userPausedDetails; }
            set { this._userPausedDetails = value; }
        }

        // Check to see if UserPausedDetails property is set
        internal bool IsSetUserPausedDetails()
        {
            return this._userPausedDetails != null;
        }

    }
}