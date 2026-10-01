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
    /// Container for the parameters to the UpdateOriginEndpoint operation. Update the specified
    /// origin endpoint. Edit the packaging preferences on an endpoint to optimize the viewing
    /// experience. You can't edit the name of the endpoint. <para> Any edits you make that
    /// impact the video output may not be reflected for a few minutes. </para>
    /// </summary>
    public partial class UpdateOriginEndpointRequest : AmazonMediaPackageV2Request
    {
        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name that describes the channel group. The name is the primary identifier for
        /// the channel group, and must be unique for your account in the AWS Region.
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
        /// The name that describes the channel. The name is the primary identifier for the channel,
        /// and must be unique for your account in the AWS Region and channel group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ContainerType. 
        /// <para>
        /// The type of container attached to this origin endpoint. A container type is a file
        /// format that encapsulates one or more media streams, such as audio and video, into
        /// a single file. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContainerType ContainerType { get; set; }

        /// <summary>
        /// Checks to see if the ContainerType property is set.
        /// </summary>
        internal bool IsSetContainerType() => this.ContainerType != null;

        /// <summary>
        /// Gets and sets the property DashManifests. 
        /// <para>
        /// A DASH manifest configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateDashManifestConfiguration> DashManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateDashManifestConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DashManifests property is set.
        /// </summary>
        internal bool IsSetDashManifests() => this.DashManifests != null && (this.DashManifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Any descriptive information that you want to add to the origin endpoint for future
        /// identification purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The expected current Entity Tag (ETag) for the resource. If the specified ETag does
        /// not match the resource's current entity tag, the update request will be rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property ForceEndpointErrorConfiguration. 
        /// <para>
        /// The failover settings for the endpoint.
        /// </para>
        /// </summary>
        public ForceEndpointErrorConfiguration ForceEndpointErrorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ForceEndpointErrorConfiguration property is set.
        /// </summary>
        internal bool IsSetForceEndpointErrorConfiguration() => this.ForceEndpointErrorConfiguration != null;

        /// <summary>
        /// Gets and sets the property HlsManifests. 
        /// <para>
        /// An HTTP live streaming (HLS) manifest configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateHlsManifestConfiguration> HlsManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateHlsManifestConfiguration>() : null;

        /// <summary>
        /// Checks to see if the HlsManifests property is set.
        /// </summary>
        internal bool IsSetHlsManifests() => this.HlsManifests != null && (this.HlsManifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LowLatencyHlsManifests. 
        /// <para>
        /// A low-latency HLS manifest configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateLowLatencyHlsManifestConfiguration> LowLatencyHlsManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateLowLatencyHlsManifestConfiguration>() : null;

        /// <summary>
        /// Checks to see if the LowLatencyHlsManifests property is set.
        /// </summary>
        internal bool IsSetLowLatencyHlsManifests() => this.LowLatencyHlsManifests != null && (this.LowLatencyHlsManifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MssManifests. 
        /// <para>
        /// A list of Microsoft Smooth Streaming (MSS) manifest configurations to update for the
        /// origin endpoint. This replaces the existing MSS manifest configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateMssManifestConfiguration> MssManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateMssManifestConfiguration>() : null;

        /// <summary>
        /// Checks to see if the MssManifests property is set.
        /// </summary>
        internal bool IsSetMssManifests() => this.MssManifests != null && (this.MssManifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name that describes the origin endpoint. The name is the primary identifier for
        /// the origin endpoint, and and must be unique for your account in the AWS Region and
        /// channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OriginEndpointName { get; set; }

        /// <summary>
        /// Checks to see if the OriginEndpointName property is set.
        /// </summary>
        internal bool IsSetOriginEndpointName() => this.OriginEndpointName != null;

        /// <summary>
        /// Gets and sets the property Segment. 
        /// <para>
        /// The segment configuration, including the segment name, duration, and other configuration
        /// values.
        /// </para>
        /// </summary>
        public Segment Segment { get; set; }

        /// <summary>
        /// Checks to see if the Segment property is set.
        /// </summary>
        internal bool IsSetSegment() => this.Segment != null;

        /// <summary>
        /// Gets and sets the property StartoverWindowSeconds. 
        /// <para>
        /// The size of the window (in seconds) to create a window of the live stream that's available
        /// for on-demand viewing. Viewers can start-over or catch-up on content that falls within
        /// the window. The maximum startover window is 1,209,600 seconds (14 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1209600)]
        public int? StartoverWindowSeconds { get; set; }

        /// <summary>
        /// Checks to see if the StartoverWindowSeconds property is set.
        /// </summary>
        internal bool IsSetStartoverWindowSeconds() => this.StartoverWindowSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property StreamNameOutputMode. 
        /// <para>
        /// The output mode for stream names in egress manifests. If you provide a value, it must
        /// match the current value. You can't change the stream name output mode after you create
        /// the endpoint.
        /// </para>
        /// </summary>
        public StreamNameOutputMode StreamNameOutputMode { get; set; }

        /// <summary>
        /// Checks to see if the StreamNameOutputMode property is set.
        /// </summary>
        internal bool IsSetStreamNameOutputMode() => this.StreamNameOutputMode != null;

        /// <summary>
        /// Gets and sets the property UriSeparator. 
        /// <para>
        /// The separator character to use in generated URIs for this origin endpoint. This setting
        /// applies to all manifest types on the endpoint. If you don't specify a value in the
        /// update request, the current value is preserved.
        /// </para>
        /// </summary>
        public UriSeparator UriSeparator { get; set; }

        /// <summary>
        /// Checks to see if the UriSeparator property is set.
        /// </summary>
        internal bool IsSetUriSeparator() => this.UriSeparator != null;
    }
}
