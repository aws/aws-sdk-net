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
    /// Required when you set Codec to the value AC4.
    /// </summary>
    public partial class Ac4Settings
    {
        private int? _bitrate;
        private Ac4BitstreamMode _bitstreamMode;
        private Ac4CodingMode _codingMode;
        private Ac4DynamicRangeCompressionDrcProfile _dynamicRangeCompressionFlatPanelTv;
        private Ac4DynamicRangeCompressionDrcProfile _dynamicRangeCompressionHomeTheater;
        private Ac4DynamicRangeCompressionDrcProfile _dynamicRangeCompressionPortableHeadphones;
        private Ac4DynamicRangeCompressionDrcProfile _dynamicRangeCompressionPortableSpeakers;
        private double? _loRoCenterMixLevel;
        private double? _loRoSurroundMixLevel;
        private double? _ltRtCenterMixLevel;
        private double? _ltRtSurroundMixLevel;
        private int? _sampleRate;
        private Ac4StereoDownmix _stereoDownmix;

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// Leave blank to use the default bitrate for the coding mode you select according to
        /// ETSI TS 103 190. Valid bitrates for coding mode 2.0 (stereo): 48000, 64000, 96000,
        /// 128000, 144000, 192000, 256000, 288000, 320000, 384000, 448000, 512000, or 768000.
        /// Valid bitrates for coding mode 5.1 (3/2 with LFE): 96000, 128000, 144000, 192000,
        /// 256000, 288000, 320000, 384000, 448000, 512000, or 768000. Valid bitrates for coding
        /// mode 5.1.4 (immersive): 192000, 256000, 288000, 320000, 384000, 448000, 512000, or
        /// 768000.
        /// </summary>
        [AWSProperty(Min=48000, Max=768000)]
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
        /// Gets and sets the property BitstreamMode. Specify the bitstream mode for the AC-4
        /// stream that the encoder emits. For more information about the AC-4 bitstream mode,
        /// see ETSI TS 103 190. Maps to dlb_paec_ac4_bed_classifier in the encoder implementation.
        /// - COMPLETE_MAIN: Complete Main (standard mix) - EMERGENCY: Stereo Emergency content
        /// </summary>
        public Ac4BitstreamMode BitstreamMode
        {
            get { return this._bitstreamMode; }
            set { this._bitstreamMode = value; }
        }

        // Check to see if BitstreamMode property is set
        internal bool IsSetBitstreamMode()
        {
            return this._bitstreamMode != null;
        }

        /// <summary>
        /// Gets and sets the property CodingMode. Dolby AC-4 coding mode. Determines number of
        /// channels. Maps to dlb_paec_ac4_bed_channel_config in the encoder implementation. -
        /// CODING_MODE_2_0: 2.0 (stereo) - maps to DLB_PAEC_AC4_BED_CHANNEL_CONFIG_20   - CODING_MODE_3_2_LFE:
        /// 5.1 surround - maps to DLB_PAEC_AC4_BED_CHANNEL_CONFIG_51 - CODING_MODE_5_1_4: 5.1.4
        /// immersive - maps to DLB_PAEC_AC4_BED_CHANNEL_CONFIG_514
        /// </summary>
        public Ac4CodingMode CodingMode
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
        /// Gets and sets the property DynamicRangeCompressionFlatPanelTv. Choose the Dolby AC-4
        /// dynamic range control (DRC) profile that MediaConvert uses when encoding the metadata
        /// in the Dolby AC-4 stream for the specified decoder mode. For information about the
        /// Dolby AC-4 DRC profiles, see the Dolby AC-4 specification.
        /// </summary>
        public Ac4DynamicRangeCompressionDrcProfile DynamicRangeCompressionFlatPanelTv
        {
            get { return this._dynamicRangeCompressionFlatPanelTv; }
            set { this._dynamicRangeCompressionFlatPanelTv = value; }
        }

        // Check to see if DynamicRangeCompressionFlatPanelTv property is set
        internal bool IsSetDynamicRangeCompressionFlatPanelTv()
        {
            return this._dynamicRangeCompressionFlatPanelTv != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionHomeTheater. Choose the Dolby AC-4
        /// dynamic range control (DRC) profile that MediaConvert uses when encoding the metadata
        /// in the Dolby AC-4 stream for the specified decoder mode. For information about the
        /// Dolby AC-4 DRC profiles, see the Dolby AC-4 specification.
        /// </summary>
        public Ac4DynamicRangeCompressionDrcProfile DynamicRangeCompressionHomeTheater
        {
            get { return this._dynamicRangeCompressionHomeTheater; }
            set { this._dynamicRangeCompressionHomeTheater = value; }
        }

        // Check to see if DynamicRangeCompressionHomeTheater property is set
        internal bool IsSetDynamicRangeCompressionHomeTheater()
        {
            return this._dynamicRangeCompressionHomeTheater != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionPortableHeadphones. Choose the Dolby
        /// AC-4 dynamic range control (DRC) profile that MediaConvert uses when encoding the
        /// metadata in the Dolby AC-4 stream for the specified decoder mode. For information
        /// about the Dolby AC-4 DRC profiles, see the Dolby AC-4 specification.
        /// </summary>
        public Ac4DynamicRangeCompressionDrcProfile DynamicRangeCompressionPortableHeadphones
        {
            get { return this._dynamicRangeCompressionPortableHeadphones; }
            set { this._dynamicRangeCompressionPortableHeadphones = value; }
        }

        // Check to see if DynamicRangeCompressionPortableHeadphones property is set
        internal bool IsSetDynamicRangeCompressionPortableHeadphones()
        {
            return this._dynamicRangeCompressionPortableHeadphones != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionPortableSpeakers. Choose the Dolby
        /// AC-4 dynamic range control (DRC) profile that MediaConvert uses when encoding the
        /// metadata in the Dolby AC-4 stream for the specified decoder mode. For information
        /// about the Dolby AC-4 DRC profiles, see the Dolby AC-4 specification.
        /// </summary>
        public Ac4DynamicRangeCompressionDrcProfile DynamicRangeCompressionPortableSpeakers
        {
            get { return this._dynamicRangeCompressionPortableSpeakers; }
            set { this._dynamicRangeCompressionPortableSpeakers = value; }
        }

        // Check to see if DynamicRangeCompressionPortableSpeakers property is set
        internal bool IsSetDynamicRangeCompressionPortableSpeakers()
        {
            return this._dynamicRangeCompressionPortableSpeakers != null;
        }

        /// <summary>
        /// Gets and sets the property LoRoCenterMixLevel. Specify a value for the following Dolby
        /// AC-4 setting: Left only/Right only center mix. MediaConvert uses this value for downmixing.
        /// How the service uses this value depends on the value that you choose for Stereo downmix.
        /// Valid values: 3.0, 1.5, 0.0, -1.5, -3.0, -4.5, -6.0, and -infinity. The value -infinity
        /// mutes the channel. This setting applies only if you keep the default value of 3/2
        /// - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different value for
        /// Coding mode, the service ignores Left only/Right only center.
        /// </summary>
        public double? LoRoCenterMixLevel
        {
            get { return this._loRoCenterMixLevel; }
            set { this._loRoCenterMixLevel = value; }
        }

        // Check to see if LoRoCenterMixLevel property is set
        internal bool IsSetLoRoCenterMixLevel()
        {
            return this._loRoCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoRoSurroundMixLevel. Specify a value for the following
        /// Dolby AC-4 setting: Left only/Right only surround mix. MediaConvert uses this value
        /// for downmixing. How the service uses this value depends on the value that you choose
        /// for Stereo downmix. Valid values: -1.5, -3.0, -4.5, -6.0, and -infinity. The value
        /// -infinity mutes the channel. This setting applies only if you keep the default value
        /// of 3/2 - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different value
        /// for Coding mode, the service ignores Left only/Right only surround.
        /// </summary>
        public double? LoRoSurroundMixLevel
        {
            get { return this._loRoSurroundMixLevel; }
            set { this._loRoSurroundMixLevel = value; }
        }

        // Check to see if LoRoSurroundMixLevel property is set
        internal bool IsSetLoRoSurroundMixLevel()
        {
            return this._loRoSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtCenterMixLevel. Specify a value for the following Dolby
        /// AC-4 setting: Left total/Right total center mix. MediaConvert uses this value for
        /// downmixing. How the service uses this value depends on the value that you choose for
        /// Stereo downmix. Valid values: 3.0, 1.5, 0.0, -1.5, -3.0, -4.5, -6.0, and -infinity.
        /// The value -infinity mutes the channel. This setting applies only if you keep the default
        /// value of 3/2 - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different
        /// value for Coding mode, the service ignores Left total/Right total center.
        /// </summary>
        public double? LtRtCenterMixLevel
        {
            get { return this._ltRtCenterMixLevel; }
            set { this._ltRtCenterMixLevel = value; }
        }

        // Check to see if LtRtCenterMixLevel property is set
        internal bool IsSetLtRtCenterMixLevel()
        {
            return this._ltRtCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtSurroundMixLevel. Specify a value for the following
        /// Dolby AC-4 setting: Left total/Right total surround mix. MediaConvert uses this value
        /// for downmixing. How the service uses this value depends on the value that you choose
        /// for Stereo downmix. Valid values: -1.5, -3.0, -4.5, -6.0, and -infinity. The value
        /// -infinity mutes the channel. This setting applies only if you keep the default value
        /// of 3/2 - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different value
        /// for Coding mode, the service ignores Left total/Right total surround.
        /// </summary>
        public double? LtRtSurroundMixLevel
        {
            get { return this._ltRtSurroundMixLevel; }
            set { this._ltRtSurroundMixLevel = value; }
        }

        // Check to see if LtRtSurroundMixLevel property is set
        internal bool IsSetLtRtSurroundMixLevel()
        {
            return this._ltRtSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleRate. This value is always 48000. It represents the
        /// sample rate in Hz.
        /// </summary>
        [AWSProperty(Min=48000, Max=48000)]
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
        /// Gets and sets the property StereoDownmix. Choose the preferred stereo downmix method.
        /// This setting tells the decoder how to downmix multi-channel audio to stereo during
        /// playback.
        /// </summary>
        public Ac4StereoDownmix StereoDownmix
        {
            get { return this._stereoDownmix; }
            set { this._stereoDownmix = value; }
        }

        // Check to see if StereoDownmix property is set
        internal bool IsSetStereoDownmix()
        {
            return this._stereoDownmix != null;
        }

    }
}