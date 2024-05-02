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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private ChannelClass _channelClass;
        private ReservationCodec _codec;
        private ReservationMaximumBitrate _maximumBitrate;
        private ReservationMaximumFramerate _maximumFramerate;
        private ReservationResolution _resolution;
        private ReservationResourceType _resourceType;
        private ReservationSpecialFeature _specialFeature;
        private ReservationVideoQuality _videoQuality;

        /// <summary>
        /// Gets and sets the property ChannelClass. Channel class, e.g. 'STANDARD'
        /// </summary>
        public ChannelClass ChannelClass
        {
            get { return this._channelClass; }
            set { this._channelClass = value; }
        }

        // Check to see if ChannelClass property is set
        internal bool IsSetChannelClass()
        {
            return this._channelClass != null;
        }

        /// <summary>
        /// Gets and sets the property Codec. Codec, e.g. 'AVC'
        /// </summary>
        public ReservationCodec Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBitrate. Maximum bitrate, e.g. 'MAX_20_MBPS'
        /// </summary>
        public ReservationMaximumBitrate MaximumBitrate
        {
            get { return this._maximumBitrate; }
            set { this._maximumBitrate = value; }
        }

        // Check to see if MaximumBitrate property is set
        internal bool IsSetMaximumBitrate()
        {
            return this._maximumBitrate != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumFramerate. Maximum framerate, e.g. 'MAX_30_FPS'
        /// (Outputs only)
        /// </summary>
        public ReservationMaximumFramerate MaximumFramerate
        {
            get { return this._maximumFramerate; }
            set { this._maximumFramerate = value; }
        }

        // Check to see if MaximumFramerate property is set
        internal bool IsSetMaximumFramerate()
        {
            return this._maximumFramerate != null;
        }

        /// <summary>
        /// Gets and sets the property Resolution. Resolution, e.g. 'HD'
        /// </summary>
        public ReservationResolution Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. Resource type, 'INPUT', 'OUTPUT', 'MULTIPLEX',
        /// or 'CHANNEL'
        /// </summary>
        public ReservationResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SpecialFeature. Special feature, e.g. 'AUDIO_NORMALIZATION'
        /// (Channels only)
        /// </summary>
        public ReservationSpecialFeature SpecialFeature
        {
            get { return this._specialFeature; }
            set { this._specialFeature = value; }
        }

        // Check to see if SpecialFeature property is set
        internal bool IsSetSpecialFeature()
        {
            return this._specialFeature != null;
        }

        /// <summary>
        /// Gets and sets the property VideoQuality. Video quality, e.g. 'STANDARD' (Outputs only)
        /// </summary>
        public ReservationVideoQuality VideoQuality
        {
            get { return this._videoQuality; }
            set { this._videoQuality = value; }
        }

        // Check to see if VideoQuality property is set
        internal bool IsSetVideoQuality()
        {
            return this._videoQuality != null;
        }

    }
}