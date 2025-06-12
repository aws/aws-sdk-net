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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJobTemplate operation.
    /// Create a new job template. For information about job templates see the User Guide
    /// at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
    /// </summary>
    public partial class CreateJobTemplateRequest : AmazonMediaConvertRequest
    {
        private AccelerationSettings _accelerationSettings;
        private string _category;
        private string _description;
        private List<HopDestination> _hopDestinations = AWSConfigs.InitializeCollections ? new List<HopDestination>() : null;
        private string _name;
        private int? _priority;
        private string _queue;
        private JobTemplateSettings _settings;
        private StatusUpdateInterval _statusUpdateInterval;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccelerationSettings. Accelerated transcoding can significantly
        /// speed up jobs with long, visually complex content. Outputs that use this feature incur
        /// pro-tier pricing. For information about feature limitations, see the AWS Elemental
        /// MediaConvert User Guide.
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
        /// Gets and sets the property Category. Optional. A category for the job template you
        /// are creating
        /// </summary>
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Description. Optional. A description of the job template
        /// you are creating.
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
        /// Gets and sets the property HopDestinations. Optional. Use queue hopping to avoid overly
        /// long waits in the backlog of the queue that you submit your job to. Specify an alternate
        /// queue and the maximum time that your job will wait in the initial queue before hopping.
        /// For more information about this feature, see the AWS Elemental MediaConvert User Guide.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HopDestination> HopDestinations
        {
            get { return this._hopDestinations; }
            set { this._hopDestinations = value; }
        }

        // Check to see if HopDestinations property is set
        internal bool IsSetHopDestinations()
        {
            return this._hopDestinations != null && (this._hopDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the job template you are creating.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Priority. Specify the relative priority for this job. In
        /// any given queue, the service begins processing the job with the highest value first.
        /// When more than one job has the same priority, the service begins processing the job
        /// that you submitted first. If you don't specify a priority, the service uses the default
        /// value 0.
        /// </summary>
        [AWSProperty(Min=-50, Max=50)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Queue. Optional. The queue that jobs created from this
        /// template are assigned to. If you don't specify this, jobs will go to the default queue.
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
        /// Gets and sets the property Settings. JobTemplateSettings contains all the transcode
        /// settings saved in the template that will be applied to jobs created from it.
        /// </summary>
        [AWSProperty(Required=true)]
        public JobTemplateSettings Settings
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
        /// Gets and sets the property Tags. The tags that you want to add to the resource. You
        /// can tag resources with a key-value pair or with only a key.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}