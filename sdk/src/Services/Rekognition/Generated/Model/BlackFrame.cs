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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// A filter that allows you to control the black frame detection by specifying the black
    /// levels and pixel coverage of black pixels in a frame. As videos can come from multiple
    /// sources, formats, and time periods, they may contain different standards and varying
    /// noise levels for black frames that need to be accounted for. For more information,
    /// see <a>StartSegmentDetection</a>.
    /// </summary>
    public partial class BlackFrame
    {
        private float? _maxPixelThreshold;
        private float? _minCoveragePercentage;

        /// <summary>
        /// Gets and sets the property MaxPixelThreshold. 
        /// <para>
        ///  A threshold used to determine the maximum luminance value for a pixel to be considered
        /// black. In a full color range video, luminance values range from 0-255. A pixel value
        /// of 0 is pure black, and the most strict filter. The maximum black pixel value is computed
        /// as follows: max_black_pixel_value = minimum_luminance + MaxPixelThreshold *luminance_range.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, for a full range video with BlackPixelThreshold = 0.1, max_black_pixel_value
        /// is 0 + 0.1 * (255-0) = 25.5.
        /// </para>
        ///  
        /// <para>
        /// The default value of MaxPixelThreshold is 0.2, which maps to a max_black_pixel_value
        /// of 51 for a full range video. You can lower this threshold to be more strict on black
        /// levels.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? MaxPixelThreshold
        {
            get { return this._maxPixelThreshold; }
            set { this._maxPixelThreshold = value; }
        }

        // Check to see if MaxPixelThreshold property is set
        internal bool IsSetMaxPixelThreshold()
        {
            return this._maxPixelThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCoveragePercentage. 
        /// <para>
        ///  The minimum percentage of pixels in a frame that need to have a luminance below the
        /// max_black_pixel_value for a frame to be considered a black frame. Luminance is calculated
        /// using the BT.709 matrix. 
        /// </para>
        ///  
        /// <para>
        /// The default value is 99, which means at least 99% of all pixels in the frame are black
        /// pixels as per the <c>MaxPixelThreshold</c> set. You can reduce this value to allow
        /// more noise on the black frame.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? MinCoveragePercentage
        {
            get { return this._minCoveragePercentage; }
            set { this._minCoveragePercentage = value; }
        }

        // Check to see if MinCoveragePercentage property is set
        internal bool IsSetMinCoveragePercentage()
        {
            return this._minCoveragePercentage.HasValue; 
        }

    }
}