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
    /// Required when you set Codec to the value AC3.
    /// </summary>
    public partial class Ac3Settings
    {
        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// The bitrate that you specify must be a multiple of 8000 within the allowed minimum
        /// and maximum values. Leave blank to use the default bitrate for the coding mode you
        /// select according ETSI TS 102 366. Valid bitrates for coding mode 1/0: Default: 96000.
        /// Minimum: 64000. Maximum: 128000. Valid bitrates for coding mode 1/1: Default: 192000.
        /// Minimum: 128000. Maximum: 384000. Valid bitrates for coding mode 2/0: Default: 192000.
        /// Minimum: 128000. Maximum: 384000. Valid bitrates for coding mode 3/2 with FLE: Default:
        /// 384000. Minimum: 384000. Maximum: 640000.
        /// </summary>
        [AWSProperty(Min = 64000, Max = 640000)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BitstreamMode. Specify the bitstream mode for the AC-3
        /// stream that the encoder emits. For more information about the AC3 bitstream mode,
        /// see ATSC A/52-2012 (Annex E).
        /// </summary>
        public Ac3BitstreamMode BitstreamMode { get; set; }

        /// <summary>
        /// Checks to see if the BitstreamMode property is set.
        /// </summary>
        internal bool IsSetBitstreamMode() => this.BitstreamMode != null;

        /// <summary>
        /// Gets and sets the property CodingMode. Dolby Digital coding mode. Determines number
        /// of channels.
        /// </summary>
        public Ac3CodingMode CodingMode { get; set; }

        /// <summary>
        /// Checks to see if the CodingMode property is set.
        /// </summary>
        internal bool IsSetCodingMode() => this.CodingMode != null;

        /// <summary>
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. If blank and
        /// input audio is Dolby Digital, dialnorm will be passed through.
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
        public Ac3DynamicRangeCompressionLine DynamicRangeCompressionLine { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionLine property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionLine() => this.DynamicRangeCompressionLine != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionProfile. When you want to add Dolby
        /// dynamic range compression (DRC) signaling to your output stream, we recommend that
        /// you use the mode-specific settings instead of Dynamic range compression profile. The
        /// mode-specific settings are Dynamic range compression profile, line mode and Dynamic
        /// range compression profile, RF mode. Note that when you specify values for all three
        /// settings, MediaConvert ignores the value of this setting in favor of the mode-specific
        /// settings. If you do use this setting instead of the mode-specific settings, choose
        /// None to leave out DRC signaling. Keep the default Film standard to set the profile
        /// to Dolby's film standard profile for all operating modes.
        /// </summary>
        public Ac3DynamicRangeCompressionProfile DynamicRangeCompressionProfile { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionProfile property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionProfile() => this.DynamicRangeCompressionProfile != null;

        /// <summary>
        /// Gets and sets the property DynamicRangeCompressionRf. Choose the Dolby Digital dynamic
        /// range control (DRC) profile that MediaConvert uses when encoding the metadata in the
        /// Dolby Digital stream for the RF operating mode. Related setting: When you use this
        /// setting, MediaConvert ignores any value you provide for Dynamic range compression
        /// profile. For information about the Dolby Digital DRC operating modes and profiles,
        /// see the Dynamic Range Control chapter of the Dolby Metadata Guide at https://developer.dolby.com/globalassets/professional/documents/dolby-metadata-guide.pdf.
        /// </summary>
        public Ac3DynamicRangeCompressionRf DynamicRangeCompressionRf { get; set; }

        /// <summary>
        /// Checks to see if the DynamicRangeCompressionRf property is set.
        /// </summary>
        internal bool IsSetDynamicRangeCompressionRf() => this.DynamicRangeCompressionRf != null;

        /// <summary>
        /// Gets and sets the property LfeFilter. Applies a 120Hz lowpass filter to the LFE channel
        /// prior to encoding. Only valid with 3_2_LFE coding mode.
        /// </summary>
        public Ac3LfeFilter LfeFilter { get; set; }

        /// <summary>
        /// Checks to see if the LfeFilter property is set.
        /// </summary>
        internal bool IsSetLfeFilter() => this.LfeFilter != null;

        /// <summary>
        /// Gets and sets the property MetadataControl. When set to FOLLOW_INPUT, encoder metadata
        /// will be sourced from the DD, DD+, or DolbyE decoder that supplied this audio data.
        /// If audio was not supplied from one of these streams, then the static metadata settings
        /// will be used.
        /// </summary>
        public Ac3MetadataControl MetadataControl { get; set; }

        /// <summary>
        /// Checks to see if the MetadataControl property is set.
        /// </summary>
        internal bool IsSetMetadataControl() => this.MetadataControl != null;

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
    }
}
