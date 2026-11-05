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
    /// Resource configuration (codec, resolution, bitrate, ...)
    /// </summary>
    public partial class ReservationResourceSpecification
    {
        /// <summary>
        /// Gets and sets the property ChannelClass. Channel class, e.g. 'STANDARD'
        /// </summary>
        public ChannelClass ChannelClass { get; set; }

        /// <summary>
        /// Checks to see if the ChannelClass property is set.
        /// </summary>
        internal bool IsSetChannelClass() => this.ChannelClass != null;

        /// <summary>
        /// Gets and sets the property Codec. Codec, e.g. 'AVC'
        /// </summary>
        public ReservationCodec Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property MaximumBitrate. Maximum bitrate, e.g. 'MAX_20_MBPS'
        /// </summary>
        public ReservationMaximumBitrate MaximumBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBitrate property is set.
        /// </summary>
        internal bool IsSetMaximumBitrate() => this.MaximumBitrate != null;

        /// <summary>
        /// Gets and sets the property MaximumFramerate. Maximum framerate, e.g. 'MAX_30_FPS'
        /// (Outputs only)
        /// </summary>
        public ReservationMaximumFramerate MaximumFramerate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumFramerate property is set.
        /// </summary>
        internal bool IsSetMaximumFramerate() => this.MaximumFramerate != null;

        /// <summary>
        /// Gets and sets the property Resolution. Resolution, e.g. 'HD'
        /// </summary>
        public ReservationResolution Resolution { get; set; }

        /// <summary>
        /// Checks to see if the Resolution property is set.
        /// </summary>
        internal bool IsSetResolution() => this.Resolution != null;

        /// <summary>
        /// Gets and sets the property ResourceType. Resource type, 'INPUT', 'OUTPUT', 'MULTIPLEX',
        /// or 'CHANNEL'
        /// </summary>
        public ReservationResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SpecialFeature. Special feature, e.g. 'AUDIO_NORMALIZATION'
        /// (Channels only)
        /// </summary>
        public ReservationSpecialFeature SpecialFeature { get; set; }

        /// <summary>
        /// Checks to see if the SpecialFeature property is set.
        /// </summary>
        internal bool IsSetSpecialFeature() => this.SpecialFeature != null;

        /// <summary>
        /// Gets and sets the property VideoQuality. Video quality, e.g. 'STANDARD' (Outputs only)
        /// </summary>
        public ReservationVideoQuality VideoQuality { get; set; }

        /// <summary>
        /// Checks to see if the VideoQuality property is set.
        /// </summary>
        internal bool IsSetVideoQuality() => this.VideoQuality != null;
    }
}
