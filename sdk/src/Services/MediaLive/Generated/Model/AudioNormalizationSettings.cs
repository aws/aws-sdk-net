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
    /// Audio Normalization Settings
    /// </summary>
    public partial class AudioNormalizationSettings
    {
        private AudioNormalizationAlgorithm _algorithm;
        private AudioNormalizationAlgorithmControl _algorithmControl;
        private AudioNormalizationPeakCalculation _peakCalculation;
        private double? _peakLimiterThreshold;
        private double? _targetLkfs;

        /// <summary>
        /// Gets and sets the property Algorithm. Choose one of the following audio normalization
        /// algorithms:ITU-R BS.1770-1: Ungated loudness. A measurement of ungated average loudness
        /// for an entire piece of content,suitable for measurement of short-form content under
        /// ATSC recommendation A/85. Supports up to 5.1 audio channels.ITU-R BS.1770-2: Gated
        /// loudness. A measurement of gated average loudness compliant with the requirements
        /// ofEBU-R128. Supports up to 5.1 audio channels.ITU-R BS.1770-3: Modified peak. The
        /// same loudness measurement algorithm as 1770-2, with an updated true peakmeasurement.ITU-R
        /// BS.1770-4: Higher channel count. Allows for more audio channels than the other algorithms,
        /// includingconfigurations such as 7.1.
        /// </summary>
        public AudioNormalizationAlgorithm Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property AlgorithmControl. When set to correctAudio the output audio
        /// is corrected using the chosen algorithm. If set to measureOnly, the audio will be
        /// measured but not adjusted.
        /// </summary>
        public AudioNormalizationAlgorithmControl AlgorithmControl
        {
            get { return this._algorithmControl; }
            set { this._algorithmControl = value; }
        }

        // Check to see if AlgorithmControl property is set
        internal bool IsSetAlgorithmControl()
        {
            return this._algorithmControl != null;
        }

        /// <summary>
        /// Gets and sets the property PeakCalculation. If set to TRUE_PEAK, calculate the TruePeak
        /// for each output's audio track loudness.
        /// </summary>
        public AudioNormalizationPeakCalculation PeakCalculation
        {
            get { return this._peakCalculation; }
            set { this._peakCalculation = value; }
        }

        // Check to see if PeakCalculation property is set
        internal bool IsSetPeakCalculation()
        {
            return this._peakCalculation != null;
        }

        /// <summary>
        /// Gets and sets the property PeakLimiterThreshold. Peak limiter threshold in decibels
        /// relative to true peak (dBTP) if TRUE_PEAK is enabled.If TRUE_PEAK is not enabled a
        /// full scale (dbFS) value is used.The peak inter-audio sample loudness in your output
        /// will be limited to the value that you specify,without affecting the overall target
        /// LKFS. Leave blank to use the default value 0.
        /// </summary>
        public double? PeakLimiterThreshold
        {
            get { return this._peakLimiterThreshold; }
            set { this._peakLimiterThreshold = value; }
        }

        // Check to see if PeakLimiterThreshold property is set
        internal bool IsSetPeakLimiterThreshold()
        {
            return this._peakLimiterThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetLkfs. Target LKFS(loudness) to adjust volume to.
        /// If no value is entered, a default value will be used according to the chosen algorithm.
        ///  The CALM Act recommends a target of -24 LKFS. The EBU R-128 specification recommends
        /// a target of -23 LKFS.
        /// </summary>
        public double? TargetLkfs
        {
            get { return this._targetLkfs; }
            set { this._targetLkfs = value; }
        }

        // Check to see if TargetLkfs property is set
        internal bool IsSetTargetLkfs()
        {
            return this._targetLkfs.HasValue; 
        }

    }
}