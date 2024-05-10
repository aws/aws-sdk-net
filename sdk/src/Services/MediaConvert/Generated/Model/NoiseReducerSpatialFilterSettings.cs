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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Noise reducer filter settings for spatial filter.
    /// </summary>
    public partial class NoiseReducerSpatialFilterSettings
    {
        private int? _postFilterSharpenStrength;
        private int? _speed;
        private int? _strength;

        /// <summary>
        /// Gets and sets the property PostFilterSharpenStrength. Specify strength of post noise
        /// reduction sharpening filter, with 0 disabling the filter and 3 enabling it at maximum
        /// strength.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public int? PostFilterSharpenStrength
        {
            get { return this._postFilterSharpenStrength; }
            set { this._postFilterSharpenStrength = value; }
        }

        // Check to see if PostFilterSharpenStrength property is set
        internal bool IsSetPostFilterSharpenStrength()
        {
            return this._postFilterSharpenStrength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Speed. The speed of the filter, from -2 (lower speed) to
        /// 3 (higher speed), with 0 being the nominal value.
        /// </summary>
        [AWSProperty(Min=-2, Max=3)]
        public int? Speed
        {
            get { return this._speed; }
            set { this._speed = value; }
        }

        // Check to see if Speed property is set
        internal bool IsSetSpeed()
        {
            return this._speed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strength. Relative strength of noise reducing filter. Higher
        /// values produce stronger filtering.
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public int? Strength
        {
            get { return this._strength; }
            set { this._strength = value; }
        }

        // Check to see if Strength property is set
        internal bool IsSetStrength()
        {
            return this._strength.HasValue; 
        }

    }
}