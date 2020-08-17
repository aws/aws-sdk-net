/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about a classification job, including the current status of the
    /// job.
    /// </summary>
    public partial class JobSummary
    {
        private List<S3BucketDefinitionForJob> _bucketDefinitions = new List<S3BucketDefinitionForJob>();
        private DateTime? _createdAt;
        private string _jobId;
        private JobStatus _jobStatus;
        private JobType _jobType;
        private string _name;

        /// <summary>
        /// Gets and sets the property BucketDefinitions. 
        /// <para>
        /// The S3 buckets that the job is configured to analyze.
        /// </para>
        /// </summary>
        public List<S3BucketDefinitionForJob> BucketDefinitions
        {
            get { return this._bucketDefinitions; }
            set { this._bucketDefinitions = value; }
        }

        // Check to see if BucketDefinitions property is set
        internal bool IsSetBucketDefinitions()
        {
            return this._bucketDefinitions != null && this._bucketDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the job was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// CANCELLED - The job was cancelled by you or a user of the master account for your
        /// organization. A job might also be cancelled if ownership of an S3 bucket changed while
        /// the job was running, and that change affected the job's access to the bucket.
        /// </para>
        /// </li> <li>
        /// <para>
        /// COMPLETE - Amazon Macie finished processing all the data specified for the job.
        /// </para>
        /// </li> <li>
        /// <para>
        /// IDLE - For a recurring job, the previous scheduled run is complete and the next scheduled
        /// run is pending. This value doesn't apply to jobs that occur only once.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PAUSED - Amazon Macie started the job, but completion of the job would exceed one
        /// or more quotas for your account.
        /// </para>
        /// </li> <li>
        /// <para>
        /// RUNNING - The job is in progress.
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
        /// ONE_TIME - The job ran or will run only once.
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

    }
}