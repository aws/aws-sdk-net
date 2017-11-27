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
    /// Advanced audio normalization settings.
    /// </summary>
    public partial class AudioNormalizationSettings
    {
        private AudioNormalizationAlgorithm _algorithm;
        private AudioNormalizationAlgorithmControl _algorithmControl;
        private int? _correctionGateLevel;
        private AudioNormalizationLoudnessLogging _loudnessLogging;
        private AudioNormalizationPeakCalculation _peakCalculation;
        private double? _targetLkfs;

        /// <summary>
        /// Gets and sets the property Algorithm.
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
        /// Gets and sets the property AlgorithmControl.
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
        /// Gets and sets the property CorrectionGateLevel. Content measuring above this level
        /// will be corrected to the target level. Content measuring below this level will not
        /// be corrected. Gating only applies when not using real_time_correction.
        /// </summary>
        public int CorrectionGateLevel
        {
            get { return this._correctionGateLevel.GetValueOrDefault(); }
            set { this._correctionGateLevel = value; }
        }

        // Check to see if CorrectionGateLevel property is set
        internal bool IsSetCorrectionGateLevel()
        {
            return this._correctionGateLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoudnessLogging.
        /// </summary>
        public AudioNormalizationLoudnessLogging LoudnessLogging
        {
            get { return this._loudnessLogging; }
            set { this._loudnessLogging = value; }
        }

        // Check to see if LoudnessLogging property is set
        internal bool IsSetLoudnessLogging()
        {
            return this._loudnessLogging != null;
        }

        /// <summary>
        /// Gets and sets the property PeakCalculation.
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
        /// Gets and sets the property TargetLkfs. Target LKFS(loudness) to adjust volume to.
        /// If no value is entered, a default value will be used according to the chosen algorithm.
        /// The CALM Act (1770-1) recommends a target of -24 LKFS. The EBU R-128 specification
        /// (1770-2) recommends a target of -23 LKFS.
        /// </summary>
        public double TargetLkfs
        {
            get { return this._targetLkfs.GetValueOrDefault(); }
            set { this._targetLkfs = value; }
        }

        // Check to see if TargetLkfs property is set
        internal bool IsSetTargetLkfs()
        {
            return this._targetLkfs.HasValue; 
        }

    }
}