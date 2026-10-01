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
    /// Required when you set Codec to the value EAC3.
    /// </summary>
    public partial class Eac3Settings
    {
        /// <summary>
        /// Gets and sets the property AttenuationControl. If set to ATTENUATE_3_DB, applies a
        /// 3 dB attenuation to the surround channels. Only used for 3/2 coding mode.
        /// </summary>
        public Eac3AttenuationControl AttenuationControl { get; set; }

        /// <summary>
        /// Checks to see if the AttenuationControl property is set.
        /// </summary>
        internal bool IsSetAttenuationControl() => this.AttenuationControl != null;

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// The bitrate that you specify must be a multiple of 8000 within the allowed minimum
        /// and maximum values. Leave blank to use the default bitrate for the coding mode you
        /// select according ETSI TS 102 366. Valid bitrates for coding mode 1/0: Default: 96000.
        /// Minimum: 32000. Maximum: 3024000. Valid bitrates for coding mode 2/0: Default: 192000.
        /// Minimum: 96000. Maximum: 3024000. Valid bitrates for coding mode 3/2: Default: 384000.
        /// Minimum: 192000. Maximum: 3024000.
        /// </summary>
        [AWSProperty(Min = 32000, Max = 3024000)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BitstreamMode. Specify the bitstream mode for the E-AC-3
        /// stream that the encoder emits. For more information about the EAC3 bitstream mode,
        /// see ATSC A/52-2012 (Annex E).
        /// </summary>
        public Eac3BitstreamMode BitstreamMode { get; set; }

        /// <summary>
        /// Checks to see if the BitstreamMode property is set.
        /// </summary>
        internal bool IsSetBitstreamMode() => this.BitstreamMode != null;

        /// <summary>
        /// Gets and sets the property CodingMode. Dolby Digital Plus coding mode. Determines
        /// number of channels.
        /// </summary>
        public Eac3CodingMode CodingMode { get; set; }

        /// <summary>
        /// Checks to see if the CodingMode property is set.
        /// </summary>
        internal bool IsSetCodingMode() => this.CodingMode != null;

        /// <summary>
        /// Gets and sets the property DcFilter. Activates a DC highpass filter for all input
        /// channels.
        /// </summary>
        public Eac3DcFilter DcFilter { get; set; }

        /// <summary>
        /// Checks to see if the DcFilter property is set.
        /// </summary>
        internal bool IsSetDcFilter() => this.DcFilter != null;

        /// <summary>
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. If blank and
        /// input audio is Dolby Digital Plus, dialnorm will be passed through.
        /// </summary>
        [AWSProperty(Min = 1, Max = 31)]
        public int? Dialnorm { get; set; }

        /// <summary>
        /// Checks to see if the Dialnorm property is set.
        /// </summary>
        internal bool IsSetDialnorm() => this.Dialnorm.HasValue;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionLine. Choose the Dolby Digital dynamic
        /// range control (DRC) profile that MediaConvert uses when encoding the metadata in the
        /// Dolby Digital stream for the line operating mode. Related setting: When you use this
        /// setting, MediaConvert ignores any value you provide for Dynamic range compression
        /// profile. For information about the Dolby Digital DRC operating modes and profiles,
        /// see the Dynamic Range Control chapter of the Dolby Metadata Guide at https://developer.dolby.com/globalassets/professional/documents/dolby-metadata-guide.pdf.
        /// </summary>
        public Eac3DynamicRangeCompressionLine DynamicRangeCompressionLine { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionLine property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionLine() => this.DynamicRangeCompressionLine != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionRf. Choose the Dolby Digital dynamic
        /// range control (DRC) profile that MediaConvert uses when encoding the metadata in the
        /// Dolby Digital stream for the RF operating mode. Related setting: When you use this
        /// setting, MediaConvert ignores any value you provide for Dynamic range compression
        /// profile. For information about the Dolby Digital DRC operating modes and profiles,
        /// see the Dynamic Range Control chapter of the Dolby Metadata Guide at https://developer.dolby.com/globalassets/professional/documents/dolby-metadata-guide.pdf.
        /// </summary>
        public Eac3DynamicRangeCompressionRf DynamicRangeCompressionRf { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionRf property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionRf() => this.DynamicRangeCompressionRf != null;

        /// <summary>
        /// Gets and sets the property LfeControl. When encoding 3/2 audio, controls whether the
        /// LFE channel is enabled
        /// </summary>
        public Eac3LfeControl LfeControl { get; set; }

        /// <summary>
        /// Checks to see if the LfeControl property is set.
        /// </summary>
        internal bool IsSetLfeControl() => this.LfeControl != null;

        /// <summary>
        /// Gets and sets the property LfeFilter. Applies a 120Hz lowpass filter to the LFE channel
        /// prior to encoding. Only valid with 3_2_LFE coding mode.
        /// </summary>
        public Eac3LfeFilter LfeFilter { get; set; }

        /// <summary>
        /// Checks to see if the LfeFilter property is set.
        /// </summary>
        internal bool IsSetLfeFilter() => this.LfeFilter != null;

        /// <summary>
        /// Gets and sets the property LoRoCenterMixLevel. Specify a value for the following Dolby
        /// Digital Plus setting: Left only/Right only center mix. MediaConvert uses this value
        /// for downmixing. How the service uses this value depends on the value that you choose
        /// for Stereo downmix. Valid values: 3.0, 1.5, 0.0, -1.5, -3.0, -4.5, -6.0, and -60.
        /// The value -60 mutes the channel. This setting applies only if you keep the default
        /// value of 3/2 - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different
        /// value for Coding mode, the service ignores Left only/Right only center.
        /// </summary>
        public double? LoRoCenterMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoRoCenterMixLevel property is set.
        /// </summary>
        internal bool IsSetLoRoCenterMixLevel() => this.LoRoCenterMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LoRoSurroundMixLevel. Specify a value for the following
        /// Dolby Digital Plus setting: Left only/Right only. MediaConvert uses this value for
        /// downmixing. How the service uses this value depends on the value that you choose for
        /// Stereo downmix. Valid values: -1.5, -3.0, -4.5, -6.0, and -60. The value -60 mutes
        /// the channel. This setting applies only if you keep the default value of 3/2 - L, R,
        /// C, Ls, Rs for the setting Coding mode. If you choose a different value for Coding
        /// mode, the service ignores Left only/Right only surround.
        /// </summary>
        public double? LoRoSurroundMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoRoSurroundMixLevel property is set.
        /// </summary>
        internal bool IsSetLoRoSurroundMixLevel() => this.LoRoSurroundMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LtRtCenterMixLevel. Specify a value for the following Dolby
        /// Digital Plus setting: Left total/Right total center mix. MediaConvert uses this value
        /// for downmixing. How the service uses this value depends on the value that you choose
        /// for Stereo downmix. Valid values: 3.0, 1.5, 0.0, -1.5, -3.0, -4.5, -6.0, and -60.
        /// The value -60 mutes the channel. This setting applies only if you keep the default
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
        /// Dolby Digital Plus setting: Left total/Right total surround mix. MediaConvert uses
        /// this value for downmixing. How the service uses this value depends on the value that
        /// you choose for Stereo downmix. Valid values: -1.5, -3.0, -4.5, -6.0, and -60. The
        /// value -60 mutes the channel. This setting applies only if you keep the default value
        /// of 3/2 - L, R, C, Ls, Rs for the setting Coding mode. If you choose a different value
        /// for Coding mode, the service ignores Left total/Right total surround.
        /// </summary>
        public double? LtRtSurroundMixLevel { get; set; }

        /// <summary>
        /// Checks to see if the LtRtSurroundMixLevel property is set.
        /// </summary>
        internal bool IsSetLtRtSurroundMixLevel() => this.LtRtSurroundMixLevel.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataControl. When set to FOLLOW_INPUT, encoder metadata
        /// will be sourced from the DD, DD+, or DolbyE decoder that supplied this audio data.
        /// If audio was not supplied from one of these streams, then the static metadata settings
        /// will be used.
        /// </summary>
        public Eac3MetadataControl MetadataControl { get; set; }

        /// <summary>
        /// Checks to see if the MetadataControl property is set.
        /// </summary>
        internal bool IsSetMetadataControl() => this.MetadataControl != null;

        /// <summary>
        /// Gets and sets the property PassthroughControl. When set to WHEN_POSSIBLE, input DD+
        /// audio will be passed through if it is present on the input. this detection is dynamic
        /// over the life of the transcode. Inputs that alternate between DD+ and non-DD+ content
        /// will have a consistent DD+ output as the system alternates between passthrough and
        /// encoding.
        /// </summary>
        public Eac3PassthroughControl PassthroughControl { get; set; }

        /// <summary>
        /// Checks to see if the PassthroughControl property is set.
        /// </summary>
        internal bool IsSetPassthroughControl() => this.PassthroughControl != null;

        /// <summary>
        /// Gets and sets the property PhaseControl. Controls the amount of phase-shift applied
        /// to the surround channels. Only used for 3/2 coding mode.
        /// </summary>
        public Eac3PhaseControl PhaseControl { get; set; }

        /// <summary>
        /// Checks to see if the PhaseControl property is set.
        /// </summary>
        internal bool IsSetPhaseControl() => this.PhaseControl != null;

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
        /// Gets and sets the property StereoDownmix. Choose how the service does stereo downmixing.
        /// This setting only applies if you keep the default value of 3/2 - L, R, C, Ls, Rs for
        /// the setting Coding mode. If you choose a different value for Coding mode, the service
        /// ignores Stereo downmix.
        /// </summary>
        public Eac3StereoDownmix StereoDownmix { get; set; }

        /// <summary>
        /// Checks to see if the StereoDownmix property is set.
        /// </summary>
        internal bool IsSetStereoDownmix() => this.StereoDownmix != null;

        /// <summary>
        /// Gets and sets the property SurroundExMode. When encoding 3/2 audio, sets whether an
        /// extra center back surround channel is matrix encoded into the left and right surround
        /// channels.
        /// </summary>
        public Eac3SurroundExMode SurroundExMode { get; set; }

        /// <summary>
        /// Checks to see if the SurroundExMode property is set.
        /// </summary>
        internal bool IsSetSurroundExMode() => this.SurroundExMode != null;

        /// <summary>
        /// Gets and sets the property SurroundMode. When encoding 2/0 audio, sets whether Dolby
        /// Surround is matrix encoded into the two channels.
        /// </summary>
        public Eac3SurroundMode SurroundMode { get; set; }

        /// <summary>
        /// Checks to see if the SurroundMode property is set.
        /// </summary>
        internal bool IsSetSurroundMode() => this.SurroundMode != null;
    }
}
