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
    /// An aspect ratio expressed as a fraction with numerator and denominator values, reduced
    /// to lowest terms. Used for the sample (pixel) aspect ratio and the display aspect ratio
    /// of a video track. For example, a 720x576 anamorphic track has a sample aspect ratio
    /// of 64 / 45 and a display aspect ratio of 16 / 9. A video track can declare an aspect
    /// ratio in two independent places, and MediaConvert reports each one where it was found
    /// rather than choosing between them. The ratio declared by the container appears on
    /// the video track itself, and the ratio declared by the video essence appears under
    /// codecMetadata. When a file declares an aspect ratio in only one of the two places,
    /// the other is null; when it declares both and they disagree, you can compare them and
    /// decide which to use.
    /// </summary>
    public partial class AspectRatio
    {
        private int? _denominator;
        private int? _numerator;

        /// <summary>
        /// Gets and sets the property Denominator. The denominator, or bottom number, in the
        /// fractional aspect ratio. For example, for a display aspect ratio of 16 / 9, the denominator
        /// would be 9.
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
        /// aspect ratio. For example, for a display aspect ratio of 16 / 9, the numerator would
        /// be 16.
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