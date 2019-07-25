/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set (Codec) under (AudioDescriptions)>(CodecSettings) to the value
    /// AC3.
    /// </summary>
    public partial class Ac3Settings
    {
        private int? _bitrate;
        private Ac3BitstreamMode _bitstreamMode;
        private Ac3CodingMode _codingMode;
        private int? _dialnorm;
        private Ac3DynamicRangeCompressionProfile _dynamicRangeCompressionProfile;
        private Ac3LfeFilter _lfeFilter;
        private Ac3MetadataControl _metadataControl;
        private int? _sampleRate;

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// Valid bitrates depend on the coding mode.
        /// </summary>
        [AWSProperty(Min=64000, Max=640000)]
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
        /// Gets and sets the property BitstreamMode. Specify the bitstream mode for the AC-3
        /// stream that the encoder emits. For more information about the AC3 bitstream mode,
        /// see ATSC A/52-2012 (Annex E).
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
        /// Gets and sets the property Dialnorm. Sets the dialnorm for the output. If blank and
        /// input audio is Dolby Digital, dialnorm will be passed through.
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
        /// Gets and sets the property DynamicRangeCompressionProfile. If set to FILM_STANDARD,
        /// adds dynamic range compression signaling to the output bitstream as defined in the
        /// Dolby Digital specification.
        /// </summary>
        public Ac3DynamicRangeCompressionProfile DynamicRangeCompressionProfile
        {
            get { return this._dynamicRangeCompressionProfile; }
            set { this._dynamicRangeCompressionProfile = value; }
        }

        // Check to see if DynamicRangeCompressionProfile property is set
        internal bool IsSetDynamicRangeCompressionProfile()
        {
            return this._dynamicRangeCompressionProfile != null;
        }

        /// <summary>
        /// Gets and sets the property LfeFilter. Applies a 120Hz lowpass filter to the LFE channel
        /// prior to encoding. Only valid with 3_2_LFE coding mode.
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
        /// Gets and sets the property MetadataControl. When set to FOLLOW_INPUT, encoder metadata
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

    }
}