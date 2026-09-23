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
    /// Object specifying a stream’s audio configuration, as set up by the broadcaster (usually
    /// in an encoder). This is part of the <a>IngestConfigurations</a> object and the deprecated
    /// <a>IngestConfiguration</a> object. It is used for monitoring stream health.
    /// </summary>
    public partial class AudioConfiguration
    {
        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// Number of audio channels.
        /// </para>
        /// </summary>
        public long? Channels { get; set; }

        /// <summary>
        /// Checks to see if the Channels property is set.
        /// </summary>
        internal bool IsSetChannels() => this.Channels.HasValue;

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// Codec used for the audio encoding.
        /// </para>
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// Number of audio samples recorded per second.
        /// </para>
        /// </summary>
        public long? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;

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
        /// Gets and sets the property Track. 
        /// <para>
        /// Name of the audio track (if the stream has an audio track). If multitrack is not enabled,
        /// this is Track0 (the sole track).
        /// </para>
        /// </summary>
        public string Track { get; set; }

        /// <summary>
        /// Checks to see if the Track property is set.
        /// </summary>
        internal bool IsSetTrack() => this.Track != null;
    }
}
