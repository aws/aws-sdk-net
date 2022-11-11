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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// The background of the image with regard to image quality and dominant colors.
    /// </summary>
    public partial class DetectLabelsImageBackground
    {
        private List<DominantColor> _dominantColors = new List<DominantColor>();
        private DetectLabelsImageQuality _quality;

        /// <summary>
        /// Gets and sets the property DominantColors. 
        /// <para>
        /// The dominant colors found in the background of an image, defined with RGB values,
        /// CSS color name, simplified color name, and PixelPercentage (the percentage of image
        /// pixels that have a particular color).
        /// </para>
        /// </summary>
        public List<DominantColor> DominantColors
        {
            get { return this._dominantColors; }
            set { this._dominantColors = value; }
        }

        // Check to see if DominantColors property is set
        internal bool IsSetDominantColors()
        {
            return this._dominantColors != null && this._dominantColors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Quality. 
        /// <para>
        /// The quality of the image background as defined by brightness and sharpness.
        /// </para>
        /// </summary>
        public DetectLabelsImageQuality Quality
        {
            get { return this._quality; }
            set { this._quality = value; }
        }

        // Check to see if Quality property is set
        internal bool IsSetQuality()
        {
            return this._quality != null;
        }

    }
}