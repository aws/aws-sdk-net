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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A description of the dominant colors in an image.
    /// </summary>
    public partial class DominantColor
    {
        /// <summary>
        /// Gets and sets the property Blue. 
        /// <para>
        /// The Blue RGB value for a dominant color.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Blue { get; set; }

        /// <summary>
        /// Checks to see if the Blue property is set.
        /// </summary>
        internal bool IsSetBlue() => this.Blue.HasValue;

        /// <summary>
        /// Gets and sets the property CSSColor. 
        /// <para>
        /// The CSS color name of a dominant color.
        /// </para>
        /// </summary>
        public string CSSColor { get; set; }

        /// <summary>
        /// Checks to see if the CSSColor property is set.
        /// </summary>
        internal bool IsSetCSSColor() => this.CSSColor != null;

        /// <summary>
        /// Gets and sets the property Green. 
        /// <para>
        /// The Green RGB value for a dominant color.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Green { get; set; }

        /// <summary>
        /// Checks to see if the Green property is set.
        /// </summary>
        internal bool IsSetGreen() => this.Green.HasValue;

        /// <summary>
        /// Gets and sets the property HexCode. 
        /// <para>
        /// The Hex code equivalent of the RGB values for a dominant color.
        /// </para>
        /// </summary>
        public string HexCode { get; set; }

        /// <summary>
        /// Checks to see if the HexCode property is set.
        /// </summary>
        internal bool IsSetHexCode() => this.HexCode != null;

        /// <summary>
        /// Gets and sets the property PixelPercent. 
        /// <para>
        /// The percentage of image pixels that have a given dominant color.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? PixelPercent { get; set; }

        /// <summary>
        /// Checks to see if the PixelPercent property is set.
        /// </summary>
        internal bool IsSetPixelPercent() => this.PixelPercent.HasValue;

        /// <summary>
        /// Gets and sets the property Red. 
        /// <para>
        /// The Red RGB value for a dominant color.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Red { get; set; }

        /// <summary>
        /// Checks to see if the Red property is set.
        /// </summary>
        internal bool IsSetRed() => this.Red.HasValue;

        /// <summary>
        /// Gets and sets the property SimplifiedColor. 
        /// <para>
        /// One of 12 simplified color names applied to a dominant color.
        /// </para>
        /// </summary>
        public string SimplifiedColor { get; set; }

        /// <summary>
        /// Checks to see if the SimplifiedColor property is set.
        /// </summary>
        internal bool IsSetSimplifiedColor() => this.SimplifiedColor != null;
    }
}
