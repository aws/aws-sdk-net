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
    /// Aac Settings
    /// </summary>
    public partial class AacSettings
    {
        /// <summary>
        /// Gets and sets the property Bitrate. Average bitrate in bits/second. Valid values depend
        /// on rate control mode and profile.
        /// </summary>
        public double? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property CodingMode. Mono, Stereo, or 5.1 channel layout. Valid
        /// values depend on rate control mode and profile. The adReceiverMix setting receives
        /// a stereo description plus control track and emits a mono AAC encode of the description
        /// track, with control data emitted in the PES header as per ETSI TS 101 154 Annex E.
        /// </summary>
        public AacCodingMode CodingMode { get; set; }

        /// <summary>
        /// Checks to see if the CodingMode property is set.
        /// </summary>
        internal bool IsSetCodingMode() => this.CodingMode != null;

        /// <summary>
        /// Gets and sets the property InputType. Set to "broadcasterMixedAd" when input contains
        /// pre-mixed main audio + AD (narration) as a stereo pair. The Audio Type field (audioType)
        /// will be set to 3, which signals to downstream systems that this stream contains "broadcaster
        /// mixed AD". Note that the input received by the encoder must contain pre-mixed audio;
        /// the encoder does not perform the mixing. The values in audioTypeControl and audioType
        /// (in AudioDescription) are ignored when set to broadcasterMixedAd. Leave set to "normal"
        /// when input does not contain pre-mixed audio + AD.
        /// </summary>
        public AacInputType InputType { get; set; }

        /// <summary>
        /// Checks to see if the InputType property is set.
        /// </summary>
        internal bool IsSetInputType() => this.InputType != null;

        /// <summary>
        /// Gets and sets the property Profile. AAC Profile.
        /// </summary>
        public AacProfile Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;

        /// <summary>
        /// Gets and sets the property RateControlMode. Rate Control Mode.
        /// </summary>
        public AacRateControlMode RateControlMode { get; set; }

        /// <summary>
        /// Checks to see if the RateControlMode property is set.
        /// </summary>
        internal bool IsSetRateControlMode() => this.RateControlMode != null;

        /// <summary>
        /// Gets and sets the property RawFormat. Sets LATM / LOAS AAC output for raw containers.
        /// </summary>
        public AacRawFormat RawFormat { get; set; }

        /// <summary>
        /// Checks to see if the RawFormat property is set.
        /// </summary>
        internal bool IsSetRawFormat() => this.RawFormat != null;

        /// <summary>
        /// Gets and sets the property SampleRate. Sample rate in Hz. Valid values depend on rate
        /// control mode and profile.
        /// </summary>
        public double? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;

        /// <summary>
        /// Gets and sets the property Spec. Use MPEG-2 AAC audio instead of MPEG-4 AAC audio
        /// for raw or MPEG-2 Transport Stream containers.
        /// </summary>
        public AacSpec Spec { get; set; }

        /// <summary>
        /// Checks to see if the Spec property is set.
        /// </summary>
        internal bool IsSetSpec() => this.Spec != null;

        /// <summary>
        /// Gets and sets the property VbrQuality. VBR Quality Level - Only used if rateControlMode
        /// is VBR.
        /// </summary>
        public AacVbrQuality VbrQuality { get; set; }

        /// <summary>
        /// Checks to see if the VbrQuality property is set.
        /// </summary>
        internal bool IsSetVbrQuality() => this.VbrQuality != null;
    }
}
