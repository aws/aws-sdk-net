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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Object specifying a stream’s video configuration, as set up by the broadcaster (usually
    /// in an encoder). This is part of the <a>IngestConfigurations</a> object and the deprecated
    /// <a>IngestConfiguration</a> object. It is used for monitoring stream health.
    /// </summary>
    public partial class VideoConfiguration
    {
        /// <summary>
        /// Gets and sets the property AvcLevel. 
        /// <para>
        /// (Deprecated) Indicates the degree of required decoder performance for a profile. Normally
        /// this is set automatically by the encoder. For details, see the H.264 specification.
        /// This is populated only when VideoConfiguration is part of the deprecated IngestConfiguration;
        /// otherwise, this is an empty string.
        /// </para>
        /// </summary>
        public string AvcLevel { get; set; }

        /// <summary>
        /// Checks to see if the AvcLevel property is set.
        /// </summary>
        internal bool IsSetAvcLevel() => this.AvcLevel != null;

        /// <summary>
        /// Gets and sets the property AvcProfile. 
        /// <para>
        /// (Deprecated) Indicates to the decoder the requirements for decoding the stream. For
        /// definitions of the valid values, see the H.264 specification. This is populated only
        /// when VideoConfiguration is part of the deprecated IngestConfiguration; otherwise,
        /// this is an empty string.
        /// </para>
        /// </summary>
        public string AvcProfile { get; set; }

        /// <summary>
        /// Checks to see if the AvcProfile property is set.
        /// </summary>
        internal bool IsSetAvcProfile() => this.AvcProfile != null;

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// Codec used for the video encoding.
        /// </para>
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property Encoder. 
        /// <para>
        /// Software or hardware used to encode the video.
        /// </para>
        /// </summary>
        public string Encoder { get; set; }

        /// <summary>
        /// Checks to see if the Encoder property is set.
        /// </summary>
        internal bool IsSetEncoder() => this.Encoder != null;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// Indicates the degree of required decoder performance for a profile. Normally this
        /// is set automatically by the encoder. When an AVC codec is used, this field has the
        /// same value as <c>avcLevel</c>.
        /// </para>
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property Profile. 
        /// <para>
        /// Indicates to the decoder the requirements for decoding the stream. When an AVC codec
        /// is used, this field has the same value as <c>avcProfile</c>.
        /// </para>
        /// </summary>
        public string Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;

        /// <summary>
        /// Gets and sets the property TargetBitrate. 
        /// <para>
        /// The expected ingest bitrate (bits per second). This is configured in the encoder.
        /// </para>
        /// </summary>
        public long? TargetBitrate { get; set; }

        /// <summary>
        /// Checks to see if the TargetBitrate property is set.
        /// </summary>
        internal bool IsSetTargetBitrate() => this.TargetBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property TargetFramerate. 
        /// <para>
        /// The expected ingest framerate. This is configured in the encoder.
        /// </para>
        /// </summary>
        public long? TargetFramerate { get; set; }

        /// <summary>
        /// Checks to see if the TargetFramerate property is set.
        /// </summary>
        internal bool IsSetTargetFramerate() => this.TargetFramerate.HasValue;

        /// <summary>
        /// Gets and sets the property Track. 
        /// <para>
        /// Name of the video track. If multitrack is not enabled, this is Track0 (the sole track).
        /// </para>
        /// </summary>
        public string Track { get; set; }

        /// <summary>
        /// Checks to see if the Track property is set.
        /// </summary>
        internal bool IsSetTrack() => this.Track != null;

        /// <summary>
        /// Gets and sets the property VideoHeight. 
        /// <para>
        /// Video-resolution height in pixels.
        /// </para>
        /// </summary>
        public long? VideoHeight { get; set; }

        /// <summary>
        /// Checks to see if the VideoHeight property is set.
        /// </summary>
        internal bool IsSetVideoHeight() => this.VideoHeight.HasValue;

        /// <summary>
        /// Gets and sets the property VideoWidth. 
        /// <para>
        /// Video-resolution width in pixels.
        /// </para>
        /// </summary>
        public long? VideoWidth { get; set; }

        /// <summary>
        /// Checks to see if the VideoWidth property is set.
        /// </summary>
        internal bool IsSetVideoWidth() => this.VideoWidth.HasValue;
    }
}
