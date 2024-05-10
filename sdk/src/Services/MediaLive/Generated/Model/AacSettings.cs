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
    /// Aac Settings
    /// </summary>
    public partial class AacSettings
    {
        private double? _bitrate;
        private AacCodingMode _codingMode;
        private AacInputType _inputType;
        private AacProfile _profile;
        private AacRateControlMode _rateControlMode;
        private AacRawFormat _rawFormat;
        private double? _sampleRate;
        private AacSpec _spec;
        private AacVbrQuality _vbrQuality;

        /// <summary>
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Valid values depend
        /// on rate control mode and profile.
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
        /// Gets and sets the property CodingMode. Mono, Stereo, or 5.1 channel layout. Valid
        /// values depend on rate control mode and profile. The adReceiverMix setting receives
        /// a stereo description plus control track and emits a mono AAC encode of the description
        /// track, with control data emitted in the PES header as per ETSI TS 101 154 Annex E.
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
        /// Gets and sets the property InputType. Set to "broadcasterMixedAd" when input contains
        /// pre-mixed main audio + AD (narration) as a stereo pair.  The Audio Type field (audioType)
        /// will be set to 3, which signals to downstream systems that this stream contains "broadcaster
        /// mixed AD". Note that the input received by the encoder must contain pre-mixed audio;
        /// the encoder does not perform the mixing. The values in audioTypeControl and audioType
        /// (in AudioDescription) are ignored when set to broadcasterMixedAd.Leave set to "normal"
        /// when input does not contain pre-mixed audio + AD.
        /// </summary>
        public AacInputType InputType
        {
            get { return this._inputType; }
            set { this._inputType = value; }
        }

        // Check to see if InputType property is set
        internal bool IsSetInputType()
        {
            return this._inputType != null;
        }

        /// <summary>
        /// Gets and sets the property Profile. AAC Profile.
        /// </summary>
        public AacProfile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property RateControlMode. Rate Control Mode.
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
        /// Gets and sets the property RawFormat. Sets LATM / LOAS AAC output for raw containers.
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
        public double? SampleRate
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
        /// Gets and sets the property Spec. Use MPEG-2 AAC audio instead of MPEG-4 AAC audio
        /// for raw or MPEG-2 Transport Stream containers.
        /// </summary>
        public AacSpec Spec
        {
            get { return this._spec; }
            set { this._spec = value; }
        }

        // Check to see if Spec property is set
        internal bool IsSetSpec()
        {
            return this._spec != null;
        }

        /// <summary>
        /// Gets and sets the property VbrQuality. VBR Quality Level - Only used if rateControlMode
        /// is VBR.
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