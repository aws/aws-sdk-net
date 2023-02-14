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
    /// EAC3.
    /// </summary>
    public partial class Eac3Settings
    {
        private Eac3AttenuationControl _attenuationControl;
        private int? _bitrate;
        private Eac3BitstreamMode _bitstreamMode;
        private Eac3CodingMode _codingMode;
        private Eac3DcFilter _dcFilter;
        private int? _dialnorm;
        private Eac3DynamicRangeCompressionLine _dynamicRangeCompressionLine;
        private Eac3DynamicRangeCompressionRf _dynamicRangeCompressionRf;
        private Eac3LfeControl _lfeControl;
        private Eac3LfeFilter _lfeFilter;
        private double? _loRoCenterMixLevel;
        private double? _loRoSurroundMixLevel;
        private double? _ltRtCenterMixLevel;
        private double? _ltRtSurroundMixLevel;
        private Eac3MetadataControl _metadataControl;
        private Eac3PassthroughControl _passthroughControl;
        private Eac3PhaseControl _phaseControl;
        private int? _sampleRate;
        private Eac3StereoDownmix _stereoDownmix;
        private Eac3SurroundExMode _surroundExMode;
        private Eac3SurroundMode _surroundMode;

        /// <summary>
        /// Gets and sets the property AttenuationControl. If set to ATTENUATE_3_DB, applies a
        /// 3 dB attenuation to the surround channels. Only used for 3/2 coding mode.
        /// </summary>
        public Eac3AttenuationControl AttenuationControl
        {
            get { return this._attenuationControl; }
            set { this._attenuationControl = value; }
        }

        // Check to see if AttenuationControl property is set
        internal bool IsSetAttenuationControl()
        {
            return this._attenuationControl != null;
        }

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// The bitrate that you specify must be a multiple of 8000 within the allowed minimum
        /// and maximum values. Leave blank to use the default bitrate for the coding mode you
        /// select according ETSI TS 102 366. Valid bitrates for coding mode 1/0: Default: 96000.
        /// Minimum: 32000. Maximum: 3024000. Valid bitrates for coding mode 2/0: Default: 192000.
        /// Minimum: 96000. Maximum: 3024000. Valid bitrates for coding mode 3/2: Default: 384000.
        /// Minimum: 192000. Maximum: 3024000.
        /// </summary>
        [AWSProperty(Min=32000, Max=3024000)]
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
        /// Gets and sets the property BitstreamMode. Specify the bitstream mode for the E-AC-3
        /// stream that the encoder emits. For more information about the EAC3 bitstream mode,
        /// see ATSC A/52-2012 (Annex E).
        /// </summary>
        public Eac3BitstreamMode BitstreamMode
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
        /// Gets and sets the property CodingMode. Dolby Digital Plus coding mode. Determines
        /// number of channels.
        /// </summary>
        public Eac3CodingMode CodingMode
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
        /// Gets and sets the property DcFilter. Activates a DC highpass filter for all input
        /// channels.
        /// </summary>
        public Eac3DcFilter DcFilter
        {
            get { return this._dcFilter; }
            set { this._dcFilter = value; }
        }

        // Check to see if DcFilter property is set
        internal bool IsSetDcFilter()
        {
            return this._dcFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. If blank and
        /// input audio is Dolby Digital Plus, dialnorm will be passed through.
        /// </summary>
        [AWSProperty(Min=1, Max=31)]
        public int Dialnorm
        {
            get { return this._dialnorm.GetValueOrDefault(); }
            set { this._dialnorm = value; }
        }

        // Check to see if Dialnorm property is set
        internal bool IsSetDialnorm()
        {
            return this._dialnorm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionLine. Choose the Dolby Digital dynamic
        /// range control (DRC) profile that MediaConvert uses when encoding the metadata in the
        /// Dolby Digital stream for the line operating mode. Related setting: When you use this
        /// setting, MediaConvert ignores any value you provide for Dynamic range compression
        /// profile (DynamicRangeCompressionProfile). For information about the Dolby Digital
        /// DRC operating modes and profiles, see the Dynamic Range Control chapter of the Dolby
        /// Metadata Guide at https://developer.dolby.com/globalassets/professional/documents/dolby-metadata-guide.pdf.
        /// </summary>
        public Eac3DynamicRangeCompressionLine DynamicRangeCompressionLine
        {
            get { return this._dynamicRangeCompressionLine; }
            set { this._dynamicRangeCompressionLine = value; }
        }

        // Check to see if DynamicRangeCompressionLine property is set
        internal bool IsSetDynamicRangeCompressionLine()
        {
            return this._dynamicRangeCompressionLine != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionRf. Choose the Dolby Digital dynamic
        /// range control (DRC) profile that MediaConvert uses when encoding the metadata in the
        /// Dolby Digital stream for the RF operating mode. Related setting: When you use this
        /// setting, MediaConvert ignores any value you provide for Dynamic range compression
        /// profile (DynamicRangeCompressionProfile). For information about the Dolby Digital
        /// DRC operating modes and profiles, see the Dynamic Range Control chapter of the Dolby
        /// Metadata Guide at https://developer.dolby.com/globalassets/professional/documents/dolby-metadata-guide.pdf.
        /// </summary>
        public Eac3DynamicRangeCompressionRf DynamicRangeCompressionRf
        {
            get { return this._dynamicRangeCompressionRf; }
            set { this._dynamicRangeCompressionRf = value; }
        }

        // Check to see if DynamicRangeCompressionRf property is set
        internal bool IsSetDynamicRangeCompressionRf()
        {
            return this._dynamicRangeCompressionRf != null;
        }

        /// <summary>
        /// Gets and sets the property LfeControl. When encoding 3/2 audio, controls whether the
        /// LFE channel is enabled
        /// </summary>
        public Eac3LfeControl LfeControl
        {
            get { return this._lfeControl; }
            set { this._lfeControl = value; }
        }

        // Check to see if LfeControl property is set
        internal bool IsSetLfeControl()
        {
            return this._lfeControl != null;
        }

        /// <summary>
        /// Gets and sets the property LfeFilter. Applies a 120Hz lowpass filter to the LFE channel
        /// prior to encoding. Only valid with 3_2_LFE coding mode.
        /// </summary>
        public Eac3LfeFilter LfeFilter
        {
            get { return this._lfeFilter; }
            set { this._lfeFilter = value; }
        }

        // Check to see if LfeFilter property is set
        internal bool IsSetLfeFilter()
        {
            return this._lfeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property LoRoCenterMixLevel. Specify a value for the following Dolby
        /// Digital Plus setting: Left only/Right only center mix (Lo/Ro center). MediaConvert
        /// uses this value for downmixing. How the service uses this value depends on the value
        /// that you choose for Stereo downmix (Eac3StereoDownmix). Valid values: 3.0, 1.5, 0.0,
        /// -1.5, -3.0, -4.5, -6.0, and -60. The value -60 mutes the channel. This setting applies
        /// only if you keep the default value of 3/2 - L, R, C, Ls, Rs (CODING_MODE_3_2) for
        /// the setting Coding mode (Eac3CodingMode). If you choose a different value for Coding
        /// mode, the service ignores Left only/Right only center (loRoCenterMixLevel).
        /// </summary>
        public double LoRoCenterMixLevel
        {
            get { return this._loRoCenterMixLevel.GetValueOrDefault(); }
            set { this._loRoCenterMixLevel = value; }
        }

        // Check to see if LoRoCenterMixLevel property is set
        internal bool IsSetLoRoCenterMixLevel()
        {
            return this._loRoCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoRoSurroundMixLevel. Specify a value for the following
        /// Dolby Digital Plus setting: Left only/Right only (Lo/Ro surround). MediaConvert uses
        /// this value for downmixing. How the service uses this value depends on the value that
        /// you choose for Stereo downmix (Eac3StereoDownmix). Valid values: -1.5, -3.0, -4.5,
        /// -6.0, and -60. The value -60 mutes the channel. This setting applies only if you keep
        /// the default value of 3/2 - L, R, C, Ls, Rs (CODING_MODE_3_2) for the setting Coding
        /// mode (Eac3CodingMode). If you choose a different value for Coding mode, the service
        /// ignores Left only/Right only surround (loRoSurroundMixLevel).
        /// </summary>
        public double LoRoSurroundMixLevel
        {
            get { return this._loRoSurroundMixLevel.GetValueOrDefault(); }
            set { this._loRoSurroundMixLevel = value; }
        }

        // Check to see if LoRoSurroundMixLevel property is set
        internal bool IsSetLoRoSurroundMixLevel()
        {
            return this._loRoSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtCenterMixLevel. Specify a value for the following Dolby
        /// Digital Plus setting: Left total/Right total center mix (Lt/Rt center). MediaConvert
        /// uses this value for downmixing. How the service uses this value depends on the value
        /// that you choose for Stereo downmix (Eac3StereoDownmix). Valid values: 3.0, 1.5, 0.0,
        /// -1.5, -3.0, -4.5, -6.0, and -60. The value -60 mutes the channel. This setting applies
        /// only if you keep the default value of 3/2 - L, R, C, Ls, Rs (CODING_MODE_3_2) for
        /// the setting Coding mode (Eac3CodingMode). If you choose a different value for Coding
        /// mode, the service ignores Left total/Right total center (ltRtCenterMixLevel).
        /// </summary>
        public double LtRtCenterMixLevel
        {
            get { return this._ltRtCenterMixLevel.GetValueOrDefault(); }
            set { this._ltRtCenterMixLevel = value; }
        }

        // Check to see if LtRtCenterMixLevel property is set
        internal bool IsSetLtRtCenterMixLevel()
        {
            return this._ltRtCenterMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LtRtSurroundMixLevel. Specify a value for the following
        /// Dolby Digital Plus setting: Left total/Right total surround mix (Lt/Rt surround).
        /// MediaConvert uses this value for downmixing. How the service uses this value depends
        /// on the value that you choose for Stereo downmix (Eac3StereoDownmix). Valid values:
        /// -1.5, -3.0, -4.5, -6.0, and -60. The value -60 mutes the channel. This setting applies
        /// only if you keep the default value of 3/2 - L, R, C, Ls, Rs (CODING_MODE_3_2) for
        /// the setting Coding mode (Eac3CodingMode). If you choose a different value for Coding
        /// mode, the service ignores Left total/Right total surround (ltRtSurroundMixLevel).
        /// </summary>
        public double LtRtSurroundMixLevel
        {
            get { return this._ltRtSurroundMixLevel.GetValueOrDefault(); }
            set { this._ltRtSurroundMixLevel = value; }
        }

        // Check to see if LtRtSurroundMixLevel property is set
        internal bool IsSetLtRtSurroundMixLevel()
        {
            return this._ltRtSurroundMixLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataControl. When set to FOLLOW_INPUT, encoder metadata
        /// will be sourced from the DD, DD+, or DolbyE decoder that supplied this audio data.
        /// If audio was not supplied from one of these streams, then the static metadata settings
        /// will be used.
        /// </summary>
        public Eac3MetadataControl MetadataControl
        {
            get { return this._metadataControl; }
            set { this._metadataControl = value; }
        }

        // Check to see if MetadataControl property is set
        internal bool IsSetMetadataControl()
        {
            return this._metadataControl != null;
        }

        /// <summary>
        /// Gets and sets the property PassthroughControl. When set to WHEN_POSSIBLE, input DD+
        /// audio will be passed through if it is present on the input. this detection is dynamic
        /// over the life of the transcode. Inputs that alternate between DD+ and non-DD+ content
        /// will have a consistent DD+ output as the system alternates between passthrough and
        /// encoding.
        /// </summary>
        public Eac3PassthroughControl PassthroughControl
        {
            get { return this._passthroughControl; }
            set { this._passthroughControl = value; }
        }

        // Check to see if PassthroughControl property is set
        internal bool IsSetPassthroughControl()
        {
            return this._passthroughControl != null;
        }

        /// <summary>
        /// Gets and sets the property PhaseControl. Controls the amount of phase-shift applied
        /// to the surround channels. Only used for 3/2 coding mode.
        /// </summary>
        public Eac3PhaseControl PhaseControl
        {
            get { return this._phaseControl; }
            set { this._phaseControl = value; }
        }

        // Check to see if PhaseControl property is set
        internal bool IsSetPhaseControl()
        {
            return this._phaseControl != null;
        }

        /// <summary>
        /// Gets and sets the property SampleRate. This value is always 48000. It represents the
        /// sample rate in Hz.
        /// </summary>
        [AWSProperty(Min=48000, Max=48000)]
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
        /// Gets and sets the property StereoDownmix. Choose how the service does stereo downmixing.
        /// This setting only applies if you keep the default value of 3/2 - L, R, C, Ls, Rs (CODING_MODE_3_2)
        /// for the setting Coding mode (Eac3CodingMode). If you choose a different value for
        /// Coding mode, the service ignores Stereo downmix (Eac3StereoDownmix).
        /// </summary>
        public Eac3StereoDownmix StereoDownmix
        {
            get { return this._stereoDownmix; }
            set { this._stereoDownmix = value; }
        }

        // Check to see if StereoDownmix property is set
        internal bool IsSetStereoDownmix()
        {
            return this._stereoDownmix != null;
        }

        /// <summary>
        /// Gets and sets the property SurroundExMode. When encoding 3/2 audio, sets whether an
        /// extra center back surround channel is matrix encoded into the left and right surround
        /// channels.
        /// </summary>
        public Eac3SurroundExMode SurroundExMode
        {
            get { return this._surroundExMode; }
            set { this._surroundExMode = value; }
        }

        // Check to see if SurroundExMode property is set
        internal bool IsSetSurroundExMode()
        {
            return this._surroundExMode != null;
        }

        /// <summary>
        /// Gets and sets the property SurroundMode. When encoding 2/0 audio, sets whether Dolby
        /// Surround is matrix encoded into the two channels.
        /// </summary>
        public Eac3SurroundMode SurroundMode
        {
            get { return this._surroundMode; }
            set { this._surroundMode = value; }
        }

        // Check to see if SurroundMode property is set
        internal bool IsSetSurroundMode()
        {
            return this._surroundMode != null;
        }

    }
}