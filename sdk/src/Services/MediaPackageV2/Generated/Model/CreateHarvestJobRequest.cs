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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
    /// Container for the parameters to the CreateHarvestJob operation.
    /// Creates a new harvest job to export content from a MediaPackage v2 channel to an S3
    /// bucket.
    /// </summary>
    public partial class CreateHarvestJobRequest : AmazonMediaPackageV2Request
    {
        private string _channelGroupName;
        private string _channelName;
        private string _clientToken;
        private string _description;
        private Destination _destination;
        private HarvestedManifests _harvestedManifests;
        private string _harvestJobName;
        private string _originEndpointName;
        private HarvesterScheduleConfiguration _scheduleConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name of the channel group containing the channel from which to harvest content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ChannelGroupName
        {
            get { return this._channelGroupName; }
            set { this._channelGroupName = value; }
        }

        // Check to see if ChannelGroupName property is set
        internal bool IsSetChannelGroupName()
        {
            return this._channelGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel from which to harvest content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the harvest job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Destination. 
        /// <para>
        /// The S3 destination where the harvested content will be placed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property HarvestedManifests. 
        /// <para>
        /// A list of manifests to be harvested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HarvestedManifests HarvestedManifests
        {
            get { return this._harvestedManifests; }
            set { this._harvestedManifests = value; }
        }

        // Check to see if HarvestedManifests property is set
        internal bool IsSetHarvestedManifests()
        {
            return this._harvestedManifests != null;
        }

        /// <summary>
        /// Gets and sets the property HarvestJobName. 
        /// <para>
        /// A name for the harvest job. This name must be unique within the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string HarvestJobName
        {
            get { return this._harvestJobName; }
            set { this._harvestJobName = value; }
        }

        // Check to see if HarvestJobName property is set
        internal bool IsSetHarvestJobName()
        {
            return this._harvestJobName != null;
        }

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name of the origin endpoint from which to harvest content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OriginEndpointName
        {
            get { return this._originEndpointName; }
            set { this._originEndpointName = value; }
        }

        // Check to see if OriginEndpointName property is set
        internal bool IsSetOriginEndpointName()
        {
            return this._originEndpointName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The configuration for when the harvest job should run, including start and end times.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HarvesterScheduleConfiguration ScheduleConfiguration
        {
            get { return this._scheduleConfiguration; }
            set { this._scheduleConfiguration = value; }
        }

        // Check to see if ScheduleConfiguration property is set
        internal bool IsSetScheduleConfiguration()
        {
            return this._scheduleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of tags associated with the harvest job.
        /// </para>
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