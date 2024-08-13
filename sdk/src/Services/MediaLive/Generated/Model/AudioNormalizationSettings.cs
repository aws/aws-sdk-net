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
        private double? _targetLkfs;

        /// <summary>
        /// Gets and sets the property Algorithm. Audio normalization algorithm to use. itu17701
        /// conforms to the CALM Act specification, itu17702 conforms to the EBU R-128 specification.
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
        /// Gets and sets the property TargetLkfs. Target LKFS(loudness) to adjust volume to.
        /// If no value is entered, a default value will be used according to the chosen algorithm.
        ///  The CALM Act (1770-1) recommends a target of -24 LKFS. The EBU R-128 specification
        /// (1770-2) recommends a target of -23 LKFS.
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