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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the ListOfferings operation. List offerings available
    /// for purchase.
    /// </summary>
    public partial class ListOfferingsRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelClass. Filter by channel class, 'STANDARD' or 'SINGLE_PIPELINE'
        /// </summary>
        public string ChannelClass { get; set; }

        /// <summary>
        /// Checks to see if the ChannelClass property is set.
        /// </summary>
        internal bool IsSetChannelClass() => this.ChannelClass != null;

        /// <summary>
        /// Gets and sets the property ChannelConfiguration. Filter to offerings that match the
        /// configuration of an existing channel, e.g. '2345678' (a channel ID)
        /// </summary>
        public string ChannelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ChannelConfiguration property is set.
        /// </summary>
        internal bool IsSetChannelConfiguration() => this.ChannelConfiguration != null;

        /// <summary>
        /// Gets and sets the property Codec. Filter by codec, 'AVC', 'HEVC', 'MPEG2', 'AUDIO',
        /// 'LINK', or 'AV1'
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property Duration. Filter by offering duration, e.g. '12'
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration != null;

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumBitrate. Filter by bitrate, 'MAX_10_MBPS', 'MAX_20_MBPS',
        /// or 'MAX_50_MBPS'
        /// </summary>
        public string MaximumBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBitrate property is set.
        /// </summary>
        internal bool IsSetMaximumBitrate() => this.MaximumBitrate != null;

        /// <summary>
        /// Gets and sets the property MaximumFramerate. Filter by framerate, 'MAX_30_FPS' or
        /// 'MAX_60_FPS'
        /// </summary>
        public string MaximumFramerate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumFramerate property is set.
        /// </summary>
        internal bool IsSetMaximumFramerate() => this.MaximumFramerate != null;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Resolution. Filter by resolution, 'SD', 'HD', 'FHD', or
        /// 'UHD'
        /// </summary>
        public string Resolution { get; set; }

        /// <summary>
        /// Checks to see if the Resolution property is set.
        /// </summary>
        internal bool IsSetResolution() => this.Resolution != null;

        /// <summary>
        /// Gets and sets the property ResourceType. Filter by resource type, 'INPUT', 'OUTPUT',
        /// 'MULTIPLEX', or 'CHANNEL'
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SpecialFeature. Filter by special feature, 'ADVANCED_AUDIO'
        /// or 'AUDIO_NORMALIZATION'
        /// </summary>
        public string SpecialFeature { get; set; }

        /// <summary>
        /// Checks to see if the SpecialFeature property is set.
        /// </summary>
        internal bool IsSetSpecialFeature() => this.SpecialFeature != null;

        /// <summary>
        /// Gets and sets the property VideoQuality. Filter by video quality, 'STANDARD', 'ENHANCED',
        /// or 'PREMIUM'
        /// </summary>
        public string VideoQuality { get; set; }

        /// <summary>
        /// Checks to see if the VideoQuality property is set.
        /// </summary>
        internal bool IsSetVideoQuality() => this.VideoQuality != null;
    }
}
