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
    /// Container for the parameters to the UpdateJobTemplate operation. Modify one of your
    /// existing job templates.
    /// </summary>
    public partial class UpdateJobTemplateRequest : AmazonMediaConvertRequest
    {
        /// <summary>
        /// Gets and sets the property AccelerationSettings. Accelerated transcoding can significantly
        /// speed up jobs with long, visually complex content. Outputs that use this feature incur
        /// pro-tier pricing. For information about feature limitations, see the AWS Elemental
        /// MediaConvert User Guide.
        /// </summary>
        public AccelerationSettings AccelerationSettings { get; set; }

        /// <summary>
        /// Checks to see if the AccelerationSettings property is set.
        /// </summary>
        internal bool IsSetAccelerationSettings() => this.AccelerationSettings != null;

        /// <summary>
        /// Gets and sets the property Category. The new category for the job template, if you
        /// are changing it.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Description. The new description for the job template,
        /// if you are changing it.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property Name. The name of the job template you are modifying
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. Specify the relative priority for this job. In
        /// any given queue, the service begins processing the job with the highest value first.
        /// When more than one job has the same priority, the service begins processing the job
        /// that you submitted first. If you don't specify a priority, the service uses the default
        /// value 0.
        /// </summary>
        [AWSProperty(Min = -50, Max = 50)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Queue. The new queue for the job template, if you are changing
        /// it.
        /// </summary>
        public string Queue { get; set; }

        /// <summary>
        /// Checks to see if the Queue property is set.
        /// </summary>
        internal bool IsSetQueue() => this.Queue != null;

        /// <summary>
        /// Gets and sets the property Settings. JobTemplateSettings contains all the transcode
        /// settings saved in the template that will be applied to jobs created from it.
        /// </summary>
        public JobTemplateSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

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
    }
}
