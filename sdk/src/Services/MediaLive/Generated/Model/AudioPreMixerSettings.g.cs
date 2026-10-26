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
    /// Audio pre-mixer settings for normalizing audio before interleaving. These settings
    /// can be applied to individual PIDs or tracks before they are combined.
    /// </summary>
    public partial class AudioPreMixerSettings
    {
        /// <summary>
        /// Gets and sets the property AudioNormalizationSettings. Audio normalization settings
        /// for loudness control. When specified, audio loudness will be normalized according
        /// to the chosen algorithm.
        /// </summary>
        public AudioNormalizationSettings AudioNormalizationSettings { get; set; }

        /// <summary>
        /// Checks to see if the AudioNormalizationSettings property is set.
        /// </summary>
        internal bool IsSetAudioNormalizationSettings() => this.AudioNormalizationSettings != null;

        /// <summary>
        /// Gets and sets the property Channels. Number of audio channels. If specified, the audio
        /// will be remixed to match this channel count. Ignored if remixSettings is specified.
        /// </summary>
        public int? Channels { get; set; }

        /// <summary>
        /// Checks to see if the Channels property is set.
        /// </summary>
        internal bool IsSetChannels() => this.Channels.HasValue;

        /// <summary>
        /// Gets and sets the property GainDb. Gain adjustment in dB to apply. Range: -60 to +60
        /// dB
        /// </summary>
        public double? GainDb { get; set; }

        /// <summary>
        /// Checks to see if the GainDb property is set.
        /// </summary>
        internal bool IsSetGainDb() => this.GainDb.HasValue;

        /// <summary>
        /// Gets and sets the property RemixSettings. Settings that control how input audio channels
        /// are remixed. When specified, allows fine-grained control over channel mapping and
        /// gain levels. Takes precedence over the 'channels' setting.
        /// </summary>
        public RemixSettings RemixSettings { get; set; }

        /// <summary>
        /// Checks to see if the RemixSettings property is set.
        /// </summary>
        internal bool IsSetRemixSettings() => this.RemixSettings != null;
    }
}
