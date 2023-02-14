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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set (Codec) under (AudioDescriptions)>(CodecSettings) to the value
    /// AAC. The service accepts one of two mutually exclusive groups of AAC settings--VBR
    /// and CBR. To select one of these modes, set the value of Bitrate control mode (rateControlMode)
    /// to "VBR" or "CBR". In VBR mode, you control the audio quality with the setting VBR
    /// quality (vbrQuality). In CBR mode, you use the setting Bitrate (bitrate). Defaults
    /// and valid values depend on the rate control mode.
    /// </summary>
    public partial class AacSettings
    {
        private AacAudioDescriptionBroadcasterMix _audioDescriptionBroadcasterMix;
        private int? _bitrate;
        private AacCodecProfile _codecProfile;
        private AacCodingMode _codingMode;
        private AacRateControlMode _rateControlMode;
        private AacRawFormat _rawFormat;
        private int? _sampleRate;
        private AacSpecification _specification;
        private AacVbrQuality _vbrQuality;

        /// <summary>
        /// Gets and sets the property AudioDescriptionBroadcasterMix. Choose BROADCASTER_MIXED_AD
        /// when the input contains pre-mixed main audio + audio description (AD) as a stereo
        /// pair. The value for AudioType will be set to 3, which signals to downstream systems
        /// that this stream contains "broadcaster mixed AD". Note that the input received by
        /// the encoder must contain pre-mixed audio; the encoder does not perform the mixing.
        /// When you choose BROADCASTER_MIXED_AD, the encoder ignores any values you provide in
        /// AudioType and FollowInputAudioType. Choose NORMAL when the input does not contain
        /// pre-mixed audio + audio description (AD). In this case, the encoder will use any values
        /// you provide for AudioType and FollowInputAudioType.
        /// </summary>
        public AacAudioDescriptionBroadcasterMix AudioDescriptionBroadcasterMix
        {
            get { return this._audioDescriptionBroadcasterMix; }
            set { this._audioDescriptionBroadcasterMix = value; }
        }

        // Check to see if AudioDescriptionBroadcasterMix property is set
        internal bool IsSetAudioDescriptionBroadcasterMix()
        {
            return this._audioDescriptionBroadcasterMix != null;
        }

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// The set of valid values for this setting is: 6000, 8000, 10000, 12000, 14000, 16000,
        /// 20000, 24000, 28000, 32000, 40000, 48000, 56000, 64000, 80000, 96000, 112000, 128000,
        /// 160000, 192000, 224000, 256000, 288000, 320000, 384000, 448000, 512000, 576000, 640000,
        /// 768000, 896000, 1024000. The value you set is also constrained by the values that
        /// you choose for Profile (codecProfile), Bitrate control mode (codingMode), and Sample
        /// rate (sampleRate). Default values depend on Bitrate control mode and Profile.
        /// </summary>
        [AWSProperty(Min=6000, Max=1024000)]
        public int Bitrate
        {
            get { return this._bitrate.GetValueOrDefault(); }
            set { this._bitrate = value; }
        }

        // Check to see if Bitrate property is set
        internal bool IsSetBitrate()
        {
            return this._bitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodecProfile. AAC Profile.
        /// </summary>
        public AacCodecProfile CodecProfile
        {
            get { return this._codecProfile; }
            set { this._codecProfile = value; }
        }

        // Check to see if CodecProfile property is set
        internal bool IsSetCodecProfile()
        {
            return this._codecProfile != null;
        }

        /// <summary>
        /// Gets and sets the property CodingMode. The Coding mode that you specify determines
        /// the number of audio channels and the audio channel layout metadata in your AAC output.
        /// Valid coding modes depend on the Rate control mode and Profile that you select. The
        /// following list shows the number of audio channels and channel layout for each coding
        /// mode. * 1.0 Audio Description (Receiver Mix): One channel, C. Includes audio description
        /// data from your stereo input. For more information see ETSI TS 101 154 Annex E. * 1.0
        /// Mono: One channel, C. * 2.0 Stereo: Two channels, L, R. * 5.1 Surround: Five channels,
        /// C, L, R, Ls, Rs, LFE.
        /// </summary>
        public AacCodingMode CodingMode
        {
            get { return this._codingMode; }
            set { this._codingMode = value; }
        }

        // Check to see if CodingMode property is set
        internal bool IsSetCodingMode()
        {
            return this._codingMode != null;
        }

        /// <summary>
        /// Gets and sets the property RateControlMode. Rate Control Mode.
        /// </summary>
        public AacRateControlMode RateControlMode
        {
            get { return this._rateControlMode; }
            set { this._rateControlMode = value; }
        }

        // Check to see if RateControlMode property is set
        internal bool IsSetRateControlMode()
        {
            return this._rateControlMode != null;
        }

        /// <summary>
        /// Gets and sets the property RawFormat. Enables LATM/LOAS AAC output. Note that if you
        /// use LATM/LOAS AAC in an output, you must choose "No container" for the output container.
        /// </summary>
        public AacRawFormat RawFormat
        {
            get { return this._rawFormat; }
            set { this._rawFormat = value; }
        }

        // Check to see if RawFormat property is set
        internal bool IsSetRawFormat()
        {
            return this._rawFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SampleRate. Specify the Sample rate in Hz. Valid sample
        /// rates depend on the Profile and Coding mode that you select. The following list shows
        /// valid sample rates for each Profile and Coding mode. * LC Profile, Coding mode 1.0,
        /// 2.0, and Receiver Mix: 8000, 12000, 16000, 22050, 24000, 32000, 44100, 48000, 88200,
        /// 96000. * LC Profile, Coding mode 5.1: 32000, 44100, 48000, 96000. * HEV1 Profile,
        /// Coding mode 1.0 and Receiver Mix: 22050, 24000, 32000, 44100, 48000. * HEV1 Profile,
        /// Coding mode 2.0 and 5.1: 32000, 44100, 48000, 96000. * HEV2 Profile, Coding mode 2.0:
        /// 22050, 24000, 32000, 44100, 48000.
        /// </summary>
        [AWSProperty(Min=8000, Max=96000)]
        public int SampleRate
        {
            get { return this._sampleRate.GetValueOrDefault(); }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Specification. Use MPEG-2 AAC instead of MPEG-4 AAC audio
        /// for raw or MPEG-2 Transport Stream containers.
        /// </summary>
        public AacSpecification Specification
        {
            get { return this._specification; }
            set { this._specification = value; }
        }

        // Check to see if Specification property is set
        internal bool IsSetSpecification()
        {
            return this._specification != null;
        }

        /// <summary>
        /// Gets and sets the property VbrQuality. VBR Quality Level - Only used if rate_control_mode
        /// is VBR.
        /// </summary>
        public AacVbrQuality VbrQuality
        {
            get { return this._vbrQuality; }
            set { this._vbrQuality = value; }
        }

        // Check to see if VbrQuality property is set
        internal bool IsSetVbrQuality()
        {
            return this._vbrQuality != null;
        }

    }
}