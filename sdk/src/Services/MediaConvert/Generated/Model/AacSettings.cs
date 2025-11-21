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
    /// Required when you set Codec to the value AAC. The service accepts one of two mutually
    /// exclusive groups of AAC settings--VBR and CBR. To select one of these modes, set the
    /// value of Bitrate control mode to "VBR" or "CBR". In VBR mode, you control the audio
    /// quality with the setting VBR quality. In CBR mode, you use the setting Bitrate. Defaults
    /// and valid values depend on the rate control mode.
    /// </summary>
    public partial class AacSettings
    {
        private AacAudioDescriptionBroadcasterMix _audioDescriptionBroadcasterMix;
        private int? _bitrate;
        private AacCodecProfile _codecProfile;
        private AacCodingMode _codingMode;
        private AacLoudnessMeasurementMode _loudnessMeasurementMode;
        private int? _rapInterval;
        private AacRateControlMode _rateControlMode;
        private AacRawFormat _rawFormat;
        private int? _sampleRate;
        private AacSpecification _specification;
        private int? _targetLoudnessRange;
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
        /// you choose for Profile, Bitrate control mode, and Sample rate. Default values depend
        /// on Bitrate control mode and Profile.
        /// </summary>
        [AWSProperty(Min=6000, Max=1024000)]
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
        /// Gets and sets the property CodecProfile. Specify the AAC profile. For the widest player
        /// compatibility and where higher bitrates are acceptable: Keep the default profile,
        /// LC (AAC-LC) For improved audio performance at lower bitrates: Choose HEV1 or HEV2.
        /// HEV1 (AAC-HE v1) adds spectral band replication to improve speech audio at low bitrates.
        /// HEV2 (AAC-HE v2) adds parametric stereo, which optimizes for encoding stereo audio
        /// at very low bitrates. For improved audio quality at lower bitrates, adaptive audio
        /// bitrate switching, and loudness control: Choose XHE.
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
        /// Mono: One channel, C. * 2.0 Stereo: Two channels, L, R. * 5.1 Surround: Six channels,
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
        /// Gets and sets the property LoudnessMeasurementMode. Choose the loudness measurement
        /// mode for your audio content. For music or advertisements: We recommend that you keep
        /// the default value, Program. For speech or other content: We recommend that you choose
        /// Anchor. When you do, MediaConvert optimizes the loudness of your output for clarify
        /// by applying speech gates.
        /// </summary>
        public AacLoudnessMeasurementMode LoudnessMeasurementMode
        {
            get { return this._loudnessMeasurementMode; }
            set { this._loudnessMeasurementMode = value; }
        }

        // Check to see if LoudnessMeasurementMode property is set
        internal bool IsSetLoudnessMeasurementMode()
        {
            return this._loudnessMeasurementMode != null;
        }

        /// <summary>
        /// Gets and sets the property RapInterval. Specify the RAP (Random Access Point) interval
        /// for your xHE-AAC audio output. A RAP allows a decoder to decode audio data mid-stream,
        /// without the need to reference previous audio frames, and perform adaptive audio bitrate
        /// switching. To specify the RAP interval: Enter an integer from 2000 to 30000, in milliseconds.
        /// Smaller values allow for better seeking and more frequent stream switching, while
        /// large values improve compression efficiency. To have MediaConvert automatically determine
        /// the RAP interval: Leave blank.
        /// </summary>
        [AWSProperty(Min=2000, Max=30000)]
        public int? RapInterval
        {
            get { return this._rapInterval; }
            set { this._rapInterval = value; }
        }

        // Check to see if RapInterval property is set
        internal bool IsSetRapInterval()
        {
            return this._rapInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RateControlMode. Specify the AAC rate control mode. For
        /// a constant bitrate: Choose CBR. Your AAC output bitrate will be equal to the value
        /// that you choose for Bitrate. For a variable bitrate: Choose VBR. Your AAC output bitrate
        /// will vary according to your audio content and the value that you choose for Bitrate
        /// quality.
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
        /// Gets and sets the property SampleRate. Specify the AAC sample rate in samples per
        /// second (Hz). Valid sample rates depend on the AAC profile and Coding mode that you
        /// select. For a list of supported sample rates, see: https://docs.aws.amazon.com/mediaconvert/latest/ug/aac-support.html
        /// </summary>
        [AWSProperty(Min=8000, Max=96000)]
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
        /// Gets and sets the property TargetLoudnessRange. Specify the xHE-AAC loudness target.
        /// Enter an integer from 6 to 16, representing "loudness units". For more information,
        /// see the following specification: Supplementary information for R 128 EBU Tech 3342-2023.
        /// </summary>
        [AWSProperty(Min=6, Max=16)]
        public int? TargetLoudnessRange
        {
            get { return this._targetLoudnessRange; }
            set { this._targetLoudnessRange = value; }
        }

        // Check to see if TargetLoudnessRange property is set
        internal bool IsSetTargetLoudnessRange()
        {
            return this._targetLoudnessRange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VbrQuality. Specify the quality of your variable bitrate
        /// (VBR) AAC audio. For a list of approximate VBR bitrates, see: https://docs.aws.amazon.com/mediaconvert/latest/ug/aac-support.html#aac_vbr
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