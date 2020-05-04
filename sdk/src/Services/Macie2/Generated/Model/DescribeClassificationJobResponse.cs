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
    /// This is the response object from the DescribeClassificationJob operation.
    /// </summary>
    public partial class DescribeClassificationJobResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private DateTime? _createdAt;
        private List<string> _customDataIdentifierIds = new List<string>();
        private string _description;
        private bool? _initialRun;
        private string _jobArn;
        private string _jobId;
        private JobStatus _jobStatus;
        private JobType _jobType;
        private DateTime? _lastRunTime;
        private string _name;
        private S3JobDefinition _s3JobDefinition;
        private int? _samplingPercentage;
        private JobScheduleFrequency _scheduleFrequency;
        private Statistics _statistics;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The token that was provided to ensure the idempotency of the request to create the
        /// job.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        /// Gets and sets the property CustomDataIdentifierIds. 
        /// <para>
        /// The custom data identifiers that the job uses to analyze data.
        /// </para>
        /// </summary>
        public List<string> CustomDataIdentifierIds
        {
            get { return this._customDataIdentifierIds; }
            set { this._customDataIdentifierIds = value; }
        }

        // Check to see if CustomDataIdentifierIds property is set
        internal bool IsSetCustomDataIdentifierIds()
        {
            return this._customDataIdentifierIds != null && this._customDataIdentifierIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the job.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InitialRun. 
        /// <para>
        /// Specifies whether the job has run for the first time.
        /// </para>
        /// </summary>
        public bool InitialRun
        {
            get { return this._initialRun.GetValueOrDefault(); }
            set { this._initialRun = value; }
        }

        // Check to see if InitialRun property is set
        internal bool IsSetInitialRun()
        {
            return this._initialRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
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
        /// The current status of the job. Possible value are:
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
        /// The schedule for running the job. Possible value are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ONE_TIME - The job ran or will run only once.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SCHEDULED - The job runs on a daily, weekly, or monthly basis. The scheduleFrequency
        /// property indicates the recurrence pattern for the job.
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
        /// Gets and sets the property LastRunTime. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the job last ran.
        /// </para>
        /// </summary>
        public DateTime LastRunTime
        {
            get { return this._lastRunTime.GetValueOrDefault(); }
            set { this._lastRunTime = value; }
        }

        // Check to see if LastRunTime property is set
        internal bool IsSetLastRunTime()
        {
            return this._lastRunTime.HasValue; 
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
        /// Gets and sets the property S3JobDefinition. 
        /// <para>
        /// The S3 buckets that the job is configured to analyze, and the scope of that analysis.
        /// </para>
        /// </summary>
        public S3JobDefinition S3JobDefinition
        {
            get { return this._s3JobDefinition; }
            set { this._s3JobDefinition = value; }
        }

        // Check to see if S3JobDefinition property is set
        internal bool IsSetS3JobDefinition()
        {
            return this._s3JobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property SamplingPercentage. 
        /// <para>
        /// The sampling depth, as a percentage, that the job applies when it processes objects.
        /// </para>
        /// </summary>
        public int SamplingPercentage
        {
            get { return this._samplingPercentage.GetValueOrDefault(); }
            set { this._samplingPercentage = value; }
        }

        // Check to see if SamplingPercentage property is set
        internal bool IsSetSamplingPercentage()
        {
            return this._samplingPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleFrequency. 
        /// <para>
        /// The recurrence pattern for running the job. If the job is configured to run every
        /// day, this value is an empty dailySchedule object. If the job is configured to run
        /// only once, this value is null.
        /// </para>
        /// </summary>
        public JobScheduleFrequency ScheduleFrequency
        {
            get { return this._scheduleFrequency; }
            set { this._scheduleFrequency = value; }
        }

        // Check to see if ScheduleFrequency property is set
        internal bool IsSetScheduleFrequency()
        {
            return this._scheduleFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The number of times that the job has run and processing statistics for the job's most
        /// recent run.
        /// </para>
        /// </summary>
        public Statistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that identifies the tags (keys and values) that are associated
        /// with the classification job.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}