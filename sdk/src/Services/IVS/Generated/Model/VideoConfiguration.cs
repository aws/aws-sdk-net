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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
        private string _avcLevel;
        private string _avcProfile;
        private string _codec;
        private string _encoder;
        private string _level;
        private string _profile;
        private long? _targetBitrate;
        private long? _targetFramerate;
        private string _track;
        private long? _videoHeight;
        private long? _videoWidth;

        /// <summary>
        /// Gets and sets the property AvcLevel. 
        /// <para>
        /// Indicates the degree of required decoder performance for a profile. Normally this
        /// is set automatically by the encoder. For details, see the H.264 specification.
        /// </para>
        /// </summary>
        public string AvcLevel
        {
            get { return this._avcLevel; }
            set { this._avcLevel = value; }
        }

        // Check to see if AvcLevel property is set
        internal bool IsSetAvcLevel()
        {
            return this._avcLevel != null;
        }

        /// <summary>
        /// Gets and sets the property AvcProfile. 
        /// <para>
        /// Indicates to the decoder the requirements for decoding the stream. For definitions
        /// of the valid values, see the H.264 specification.
        /// </para>
        /// </summary>
        public string AvcProfile
        {
            get { return this._avcProfile; }
            set { this._avcProfile = value; }
        }

        // Check to see if AvcProfile property is set
        internal bool IsSetAvcProfile()
        {
            return this._avcProfile != null;
        }

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// Codec used for the video encoding.
        /// </para>
        /// </summary>
        public string Codec
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
        /// Gets and sets the property Encoder. 
        /// <para>
        /// Software or hardware used to encode the video.
        /// </para>
        /// </summary>
        public string Encoder
        {
            get { return this._encoder; }
            set { this._encoder = value; }
        }

        // Check to see if Encoder property is set
        internal bool IsSetEncoder()
        {
            return this._encoder != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// Indicates the degree of required decoder performance for a profile. Normally this
        /// is set automatically by the encoder. When an AVC codec is used, this field has the
        /// same value as <c>avcLevel</c>.
        /// </para>
        /// </summary>
        public string Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property Profile. 
        /// <para>
        /// Indicates to the decoder the requirements for decoding the stream. When an AVC codec
        /// is used, this field has the same value as <c>avcProfile</c>.
        /// </para>
        /// </summary>
        public string Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property TargetBitrate. 
        /// <para>
        /// The expected ingest bitrate (bits per second). This is configured in the encoder.
        /// </para>
        /// </summary>
        public long? TargetBitrate
        {
            get { return this._targetBitrate; }
            set { this._targetBitrate = value; }
        }

        // Check to see if TargetBitrate property is set
        internal bool IsSetTargetBitrate()
        {
            return this._targetBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetFramerate. 
        /// <para>
        /// The expected ingest framerate. This is configured in the encoder.
        /// </para>
        /// </summary>
        public long? TargetFramerate
        {
            get { return this._targetFramerate; }
            set { this._targetFramerate = value; }
        }

        // Check to see if TargetFramerate property is set
        internal bool IsSetTargetFramerate()
        {
            return this._targetFramerate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Track. 
        /// <para>
        /// Name of the video track. If multitrack is not enabled, this is track0 (the sole track).
        /// </para>
        /// </summary>
        public string Track
        {
            get { return this._track; }
            set { this._track = value; }
        }

        // Check to see if Track property is set
        internal bool IsSetTrack()
        {
            return this._track != null;
        }

        /// <summary>
        /// Gets and sets the property VideoHeight. 
        /// <para>
        /// Video-resolution height in pixels.
        /// </para>
        /// </summary>
        public long? VideoHeight
        {
            get { return this._videoHeight; }
            set { this._videoHeight = value; }
        }

        // Check to see if VideoHeight property is set
        internal bool IsSetVideoHeight()
        {
            return this._videoHeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VideoWidth. 
        /// <para>
        /// Video-resolution width in pixels.
        /// </para>
        /// </summary>
        public long? VideoWidth
        {
            get { return this._videoWidth; }
            set { this._videoWidth = value; }
        }

        // Check to see if VideoWidth property is set
        internal bool IsSetVideoWidth()
        {
            return this._videoWidth.HasValue; 
        }

    }
}