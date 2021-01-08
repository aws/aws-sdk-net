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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Noise reducer filter settings for temporal filter.
    /// </summary>
    public partial class NoiseReducerTemporalFilterSettings
    {
        private int? _aggressiveMode;
        private NoiseFilterPostTemporalSharpening _postTemporalSharpening;
        private int? _speed;
        private int? _strength;

        /// <summary>
        /// Gets and sets the property AggressiveMode. Use Aggressive mode for content that has
        /// complex motion. Higher values produce stronger temporal filtering. This filters highly
        /// complex scenes more aggressively and creates better VQ for low bitrate outputs.
        /// </summary>
        [AWSProperty(Min=0, Max=4)]
        public int AggressiveMode
        {
            get { return this._aggressiveMode.GetValueOrDefault(); }
            set { this._aggressiveMode = value; }
        }

        // Check to see if AggressiveMode property is set
        internal bool IsSetAggressiveMode()
        {
            return this._aggressiveMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PostTemporalSharpening. Optional. When you set Noise reducer
        /// (noiseReducer) to Temporal (TEMPORAL), you can use this setting to apply sharpening.
        /// The default behavior, Auto (AUTO), allows the transcoder to determine whether to apply
        /// filtering, depending on input type and quality. When you set Noise reducer to Temporal,
        /// your output bandwidth is reduced. When Post temporal sharpening is also enabled, that
        /// bandwidth reduction is smaller.
        /// </summary>
        public NoiseFilterPostTemporalSharpening PostTemporalSharpening
        {
            get { return this._postTemporalSharpening; }
            set { this._postTemporalSharpening = value; }
        }

        // Check to see if PostTemporalSharpening property is set
        internal bool IsSetPostTemporalSharpening()
        {
            return this._postTemporalSharpening != null;
        }

        /// <summary>
        /// Gets and sets the property Speed. The speed of the filter (higher number is faster).
        /// Low setting reduces bit rate at the cost of transcode time, high setting improves
        /// transcode time at the cost of bit rate.
        /// </summary>
        [AWSProperty(Min=-1, Max=3)]
        public int Speed
        {
            get { return this._speed.GetValueOrDefault(); }
            set { this._speed = value; }
        }

        // Check to see if Speed property is set
        internal bool IsSetSpeed()
        {
            return this._speed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strength. Specify the strength of the noise reducing filter
        /// on this output. Higher values produce stronger filtering. We recommend the following
        /// value ranges, depending on the result that you want: * 0-2 for complexity reduction
        /// with minimal sharpness loss * 2-8 for complexity reduction with image preservation
        /// * 8-16 for a high level of complexity reduction
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public int Strength
        {
            get { return this._strength.GetValueOrDefault(); }
            set { this._strength = value; }
        }

        // Check to see if Strength property is set
        internal bool IsSetStrength()
        {
            return this._strength.HasValue; 
        }

    }
}