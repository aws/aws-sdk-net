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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set Codec to the value MP2.
    /// </summary>
    public partial class Mp2Settings
    {
        private Mp2AudioDescriptionMix _audioDescriptionMix;
        private int? _bitrate;
        private int? _channels;
        private int? _sampleRate;

        /// <summary>
        /// Gets and sets the property AudioDescriptionMix. Choose BROADCASTER_MIXED_AD when the
        /// input contains pre-mixed main audio + audio description (AD) as a stereo pair. The
        /// value for AudioType will be set to 3, which signals to downstream systems that this
        /// stream contains "broadcaster mixed AD". Note that the input received by the encoder
        /// must contain pre-mixed audio; the encoder does not perform the mixing. When you choose
        /// BROADCASTER_MIXED_AD, the encoder ignores any values you provide in AudioType and
        /// FollowInputAudioType. Choose NONE when the input does not contain pre-mixed audio
        /// + audio description (AD). In this case, the encoder will use any values you provide
        /// for AudioType and FollowInputAudioType.
        /// </summary>
        public Mp2AudioDescriptionMix AudioDescriptionMix
        {
            get { return this._audioDescriptionMix; }
            set { this._audioDescriptionMix = value; }
        }

        // Check to see if AudioDescriptionMix property is set
        internal bool IsSetAudioDescriptionMix()
        {
            return this._audioDescriptionMix != null;
        }

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// </summary>
        [AWSProperty(Min=32000, Max=384000)]
        public int? Bitrate
        {
            get { return this._bitrate; }
            set { this._bitrate = value; }
        }

        // Check to see if Bitrate property is set
        internal bool IsSetBitrate()
        {
            return this._bitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Channels. Set Channels to specify the number of channels
        /// in this output audio track. Choosing Mono in will give you 1 output channel; choosing
        /// Stereo will give you 2. In the API, valid values are 1 and 2.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public int? Channels
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
        /// Gets and sets the property SampleRate. Sample rate in Hz.
        /// </summary>
        [AWSProperty(Min=32000, Max=48000)]
        public int? SampleRate
        {
            get { return this._sampleRate; }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate.HasValue; 
        }

    }
}