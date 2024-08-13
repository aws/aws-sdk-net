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
    /// A description of the dominant colors in an image.
    /// </summary>
    public partial class DominantColor
    {
        private int? _blue;
        private string _cssColor;
        private int? _green;
        private string _hexCode;
        private float? _pixelPercent;
        private int? _red;
        private string _simplifiedColor;

        /// <summary>
        /// Gets and sets the property Blue. 
        /// <para>
        /// The Blue RGB value for a dominant color.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Blue
        {
            get { return this._blue; }
            set { this._blue = value; }
        }

        // Check to see if Blue property is set
        internal bool IsSetBlue()
        {
            return this._blue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CSSColor. 
        /// <para>
        /// The CSS color name of a dominant color.
        /// </para>
        /// </summary>
        public string CSSColor
        {
            get { return this._cssColor; }
            set { this._cssColor = value; }
        }

        // Check to see if CSSColor property is set
        internal bool IsSetCSSColor()
        {
            return this._cssColor != null;
        }

        /// <summary>
        /// Gets and sets the property Green. 
        /// <para>
        /// The Green RGB value for a dominant color.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Green
        {
            get { return this._green; }
            set { this._green = value; }
        }

        // Check to see if Green property is set
        internal bool IsSetGreen()
        {
            return this._green.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HexCode. 
        /// <para>
        /// The Hex code equivalent of the RGB values for a dominant color.
        /// </para>
        /// </summary>
        public string HexCode
        {
            get { return this._hexCode; }
            set { this._hexCode = value; }
        }

        // Check to see if HexCode property is set
        internal bool IsSetHexCode()
        {
            return this._hexCode != null;
        }

        /// <summary>
        /// Gets and sets the property PixelPercent. 
        /// <para>
        /// The percentage of image pixels that have a given dominant color.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? PixelPercent
        {
            get { return this._pixelPercent; }
            set { this._pixelPercent = value; }
        }

        // Check to see if PixelPercent property is set
        internal bool IsSetPixelPercent()
        {
            return this._pixelPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Red. 
        /// <para>
        /// The Red RGB value for a dominant color.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Red
        {
            get { return this._red; }
            set { this._red = value; }
        }

        // Check to see if Red property is set
        internal bool IsSetRed()
        {
            return this._red.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SimplifiedColor. 
        /// <para>
        /// One of 12 simplified color names applied to a dominant color.
        /// </para>
        /// </summary>
        public string SimplifiedColor
        {
            get { return this._simplifiedColor; }
            set { this._simplifiedColor = value; }
        }

        // Check to see if SimplifiedColor property is set
        internal bool IsSetSimplifiedColor()
        {
            return this._simplifiedColor != null;
        }

    }
}