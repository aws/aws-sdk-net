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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private Ac3AttenuationControl _attenuationControl;
        private double? _bitrate;
        private Ac3BitstreamMode _bitstreamMode;
        private Ac3CodingMode _codingMode;
        private int? _dialnorm;
        private Ac3DrcProfile _drcProfile;
        private Ac3LfeFilter _lfeFilter;
        private Ac3MetadataControl _metadataControl;

        /// <summary>
        /// Gets and sets the property AttenuationControl. Applies a 3 dB attenuation to the surround
        /// channels. Applies only when the coding mode parameter is CODING_MODE_3_2_LFE.
        /// </summary>
        public Ac3AttenuationControl AttenuationControl
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
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Valid bitrates
        /// depend on the coding mode.
        /// </summary>
        public double? Bitrate
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
        /// Gets and sets the property BitstreamMode. Specifies the bitstream mode (bsmod) for
        /// the emitted AC-3 stream. See ATSC A/52-2012 for background on these values.
        /// </summary>
        public Ac3BitstreamMode BitstreamMode
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
        /// Gets and sets the property CodingMode. Dolby Digital coding mode. Determines number
        /// of channels.
        /// </summary>
        public Ac3CodingMode CodingMode
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
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. If excluded
        /// and input audio is Dolby Digital, dialnorm will be passed through.
        /// </summary>
        [AWSProperty(Min=1, Max=31)]
        public int? Dialnorm
        {
            get { return this._dialnorm; }
            set { this._dialnorm = value; }
        }

        // Check to see if Dialnorm property is set
        internal bool IsSetDialnorm()
        {
            return this._dialnorm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DrcProfile. If set to filmStandard, adds dynamic range
        /// compression signaling to the output bitstream as defined in the Dolby Digital specification.
        /// </summary>
        public Ac3DrcProfile DrcProfile
        {
            get { return this._drcProfile; }
            set { this._drcProfile = value; }
        }

        // Check to see if DrcProfile property is set
        internal bool IsSetDrcProfile()
        {
            return this._drcProfile != null;
        }

        /// <summary>
        /// Gets and sets the property LfeFilter. When set to enabled, applies a 120Hz lowpass
        /// filter to the LFE channel prior to encoding. Only valid in codingMode32Lfe mode.
        /// </summary>
        public Ac3LfeFilter LfeFilter
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
        /// Gets and sets the property MetadataControl. When set to "followInput", encoder metadata
        /// will be sourced from the DD, DD+, or DolbyE decoder that supplied this audio data.
        /// If audio was not supplied from one of these streams, then the static metadata settings
        /// will be used.
        /// </summary>
        public Ac3MetadataControl MetadataControl
        {
            get { return this._metadataControl; }
            set { this._metadataControl = value; }
        }

        // Check to see if MetadataControl property is set
        internal bool IsSetMetadataControl()
        {
            return this._metadataControl != null;
        }

    }
}