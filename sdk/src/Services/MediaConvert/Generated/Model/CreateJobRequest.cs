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
    /// Container for the parameters to the CreateJob operation.
    /// Create a new transcoding job. For information about jobs and job settings, see the
    /// User Guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
    /// </summary>
    public partial class CreateJobRequest : AmazonMediaConvertRequest
    {
        private AccelerationSettings _accelerationSettings;
        private BillingTagsSource _billingTagsSource;
        private string _clientRequestToken;
        private List<HopDestination> _hopDestinations = new List<HopDestination>();
        private string _jobTemplate;
        private int? _priority;
        private string _queue;
        private string _role;
        private JobSettings _settings;
        private SimulateReservedQueue _simulateReservedQueue;
        private StatusUpdateInterval _statusUpdateInterval;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private Dictionary<string, string> _userMetadata = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AccelerationSettings. Optional. Accelerated transcoding
        /// can significantly speed up jobs with long, visually complex content. Outputs that
        /// use this feature incur pro-tier pricing. For information about feature limitations,
        /// see the AWS Elemental MediaConvert User Guide.
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
        /// Gets and sets the property BillingTagsSource. Optional. Choose a tag type that AWS
        /// Billing and Cost Management will use to sort your AWS Elemental MediaConvert costs
        /// on any billing report that you set up. Any transcoding outputs that don't have an
        /// associated tag will appear in your billing report unsorted. If you don't choose a
        /// valid value for this field, your job outputs will appear on the billing report unsorted.
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
        /// Gets and sets the property HopDestinations. Optional. Use queue hopping to avoid overly
        /// long waits in the backlog of the queue that you submit your job to. Specify an alternate
        /// queue and the maximum time that your job will wait in the initial queue before hopping.
        /// For more information about this feature, see the AWS Elemental MediaConvert User Guide.
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
        /// Gets and sets the property JobTemplate. Optional. When you create a job, you can either
        /// specify a job template or specify the transcoding settings individually.
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
        /// Gets and sets the property Priority. Optional. Specify the relative priority for this
        /// job. In any given queue, the service begins processing the job with the highest value
        /// first. When more than one job has the same priority, the service begins processing
        /// the job that you submitted first. If you don't specify a priority, the service uses
        /// the default value 0.
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
        /// Gets and sets the property Queue. Optional. When you create a job, you can specify
        /// a queue to send it to. If you don't specify, the job will go to the default queue.
        /// For more about queues, see the User Guide topic at https://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html.
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
        /// Gets and sets the property Role. Required. The IAM role you use for creating this
        /// job. For details about permissions, see the User Guide topic at the User Guide at
        /// https://docs.aws.amazon.com/mediaconvert/latest/ug/iam-role.html.
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
        /// Gets and sets the property SimulateReservedQueue. Optional. Enable this setting when
        /// you run a test job to estimate how many reserved transcoding slots (RTS) you need.
        /// When this is enabled, MediaConvert runs your job from an on-demand queue with similar
        /// performance to what you will see with one RTS in a reserved queue. This setting is
        /// disabled by default.
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
        /// Gets and sets the property StatusUpdateInterval. Optional. Specify how often MediaConvert
        /// sends STATUS_UPDATE events to Amazon CloudWatch Events. Set the interval, in seconds,
        /// between status updates. MediaConvert sends an update at this interval from the time
        /// the service begins processing your job to the time it completes the transcode or encounters
        /// an error.
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
        /// Gets and sets the property Tags. Optional. The tags that you want to add to the resource.
        /// You can tag resources with a key-value pair or with only a key.  Use standard AWS
        /// tags on your job for automatic integration with AWS services and for custom integrations
        /// and workflows.
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

        /// <summary>
        /// Gets and sets the property UserMetadata. Optional. User-defined metadata that you
        /// want to associate with an MediaConvert job. You specify metadata in key/value pairs.
        ///  Use only for existing integrations or workflows that rely on job metadata tags. Otherwise,
        /// we recommend that you use standard AWS tags.
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

    }
}