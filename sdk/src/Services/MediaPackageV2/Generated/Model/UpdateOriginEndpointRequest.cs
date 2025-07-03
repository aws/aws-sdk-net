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
    /// Container for the parameters to the UpdateOriginEndpoint operation.
    /// Update the specified origin endpoint. Edit the packaging preferences on an endpoint
    /// to optimize the viewing experience. You can't edit the name of the endpoint.
    /// 
    ///  
    /// <para>
    /// Any edits you make that impact the video output may not be reflected for a few minutes.
    /// </para>
    /// </summary>
    public partial class UpdateOriginEndpointRequest : AmazonMediaPackageV2Request
    {
        private string _channelGroupName;
        private string _channelName;
        private ContainerType _containerType;
        private List<CreateDashManifestConfiguration> _dashManifests = AWSConfigs.InitializeCollections ? new List<CreateDashManifestConfiguration>() : null;
        private string _description;
        private string _eTag;
        private ForceEndpointErrorConfiguration _forceEndpointErrorConfiguration;
        private List<CreateHlsManifestConfiguration> _hlsManifests = AWSConfigs.InitializeCollections ? new List<CreateHlsManifestConfiguration>() : null;
        private List<CreateLowLatencyHlsManifestConfiguration> _lowLatencyHlsManifests = AWSConfigs.InitializeCollections ? new List<CreateLowLatencyHlsManifestConfiguration>() : null;
        private List<CreateMssManifestConfiguration> _mssManifests = AWSConfigs.InitializeCollections ? new List<CreateMssManifestConfiguration>() : null;
        private string _originEndpointName;
        private Segment _segment;
        private int? _startoverWindowSeconds;

        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name that describes the channel group. The name is the primary identifier for
        /// the channel group, and must be unique for your account in the AWS Region.
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
        /// The name that describes the channel. The name is the primary identifier for the channel,
        /// and must be unique for your account in the AWS Region and channel group. 
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
        /// Gets and sets the property ContainerType. 
        /// <para>
        /// The type of container attached to this origin endpoint. A container type is a file
        /// format that encapsulates one or more media streams, such as audio and video, into
        /// a single file. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerType ContainerType
        {
            get { return this._containerType; }
            set { this._containerType = value; }
        }

        // Check to see if ContainerType property is set
        internal bool IsSetContainerType()
        {
            return this._containerType != null;
        }

        /// <summary>
        /// Gets and sets the property DashManifests. 
        /// <para>
        /// A DASH manifest configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateDashManifestConfiguration> DashManifests
        {
            get { return this._dashManifests; }
            set { this._dashManifests = value; }
        }

        // Check to see if DashManifests property is set
        internal bool IsSetDashManifests()
        {
            return this._dashManifests != null && (this._dashManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Any descriptive information that you want to add to the origin endpoint for future
        /// identification purposes.
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// The expected current Entity Tag (ETag) for the resource. If the specified ETag does
        /// not match the resource's current entity tag, the update request will be rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property ForceEndpointErrorConfiguration. 
        /// <para>
        /// The failover settings for the endpoint.
        /// </para>
        /// </summary>
        public ForceEndpointErrorConfiguration ForceEndpointErrorConfiguration
        {
            get { return this._forceEndpointErrorConfiguration; }
            set { this._forceEndpointErrorConfiguration = value; }
        }

        // Check to see if ForceEndpointErrorConfiguration property is set
        internal bool IsSetForceEndpointErrorConfiguration()
        {
            return this._forceEndpointErrorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HlsManifests. 
        /// <para>
        /// An HTTP live streaming (HLS) manifest configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateHlsManifestConfiguration> HlsManifests
        {
            get { return this._hlsManifests; }
            set { this._hlsManifests = value; }
        }

        // Check to see if HlsManifests property is set
        internal bool IsSetHlsManifests()
        {
            return this._hlsManifests != null && (this._hlsManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LowLatencyHlsManifests. 
        /// <para>
        /// A low-latency HLS manifest configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateLowLatencyHlsManifestConfiguration> LowLatencyHlsManifests
        {
            get { return this._lowLatencyHlsManifests; }
            set { this._lowLatencyHlsManifests = value; }
        }

        // Check to see if LowLatencyHlsManifests property is set
        internal bool IsSetLowLatencyHlsManifests()
        {
            return this._lowLatencyHlsManifests != null && (this._lowLatencyHlsManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MssManifests. 
        /// <para>
        /// A list of Microsoft Smooth Streaming (MSS) manifest configurations to update for the
        /// origin endpoint. This replaces the existing MSS manifest configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreateMssManifestConfiguration> MssManifests
        {
            get { return this._mssManifests; }
            set { this._mssManifests = value; }
        }

        // Check to see if MssManifests property is set
        internal bool IsSetMssManifests()
        {
            return this._mssManifests != null && (this._mssManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name that describes the origin endpoint. The name is the primary identifier for
        /// the origin endpoint, and and must be unique for your account in the AWS Region and
        /// channel. 
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
        /// Gets and sets the property Segment. 
        /// <para>
        /// The segment configuration, including the segment name, duration, and other configuration
        /// values.
        /// </para>
        /// </summary>
        public Segment Segment
        {
            get { return this._segment; }
            set { this._segment = value; }
        }

        // Check to see if Segment property is set
        internal bool IsSetSegment()
        {
            return this._segment != null;
        }

        /// <summary>
        /// Gets and sets the property StartoverWindowSeconds. 
        /// <para>
        /// The size of the window (in seconds) to create a window of the live stream that's available
        /// for on-demand viewing. Viewers can start-over or catch-up on content that falls within
        /// the window. The maximum startover window is 1,209,600 seconds (14 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=1209600)]
        public int? StartoverWindowSeconds
        {
            get { return this._startoverWindowSeconds; }
            set { this._startoverWindowSeconds = value; }
        }

        // Check to see if StartoverWindowSeconds property is set
        internal bool IsSetStartoverWindowSeconds()
        {
            return this._startoverWindowSeconds.HasValue; 
        }

    }
}