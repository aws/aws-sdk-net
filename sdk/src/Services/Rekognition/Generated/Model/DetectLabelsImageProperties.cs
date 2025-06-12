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
    /// Information about the quality and dominant colors of an input image. Quality and color
    /// information is returned for the entire image, foreground, and background.
    /// </summary>
    public partial class DetectLabelsImageProperties
    {
        private DetectLabelsImageBackground _background;
        private List<DominantColor> _dominantColors = AWSConfigs.InitializeCollections ? new List<DominantColor>() : null;
        private DetectLabelsImageForeground _foreground;
        private DetectLabelsImageQuality _quality;

        /// <summary>
        /// Gets and sets the property Background. 
        /// <para>
        /// Information about the properties of an image’s background, including the background’s
        /// quality and dominant colors, including the quality and dominant colors of the image.
        /// </para>
        /// </summary>
        public DetectLabelsImageBackground Background
        {
            get { return this._background; }
            set { this._background = value; }
        }

        // Check to see if Background property is set
        internal bool IsSetBackground()
        {
            return this._background != null;
        }

        /// <summary>
        /// Gets and sets the property DominantColors. 
        /// <para>
        /// Information about the dominant colors found in an image, described with RGB values,
        /// CSS color name, simplified color name, and PixelPercentage (the percentage of image
        /// pixels that have a particular color).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DominantColor> DominantColors
        {
            get { return this._dominantColors; }
            set { this._dominantColors = value; }
        }

        // Check to see if DominantColors property is set
        internal bool IsSetDominantColors()
        {
            return this._dominantColors != null && (this._dominantColors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Foreground. 
        /// <para>
        /// Information about the properties of an image’s foreground, including the foreground’s
        /// quality and dominant colors, including the quality and dominant colors of the image.
        /// </para>
        /// </summary>
        public DetectLabelsImageForeground Foreground
        {
            get { return this._foreground; }
            set { this._foreground = value; }
        }

        // Check to see if Foreground property is set
        internal bool IsSetForeground()
        {
            return this._foreground != null;
        }

        /// <summary>
        /// Gets and sets the property Quality. 
        /// <para>
        /// Information about the quality of the image foreground as defined by brightness, sharpness,
        /// and contrast. The higher the value the greater the brightness, sharpness, and contrast
        /// respectively.
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