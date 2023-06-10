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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOriginEndpoint operation.
    /// The endpoint is attached to a channel, and represents the output of the live content.
    /// You can associate multiple endpoints to a single channel. Each endpoint gives players
    /// and downstream CDNs (such as Amazon CloudFront) access to the content for playback.
    /// Content can't be served from a channel until it has an endpoint. You can create only
    /// one endpoint with each request.
    /// </summary>
    public partial class CreateOriginEndpointRequest : AmazonMediaPackageV2Request
    {
        private string _channelGroupName;
        private string _channelName;
        private string _clientToken;
        private ContainerType _containerType;
        private string _description;
        private List<CreateHlsManifestConfiguration> _hlsManifests = new List<CreateHlsManifestConfiguration>();
        private List<CreateLowLatencyHlsManifestConfiguration> _lowLatencyHlsManifests = new List<CreateLowLatencyHlsManifestConfiguration>();
        private string _originEndpointName;
        private Segment _segment;
        private int? _startoverWindowSeconds;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
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
        /// Gets and sets the property ContainerType. 
        /// <para>
        /// The type of container to attach to this origin endpoint. A container type is a file
        /// format that encapsulates one or more media streams, such as audio and video, into
        /// a single file. You can't change the container type after you create the endpoint.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Enter any descriptive text that helps you to identify the origin endpoint.
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
        /// Gets and sets the property HlsManifests. 
        /// <para>
        /// An HTTP live streaming (HLS) manifest configuration.
        /// </para>
        /// </summary>
        public List<CreateHlsManifestConfiguration> HlsManifests
        {
            get { return this._hlsManifests; }
            set { this._hlsManifests = value; }
        }

        // Check to see if HlsManifests property is set
        internal bool IsSetHlsManifests()
        {
            return this._hlsManifests != null && this._hlsManifests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LowLatencyHlsManifests. 
        /// <para>
        /// A low-latency HLS manifest configuration.
        /// </para>
        /// </summary>
        public List<CreateLowLatencyHlsManifestConfiguration> LowLatencyHlsManifests
        {
            get { return this._lowLatencyHlsManifests; }
            set { this._lowLatencyHlsManifests = value; }
        }

        // Check to see if LowLatencyHlsManifests property is set
        internal bool IsSetLowLatencyHlsManifests()
        {
            return this._lowLatencyHlsManifests != null && this._lowLatencyHlsManifests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name that describes the origin endpoint. The name is the primary identifier for
        /// the origin endpoint, and must be unique for your account in the AWS Region and channel.
        /// You can't use spaces in the name. You can't change the name after you create the endpoint.
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
        public int StartoverWindowSeconds
        {
            get { return this._startoverWindowSeconds.GetValueOrDefault(); }
            set { this._startoverWindowSeconds = value; }
        }

        // Check to see if StartoverWindowSeconds property is set
        internal bool IsSetStartoverWindowSeconds()
        {
            return this._startoverWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A comma-separated list of tag key:value pairs that you define. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"Key1": "Value1",</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>"Key2": "Value2"</code> 
        /// </para>
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

    }
}