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
    /// AAC. The service accepts one of two mutually exclusive groups of AAC settings--VBR
    /// and CBR. To select one of these modes, set the value of Bitrate control mode (rateControlMode)
    /// to "VBR" or "CBR".  In VBR mode, you control the audio quality with the setting VBR
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
        /// Gets and sets the property AudioDescriptionBroadcasterMix.
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
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Defaults and valid
        /// values depend on rate control mode and profile.
        /// </summary>
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
        /// Gets and sets the property CodecProfile.
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
        /// Gets and sets the property CodingMode.
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
        /// Gets and sets the property RateControlMode.
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
        /// Gets and sets the property RawFormat.
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
        /// Gets and sets the property SampleRate. Sample rate in Hz. Valid values depend on rate
        /// control mode and profile.
        /// </summary>
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
        /// Gets and sets the property Specification.
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
        /// Gets and sets the property VbrQuality.
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