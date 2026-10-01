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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set Codec to the value AC4.
    /// </summary>
    public partial class Ac4Settings
    {
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
        [AWSProperty(Min = 48000, Max = 768000)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BitstreamMode. Specify the bitstream mode for the AC-4
        /// stream that the encoder emits. For more information about the AC-4 bitstream mode,
        /// see ETSI TS 103 190. Maps to dlb_paec_ac4_bed_classifier in the encoder implementation.
        /// - COMPLETE_MAIN: Complete Main (standard mix) - EMERGENCY: Stereo Emergency content
        /// </summary>
        public Ac4BitstreamMode BitstreamMode { get; set; }

        /// <summary>
        /// Checks to see if the BitstreamMode property is set.
        /// </summary>
        internal bool IsSetBitstreamMode() => this.BitstreamMode != null;

        /// <summary>
        /// Gets and sets the property CodingMode. Dolby AC-4 coding mode. Determines number of
        /// channels. Maps to dlb_paec_ac4_bed_channel_config in the encoder implementation. -
        /// CODING_MODE_2_0: 2.0 (stereo) - maps to DLB_PAEC_AC4_BED_CHANNEL_CONFIG_20 - CODING_MODE_3_2_LFE:
        /// 5.1 surround - maps to DLB_PAEC_AC4_BED_CHANNEL_CONFIG_51 - CODING_MODE_5_1_4: 5.1.4
        /// immersive - maps to DLB_PAEC_AC4_BED_CHANNEL_CONFIG_514
        /// </summary>
        public Ac4CodingMode CodingMode { get; set; }

        /// <summary>
        /// Checks to see if the CodingMode property is set.
        /// </summary>
        internal bool IsSetCodingMode() => this.CodingMode != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionFlatPanelTv. Choose the Dolby AC-4
        /// dynamic range control (DRC) profile that MediaConvert uses when encoding the metadata
        /// in the Dolby AC-4 stream for the specified decoder mode. For information about the
        /// Dolby AC-4 DRC profiles, see the Dolby AC-4 specification.
        /// </summary>
        public Ac4DynamicRangeCompressionDrcProfile DynamicRangeCompressionFlatPanelTv { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionFlatPanelTv property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionFlatPanelTv() => this.DynamicRangeCompressionFlatPanelTv != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionHomeTheater. Choose the Dolby AC-4
        /// dynamic range control (DRC) profile that MediaConvert uses when encoding the metadata
        /// in the Dolby AC-4 stream for the specified decoder mode. For information about the
        /// Dolby AC-4 DRC profiles, see the Dolby AC-4 specification.
        /// </summary>
        public Ac4DynamicRangeCompressionDrcProfile DynamicRangeCompressionHomeTheater { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionHomeTheater property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionHomeTheater() => this.DynamicRangeCompressionHomeTheater != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionPortableHeadphones. Choose the Dolby
        /// AC-4 dynamic range control (DRC) profile that MediaConvert uses when encoding the
        /// metadata in the Dolby AC-4 stream for the specified decoder mode. For information
        /// about the Dolby AC-4 DRC profiles, see the Dolby AC-4 specification.
        /// </summary>
        public Ac4DynamicRangeCompressionDrcProfile DynamicRangeCompressionPortableHeadphones { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionPortableHeadphones property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionPortableHeadphones() => this.DynamicRangeCompressionPortableHeadphones != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionPortableSpeakers. Choose the Dolby
        /// AC-4 dynamic range control (DRC) profile that MediaConvert uses when encoding the
        /// metadata in the Dolby AC-4 stream for the specified decoder mode. For information
        /// about the Dolby AC-4 DRC profiles, see the Dolby AC-4 specification.
        /// </summary>
        public Ac4DynamicRangeCompressionDrcProfile DynamicRangeCompressionPortableSpeakers { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionPortableSpeakers property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionPortableSpeakers() => this.DynamicRangeCompressionPortableSpeakers != null;

        /// <summary>
        /// Gets and sets the property LoRoCenterMixLevel. Specify a value for the following Dolby
        /// AC-4 setting: Left only/Right only center mix. MediaConvert uses this value for downmixing.
        /// How the service uses this value depends on the value that you choose for Stereo downmix.
        /// Valid values: 3.0, 1.5, 0.0, -1.5, -3.0, -4.5, -6.0, and -infinity. The value -infinity
        /// mutes the channel. This setting applies only if you keep the default value of 3/2
        /// - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different value for
        /// Coding mode, the service ignores Left only/Right only center.
        /// </summary>
        public double? LoRoCenterMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoRoCenterMixLevel property is set.
        /// </summary>
        internal bool IsSetLoRoCenterMixLevel() => this.LoRoCenterMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LoRoSurroundMixLevel. Specify a value for the following
        /// Dolby AC-4 setting: Left only/Right only surround mix. MediaConvert uses this value
        /// for downmixing. How the service uses this value depends on the value that you choose
        /// for Stereo downmix. Valid values: -1.5, -3.0, -4.5, -6.0, and -infinity. The value
        /// -infinity mutes the channel. This setting applies only if you keep the default value
        /// of 3/2 - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different value
        /// for Coding mode, the service ignores Left only/Right only surround.
        /// </summary>
        public double? LoRoSurroundMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoRoSurroundMixLevel property is set.
        /// </summary>
        internal bool IsSetLoRoSurroundMixLevel() => this.LoRoSurroundMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LtRtCenterMixLevel. Specify a value for the following Dolby
        /// AC-4 setting: Left total/Right total center mix. MediaConvert uses this value for
        /// downmixing. How the service uses this value depends on the value that you choose for
        /// Stereo downmix. Valid values: 3.0, 1.5, 0.0, -1.5, -3.0, -4.5, -6.0, and -infinity.
        /// The value -infinity mutes the channel. This setting applies only if you keep the default
        /// value of 3/2 - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different
        /// value for Coding mode, the service ignores Left total/Right total center.
        /// </summary>
        public double? LtRtCenterMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LtRtCenterMixLevel property is set.
        /// </summary>
        internal bool IsSetLtRtCenterMixLevel() => this.LtRtCenterMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LtRtSurroundMixLevel. Specify a value for the following
        /// Dolby AC-4 setting: Left total/Right total surround mix. MediaConvert uses this value
        /// for downmixing. How the service uses this value depends on the value that you choose
        /// for Stereo downmix. Valid values: -1.5, -3.0, -4.5, -6.0, and -infinity. The value
        /// -infinity mutes the channel. This setting applies only if you keep the default value
        /// of 3/2 - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different value
        /// for Coding mode, the service ignores Left total/Right total surround.
        /// </summary>
        public double? LtRtSurroundMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LtRtSurroundMixLevel property is set.
        /// </summary>
        internal bool IsSetLtRtSurroundMixLevel() => this.LtRtSurroundMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property SampleRate. This value is always 48000. It represents the
        /// sample rate in Hz.
        /// </summary>
        [AWSProperty(Min = 48000, Max = 48000)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;

        /// <summary>
        /// Gets and sets the property StereoDownmix. Choose the preferred stereo downmix method.
        /// This setting tells the decoder how to downmix multi-channel audio to stereo during
        /// playback.
        /// </summary>
        public Ac4StereoDownmix StereoDownmix { get; set; }

        /// <summary>
        /// Checks to see if the StereoDownmix property is set.
        /// </summary>
        internal bool IsSetStereoDownmix() => this.StereoDownmix != null;
    }
}
