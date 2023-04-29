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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The <code>Job</code> object contains details about a job.
    /// </summary>
    public partial class Job
    {
        private AbortConfig _abortConfig;
        private string _comment;
        private DateTime? _completedAt;
        private DateTime? _createdAt;
        private string _description;
        private Dictionary<string, string> _documentParameters = new Dictionary<string, string>();
        private bool? _forceCanceled;
        private bool? _isConcurrent;
        private string _jobArn;
        private JobExecutionsRetryConfig _jobExecutionsRetryConfig;
        private JobExecutionsRolloutConfig _jobExecutionsRolloutConfig;
        private string _jobId;
        private JobProcessDetails _jobProcessDetails;
        private string _jobTemplateArn;
        private DateTime? _lastUpdatedAt;
        private string _namespaceId;
        private PresignedUrlConfig _presignedUrlConfig;
        private string _reasonCode;
        private List<ScheduledJobRollout> _scheduledJobRollouts = new List<ScheduledJobRollout>();
        private SchedulingConfig _schedulingConfig;
        private JobStatus _status;
        private List<string> _targets = new List<string>();
        private TargetSelection _targetSelection;
        private TimeoutConfig _timeoutConfig;

        /// <summary>
        /// Gets and sets the property AbortConfig. 
        /// <para>
        /// Configuration for criteria to abort the job.
        /// </para>
        /// </summary>
        public AbortConfig AbortConfig
        {
            get { return this._abortConfig; }
            set { this._abortConfig = value; }
        }

        // Check to see if AbortConfig property is set
        internal bool IsSetAbortConfig()
        {
            return this._abortConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// If the job was updated, describes the reason for the update.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job was completed.
        /// </para>
        /// </summary>
        public DateTime CompletedAt
        {
            get { return this._completedAt.GetValueOrDefault(); }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text description of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
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
        /// Gets and sets the property DocumentParameters. 
        /// <para>
        /// A key-value map that pairs the patterns that need to be replaced in a managed template
        /// job document schema. You can use the description of each key as a guidance to specify
        /// the inputs during runtime when creating a job.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>documentParameters</code> can only be used when creating jobs from Amazon Web
        /// Services managed templates. This parameter can't be used with custom job templates
        /// or to create jobs from them.
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, string> DocumentParameters
        {
            get { return this._documentParameters; }
            set { this._documentParameters = value; }
        }

        // Check to see if DocumentParameters property is set
        internal bool IsSetDocumentParameters()
        {
            return this._documentParameters != null && this._documentParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ForceCanceled. 
        /// <para>
        /// Will be <code>true</code> if the job was canceled with the optional <code>force</code>
        /// parameter set to <code>true</code>.
        /// </para>
        /// </summary>
        public bool ForceCanceled
        {
            get { return this._forceCanceled.GetValueOrDefault(); }
            set { this._forceCanceled = value; }
        }

        // Check to see if ForceCanceled property is set
        internal bool IsSetForceCanceled()
        {
            return this._forceCanceled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsConcurrent. 
        /// <para>
        /// Indicates whether a job is concurrent. Will be true when a job is rolling out new
        /// job executions or canceling previously created executions, otherwise false.
        /// </para>
        /// </summary>
        public bool IsConcurrent
        {
            get { return this._isConcurrent.GetValueOrDefault(); }
            set { this._isConcurrent = value; }
        }

        // Check to see if IsConcurrent property is set
        internal bool IsSetIsConcurrent()
        {
            return this._isConcurrent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// An ARN identifying the job with format "arn:aws:iot:region:account:job/jobId".
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
        /// Gets and sets the property JobExecutionsRetryConfig. 
        /// <para>
        /// The configuration for the criteria to retry the job.
        /// </para>
        /// </summary>
        public JobExecutionsRetryConfig JobExecutionsRetryConfig
        {
            get { return this._jobExecutionsRetryConfig; }
            set { this._jobExecutionsRetryConfig = value; }
        }

        // Check to see if JobExecutionsRetryConfig property is set
        internal bool IsSetJobExecutionsRetryConfig()
        {
            return this._jobExecutionsRetryConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobExecutionsRolloutConfig. 
        /// <para>
        /// Allows you to create a staged rollout of a job.
        /// </para>
        /// </summary>
        public JobExecutionsRolloutConfig JobExecutionsRolloutConfig
        {
            get { return this._jobExecutionsRolloutConfig; }
            set { this._jobExecutionsRolloutConfig = value; }
        }

        // Check to see if JobExecutionsRolloutConfig property is set
        internal bool IsSetJobExecutionsRolloutConfig()
        {
            return this._jobExecutionsRolloutConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier you assigned to this job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property JobProcessDetails. 
        /// <para>
        /// Details about the job process.
        /// </para>
        /// </summary>
        public JobProcessDetails JobProcessDetails
        {
            get { return this._jobProcessDetails; }
            set { this._jobProcessDetails = value; }
        }

        // Check to see if JobProcessDetails property is set
        internal bool IsSetJobProcessDetails()
        {
            return this._jobProcessDetails != null;
        }

        /// <summary>
        /// Gets and sets the property JobTemplateArn. 
        /// <para>
        /// The ARN of the job template used to create the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string JobTemplateArn
        {
            get { return this._jobTemplateArn; }
            set { this._jobTemplateArn = value; }
        }

        // Check to see if JobTemplateArn property is set
        internal bool IsSetJobTemplateArn()
        {
            return this._jobTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The namespace used to indicate that a job is a customer-managed job.
        /// </para>
        ///  
        /// <para>
        /// When you specify a value for this parameter, Amazon Web Services IoT Core sends jobs
        /// notifications to MQTT topics that contain the value in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>$aws/things/<i>THING_NAME</i>/jobs/<i>JOB_ID</i>/notify-namespace-<i>NAMESPACE_ID</i>/</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>namespaceId</code> feature is in public preview.
        /// </para>
        ///  </note>
        /// </summary>
        public string NamespaceId
        {
            get { return this._namespaceId; }
            set { this._namespaceId = value; }
        }

        // Check to see if NamespaceId property is set
        internal bool IsSetNamespaceId()
        {
            return this._namespaceId != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedUrlConfig. 
        /// <para>
        /// Configuration for pre-signed S3 URLs.
        /// </para>
        /// </summary>
        public PresignedUrlConfig PresignedUrlConfig
        {
            get { return this._presignedUrlConfig; }
            set { this._presignedUrlConfig = value; }
        }

        // Check to see if PresignedUrlConfig property is set
        internal bool IsSetPresignedUrlConfig()
        {
            return this._presignedUrlConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// If the job was updated, provides the reason code for the update.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledJobRollouts. 
        /// <para>
        /// Displays the next seven maintenance window occurrences and their start times.
        /// </para>
        /// </summary>
        public List<ScheduledJobRollout> ScheduledJobRollouts
        {
            get { return this._scheduledJobRollouts; }
            set { this._scheduledJobRollouts = value; }
        }

        // Check to see if ScheduledJobRollouts property is set
        internal bool IsSetScheduledJobRollouts()
        {
            return this._scheduledJobRollouts != null && this._scheduledJobRollouts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SchedulingConfig. 
        /// <para>
        /// The configuration that allows you to schedule a job for a future date and time in
        /// addition to specifying the end behavior for each job execution.
        /// </para>
        /// </summary>
        public SchedulingConfig SchedulingConfig
        {
            get { return this._schedulingConfig; }
            set { this._schedulingConfig = value; }
        }

        // Check to see if SchedulingConfig property is set
        internal bool IsSetSchedulingConfig()
        {
            return this._schedulingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job, one of <code>IN_PROGRESS</code>, <code>CANCELED</code>, <code>DELETION_IN_PROGRESS</code>
        /// or <code>COMPLETED</code>. 
        /// </para>
        /// </summary>
        public JobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A list of IoT things and thing groups to which the job should be sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetSelection. 
        /// <para>
        /// Specifies whether the job will continue to run (CONTINUOUS), or will be complete after
        /// all those things specified as targets have completed the job (SNAPSHOT). If continuous,
        /// the job may also be run on a thing when a change is detected in a target. For example,
        /// a job will run on a device when the thing representing the device is added to a target
        /// group, even after the job was completed by all things originally in the group. 
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend that you use continuous jobs instead of snapshot jobs for dynamic thing
        /// group targets. By using continuous jobs, devices that join the group receive the job
        /// execution even after the job has been created.
        /// </para>
        ///  </note>
        /// </summary>
        public TargetSelection TargetSelection
        {
            get { return this._targetSelection; }
            set { this._targetSelection = value; }
        }

        // Check to see if TargetSelection property is set
        internal bool IsSetTargetSelection()
        {
            return this._targetSelection != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Specifies the amount of time each device has to finish its execution of the job. A
        /// timer is started when the job execution status is set to <code>IN_PROGRESS</code>.
        /// If the job execution status is not set to another terminal state before the timer
        /// expires, it will be automatically set to <code>TIMED_OUT</code>.
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfig
        {
            get { return this._timeoutConfig; }
            set { this._timeoutConfig = value; }
        }

        // Check to see if TimeoutConfig property is set
        internal bool IsSetTimeoutConfig()
        {
            return this._timeoutConfig != null;
        }

    }
}