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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Each job converts an input file into an output file or files. For more information,
    /// see the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
    /// </summary>
    public partial class Job
    {
        private AccelerationSettings _accelerationSettings;
        private AccelerationStatus _accelerationStatus;
        private string _arn;
        private BillingTagsSource _billingTagsSource;
        private string _clientRequestToken;
        private DateTime? _createdAt;
        private JobPhase _currentPhase;
        private int? _errorCode;
        private string _errorMessage;
        private List<HopDestination> _hopDestinations = new List<HopDestination>();
        private string _id;
        private int? _jobPercentComplete;
        private string _jobTemplate;
        private JobMessages _messages;
        private List<OutputGroupDetail> _outputGroupDetails = new List<OutputGroupDetail>();
        private int? _priority;
        private string _queue;
        private List<QueueTransition> _queueTransitions = new List<QueueTransition>();
        private int? _retryCount;
        private string _role;
        private JobSettings _settings;
        private SimulateReservedQueue _simulateReservedQueue;
        private JobStatus _status;
        private StatusUpdateInterval _statusUpdateInterval;
        private Timing _timing;
        private Dictionary<string, string> _userMetadata = new Dictionary<string, string>();
        private List<WarningGroup> _warnings = new List<WarningGroup>();

        /// <summary>
        /// Gets and sets the property AccelerationSettings. Accelerated transcoding can significantly
        /// speed up jobs with long, visually complex content.
        /// </summary>
        public AccelerationSettings AccelerationSettings
        {
            get { return this._accelerationSettings; }
            set { this._accelerationSettings = value; }
        }

        // Check to see if AccelerationSettings property is set
        internal bool IsSetAccelerationSettings()
        {
            return this._accelerationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property AccelerationStatus. Describes whether the current job is
        /// running with accelerated transcoding. For jobs that have Acceleration (AccelerationMode)
        /// set to DISABLED, AccelerationStatus is always NOT_APPLICABLE. For jobs that have Acceleration
        /// (AccelerationMode) set to ENABLED or PREFERRED, AccelerationStatus is one of the other
        /// states. AccelerationStatus is IN_PROGRESS initially, while the service determines
        /// whether the input files and job settings are compatible with accelerated transcoding.
        /// If they are, AcclerationStatus is ACCELERATED. If your input files and job settings
        /// aren't compatible with accelerated transcoding, the service either fails your job
        /// or runs it without accelerated transcoding, depending on how you set Acceleration
        /// (AccelerationMode). When the service runs your job without accelerated transcoding,
        /// AccelerationStatus is NOT_ACCELERATED.
        /// </summary>
        public AccelerationStatus AccelerationStatus
        {
            get { return this._accelerationStatus; }
            set { this._accelerationStatus = value; }
        }

        // Check to see if AccelerationStatus property is set
        internal bool IsSetAccelerationStatus()
        {
            return this._accelerationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. An identifier for this resource that is unique within
        /// all of AWS.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingTagsSource. The tag type that AWS Billing and Cost
        /// Management will use to sort your AWS Elemental MediaConvert costs on any billing report
        /// that you set up.
        /// </summary>
        public BillingTagsSource BillingTagsSource
        {
            get { return this._billingTagsSource; }
            set { this._billingTagsSource = value; }
        }

        // Check to see if BillingTagsSource property is set
        internal bool IsSetBillingTagsSource()
        {
            return this._billingTagsSource != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. Prevent duplicate jobs from being created
        /// and ensure idempotency for your requests. A client request token can be any string
        /// that includes up to 64 ASCII characters. If you reuse a client request token within
        /// one minute of a successful request, the API returns the job details of the original
        /// request instead. For more information see https://docs.aws.amazon.com/mediaconvert/latest/apireference/idempotency.html.
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. The time, in Unix epoch format in seconds, when
        /// the job got created.
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
        /// Gets and sets the property CurrentPhase. A job's phase can be PROBING, TRANSCODING
        /// OR UPLOADING
        /// </summary>
        public JobPhase CurrentPhase
        {
            get { return this._currentPhase; }
            set { this._currentPhase = value; }
        }

        // Check to see if CurrentPhase property is set
        internal bool IsSetCurrentPhase()
        {
            return this._currentPhase != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. Error code for the job
        /// </summary>
        public int ErrorCode
        {
            get { return this._errorCode.GetValueOrDefault(); }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. Error message of Job
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property HopDestinations. Optional list of hop destinations.
        /// </summary>
        public List<HopDestination> HopDestinations
        {
            get { return this._hopDestinations; }
            set { this._hopDestinations = value; }
        }

        // Check to see if HopDestinations property is set
        internal bool IsSetHopDestinations()
        {
            return this._hopDestinations != null && this._hopDestinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. A portion of the job's ARN, unique within your AWS
        /// Elemental MediaConvert resources
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property JobPercentComplete. An estimate of how far your job has
        /// progressed. This estimate is shown as a percentage of the total time from when your
        /// job leaves its queue to when your output files appear in your output Amazon S3 bucket.
        /// AWS Elemental MediaConvert provides jobPercentComplete in CloudWatch STATUS_UPDATE
        /// events and in the response to GetJob and ListJobs requests. The jobPercentComplete
        /// estimate is reliable for the following input containers: Quicktime, Transport Stream,
        /// MP4, and MXF. For some jobs, the service can't provide information about job progress.
        /// In those cases, jobPercentComplete returns a null value.
        /// </summary>
        public int JobPercentComplete
        {
            get { return this._jobPercentComplete.GetValueOrDefault(); }
            set { this._jobPercentComplete = value; }
        }

        // Check to see if JobPercentComplete property is set
        internal bool IsSetJobPercentComplete()
        {
            return this._jobPercentComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobTemplate. The job template that the job is created from,
        /// if it is created from a job template.
        /// </summary>
        public string JobTemplate
        {
            get { return this._jobTemplate; }
            set { this._jobTemplate = value; }
        }

        // Check to see if JobTemplate property is set
        internal bool IsSetJobTemplate()
        {
            return this._jobTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property Messages. Provides messages from the service about jobs
        /// that you have already successfully submitted.
        /// </summary>
        public JobMessages Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null;
        }

        /// <summary>
        /// Gets and sets the property OutputGroupDetails. List of output group details
        /// </summary>
        public List<OutputGroupDetail> OutputGroupDetails
        {
            get { return this._outputGroupDetails; }
            set { this._outputGroupDetails = value; }
        }

        // Check to see if OutputGroupDetails property is set
        internal bool IsSetOutputGroupDetails()
        {
            return this._outputGroupDetails != null && this._outputGroupDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Priority. Relative priority on the job.
        /// </summary>
        [AWSProperty(Min=-50, Max=50)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Queue. When you create a job, you can specify a queue to
        /// send it to. If you don't specify, the job will go to the default queue. For more about
        /// queues, see the User Guide topic at https://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        public string Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

        /// <summary>
        /// Gets and sets the property QueueTransitions. The job's queue hopping history.
        /// </summary>
        public List<QueueTransition> QueueTransitions
        {
            get { return this._queueTransitions; }
            set { this._queueTransitions = value; }
        }

        // Check to see if QueueTransitions property is set
        internal bool IsSetQueueTransitions()
        {
            return this._queueTransitions != null && this._queueTransitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RetryCount. The number of times that the service automatically
        /// attempted to process your job after encountering an error.
        /// </summary>
        public int RetryCount
        {
            get { return this._retryCount.GetValueOrDefault(); }
            set { this._retryCount = value; }
        }

        // Check to see if RetryCount property is set
        internal bool IsSetRetryCount()
        {
            return this._retryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Role. The IAM role you use for creating this job. For details
        /// about permissions, see the User Guide topic at the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/iam-role.html
        /// </summary>
        [AWSProperty(Required=true)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. JobSettings contains all the transcode settings
        /// for a job.
        /// </summary>
        [AWSProperty(Required=true)]
        public JobSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property SimulateReservedQueue. Enable this setting when you run
        /// a test job to estimate how many reserved transcoding slots (RTS) you need. When this
        /// is enabled, MediaConvert runs your job from an on-demand queue with similar performance
        /// to what you will see with one RTS in a reserved queue. This setting is disabled by
        /// default.
        /// </summary>
        public SimulateReservedQueue SimulateReservedQueue
        {
            get { return this._simulateReservedQueue; }
            set { this._simulateReservedQueue = value; }
        }

        // Check to see if SimulateReservedQueue property is set
        internal bool IsSetSimulateReservedQueue()
        {
            return this._simulateReservedQueue != null;
        }

        /// <summary>
        /// Gets and sets the property Status. A job's status can be SUBMITTED, PROGRESSING, COMPLETE,
        /// CANCELED, or ERROR.
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
        /// Gets and sets the property StatusUpdateInterval. Specify how often MediaConvert sends
        /// STATUS_UPDATE events to Amazon CloudWatch Events. Set the interval, in seconds, between
        /// status updates. MediaConvert sends an update at this interval from the time the service
        /// begins processing your job to the time it completes the transcode or encounters an
        /// error.
        /// </summary>
        public StatusUpdateInterval StatusUpdateInterval
        {
            get { return this._statusUpdateInterval; }
            set { this._statusUpdateInterval = value; }
        }

        // Check to see if StatusUpdateInterval property is set
        internal bool IsSetStatusUpdateInterval()
        {
            return this._statusUpdateInterval != null;
        }

        /// <summary>
        /// Gets and sets the property Timing. Information about when jobs are submitted, started,
        /// and finished is specified in Unix epoch format in seconds.
        /// </summary>
        public Timing Timing
        {
            get { return this._timing; }
            set { this._timing = value; }
        }

        // Check to see if Timing property is set
        internal bool IsSetTiming()
        {
            return this._timing != null;
        }

        /// <summary>
        /// Gets and sets the property UserMetadata. User-defined metadata that you want to associate
        /// with an MediaConvert job. You specify metadata in key/value pairs.
        /// </summary>
        public Dictionary<string, string> UserMetadata
        {
            get { return this._userMetadata; }
            set { this._userMetadata = value; }
        }

        // Check to see if UserMetadata property is set
        internal bool IsSetUserMetadata()
        {
            return this._userMetadata != null && this._userMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Warnings. Contains any warning messages for the job. Use
        /// to help identify potential issues with your input, output, or job. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/warning_codes.html
        /// </summary>
        public List<WarningGroup> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && this._warnings.Count > 0; 
        }

    }
}