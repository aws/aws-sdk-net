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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHarvestJob operation. Creates a new harvest
    /// job to export content from a MediaPackage v2 channel to an S3 bucket.
    /// </summary>
    public partial class CreateHarvestJobRequest : AmazonMediaPackageV2Request
    {
        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name of the channel group containing the channel from which to harvest content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelGroupName property is set.
        /// </summary>
        internal bool IsSetChannelGroupName() => this.ChannelGroupName != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel from which to harvest content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the harvest job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The S3 destination where the harvested content will be placed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Destination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property HarvestJobName. 
        /// <para>
        /// A name for the harvest job. This name must be unique within the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string HarvestJobName { get; set; }

        /// <summary>
        /// Checks to see if the HarvestJobName property is set.
        /// </summary>
        internal bool IsSetHarvestJobName() => this.HarvestJobName != null;

        /// <summary>
        /// Gets and sets the property HarvestedManifests. 
        /// <para>
        /// A list of manifests to be harvested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarvestedManifests HarvestedManifests { get; set; }

        /// <summary>
        /// Checks to see if the HarvestedManifests property is set.
        /// </summary>
        internal bool IsSetHarvestedManifests() => this.HarvestedManifests != null;

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name of the origin endpoint from which to harvest content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OriginEndpointName { get; set; }

        /// <summary>
        /// Checks to see if the OriginEndpointName property is set.
        /// </summary>
        internal bool IsSetOriginEndpointName() => this.OriginEndpointName != null;

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The configuration for when the harvest job should run, including start and end times.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarvesterScheduleConfiguration ScheduleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleConfiguration property is set.
        /// </summary>
        internal bool IsSetScheduleConfiguration() => this.ScheduleConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of tags associated with the harvest job.
        /// </para>
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
    }
}
