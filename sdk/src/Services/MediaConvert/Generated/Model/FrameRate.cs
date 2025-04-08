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
    /// The frame rate of the video or audio track.
    /// </summary>
    public partial class FrameRate
    {
        private int? _denominator;
        private int? _numerator;

        /// <summary>
        /// Gets and sets the property Denominator. The denominator, or bottom number, in the
        /// fractional frame rate. For example, if your frame rate is 24000 / 1001 (23.976 frames
        /// per second), then the denominator would be 1001.
        /// </summary>
        public int? Denominator
        {
            get { return this._denominator; }
            set { this._denominator = value; }
        }

        // Check to see if Denominator property is set
        internal bool IsSetDenominator()
        {
            return this._denominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Numerator. The numerator, or top number, in the fractional
        /// frame rate. For example, if your frame rate is 24000 / 1001 (23.976 frames per second),
        /// then the numerator would be 24000.
        /// </summary>
        public int? Numerator
        {
            get { return this._numerator; }
            set { this._numerator = value; }
        }

        // Check to see if Numerator property is set
        internal bool IsSetNumerator()
        {
            return this._numerator.HasValue; 
        }

    }
}