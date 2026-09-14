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
    /// Container for the parameters to the CreateJob operation. Create a new transcoding
    /// job. For information about jobs and job settings, see the User Guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
    /// </summary>
    public partial class CreateJobRequest : AmazonMediaConvertRequest
    {
        /// <summary>
        /// Gets and sets the property AccelerationSettings. Optional. Accelerated transcoding
        /// can significantly speed up jobs with long, visually complex content. Outputs that
        /// use this feature incur pro-tier pricing. For information about feature limitations,
        /// see the AWS Elemental MediaConvert User Guide.
        /// </summary>
        public AccelerationSettings AccelerationSettings { get; set; }

        /// <summary>
        /// Checks to see if the AccelerationSettings property is set.
        /// </summary>
        internal bool IsSetAccelerationSettings() => this.AccelerationSettings != null;

        /// <summary>
        /// Gets and sets the property BillingTagsSource. Optionally choose a Billing tags source
        /// that AWS Billing and Cost Management will use to display tags for individual output
        /// costs on any billing report that you set up. Leave blank to use the default value,
        /// Job.
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
        /// Gets and sets the property HopDestinations. Optional. Use queue hopping to avoid overly
        /// long waits in the backlog of the queue that you submit your job to. Specify an alternate
        /// queue and the maximum time that your job will wait in the initial queue before hopping.
        /// For more information about this feature, see the AWS Elemental MediaConvert User Guide.
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
        /// Gets and sets the property JobEngineVersion. Use Job engine versions to run jobs for
        /// your production workflow on one version, while you test and validate the latest version.
        /// Job engine versions represent periodically grouped MediaConvert releases with new
        /// features, updates, improvements, and fixes. Job engine versions are in a YYYY-MM-DD
        /// format. Note that the Job engine version feature is not publicly available at this
        /// time. To request access, contact AWS support.
        /// </summary>
        public string JobEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the JobEngineVersion property is set.
        /// </summary>
        internal bool IsSetJobEngineVersion() => this.JobEngineVersion != null;

        /// <summary>
        /// Gets and sets the property JobTemplate. Optional. When you create a job, you can either
        /// specify a job template or specify the transcoding settings individually.
        /// </summary>
        public string JobTemplate { get; set; }

        /// <summary>
        /// Checks to see if the JobTemplate property is set.
        /// </summary>
        internal bool IsSetJobTemplate() => this.JobTemplate != null;

        /// <summary>
        /// Gets and sets the property Priority. Optional. Specify the relative priority for this
        /// job. In any given queue, the service begins processing the job with the highest value
        /// first. When more than one job has the same priority, the service begins processing
        /// the job that you submitted first. If you don't specify a priority, the service uses
        /// the default value 0.
        /// </summary>
        [AWSProperty(Min = -50, Max = 50)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Queue. Optional. When you create a job, you can specify
        /// a queue to send it to. If you don't specify, the job will go to the default queue.
        /// For more about queues, see the User Guide topic at https://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html.
        /// </summary>
        public string Queue { get; set; }

        /// <summary>
        /// Checks to see if the Queue property is set.
        /// </summary>
        internal bool IsSetQueue() => this.Queue != null;

        /// <summary>
        /// Gets and sets the property Role. Required. The IAM role you use for creating this
        /// job. For details about permissions, see the User Guide topic at the User Guide at
        /// https://docs.aws.amazon.com/mediaconvert/latest/ug/iam-role.html.
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
        /// Gets and sets the property SimulateReservedQueue. Optional. Enable this setting when
        /// you run a test job to estimate how many reserved transcoding slots (RTS) you need.
        /// When this is enabled, MediaConvert runs your job from an on-demand queue with similar
        /// performance to what you will see with one RTS in a reserved queue. This setting is
        /// disabled by default.
        /// </summary>
        public SimulateReservedQueue SimulateReservedQueue { get; set; }

        /// <summary>
        /// Checks to see if the SimulateReservedQueue property is set.
        /// </summary>
        internal bool IsSetSimulateReservedQueue() => this.SimulateReservedQueue != null;

        /// <summary>
        /// Gets and sets the property StatusUpdateInterval. Optional. Specify how often MediaConvert
        /// sends STATUS_UPDATE events to Amazon CloudWatch Events. Set the interval, in seconds,
        /// between status updates. MediaConvert sends an update at this interval from the time
        /// the service begins processing your job to the time it completes the transcode or encounters
        /// an error.
        /// </summary>
        public StatusUpdateInterval StatusUpdateInterval { get; set; }

        /// <summary>
        /// Checks to see if the StatusUpdateInterval property is set.
        /// </summary>
        internal bool IsSetStatusUpdateInterval() => this.StatusUpdateInterval != null;

        /// <summary>
        /// Gets and sets the property Tags. Optional. The tags that you want to add to the resource.
        /// You can tag resources with a key-value pair or with only a key. Use standard AWS tags
        /// on your job for automatic integration with AWS services and for custom integrations
        /// and workflows.
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
        /// Gets and sets the property UserMetadata. Optional. User-defined metadata that you
        /// want to associate with an MediaConvert job. You specify metadata in key/value pairs.
        /// Use only for existing integrations or workflows that rely on job metadata tags. Otherwise,
        /// we recommend that you use standard AWS tags.
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
    }
}
