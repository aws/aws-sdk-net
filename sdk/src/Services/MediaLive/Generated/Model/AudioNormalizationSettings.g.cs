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
    /// Audio Normalization Settings
    /// </summary>
    public partial class AudioNormalizationSettings
    {
        /// <summary>
        /// Gets and sets the property Algorithm. Choose one of the following audio normalization
        /// algorithms: ITU-R BS.1770-1: Ungated loudness. A measurement of ungated average loudness
        /// for an entire piece of content, suitable for measurement of short-form content under
        /// ATSC recommendation A/85. Supports up to 5.1 audio channels. ITU-R BS.1770-2: Gated
        /// loudness. A measurement of gated average loudness compliant with the requirements
        /// of EBU-R128. Supports up to 5.1 audio channels. ITU-R BS.1770-3: Modified peak. The
        /// same loudness measurement algorithm as 1770-2, with an updated true peak measurement.
        /// ITU-R BS.1770-4: Higher channel count. Allows for more audio channels than the other
        /// algorithms, including configurations such as 7.1.
        /// </summary>
        public AudioNormalizationAlgorithm Algorithm { get; set; }

        /// <summary>
        /// Checks to see if the Algorithm property is set.
        /// </summary>
        internal bool IsSetAlgorithm() => this.Algorithm != null;

        /// <summary>
        /// Gets and sets the property AlgorithmControl. When set to correctAudio the output audio
        /// is corrected using the chosen algorithm. If set to measureOnly, the audio will be
        /// measured but not adjusted.
        /// </summary>
        public AudioNormalizationAlgorithmControl AlgorithmControl { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmControl property is set.
        /// </summary>
        internal bool IsSetAlgorithmControl() => this.AlgorithmControl != null;

        /// <summary>
        /// Gets and sets the property PeakCalculation. If set to TRUE_PEAK, calculate the TruePeak
        /// for each output's audio track loudness.
        /// </summary>
        public AudioNormalizationPeakCalculation PeakCalculation { get; set; }

        /// <summary>
        /// Checks to see if the PeakCalculation property is set.
        /// </summary>
        internal bool IsSetPeakCalculation() => this.PeakCalculation != null;

        /// <summary>
        /// Gets and sets the property PeakLimiterThreshold. Peak limiter threshold in decibels
        /// relative to true peak (dBTP) if TRUE_PEAK is enabled. If TRUE_PEAK is not enabled
        /// a full scale (dbFS) value is used. The peak inter-audio sample loudness in your output
        /// will be limited to the value that you specify, without affecting the overall target
        /// LKFS. Leave blank to use the default value 0.
        /// </summary>
        public double? PeakLimiterThreshold { get; set; }

        /// <summary>
        /// Checks to see if the PeakLimiterThreshold property is set.
        /// </summary>
        internal bool IsSetPeakLimiterThreshold() => this.PeakLimiterThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property TargetLkfs. Target LKFS(loudness) to adjust volume to.
        /// If no value is entered, a default value will be used according to the chosen algorithm.
        /// The CALM Act recommends a target of -24 LKFS. The EBU R-128 specification recommends
        /// a target of -23 LKFS.
        /// </summary>
        public double? TargetLkfs { get; set; }

        /// <summary>
        /// Checks to see if the TargetLkfs property is set.
        /// </summary>
        internal bool IsSetTargetLkfs() => this.TargetLkfs.HasValue;
    }
}
