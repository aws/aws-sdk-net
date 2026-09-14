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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Each job converts an input file into an output file or files. For more information,
    /// see the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
    /// </summary>
    public partial class Job
    {
        /// <summary>
        /// Gets and sets the property AccelerationSettings. Accelerated transcoding can significantly
        /// speed up jobs with long, visually complex content.
        /// </summary>
        public AccelerationSettings AccelerationSettings { get; set; }

        /// <summary>
        /// Checks to see if the AccelerationSettings property is set.
        /// </summary>
        internal bool IsSetAccelerationSettings() => this.AccelerationSettings != null;

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
        public AccelerationStatus AccelerationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccelerationStatus property is set.
        /// </summary>
        internal bool IsSetAccelerationStatus() => this.AccelerationStatus != null;

        /// <summary>
        /// Gets and sets the property Arn. An identifier for this resource that is unique within
        /// all of AWS.
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BillingTagsSource. The tag type that AWS Billing and Cost
        /// Management will use to sort your AWS Elemental MediaConvert costs on any billing report
        /// that you set up.
        /// </summary>
        public BillingTagsSource BillingTagsSource { get; set; }

        /// <summary>
        /// Checks to see if the BillingTagsSource property is set.
        /// </summary>
        internal bool IsSetBillingTagsSource() => this.BillingTagsSource != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. Prevent duplicate jobs from being created
        /// and ensure idempotency for your requests. A client request token can be any string
        /// that includes up to 64 ASCII characters. If you reuse a client request token within
        /// one minute of a successful request, the API returns the job details of the original
        /// request instead. For more information see https://docs.aws.amazon.com/mediaconvert/latest/apireference/idempotency.html.
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The time, in Unix epoch format in seconds, when
        /// the job got created.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentPhase. A job's phase can be PROBING, TRANSCODING
        /// OR UPLOADING
        /// </summary>
        public JobPhase CurrentPhase { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPhase property is set.
        /// </summary>
        internal bool IsSetCurrentPhase() => this.CurrentPhase != null;

        /// <summary>
        /// Gets and sets the property ElementalInferenceConfiguration. The Elemental Inference
        /// configuration used in this job.
        /// </summary>
        public ElementalInferenceConfiguration ElementalInferenceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ElementalInferenceConfiguration property is set.
        /// </summary>
        internal bool IsSetElementalInferenceConfiguration() => this.ElementalInferenceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. Error code for the job
        /// </summary>
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. Error message of Job
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property HopDestinations. Optional list of hop destinations.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HopDestination> HopDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<HopDestination>() : null;

        /// <summary>
        /// Checks to see if the HopDestinations property is set.
        /// </summary>
        internal bool IsSetHopDestinations() => this.HopDestinations != null && (this.HopDestinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. A portion of the job's ARN, unique within your AWS
        /// Elemental MediaConvert resources
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property JobEngineVersionRequested. The Job engine version that
        /// you requested for your job. Valid versions are in a YYYY-MM-DD format.
        /// </summary>
        public string JobEngineVersionRequested { get; set; }

        /// <summary>
        /// Checks to see if the JobEngineVersionRequested property is set.
        /// </summary>
        internal bool IsSetJobEngineVersionRequested() => this.JobEngineVersionRequested != null;

        /// <summary>
        /// Gets and sets the property JobEngineVersionUsed. The Job engine version that your
        /// job used. Job engine versions are in a YYYY-MM-DD format. When you request an expired
        /// version, the response for this property will be empty. Requests to create jobs with
        /// an expired version result in a regular job, as if no specific Job engine version was
        /// requested. When you request an invalid version, the response for this property will
        /// be empty. Requests to create jobs with an invalid version result in a 400 error message,
        /// and no job is created.
        /// </summary>
        public string JobEngineVersionUsed { get; set; }

        /// <summary>
        /// Checks to see if the JobEngineVersionUsed property is set.
        /// </summary>
        internal bool IsSetJobEngineVersionUsed() => this.JobEngineVersionUsed != null;

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
        public int? JobPercentComplete { get; set; }

        /// <summary>
        /// Checks to see if the JobPercentComplete property is set.
        /// </summary>
        internal bool IsSetJobPercentComplete() => this.JobPercentComplete.HasValue;

        /// <summary>
        /// Gets and sets the property JobTemplate. The job template that the job is created from,
        /// if it is created from a job template.
        /// </summary>
        public string JobTemplate { get; set; }

        /// <summary>
        /// Checks to see if the JobTemplate property is set.
        /// </summary>
        internal bool IsSetJobTemplate() => this.JobTemplate != null;

        /// <summary>
        /// Gets and sets the property LastShareDetails. Contains information about the most recent
        /// share attempt for the job. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/creating-resource-share.html
        /// </summary>
        public string LastShareDetails { get; set; }

        /// <summary>
        /// Checks to see if the LastShareDetails property is set.
        /// </summary>
        internal bool IsSetLastShareDetails() => this.LastShareDetails != null;

        /// <summary>
        /// Gets and sets the property Messages. Provides messages from the service about jobs
        /// that you have already successfully submitted.
        /// </summary>
        public JobMessages Messages { get; set; }

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null;

        /// <summary>
        /// Gets and sets the property OutputGroupDetails. List of output group details
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputGroupDetail> OutputGroupDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputGroupDetail>() : null;

        /// <summary>
        /// Checks to see if the OutputGroupDetails property is set.
        /// </summary>
        internal bool IsSetOutputGroupDetails() => this.OutputGroupDetails != null && (this.OutputGroupDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Priority. Relative priority on the job.
        /// </summary>
        [AWSProperty(Min = -50, Max = 50)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Queue. When you create a job, you can specify a queue to
        /// send it to. If you don't specify, the job will go to the default queue. For more about
        /// queues, see the User Guide topic at https://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        public string Queue { get; set; }

        /// <summary>
        /// Checks to see if the Queue property is set.
        /// </summary>
        internal bool IsSetQueue() => this.Queue != null;

        /// <summary>
        /// Gets and sets the property QueueTransitions. The job's queue hopping history.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueueTransition> QueueTransitions { get; set; } = AWSConfigs.InitializeCollections ? new List<QueueTransition>() : null;

        /// <summary>
        /// Checks to see if the QueueTransitions property is set.
        /// </summary>
        internal bool IsSetQueueTransitions() => this.QueueTransitions != null && (this.QueueTransitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RetryCount. The number of times that the service automatically
        /// attempted to process your job after encountering an error.
        /// </summary>
        public int? RetryCount { get; set; }

        /// <summary>
        /// Checks to see if the RetryCount property is set.
        /// </summary>
        internal bool IsSetRetryCount() => this.RetryCount.HasValue;

        /// <summary>
        /// Gets and sets the property Role. The IAM role you use for creating this job. For details
        /// about permissions, see the User Guide topic at the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/iam-role.html
        /// </summary>
        [AWSProperty(Required = true)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Settings. JobSettings contains all the transcode settings
        /// for a job.
        /// </summary>
        [AWSProperty(Required = true)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property ShareStatus. A job's share status can be NOT_SHARED, INITIATED,
        /// or SHARED
        /// </summary>
        public ShareStatus ShareStatus { get; set; }

        /// <summary>
        /// Checks to see if the ShareStatus property is set.
        /// </summary>
        internal bool IsSetShareStatus() => this.ShareStatus != null;

        /// <summary>
        /// Gets and sets the property SimulateReservedQueue. Enable this setting when you run
        /// a test job to estimate how many reserved transcoding slots (RTS) you need. When this
        /// is enabled, MediaConvert runs your job from an on-demand queue with similar performance
        /// to what you will see with one RTS in a reserved queue. This setting is disabled by
        /// default.
        /// </summary>
        public SimulateReservedQueue SimulateReservedQueue { get; set; }

        /// <summary>
        /// Checks to see if the SimulateReservedQueue property is set.
        /// </summary>
        internal bool IsSetSimulateReservedQueue() => this.SimulateReservedQueue != null;

        /// <summary>
        /// Gets and sets the property Status. A job's status can be SUBMITTED, PROGRESSING, COMPLETE,
        /// CANCELED, or ERROR.
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusUpdateInterval. Specify how often MediaConvert sends
        /// STATUS_UPDATE events to Amazon CloudWatch Events. Set the interval, in seconds, between
        /// status updates. MediaConvert sends an update at this interval from the time the service
        /// begins processing your job to the time it completes the transcode or encounters an
        /// error.
        /// </summary>
        public StatusUpdateInterval StatusUpdateInterval { get; set; }

        /// <summary>
        /// Checks to see if the StatusUpdateInterval property is set.
        /// </summary>
        internal bool IsSetStatusUpdateInterval() => this.StatusUpdateInterval != null;

        /// <summary>
        /// Gets and sets the property Timing. Information about when jobs are submitted, started,
        /// and finished is specified in Unix epoch format in seconds.
        /// </summary>
        public Timing Timing { get; set; }

        /// <summary>
        /// Checks to see if the Timing property is set.
        /// </summary>
        internal bool IsSetTiming() => this.Timing != null;

        /// <summary>
        /// Gets and sets the property UserMetadata. User-defined metadata that you want to associate
        /// with an MediaConvert job. You specify metadata in key/value pairs.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> UserMetadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the UserMetadata property is set.
        /// </summary>
        internal bool IsSetUserMetadata() => this.UserMetadata != null && (this.UserMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Warnings. Contains any warning messages for the job. Use
        /// to help identify potential issues with your input, output, or job. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/warning_codes.html
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WarningGroup> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<WarningGroup>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
