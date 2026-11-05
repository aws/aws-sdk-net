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
    /// Ac3 Settings
    /// </summary>
    public partial class Ac3Settings
    {
        /// <summary>
        /// Gets and sets the property AttenuationControl. Applies a 3 dB attenuation to the surround
        /// channels. Applies only when the coding mode parameter is CODING_MODE_3_2_LFE.
        /// </summary>
        public Ac3AttenuationControl AttenuationControl { get; set; }

        /// <summary>
        /// Checks to see if the AttenuationControl property is set.
        /// </summary>
        internal bool IsSetAttenuationControl() => this.AttenuationControl != null;

        /// <summary>
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Valid bitrates
        /// depend on the coding mode.
        /// </summary>
        public double? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property BitstreamMode. Specifies the bitstream mode (bsmod) for
        /// the emitted AC-3 stream. See ATSC A/52-2012 for background on these values.
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
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. If excluded
        /// and input audio is Dolby Digital, dialnorm will be passed through.
        /// </summary>
        public int? Dialnorm { get; set; }

        /// <summary>
        /// Checks to see if the Dialnorm property is set.
        /// </summary>
        internal bool IsSetDialnorm() => this.Dialnorm.HasValue;

        /// <summary>
        /// Gets and sets the property DrcProfile. If set to filmStandard, adds dynamic range
        /// compression signaling to the output bitstream as defined in the Dolby Digital specification.
        /// </summary>
        public Ac3DrcProfile DrcProfile { get; set; }

        /// <summary>
        /// Checks to see if the DrcProfile property is set.
        /// </summary>
        internal bool IsSetDrcProfile() => this.DrcProfile != null;

        /// <summary>
        /// Gets and sets the property LfeFilter. When set to enabled, applies a 120Hz lowpass
        /// filter to the LFE channel prior to encoding. Only valid in codingMode32Lfe mode.
        /// </summary>
        public Ac3LfeFilter LfeFilter { get; set; }

        /// <summary>
        /// Checks to see if the LfeFilter property is set.
        /// </summary>
        internal bool IsSetLfeFilter() => this.LfeFilter != null;

        /// <summary>
        /// Gets and sets the property MetadataControl. When set to "followInput", encoder metadata
        /// will be sourced from the DD, DD+, or DolbyE decoder that supplied this audio data.
        /// If audio was not supplied from one of these streams, then the static metadata settings
        /// will be used.
        /// </summary>
        public Ac3MetadataControl MetadataControl { get; set; }

        /// <summary>
        /// Checks to see if the MetadataControl property is set.
        /// </summary>
        internal bool IsSetMetadataControl() => this.MetadataControl != null;
    }
}
