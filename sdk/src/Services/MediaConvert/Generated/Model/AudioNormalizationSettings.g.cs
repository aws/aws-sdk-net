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
    /// Advanced audio normalization settings. Ignore these settings unless you need to comply
    /// with a loudness standard.
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
        /// Gets and sets the property AlgorithmControl. When enabled the output audio is corrected
        /// using the chosen algorithm. If disabled, the audio will be measured but not adjusted.
        /// </summary>
        public AudioNormalizationAlgorithmControl AlgorithmControl { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmControl property is set.
        /// </summary>
        internal bool IsSetAlgorithmControl() => this.AlgorithmControl != null;

        /// <summary>
        /// Gets and sets the property CorrectionGateLevel. Content measuring above this level
        /// will be corrected to the target level. Content measuring below this level will not
        /// be corrected.
        /// </summary>
        [AWSProperty(Min = -70, Max = 0)]
        public int? CorrectionGateLevel { get; set; }

        /// <summary>
        /// Checks to see if the CorrectionGateLevel property is set.
        /// </summary>
        internal bool IsSetCorrectionGateLevel() => this.CorrectionGateLevel.HasValue;

        /// <summary>
        /// Gets and sets the property LoudnessLogging. If set to LOG, log each output's audio
        /// track loudness to a CSV file.
        /// </summary>
        public AudioNormalizationLoudnessLogging LoudnessLogging { get; set; }

        /// <summary>
        /// Checks to see if the LoudnessLogging property is set.
        /// </summary>
        internal bool IsSetLoudnessLogging() => this.LoudnessLogging != null;

        /// <summary>
        /// Gets and sets the property PeakCalculation. If set to TRUE_PEAK, calculate and log
        /// the TruePeak for each output's audio track loudness.
        /// </summary>
        public AudioNormalizationPeakCalculation PeakCalculation { get; set; }

        /// <summary>
        /// Checks to see if the PeakCalculation property is set.
        /// </summary>
        internal bool IsSetPeakCalculation() => this.PeakCalculation != null;

        /// <summary>
        /// Gets and sets the property TargetLkfs. When you use Audio normalization, optionally
        /// use this setting to specify a target loudness. If you don't specify a value here,
        /// the encoder chooses a value for you, based on the algorithm that you choose for Algorithm.
        /// If you choose algorithm 1770-1, the encoder will choose -24 LKFS; otherwise, the encoder
        /// will choose -23 LKFS.
        /// </summary>
        public double? TargetLkfs { get; set; }

        /// <summary>
        /// Checks to see if the TargetLkfs property is set.
        /// </summary>
        internal bool IsSetTargetLkfs() => this.TargetLkfs.HasValue;

        /// <summary>
        /// Gets and sets the property TruePeakLimiterThreshold. Specify the True-peak limiter
        /// threshold in decibels relative to full scale (dBFS). The peak inter-audio sample loudness
        /// in your output will be limited to the value that you specify, without affecting the
        /// overall target LKFS. Enter a value from 0 to -8. Leave blank to use the default value
        /// 0.
        /// </summary>
        public double? TruePeakLimiterThreshold { get; set; }

        /// <summary>
        /// Checks to see if the TruePeakLimiterThreshold property is set.
        /// </summary>
        internal bool IsSetTruePeakLimiterThreshold() => this.TruePeakLimiterThreshold.HasValue;
    }
}
