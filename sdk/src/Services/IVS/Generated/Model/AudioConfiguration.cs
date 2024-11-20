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
    /// Object specifying a stream’s audio configuration, as set up by the broadcaster (usually
    /// in an encoder). This is part of the <a>IngestConfigurations</a> object and the deprecated
    /// <a>IngestConfiguration</a> object. It is used for monitoring stream health.
    /// </summary>
    public partial class AudioConfiguration
    {
        private long? _channels;
        private string _codec;
        private long? _sampleRate;
        private long? _targetBitrate;
        private string _track;

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// Number of audio channels.
        /// </para>
        /// </summary>
        public long? Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// Codec used for the audio encoding.
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
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// Number of audio samples recorded per second.
        /// </para>
        /// </summary>
        public long? SampleRate
        {
            get { return this._sampleRate; }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate.HasValue; 
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
        /// Gets and sets the property Track. 
        /// <para>
        /// Name of the audio track (if the stream has an audio track). If multitrack is not enabled,
        /// this is track0 (the sole track).
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

    }
}